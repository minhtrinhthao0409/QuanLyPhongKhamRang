BEGIN TRANSACTION;
CREATE TABLE "Appointments" (
    "AppointmentId" TEXT PRIMARY KEY,
    "PatientId" TEXT NOT NULL,
    "DoctorUserId" TEXT NOT NULL, -- trỏ đến Users.Id
    "AppointmentDate" DATE NOT NULL,
    "StartTime" TIME NOT NULL,
    "EndTime" TIME NOT NULL,
    "PaymentStatus" INTEGER DEFAULT 0,
    FOREIGN KEY("DoctorUserId") REFERENCES "Users"("Id"),
    FOREIGN KEY("PatientId") REFERENCES "Patients"("Id")
);
CREATE TABLE Guardians (
    GuardianId TEXT PRIMARY KEY,
    FullName TEXT NOT NULL,
    PhoneNumber TEXT NOT NULL,
    Email TEXT
);
CREATE TABLE "Invoice" (
	"InvoiceId"	INTEGER,
	"PatientId"	TEXT NOT NULL,
	"CreatedAt"	 DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY("InvoiceId" AUTOINCREMENT)
);
CREATE TABLE "InvoiceDetail" (
	"Id"	INTEGER,
	"InvoiceId"	INTEGER NOT NULL,
	"ServiceId"	INTEGER NOT NULL,
	"Price"	NUMERIC,
	PRIMARY KEY("Id")
);
CREATE TABLE "MedicalRecords" (
	"Id"	TEXT,
	"PatientId"	TEXT NOT NULL,
	"DoctorId"	TEXT NOT NULL,
	"Symptoms"	TEXT,
	"Diagnosis"	TEXT,
	"TreatmentPlan"	TEXT,
	"RecordDate"	DATE NOT NULL,
	PRIMARY KEY("Id"),
	FOREIGN KEY("DoctorId") REFERENCES "Doctors"("IdDoctor"),
	FOREIGN KEY("PatientId") REFERENCES "Patients"("Id")
);
CREATE TABLE Patients (
    PatientId TEXT PRIMARY KEY,
    Name TEXT NOT NULL,
    DOB DATE,
    Gender BOOLEAN,
    PhoneNumber TEXT,
    Email TEXT,
    GuardianId TEXT,
    FOREIGN KEY (GuardianId) REFERENCES Guardians(GuardianId)
);
CREATE TABLE "Payment" (
	"TransactionId"	TEXT,
	"AppointmentId"	TEXT NOT NULL,
	"PaymentMethod"	TEXT NOT NULL,
	"Total"	NUMERIC NOT NULL,
	"Balance"	NUMERIC NOT NULL,
	"Status"	TEXT NOT NULL,
	"CreatedAt"	TEXT DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY("TransactionId")
);
CREATE TABLE "Schedule" (
	"ScheduleId"	INTEGER,
	"DoctorId"	TEXT NOT NULL,
	"StartTime"	TEXT,
	"EndTime"	TEXT,
	PRIMARY KEY("ScheduleId" AUTOINCREMENT)
);
CREATE TABLE "Services" (
	"ServicesId"	INTEGER,
	"ServicesName"	TEXT,
	"CurrentPrice"	NUMERIC,
	PRIMARY KEY("ServicesId" AUTOINCREMENT)
);
CREATE TABLE "Users" (
	"Id"	TEXT,
	"UserName"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	"FullName"	TEXT,
	"Email"	TEXT,
	"PhoneNumber"	TEXT,
	"Role"	INTEGER NOT NULL CHECK("Role" IN (1, 2, 3)),
	PRIMARY KEY("Id")
);

INSERT INTO "Users" VALUES('admin-0001-uuid-unique-9999','admin','admin123',NULL,'admin@clinic.com',NULL,1);

CREATE TABLE "log" (
	"Id"	INTEGER,
	"UserId"	TEXT NOT NULL,
	"Action"	TEXT,
	PRIMARY KEY("Id")
);
DELETE FROM "sqlite_sequence";
COMMIT;