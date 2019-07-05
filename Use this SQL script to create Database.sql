USE [EzManage]
GO
/****** Object:  Table [dbo].[CSVC]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CSVC](
	[IDCSVC] [varchar](50) NOT NULL,
	[TENCSVC] [nvarchar](100) NULL,
	[NGAYNHAP] [date] NULL,
	[SL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCSVC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MAHOADON] [varchar](8000) NOT NULL,
	[MASACH] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC,
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [varchar](50) NOT NULL,
	[MATUASACH] [varchar](50) NULL,
	[SOLUONGNHAPMOI] [int] NULL,
	[NGAYNHAP] [date] NOT NULL,
	[MALOHANG] [nvarchar](20) NULL,
	[NOINHAP] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONBANHANG]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBANHANG](
	[MAHOADON] [varchar](8000) NOT NULL,
	[THANHTIEN] [money] NULL,
	[TIENTHUA] [money] NULL,
	[NGAYLAPHOADON] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONVPP]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONVPP](
	[MAHOADON] [varchar](50) NOT NULL,
	[MALOAISANPHAM] [varchar](20) NULL,
	[SOLUONGMOI] [int] NULL,
	[NGAYNHAP] [date] NOT NULL,
	[MALOHANG] [nvarchar](20) NULL,
	[NHACUNGCAP] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOSACH]    Script Date: 05-Jul-19 9:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOSACH](
	[MATUASACH] [varchar](50) NOT NULL,
	[SOLUONGMOI] [int] NOT NULL,
	[MALOHANG] [nvarchar](20) NULL,
	[TONGSOLUONG] [int] NULL,
	[SOLUONGTONKHO] [int] NULL,
	[NGAYNHAP] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATUASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOVANPHONGPHAM]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOVANPHONGPHAM](
	[MALOAISANPHAM] [varchar](20) NOT NULL,
	[SOLUONGTONKHO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAISANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PASSWORD]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PASSWORD](
	[ID] [varchar](20) NOT NULL,
	[USERNAME] [nvarchar](20) NOT NULL,
	[PASS] [nvarchar](100) NOT NULL,
	[ACCESSLEVEL] [int] NOT NULL,
 CONSTRAINT [PK__PASSWORD__3214EC27439C141F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [varchar](50) NOT NULL,
	[TENSACH] [nvarchar](100) NOT NULL,
	[TENTG] [nvarchar](100) NOT NULL,
	[DICHGIA] [nvarchar](50) NULL,
	[GIA] [int] NOT NULL,
	[THELOAI] [nvarchar](100) NOT NULL,
	[NGAYXB] [date] NULL,
	[LANTAIBAN] [int] NULL,
	[MATUASACH] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALARY]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALARY](
	[ID] [varchar](20) NOT NULL,
	[MONTH] [varchar](10) NOT NULL,
	[YEAR] [int] NOT NULL,
	[TOTALTIME] [int] NULL,
	[BS] [int] NOT NULL,
	[ADDS] [int] NULL,
	[SLR] [int] NULL,
	[SALARYLV] [float] NULL,
 CONSTRAINT [PK__SALARY__3214EC275E60A51A] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[MONTH] ASC,
	[YEAR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[ID] [varchar](20) NOT NULL,
	[FULLNAME] [nvarchar](50) NOT NULL,
	[DOB] [date] NULL,
	[LOCA] [nvarchar](50) NOT NULL,
	[SEX] [int] NOT NULL,
	[PHONE] [varchar](20) NOT NULL,
	[PAYRATE] [float] NOT NULL,
	[BASICRATE] [int] NOT NULL,
	[ALLOWENCE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFFLOG]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFFLOG](
	[ID] [varchar](20) NOT NULL,
	[LOGINTIME] [datetime] NOT NULL,
	[LOGOUTTIME] [datetime] NOT NULL,
	[LV] [int] NOT NULL,
	[USERNAME] [nvarchar](20) NOT NULL,
	[WTIME] [int] NOT NULL,
 CONSTRAINT [SL_PRIMARYKEY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[LOGINTIME] ASC,
	[LOGOUTTIME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VANPHONGPHAM]    Script Date: 05-Jul-19 9:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VANPHONGPHAM](
	[GIA] [money] NULL,
	[NGAYSANXUAT] [datetime] NULL,
	[HANSUDUNG] [datetime] NULL,
	[MASANPHAM] [varchar](50) NOT NULL,
	[NHASANXUAT] [nvarchar](100) NULL,
	[MALOAISANPHAM] [varchar](20) NOT NULL,
	[DANHMUC] [nvarchar](100) NULL,
	[TENSANPHAM] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADONBANHANG] ([MAHOADON])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADONBANHANG] ([MAHOADON])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADONBANHANG] ([MAHOADON])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MATUASACH])
REFERENCES [dbo].[KHOSACH] ([MATUASACH])
GO
ALTER TABLE [dbo].[HOADONVPP]  WITH CHECK ADD  CONSTRAINT [FK_MALOAISANPHAM_KHOVANPHONGPHAM] FOREIGN KEY([MALOAISANPHAM])
REFERENCES [dbo].[KHOVANPHONGPHAM] ([MALOAISANPHAM])
GO
ALTER TABLE [dbo].[HOADONVPP] CHECK CONSTRAINT [FK_MALOAISANPHAM_KHOVANPHONGPHAM]
GO
ALTER TABLE [dbo].[PASSWORD]  WITH CHECK ADD  CONSTRAINT [FK_PW_ST0] FOREIGN KEY([ID])
REFERENCES [dbo].[STAFF] ([ID])
GO
ALTER TABLE [dbo].[PASSWORD] CHECK CONSTRAINT [FK_PW_ST0]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_KHOSACH_MATUASACH] FOREIGN KEY([MATUASACH])
REFERENCES [dbo].[KHOSACH] ([MATUASACH])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_KHOSACH_MATUASACH]
GO
ALTER TABLE [dbo].[SALARY]  WITH CHECK ADD  CONSTRAINT [FK_SLR_ST] FOREIGN KEY([ID])
REFERENCES [dbo].[STAFF] ([ID])
GO
ALTER TABLE [dbo].[SALARY] CHECK CONSTRAINT [FK_SLR_ST]
GO
