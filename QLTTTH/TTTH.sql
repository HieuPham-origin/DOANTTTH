use master 
if exists (select * from sysdatabases where name = 'TTTH')
	drop database TTTH

create database TTTH
use TTTH


CREATE TABLE Tai_Khoan
(
	TaiKhoan varchar(20),
	pass varchar(30),
	loai int --1: Giang vien; 2: Hoc vien
	primary key(TaiKhoan)
)


CREATE TABLE Hoc_vien
(
	Ma_HV varchar(20),
	Ten_HV NVARCHAR(50) NOT NULL,
	Nam_sinh DATE NOT NULL,
	Dia_chi NVARCHAR(50) NOT NULL,
	sdt VARCHAR(10) NOT NULL,
	CONSTRAINT pk_maHV PRIMARY KEY (Ma_HV),
);
CREATE TABLE Phong_hoc
(
  Ma_PH INT NOT NULL IDENTITY (1,1),
  Ten_PH NVARCHAR(20) NOT NULL,
  CONSTRAINT pk_maPH PRIMARY KEY (Ma_PH)
);

CREATE TABLE Ca_hoc
(
  Ma_ca INT NOT NULL IDENTITY (1,1),
  Buoi INT NOT NULL,
  Gio_bat_dau DATE NOT NULL,
  Gio_ket_thuc DATE NOT NULL,
  CONSTRAINT pk_MaCa PRIMARY KEY (Ma_ca)
);
CREATE TABLE Giang_vien
(
	Ma_GV varchar(20) NOT NULL,
	Ten_GV NVARCHAR(50) NOT NULL,
	Nam_sinh DATE NOT NULL,
	sdt VARCHAR(10) NOT NULL,
	Que_quan NVARCHAR(25) NOT NULL,
	CONSTRAINT pk_MaGV PRIMARY KEY (Ma_GV),
);
CREATE TABLE Khoa_hoc
(
	Ma_KH INT NOT NULL IDENTITY (1,1),
	Ten_KH NVARCHAR(50) NOT NULL,
	Ma_PH INT NOT NULL,
	Ma_ca INT NOT NULL,
	Ma_GV varchar(20)	NOT NULL,
	Ngay_bat_dau DATE NOT NULL,
	Ngay_ket_thuc DATE NOT NULL,
	Dang_mo BIT,
	Hoc_phi INT NOT NULL,
	So_buoi INT NOT NULL,
	Soluong INT NOT NULL,

	CONSTRAINT pk_MaKH PRIMARY KEY (Ma_KH),
	FOREIGN KEY (Ma_PH) REFERENCES Phong_hoc(Ma_PH),
	FOREIGN KEY (Ma_ca) REFERENCES Ca_hoc(Ma_ca),
	FOREIGN KEY (Ma_GV) REFERENCES Giang_vien(Ma_GV)
);
CREATE TABLE Hoa_don
(
	Ma_hd INT NOT NULL IDENTITY (1,1),
	Ten_hd NVARCHAR(10) NOT NULL,
	Ma_KH INT NOT NULL,
	Ngay_lap DATE DEFAULT getdate() NOT NULL,
	CONSTRAINT pk_MaHD PRIMARY KEY (Ma_hd),
	FOREIGN KEY (Ma_KH) REFERENCES Khoa_hoc(Ma_KH)

);
CREATE TABLE chi_tiet
(
	Ngay_Dang_Ky DATE NOT NULL,
	Ma_HV varchar(20) NOT NULL,
	Ma_KH INT NOT NULL,
	PRIMARY KEY (Ma_HV, Ma_KH),
	FOREIGN KEY (Ma_HV) REFERENCES Hoc_vien(Ma_HV),
	FOREIGN KEY (Ma_KH) REFERENCES Khoa_hoc(Ma_KH)
);
go


--Trigger tu add vao taikhoan sau khi insert Hoc vien

