DROP DATABASE IF EXISTS Clinic;

CREATE DATABASE IF NOT EXISTS Clinic;
USE Clinic;

-- Таблиця лікарів
CREATE TABLE Doctors (
    DoctorID INT AUTO_INCREMENT PRIMARY KEY,
    LastName VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Specialty ENUM('ЛОР', 'Геніколог', 'Хірург') NOT NULL
);

-- Таблиця пацієнтів
CREATE TABLE Patients (
    PatientID INT AUTO_INCREMENT PRIMARY KEY,
    LastName VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender ENUM('Male', 'Female') NOT NULL,
    PhoneNumber VARCHAR(15)
);

-- Таблиця амбулаторних карток
CREATE TABLE AmbulatoryCards (
    AmbulatoryCardID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    EntryDate DATE NOT NULL,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

-- Таблиця медичних карток
CREATE TABLE MedicalRecords (
    RecordID INT AUTO_INCREMENT PRIMARY KEY,
    AmbulatoryCardID INT NOT NULL,
    HealthStatus TEXT NOT NULL,
    Notes TEXT,
    FOREIGN KEY (AmbulatoryCardID) REFERENCES AmbulatoryCards(AmbulatoryCardID)
);

-- Таблиця прийомів
CREATE TABLE Appointments (
    AppointmentID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    Notes TEXT,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);



-- Додавання даних у таблицю Doctors
INSERT INTO Doctors (LastName, FirstName, DateOfBirth, Specialty) 
VALUES 
('Семенчук', 'Василь', '1982-07-15', 'Хірург'),
('Кравченко', 'Ірина', '1991-02-11', 'Геніколог'),
('Онищенко', 'Павло', '1980-11-20', 'ЛОР'),
('Ткачук', 'Марина', '1985-01-17', 'Геніколог'),
('Гнатюк', 'Володимир', '1972-03-30', 'Хірург'),
('Мазур', 'Юлія', '1990-09-12', 'ЛОР'),
('Сергієнко', 'Наталя', '1983-05-28', 'Геніколог'),
('Демиденко', 'Олег', '1978-10-03', 'Хірург'),
('Бойко', 'Олена', '1994-06-15', 'ЛОР'),
('Ющенко', 'Роман', '1987-12-05', 'Хірург');

-- Додавання даних у таблицю Patients
INSERT INTO Patients (LastName, FirstName, DateOfBirth, Gender, PhoneNumber) 
VALUES 
('Зеленська', 'Ольга', '1993-08-20', 'Female', '0502223344'),
('Климчук', 'Андрій', '1980-09-11', 'Male', '0673322110'),
('Білик', 'Наталя', '1997-04-21', 'Female', '0639871234'),
('Савчук', 'Олександр', '1985-01-30', 'Male', '0504567891'),
('Лисенко', 'Аліна', '1999-02-14', 'Female', '0987650987'),
('Даниленко', 'Віталій', '1982-05-10', 'Male', '0931233210'),
('Гуменюк', 'Софія', '1995-12-02', 'Female', '0671112234'),
('Романчук', 'Валентин', '1979-08-19', 'Male', '0509991230'),
('Черниш', 'Вікторія', '2001-07-01', 'Female', '0991234561'),
('Костенко', 'Михайло', '1976-11-22', 'Male', '0639876544');

--  Додавання даних у таблицю Appointments
INSERT INTO AmbulatoryCards (PatientID, EntryDate)
VALUES
(1, '2024-12-01'),
(2, '2024-12-02'),
(3, '2024-12-03'),
(4, '2024-12-04'),
(5, '2024-12-05'),
(6, '2024-12-06'),
(7, '2024-12-07'),
(8, '2024-12-08'),
(9, '2024-12-09'),
(10, '2024-12-10');



-- Додавання даних у таблицю Appointments
INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Notes)
VALUES
(1, 2, '2024-12-01 10:00:00', 'Консультація'),
(2, 1, '2024-12-02 12:00:00', 'Огляд'),
(3, 3, '2024-12-03 14:00:00', 'Наступний прийом'),
(4, 1, '2024-12-04 16:00:00', 'Консультація'),
(5, 2, '2024-12-05 18:00:00', 'Обговорення аналізів'),
(6, 3, '2024-12-06 10:00:00', 'Рутинний огляд'),
(7, 1, '2024-12-07 12:00:00', 'Щорічна перевірка'),
(8, 2, '2024-12-08 14:00:00', 'Фізичний огляд'),
(9, 3, '2024-12-09 16:00:00', 'Наступний прийом'),
(10, 1, '2024-12-10 18:00:00', 'Огляд результатів лікування');




-- Додавання даних у таблицю MedicalRecords
INSERT INTO MedicalRecords (AmbulatoryCardID, HealthStatus, Notes)
VALUES
(1, 'Гострий фарингіт', 'Призначено курс антибіотиків'),
(2, 'Загальний стан добрий', 'Рекомендовано вітаміни'),
(3, 'Післяопераційний період', 'Рекомендована реабілітація'),
(4, 'Закладеність носа', 'Лікування спреями та інгаляції'),
(5, 'Поріз руки', 'Оброблено, накладено пов\'язку'),
(6, 'Хронічний синусит', 'Рекомендовано лікування антигістамінними'),
(7, 'Задовільний стан', 'Плановий огляд, без скарг'),
(8, 'Післяопераційний стан', 'Призначено додаткове обстеження'),
(9, 'Хронічний риніт', 'Призначено фізіотерапію'),
(10, 'Невеликі болі у спині', 'Рекомендовано консультацію невролога');


-- Додавання даних у таблицю AmbulatoryCards
INSERT INTO AmbulatoryCards (PatientID, EntryDate)
VALUES
(1, '2024-12-01'),
(2, '2024-12-02'),
(3, '2024-12-03'),
(4, '2024-12-04'),
(5, '2024-12-05'),
(6, '2024-12-06'),
(7, '2024-12-07'),
(8, '2024-12-08'),
(9, '2024-12-09'),
(10, '2024-12-10');





