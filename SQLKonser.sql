create database konser;
use konser;

create table pengguna(
id_user int not null IDENTITY(1,1) primary key,
nama_lengkap varchar(200) not null,
username varchar(100) not null,
password varchar(100) not null,
jenis_kelamin char(5) check (jenis_kelamin = 'L' or jenis_kelamin = 'P') not null,
no_telp char(14)
);

create table tiket(
id_tiket int identity(1,1) not null primary key,
kode_tiket varchar(100) not null,
nama_tiket varchar(200) not null, 
lokasi varchar(200),
open_gate datetime,
tanggal_mulai datetime,
selesai datetime, 
harga int not null,
foto varchar(500)
);

create table transaksi(
id_transaksi int identity(1,1) not null primary key,
id_user int foreign key references pengguna(id_user),
id_tiket int foreign key references tiket(id_tiket) not null,
kode_transaksi varchar(100) not null,
metode_bayar varchar(100) not null,
kode_pembayaran varchar(100) not null
);

insert into pengguna(nama_lengkap, username, password,jenis_kelamin,no_telp) values ('John Doe','john123','password','L','08123456789');


insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAAEEE0101', 
'Maliq Essentials Oil Concert', 
'2022-01-30 07:00:00',
'2022-01-30 08:00:00',
'2022-01-30 10:00:00',
30000,
'1.png',
'Pekanbaru'
);

insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAEE0102', 
'Musik Lo At The Park', 
'2022-01-22 10:00:00',
'2022-01-22 11:00:00',
'2022-01-22 13:00:00',
50000,
'2.png',
'Jakarta Timur'
);

insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAAEEE0103', 
'JKT48 Tunas Nggk Tumbuh', 
'2022-01-14 13:00:00',
'2022-01-14 14:00:00',
'2022-01-14 18:00:00',
100000,
'3.png',
'Jakarta Pusat'
);

insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAAEEE0104', 
'JKT96 Gadis Tua', 
'2022-01-15 20:00:00',
'2022-01-15 21:00:00',
'2022-01-15 23:30:00',
150000,
'4.png',
'Jakarta Pusat'
);
insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAAEEE0105', 
'An Intimate Hour With Who', 
'2022-02-13 07:00:00',
'2022-02-13 08:00:00',
'2022-02-13 10:00:00',
50000,
'5.png',
'Jakarta Timur'
);
insert into tiket(kode_tiket, nama_tiket, open_gate, tanggal_mulai, selesai, harga, foto, lokasi) 
values(
'AAAEEE0107', 
'Recalling Stereoid Consert', 
'2022-05-25 10:00:00',
'2022-05-25 11:00:00',
'2022-05-25 14:00:00',
120000,
'6.png',
'Pekanbaru'
);