go 
CREATE TRIGGER trg_InsertTaiKhoanForNewStudent
ON Hoc_vien
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (TaiKhoan, pass, loai)
    SELECT inserted.Ma_HV, inserted.sdt, 2
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.Ma_HV = Tai_Khoan.TaiKhoan
    WHERE Tai_Khoan.TaiKhoan IS NULL;
END;
go

go 
CREATE TRIGGER trg_InsertTaiKhoanForNewTeacher
ON Giang_vien
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (TaiKhoan, pass, loai)
    SELECT inserted.Ma_GV, inserted.sdt, 1
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.Ma_GV = Tai_Khoan.TaiKhoan
    WHERE Tai_Khoan.TaiKhoan IS NULL;
END;
go




go
create function dbo.auto_mHV()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(Ma_HV) from Hoc_vien) = 0
		set @ID = '000'
	else
		select @ID = max(right(Ma_HV, 3)) from Hoc_vien
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'HV00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'HV0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go


go
create function dbo.auto_mGV()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(Ma_GV) from Giang_vien) = 0
		set @ID = '000'
	else
		select @ID = max(right(Ma_GV, 3)) from Giang_vien
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'GV00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'GV0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go





go
CREATE PROCEDURE dbo.HocVien_CRUD
	@StatementType VARCHAR(10),
	@Ma_HV VARCHAR(20) = NULL,
	@Ten_HV NVARCHAR(50) = NULL,
	@Nam_sinh DATE = NULL,
	@Dia_chi NVARCHAR(50) = NULL,
	@sdt VARCHAR(10) = NULL
	AS
	BEGIN
		SET NOCOUNT ON;
		IF (@StatementType = 'SELECT')
		BEGIN
			SELECT *
			FROM dbo.Hoc_vien
			WHERE Ma_HV = @Ma_HV
		END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Hoc_vien (Ma_HV, Ten_HV, Nam_sinh, Dia_chi, sdt)
		VALUES (dbo.auto_mHV(), @Ten_HV, @Nam_sinh, @Dia_chi, @sdt)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
	UPDATE dbo.Hoc_vien
		SET Ten_HV = @Ten_HV,
		Nam_sinh = @Nam_sinh,
		Dia_chi = @Dia_chi,
		sdt = @sdt
		WHERE Ma_HV = @Ma_HV
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Hoc_vien
		WHERE Ma_HV = @Ma_HV
	END
END


--CRUD Phonghoc
go
CREATE PROCEDURE dbo.PhongHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_PH INT = NULL,
	@Ten_PH NVARCHAR(20) = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Phong_hoc
		WHERE Ma_PH = @Ma_PH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Phong_hoc (Ten_PH)
		VALUES (@Ten_PH)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Phong_hoc
		SET Ten_PH = @Ten_PH
		WHERE Ma_PH = @Ma_PH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Phong_hoc
		WHERE Ma_PH = @Ma_PH
	END
END

go
CREATE PROCEDURE dbo.CaHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_ca INT = NULL,
	@Buoi INT = NULL,
	@Gio_bat_dau DATE = NULL,
	@Gio_ket_thuc DATE = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Ca_hoc
		WHERE Ma_ca = @Ma_ca
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Ca_hoc (Buoi, Gio_bat_dau, Gio_ket_thuc)
		VALUES (@Buoi, @Gio_bat_dau, @Gio_ket_thuc)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Ca_hoc
		SET Buoi = @Buoi,
		Gio_bat_dau = @Gio_bat_dau,
		Gio_ket_thuc = @Gio_ket_thuc
		WHERE Ma_ca = @Ma_ca
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Ca_hoc
		WHERE Ma_ca = @Ma_ca
	END
END

