/****** Object:  Table [dbo].[products]    Script Date: 2016-11-10 2:04:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[productID] [smallint] IDENTITY(1,1) NOT NULL,
	[cost] [money] NULL,
	[manufacturer] [nvarchar](255) NULL,
	[model] [nvarchar](255) NULL,
	[RAM_type] [nvarchar](255) NULL,
	[RAM_size] [nvarchar](255) NULL,
	[displaytype] [nvarchar](255) NULL,
	[screensize] [nvarchar](255) NULL,
	[resolution] [nvarchar](255) NULL,
	[CPU_Class] [nvarchar](255) NULL,
	[CPU_brand] [nvarchar](255) NULL,
	[CPU_type] [nvarchar](255) NULL,
	[CPU_speed] [nvarchar](255) NULL,
	[CPU_number] [nvarchar](255) NULL,
	[condition] [nvarchar](255) NULL,
	[OS] [nvarchar](255) NULL,
	[platform] [nvarchar](255) NULL,
	[HDD_size] [nvarchar](255) NULL,
	[HDD_speed] [nvarchar](255) NULL,
	[GPU_Type] [nvarchar](255) NULL,
	[optical_drive] [nvarchar](255) NULL,
	[Audio_type] [nvarchar](255) NULL,
	[LAN] [nvarchar](255) NULL,
	[WIFI] [nvarchar](255) NULL,
	[width] [nvarchar](255) NULL,
	[height] [nvarchar](255) NULL,
	[depth] [nvarchar](255) NULL,
	[weight] [nvarchar](255) NULL,
	[moust_type] [nvarchar](255) NULL,
	[power] [nvarchar](255) NULL,
	[webcam] [nvarchar](255) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (1, 719.9700, N'Asus ', N'G71GX-RX05', N'DDR2', N'6GB', N'WXGA+ TFT active matrix', N'17.1"', N'1440 x 900', N'Core Duo', N'Intel', N'Dual-Core', N'2.53GHz', N'P8700', N'Refurbished', N'Windows Vista Home Premium 64-Bit', N'Laptop', N'500GB', N'5400 RPM', N'NVIDIA GeForce GTX 260M', N'DVD Super Multi Burner', N'Integrated Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.2"', N'2.0"', N'11.8"', N'8.8 lbs', N'Touch Pad', N'8-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (2, 799.9600, N'Asus ', N'X73SV-XR1', N'DDR3', N'4GB', N'Full HD Color-Shine Glare-type Display', N'17.3"', N'1600 x 900', N'Core i5', N'Intel', N'Dual-Core', N'2.30GHz', N'i5-2410M', N'New', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'750GB', N'5400 RPM', N'Intel Graphics Media Accelerator HD', N'DVD Super Multi Burner/BD Player', N'Integrated Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.8"', N'1.5”', N'11.2"', N'6.9 lbs', N'Touch Pad', N'6-Cell Lithium-ion', N'0.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (3, 1052.9900, N'Lenovo ', N'G770', N'DDR3', N'4GB', N'HD+ VibrantView LED Backlight', N'17.3"', N'1600 x 900', N'Core i3', N'Intel', N'Dual-Core', N'2.1GHz', N'2310M', N'Open Box', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'500GB', N'5400 RPM', N'Intel HD Graphics 3000', N'DVD Dual Layer Burner', N'High-Definition Audio', N'10/100 Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.38"', N'1.77"', N'10.71"', N'6.61 lbs', N'Touchpad', N'6-Cell Lithium-ion', N'2.0MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (4, 1263.9600, N'Acer', N'AS7750G-9621 ', N'DDR3', N'8GB', N'HD+ Widescreen CineCrystal LED-backlit Display', N'17.3"', N'1600 x 900', N'Core i7', N'Intel', N'Quad-Core', N'2.0GHz', N'i7-2630QM', N'Open Box', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'750GB', N'5400 RPM', N'ATI Mobility Radeon HD 6650M', N'DVD Super Multi Burner/BD Player', N'Optimized Dolby Advanced Audio v2 audio enhancement', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.59"', N'1.38"', N'11"', N'7.27 lbs', N'Multi-Gesture Touchpad', N'6-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (5, 799.9700, N'Asus ', N'G73JH-BST7', N'DDR3', N'6GB', N'HD LED-backlit Widescreen Display', N'17.3"', N'1600 x 900', N'Core i7', N'Intel', N'Quad-Core', N'1.73GHz', N'i7-740QM', N'Refurbished', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'640GB', N'5400 RPM', N'ATI Mobility Radeon HD 5870', N'DVD Super Multi Burner', N'Integrated Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.34"', N'2.24"', N'12.60"', N'8.45 lbs.', N'Touchpad', N'8-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (6, 1499.9900, N'Asus ', N'G74Sx-RH71', N'DDR3', N'12GB', N'Full HD LED Backlight', N'17.3"', N'1920 x 1080', N'Core i7', N'Intel', N'Quad-Core', N'2.20GHz', N'i7-2670QM', N'New', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'750GB', N'7200 RPM', N'NVIDIA GeForce GTX 560M', N'DVD Super Multi Burner', N'THX TruStudio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.5"', N'2.4"', N'12.8"', N'9.5 lbs', N'Touchpad', N'8-Cell Lithium-ion', N'2.0MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (7, 1499.9900, N'Toshiba ', N'X770-01J', N'DDR3', N'8GB', N'LED backlight', N'17.3"', N'1600 x 900', N'Core i7', N'Intel', N'Quad-Core', N'2.0GHz', N'i7-2630QM', N'New', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'1TB', N'5400 RPM', N'NVIDIA GeForce GTX 560M', N'DVD Super Multi Burner/BD Player', N'High-Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'16.3"', N'1.7"', N'10.8"', N'7.5 lbs', N'Touchpad', N'8-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (8, 275.9900, N'HP ', N'nx6125', N'DDR', N'512MB', N'SXGA+ wide viewing angle', N'15.4" ', N'1400 x 1050', N'Turion 64', N'AMD', N'Single-Core', N'1.6GHz', N'ML-30', N'Off-Lease', N'Windows XP Pro 32-Bit', N'Laptop', N'40GB', N'5400 RPM', N'ATI Mobility Radeon X300', N'CDROM Burner/DVD Player', N'HP Premier Sound 16-bit Sound', N'10/100 Ethernet LAN', N'802.11b/g Wireless Networking', N'12.9"', N'1.22"', N'10.6"', N'5.9 lb', N'Touchpad', N'6-Cell Lithium-ion', N'None')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (9, 395.9700, N'Lenovo ', N'T61', N'DDR2', N'1GB', N'WXGA anti-glare', N'15.4" ', N'1280 × 800', N'Core 2 Duo', N'Intel', N'Dual-Core', N'2GHz', N'T7300', N'Off-Lease', N'Windows XP Pro 32-Bit', N'Laptop', N'80GB', N'5400 RPM', N'Intel Graphics Media Accelerator X3100', N'CDROM Burner/DVD Player', N'High-Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11a/b/g Wireless Networking', N'14.1"', N'1.4"', N'10.0"', N'5.9 lb', N'TrackPoint', N'6-Cell Lithium-ion', N'None')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (10, 499.0000, N'HP ', N'630', N'DDR3', N'4GB', N'LED-backlit HD anti-glare', N'15.6" ', N'1366 x 768', N'Core i3', N'Intel', N'Dual-Core', N'2.40GHz', N'i3-370M', N'New', N'Windows 7 Professional 64-Bit', N'Laptop', N'500GB', N'5400 RPM', N'Intel Graphics Media Accelerator 4500MHD', N'DVD Super Multi Dual Layer Burner', N'High-Definition Audio', N'10/100 Ethernet LAN', N'802.11b/g/n Wireless Networking', N'14.80"', N'1.41"', N'9.72"', N'5.5 lbs', N'Multi-Gesture Touchpad', N'6-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (11, 572.9600, N'Acer ', N'AS5552-7686 ', N'DDR3', N'6GB', N'Acer CineCrystal LED Backlit Display', N'15.6"', N'1366 x 768', N'Phenom II', N'AMD', N'Quad-Core', N'2.20GHz', N'N970', N'Open Box', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'500GB', N'5400 RPM', N'ATI Radeon HD 4250', N'DVD Super Multi Dual Layer Burner', N'High Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'15"', N'1.3"', N'9.9"', N'5.74 lbs', N'Multi-Gesture Touchpad', N'6-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (12, 769.9900, N'Toshiba ', N'P750-00Y', N'DDR3', N'6GB', N'LED backlight', N'15.6"', N'1366 x 768', N'Core i5', N'Intel', N'Dual-Core', N'2.30GHz', N'i5-2410M', N'New', N'Windows 7 Home Premium 64-Bit', N'Laptop', N'640GB', N'5400 RPM', N'Intel HD Graphics 3000', N'DVD Super Multi Dual Layer Burner', N'High-Definition Audio', N'10/100 Ethernet LAN', N'802.11b/g/n Wireless Networking', N'15.0"', N'1.5"', N'10"', N'5.8 lbs', N'Multi-Gesture Touchpad', N'6-Cell Lithium-ion', N'1.3MP')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (13, 799.9900, N'HP ', N'HPE h8-1010', N'DDR3', N'8GB', N'NA', N'NA', N'NA', N'Core i5', N'Intel', N'Dual-Core', N'2.70GHz', N'i5-2390T', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'AMD Radeon HD 6450', N'SuperMulti DVD Burner', N'Realtek ALC656', N'10/100/1000 Gigabit Ethernet LAN', N'802.11 b/g/n PCI Express Wireless Mini Card', N'NA', N'NA', N'NA', N'NA', N'USB', N'300 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (14, 1199.9900, N'iBUYPOWER', N'968SLCK', N'DDR3', N'8GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.4GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'Nvidia GTS 450', N'DVDRW Dual Layer', N'Integrated Audio', N'10/100/1000 Gigabit Ethernet LAN', N'NA', N'8.74"', N'21.29"', N'24.26"', N'NA', N'USB', N'700 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (15, 1399.9900, N'CybertronPC', N'TGM2111E', N'DDR3', N'16GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.4GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'NVIDIA GeForce GTX 550 Ti', N'Blu-ray ROM', N'High Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'NA', N'7.9"', N'18"', N'19.7"', N'NA', N'USB', N'600 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (16, 1599.9900, N'iBUYPOWER', N'964SLCK', N'DDR3', N'8GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.46GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'AMD Radeon HD 6850', N'Blu-Ray Player/DVD Burner', N'Integrated Audio', N'10/100/1000 Gigabit Ethernet LAN', N'NA', N'8.74"', N'21.29"', N'24.26"', N'NA', N'USB', N'800 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (17, 1499.9900, N'CybertronPC', N'TGM2141L', N'DDR3', N'16GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.4GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'2 - AMD Radeon HD 6670 in CrossFireX Configuration', N'Blu-ray ROM', N'High Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'NA', N'7.9"', N'18"', N'19.7"', N'NA', N'USB', N'600 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (18, 4699.9900, N'CybertronPC', N'TGM2171C', N'DDR3', N'16GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.4GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'NVIDIA GeForce GTX 590', N'Blu-ray ROM', N'High Definition Audio', N'10/100/1000 Gigabit Ethernet LAN', N'NA', N'12.52"', N'26.22"', N'24.17"', N'NA', N'USB', N'1000 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (19, 1499.9900, N'Gateway ', N'FX6860-EF30P', N'DDR3', N'16GB', N'NA', N'NA', N'NA', N'Core i7', N'Intel', N'Quad-Core', N'3.4GHz', N'i7-2600K', N'New', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'2 TB', N'7200 RPM', N'NVIDIA GeForce GTX 560 Ti', N'Blu-ray/DVD optical combo drive', N'High-Definition Audio With 5.1-Channel', N'10/100/1000 Gigabit Ethernet LAN', N'802.11 b/g/n PCI Express Wireless Mini Card', N'7"', N'14.9"', N'15.8"', N'31.08 lbs', N'USB', N'750 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (20, 699.9900, N'HP ', N'P7-1047', N'DDR3', N'6 GB', N'NA', N'NA', N'NA', N'Core i5', N'Intel', N'Quad-Core', N'2.50 GHz', N'i5-2400K', N'Refurbished', N'Windows 7 Home Premium 64-Bit', N'Desktop PC', N'1TB', N'7200 RPM', N'Intel HD Graphics', N'SuperMulti DVD Burner', N'Intel H61 PCH Chipset', N'10/100 Ethernet LAN', N'802.11b/g/n Wireless Networking', N'6.89"', N'15.28"', N'16.14"', N'21.16 lbs', N'USB', N'600 Watt', N'NA')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (21, 1199.9900, N'Apple', N'iMac', N'DDR3', N'4GB', N'backlit glossy widescreen TFT display', N'21.5"', N'1920 x 1080', N'Core i5', N'Intel', N'Quad-Core', N'2.50 GHz', N'i5-2400K', N'New', N'OS X Lion', N'Desktop PC', N'500GB', N'7200 RPM', N'AMD Radeon HD 6750M', N'8x SuperDrive with 4x Double-Layer', N'Apple Audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'20.8"', N'17.75"', N'7.42"', N'20.5 lbs', N'Wireless', N'NA', N'HD')
INSERT [dbo].[products] ([productID], [cost], [manufacturer], [model], [RAM_type], [RAM_size], [displaytype], [screensize], [resolution], [CPU_Class], [CPU_brand], [CPU_type], [CPU_speed], [CPU_number], [condition], [OS], [platform], [HDD_size], [HDD_speed], [GPU_Type], [optical_drive], [Audio_type], [LAN], [WIFI], [width], [height], [depth], [weight], [moust_type], [power], [webcam]) VALUES (22, 3599.0000, N'Apple', N'Mac Pro', N'DDR3', N'6 GB', N'NA', N'NA', N'NA', N'Xeon', N'Intel', N'8-Core', N'2.66GHz', N'E5620', N'New', N'OS X Lion', N'Desktop PC', N'1TB', N'7200 RPM', N'ATI Radeon HD 5770 with 1GB GDDR5', N'18x SuperDrive with double-layer support', N'Optical digital audio', N'10/100/1000 Gigabit Ethernet LAN', N'802.11b/g/n Wireless Networking', N'8.1"', N'20.1"', N'18.7"', N'41.2 lbs', N'Wireless', N'NA', N'NA')
SET IDENTITY_INSERT [dbo].[products] OFF
USE [master]
GO
ALTER DATABASE [DollarComputers] SET  READ_WRITE 
GO
