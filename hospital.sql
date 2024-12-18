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

-- Таблиця медичних карток
CREATE TABLE MedicalRecords (
    RecordID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    HealthStatus TEXT NOT NULL,
    Notes TEXT,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
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

-- Додавання даних у таблицю Appointments
INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Notes) 
VALUES 
(6, 6, '2024-12-25 09:00:00', 'Огляд ЛОР, скарги на біль у горлі'),
(7, 7, '2024-12-26 11:00:00', 'Консультація з приводу планування вагітності'),
(8, 8, '2024-12-27 12:30:00', 'Огляд після операції'),
(9, 9, '2024-12-28 15:00:00', 'Огляд ЛОР, закладеність носа'),
(10, 10, '2024-12-29 16:00:00', 'Рана на руці, перев\'язка'),
(1, 6, '2024-12-30 08:30:00', 'Повторний огляд ЛОР'),
(2, 7, '2024-12-31 10:30:00', 'Плановий огляд гінеколога'),
(3, 8, '2025-01-02 14:00:00', 'Перевірка після операції'),
(4, 9, '2025-01-03 15:45:00', 'Повторний прийом ЛОР'),
(5, 10, '2025-01-04 11:00:00', 'Консультація у хірурга, біль у спині');

-- Додавання даних у таблицю MedicalRecords
INSERT INTO MedicalRecords (PatientID, HealthStatus, Notes) 
VALUES 
(6, 'Гострий фарингіт', 'Призначено курс антибіотиків'),
(7, 'Загальний стан добрий', 'Рекомендовано вітаміни'),
(8, 'Післяопераційний період', 'Рекомендована реабілітація'),
(9, 'Закладеність носа', 'Лікування спреями та інгаляції'),
(10, 'Поріз руки', 'Оброблено, накладено пов\'язку'),
(1, 'Хронічний синусит', 'Рекомендовано лікування антигістамінними'),
(2, 'Задовільний стан', 'Плановий огляд, без скарг'),
(3, 'Післяопераційний стан', 'Призначено додаткове обстеження'),
(4, 'Хронічний риніт', 'Призначено фізіотерапію'),
(5, 'Невеликі болі у спині', 'Рекомендовано консультацію невролога');