go
CREATE PROCEDURE dbo.GiangVien_CRUD
	@StatementType VARCHAR(10),
	@Ma_GV VARCHAR(20) = NULL,
	@Ten_GV NVARCHAR(50) = NULL,
	@Nam_sinh DATE = NULL,
	@sdt VARCHAR(10) = NULL,
	@Que_quan NVARCHAR(25) = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Giang_vien
		WHERE Ma_GV = @Ma_GV
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Giang_vien (Ma_GV, Ten_GV, Nam_sinh, sdt, Que_quan)
		VALUES (dbo.auto_mGV(), @Ten_GV, @Nam_sinh, @sdt, @Que_quan)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Giang_vien
		SET Ten_GV = @Ten_GV,
		Nam_sinh = @Nam_sinh,
		sdt = @sdt,
		Que_quan = @Que_quan
		WHERE Ma_GV = @Ma_GV
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Giang_vien
		WHERE Ma_GV = @Ma_GV
	END
END


go
CREATE PROCEDURE dbo.KhoaHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_KH INT = NULL,
	@Ten_KH NVARCHAR(50) = NULL,
	@Ma_PH INT = NULL,
	@Ma_ca INT = NULL,
	@Ma_GV VARCHAR(20) = NULL,
	@Ngay_bat_dau DATE = NULL,
	@Ngay_ket_thuc DATE = NULL,
	@Dang_mo BIT = NULL,
	@Hoc_phi INT = NULL,
	@So_buoi INT = NULL,
	@Soluong INT = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Khoa_hoc
		WHERE Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Khoa_hoc (Ten_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, Hoc_phi, So_buoi, Soluong)
		VALUES (@Ten_KH, @Ma_PH, @Ma_ca, @Ma_GV, @Ngay_bat_dau, @Ngay_ket_thuc, @Dang_mo, @Hoc_phi, @So_buoi, @Soluong)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Khoa_hoc
		SET Ten_KH = @Ten_KH,
		Ma_PH = @Ma_PH,
		Ma_ca = @Ma_ca,
		Ma_GV = @Ma_GV,
		Ngay_bat_dau = @Ngay_bat_dau,
		Ngay_ket_thuc = @Ngay_ket_thuc,
		Dang_mo = @Dang_mo,
		Hoc_phi = @Hoc_phi,
		So_buoi = @So_buoi,
		Soluong = @Soluong
		WHERE Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Khoa_hoc
		WHERE Ma_KH = @Ma_KH
	END
END



go
CREATE PROCEDURE dbo.HoaDon_CRUD
	@StatementType VARCHAR(10),
	@Ma_hd INT = NULL,
	@Ten_hd NVARCHAR(10) = NULL,
	@Ma_KH INT = NULL,
	@Ngay_lap DATE = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Hoa_don
		WHERE Ma_hd = @Ma_hd
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Hoa_don (Ten_hd, Ma_KH, Ngay_lap)
		VALUES (@Ten_hd, @Ma_KH, COALESCE(@ngay_lap, GETDATE()))
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Hoa_don
		SET Ten_hd = @Ten_hd,
		Ma_KH = @Ma_KH,
		Ngay_lap = @Ngay_lap
		WHERE Ma_hd = @Ma_hd
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Hoa_don
		WHERE Ma_hd = @Ma_hd
	END
END


go
CREATE PROCEDURE dbo.ChiTiet_CRUD
	@StatementType VARCHAR(10),
	@Ngay_Dang_Ky DATE = NULL,
	@Ma_HV varchar(20) = NULL,
	@Ma_KH INT = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.chi_tiet
		WHERE Ma_HV = @Ma_HV AND Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.chi_tiet (Ngay_Dang_Ky, Ma_HV, Ma_KH)
		VALUES (@Ngay_Dang_Ky, @Ma_HV, @Ma_KH)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.chi_tiet
		SET Ngay_Dang_Ky = @Ngay_Dang_Ky
		WHERE Ma_HV = @Ma_HV AND Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.chi_tiet
		WHERE Ma_HV = @Ma_HV AND Ma_KH = @Ma_KH
	END
END