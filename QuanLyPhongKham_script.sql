BEGIN TRANSACTION;
CREATE TABLE "Appointments" (
	"AppointmentId"	TEXT,
	"DoctorId"	TEXT NOT NULL,
	"PatientId"	TEXT NOT NULL,
	"AppointmentDate"	DATE NOT NULL,
	"StartTime"	TIME NOT NULL,
	"EndTime"	TIME NOT NULL,
	PRIMARY KEY("AppointmentId"),
	FOREIGN KEY("DoctorId") REFERENCES "Users"("Id"),
	FOREIGN KEY("PatientId") REFERENCES "Patients"("PatientId")
);
CREATE TABLE "Guardians" (
	"GuardianId"	TEXT,
	"FullName"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT,
	PRIMARY KEY("GuardianId")
);
CREATE TABLE "Invoice" (
	"InvoiceId"	INTEGER,
	"PatientId"	TEXT NOT NULL,
	"PatientName"	TEXT,
	"CreatedAt"	DATETIME DEFAULT CURRENT_TIMESTAMP,
	"TotalAmount"	REAL NOT NULL DEFAULT 0,
	"PaidAmount"	REAL NOT NULL DEFAULT 0,
	"Status"	TEXT DEFAULT 'Chưa thanh toán',
	PRIMARY KEY("InvoiceId" AUTOINCREMENT),
	FOREIGN KEY("PatientId") REFERENCES "Patients"("PatientId")
);
CREATE TABLE "InvoiceDetail" (
	"InvoiceDetailId"	INTEGER,
	"InvoiceId"	INTEGER NOT NULL,
	"ServiceName"	TEXT NOT NULL,
	"UnitPrice"	REAL NOT NULL,
	"Quantity"	INTEGER NOT NULL,
	"TotalPrice"	REAL NOT NULL,
	PRIMARY KEY("InvoiceDetailId" AUTOINCREMENT),
	FOREIGN KEY("InvoiceId") REFERENCES "Invoice"("InvoiceId")
);
CREATE TABLE "Loggings" (
	"LoggingID"	TEXT,
	"UserID"	TEXT,
	"UserName"	TEXT,
	"Content"	TEXT,
	"DateTime"	TEXT,
	PRIMARY KEY("LoggingID"),
	FOREIGN KEY("UserID") REFERENCES "Users"("Id")
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
	FOREIGN KEY("DoctorId") REFERENCES "Users"("Id"),
	FOREIGN KEY("PatientId") REFERENCES "Patients"("PatientId")
);
CREATE TABLE "Patients" (
	"PatientId"	TEXT,
	"FullName"	TEXT NOT NULL,
	"DOB"	DATE,
	"Gender"	BOOLEAN,
	"PhoneNumber"	TEXT,
	"Email"	TEXT,
	"GuardianId"	TEXT DEFAULT NULL,
	PRIMARY KEY("PatientId"),
	FOREIGN KEY("GuardianId") REFERENCES "Guardians"("GuardianId")
);
CREATE TABLE "Payment" (
	"TransactionId"	TEXT,
	"AppointmentId"	TEXT NOT NULL,
	"PaymentMethod"	TEXT NOT NULL,
	"Total"	NUMERIC NOT NULL,
	"Balance"	NUMERIC NOT NULL,
	"Status"	TEXT NOT NULL,
	"CreatedAt"	TEXT DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY("TransactionId"),
	FOREIGN KEY("AppointmentId") REFERENCES "Appointments"("AppointmentId")
);
CREATE TABLE "Services" (
	"ServicesId"	INTEGER,
	"ServicesName"	TEXT,
	"CurrentPrice"	NUMERIC,
	"ServiceActive"	INT NOT NULL DEFAULT 1,
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
	"Active"	INTEGER DEFAULT 1 CHECK("Active" IN (0, 1)),
	PRIMARY KEY("Id")
);

INSERT INTO "Users" VALUES('admin-0001-uuid-unique-9999','admin','admin123',NULL,'admin@clinic.com',NULL,1);

DELETE FROM "sqlite_sequence";
COMMIT;