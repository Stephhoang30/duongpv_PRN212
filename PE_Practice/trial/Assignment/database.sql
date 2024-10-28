USE [master]
GO

CREATE DATABASE [DUONGPV14_PRN]
GO
USE [DUONGPV14_PRN]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tạo bảng Lecturers
CREATE TABLE [dbo].[Lecturers](
    [Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](40) NOT NULL,
    [Male] [bit] NOT NULL,
    [Dob] [date] NOT NULL,
    [Note] [ntext] NOT NULL,
 CONSTRAINT [PK_Lecturers] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- Tạo bảng Students
CREATE TABLE [dbo].[Students](
    [Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](40) NOT NULL,
    [Male] [bit] NOT NULL,
    [Dob] [date] NOT NULL,
    [Note] [ntext] NOT NULL,
	[Nationality] [ntext],
	[LectureId] [int] NOT NULL
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

-- Tạo bảng Subjects
CREATE TABLE [dbo].[Subjects](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Subject] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng Classes
CREATE TABLE [dbo].[Classes](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [ClassName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng Student_Subject
CREATE TABLE [dbo].[Student_Subject](
    [StudentId] [int] NOT NULL,
    [SubjectId] [int] NOT NULL,
    [Grade] [float] NOT NULL,
 CONSTRAINT [PK_Student_Subject] PRIMARY KEY CLUSTERED 
(
    [StudentId] ASC,
    [SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng Student_Class
CREATE TABLE [dbo].[Student_Class](
    [StudentId] [int] NOT NULL,
    [ClassId] [int] NOT NULL,
 CONSTRAINT [PK_Student_Class] PRIMARY KEY CLUSTERED 
(
    [StudentId] ASC,
    [ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Thêm ràng buộc khóa ngoại
-- Ràng buộc giữa bảng Student_Subject và bảng Subjects
ALTER TABLE [dbo].[Student_Subject]
ADD CONSTRAINT FK_Student_Subject_Subjects
FOREIGN KEY (SubjectId) REFERENCES [dbo].[Subjects](Id);

-- Ràng buộc giữa bảng Student_Subject và bảng Students
ALTER TABLE [dbo].[Student_Subject]
ADD CONSTRAINT FK_Student_Subject_Students
FOREIGN KEY (StudentId) REFERENCES [dbo].[Students](Id);

-- Ràng buộc giữa bảng Student_Class và bảng Classes
ALTER TABLE [dbo].[Student_Class]
ADD CONSTRAINT FK_Student_Class_Classes
FOREIGN KEY (ClassId) REFERENCES [dbo].[Classes](Id);

-- Ràng buộc giữa bảng Student_Class và bảng Students
ALTER TABLE [dbo].[Student_Class]
ADD CONSTRAINT FK_Student_Class_Students
FOREIGN KEY (StudentId) REFERENCES [dbo].[Students](Id);

ALTER TABLE [dbo].[Students]
ADD CONSTRAINT FK_Students_Lecturers
FOREIGN KEY (LectureId) REFERENCES [dbo].[Lecturers](Id);



-- Thêm dữ liệu vào bảng Lecturers
INSERT INTO [dbo].[Lecturers] ([FullName], [Male], [Dob], [Note]) VALUES
('John Doe', 1, '1975-04-12', 'Professor of Mathematics'),
('Jane Smith', 0, '1980-09-15', 'Professor of Computer Science'),
('Robert Brown', 1, '1970-11-23', 'Professor of Physics');
GO


-- Thêm dữ liệu vào bảng Students
INSERT INTO [dbo].[Students] ([FullName], [Male], [Dob], [Note], [Nationality], [LectureId]) VALUES
('Alice Johnson', 0, '2000-03-01', 'Freshman student', 'American', 1),
('Bob Lee', 1, '1999-07-21', 'Sophomore student', 'Canadian', 2),
('Charlie Kim', 1, '2001-11-11', 'Junior student', 'Korean', 3),
('David Park', 1, '2002-01-20', 'Senior student', 'Korean', 1),
('Eva Green', 0, '2000-05-30', 'Freshman student', 'British', 2);
GO


-- Thêm dữ liệu vào bảng Subjects
INSERT INTO [dbo].[Subjects] ([Subject]) VALUES
('PRN212'),
('PRN221'),
('PRN231');
GO

-- Thêm dữ liệu vào bảng Classes
INSERT INTO [dbo].[Classes] ([ClassName]) VALUES
('SE0001'),
('SE0002'),
('SE0003');
GO

-- Thêm dữ liệu vào bảng Student_Subject (10 dữ liệu mới)
INSERT INTO [dbo].[Student_Subject] ([StudentId], [SubjectId], [Grade]) VALUES
(1, 2, 78.0),
(1, 3, 88.5),
(2, 1, 82.0),
(2, 3, 85.0),
(3, 1, 90.0),
(3, 2, 89.5),
(4, 2, 91.0),
(4, 3, 84.0),
(5, 1, 86.0),
(5, 3, 87.5),
(1, 1, 85.5),
(2, 2, 90.0),
(3, 3, 75.0),
(4, 1, 88.0),
(5, 2, 92.5);
GO

-- Thêm dữ liệu vào bảng Student_Class (10 dữ liệu mới)
INSERT INTO [dbo].[Student_Class] ([StudentId], [ClassId]) VALUES
(1, 2),
(1, 3),
(2, 1),
(2, 3),
(3, 1),
(3, 2),
(4, 2),
(4, 3),
(5, 1),
(5, 3),
(1, 1),
(2, 2),
(3, 3),
(4, 1),
(5, 2);
GO