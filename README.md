CREATE DATABASE Repair COLLATE Cyrillic_General_100_CI_AS
GO

USE Repair

CREATE TABLE Role (
	Role_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(50)
)

INSERT INTO Role (Name) VALUES
('Менеджер'),
('Техник'),
('Оператор'),
('Заказчик')

CREATE TABLE Status (
	Status_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(50)
)

INSERT INTO Status (Name) VALUES
('В процессе ремонта'),
('Готова к выдаче'),
('Новая заявка'),
('ожидание запчастей')

CREATE TABLE Users(
    userID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    fio VARCHAR(100),
    phone VARCHAR(20),
    login VARCHAR(50),
    password VARCHAR(50),
    Role_ID INT FOREIGN KEY REFERENCES Role(Role_ID) NOT NULL CHECK(Role_ID >= 1 and Role_ID <= 4)
)


INSERT INTO users (fio, phone, login, password, Role_ID) VALUES
('Минаева Алиса Тимофеевна', '89210563128', 'login1', 'pass1', 1),     
('Воробьев Фёдор Алексеевич', '89535078985', 'login2', 'pass2', 2),    
('Захарова Алёна Андреевна', '89210673849', 'login3', 'pass3', 2),     
('Гусева Василиса Дмитриевна', '89990563748', 'login4', 'pass4', 3),   
('Миронов Даниэль Львович', '89994563847', 'login5', 'pass5', 3),      
('Белов Роман Добрынич', '89219567849', 'login6', 'pass6', 4),         
('Кузин Михаил Родионович', '89219567841', 'login7', 'pass7', 4),      
('Ковалева Софья Владимировна', '89219567842', 'login8', 'pass8', 4),  
('Глухова Вероника Владимировна', '89219567843', 'login9', 'pass9', 4),
('Князев Арсений Андреевич', '89219567844', 'login10', 'pass10', 2);   

CREATE TABLE Requests (
    requestID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    startDate DATE,
    homeTechType VARCHAR(50),
    homeTechModel VARCHAR(100),
    problemDescription VARCHAR(255),
    Status_ID int FOREIGN KEY REFERENCES Status(Status_ID) NOT NULL CHECK(Status_ID >= 1 and Status_ID <= 4),
    completionDate DATE,
    repairParts VARCHAR(255),
    masterID INT FOREIGN KEY REFERENCES Users(userID),
    clientID INT FOREIGN KEY REFERENCES Users(userID) NOT NULL,
);

INSERT INTO Requests (startDate, homeTechType, homeTechModel, problemDescription, Status_ID, completionDate, repairParts, masterID, clientID) VALUES
('2023-06-06', 'Фен', 'Ладомир ТА112 белый', 'Перестал работать', 1, NULL, NULL, 2, 7),
('2023-05-05', 'Тостер', 'Redmond RT-437 черный', 'Перестал работать', 1, NULL, NULL, 3, 7),
('2022-07-07', 'Холодильник', 'Indesit DS 316 W белый', 'Не морозит одна из камер холодильника', 2, '2023-01-01', NULL, 2, 8),
('2023-08-02', 'Стиральная машина', 'DEXP WM-F610NTMA/WW белый', 'Перестали работать многие режимы стирки', 3, NULL, NULL, 8, 8),
('2023-08-02', 'Мультиварка', 'Redmond RMC-M95 черный', 'Перестала включаться', 3, NULL, NULL, 9, 9),
('2023-08-02', 'Фен', 'Ладомир ТА113 чёрный', 'Перестал работать', 2, '2023-08-03', NULL, 2, 7),
('2023-07-09', 'Холодильник', 'Indesit DS 314 W серый', 'Гудит, но не замораживает', 2, '2023-08-03', 'Мотор обдува морозильной камеры холодильника', 2, 8);

CREATE TABLE Comments (
    commentID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    message VARCHAR(255),
    masterID INT FOREIGN KEY REFERENCES Users(userID) NOT NULL,
    requestID INT FOREIGN KEY REFERENCES Requests(requestID) NOT NULL,
);

-- Вставка данных в таблицу comments
INSERT INTO comments (message, masterID, requestID) VALUES
('Интересная поломка', 2, 1),
('Очень странно, будем разбираться!', 3, 2),
('Скорее всего потребуется мотор обдува!', 2, 7),
('Интересная поломка', 2, 1),
('Очень странно, будем разбираться!', 3, 6);
