use muzicka_radnja;

-- Mjesta 
insert into Mjesto (Naziv, Oznaka) values ('Banja Luka','78000');
insert into Mjesto (Naziv, Oznaka) values ('Laktaši','78250');
insert into Mjesto (Naziv, Oznaka) values ('Gradiška','78200');
insert into Mjesto (Naziv, Oznaka) values ('Beograd','11000');
insert into Mjesto (Naziv, Oznaka) values ('Istočno Sarajevo','70000');

-- Osoba
insert into Osoba(IdMjesto, Ime, Prezime, JMB, BrojTelefona, Email, DatumRodjenja, Pol)
 values ((select Id from Mjesto where Naziv = 'Banja Luka'), 'Jovan', 'Marić', '4587652154876','063254789','joca@mail.com',CURRENT_DATE(),'muški');
insert into Osoba(IdMjesto, Ime, Prezime, JMB, BrojTelefona, Email, DatumRodjenja, Pol)
 values ((select Id from Mjesto where Naziv = 'Laktaši'), 'Mirko', 'Malinić', '8546325789521','066365874','mirko@mail.com',CURRENT_DATE(),'muški');
insert into Osoba(IdMjesto, Ime, Prezime, JMB, BrojTelefona, Email, DatumRodjenja, Pol)
 values ((select Id from Mjesto where Naziv = 'Beograd'), 'Jelena', 'Samardžić', '4348652154876','063254321','jeca@mail.com',CURRENT_DATE(),'ženski');
insert into Osoba(IdMjesto, Ime, Prezime, JMB, BrojTelefona, Email, DatumRodjenja, Pol)
 values ((select Id from Mjesto where Naziv = 'Gradiška'), 'Milana', 'Smiljanić', '4587649854876','063254478','miljana@mail.com',CURRENT_DATE(),'ženski');
insert into Osoba(IdMjesto, Ime, Prezime, JMB, BrojTelefona, Email, DatumRodjenja, Pol)
 values ((select Id from Mjesto where Naziv = 'Istočno Sarajevo'), 'Slobodan', 'Rasovski', '4587654584876','063236989','rasovski@mail.com',CURRENT_DATE(),'muški');

-- Zaposleni
insert into Zaposleni (Id, KorisnickoIme, Lozinka, DatumZaposlenja )
    values((select Id from Osoba where JMB = '4587652154876'), 'jovan','jovan', CURRENT_DATE());
insert into Zaposleni (Id, KorisnickoIme, Lozinka, DatumZaposlenja )
    values((select Id from Osoba where JMB = '8546325789521'), 'mirko','mirko', CURRENT_DATE());

-- Klijenti
insert into Klijent (Id, DatumUclanjivanja)
    values((select Id from Osoba where JMB='4348652154876'), CURRENT_DATE());
insert into Klijent (Id, DatumUclanjivanja)
    values((select Id from Osoba where JMB='4587649854876'), CURRENT_DATE());

-- Administrator
insert into Administrator (Id, KorisnickoIme, Lozinka, PoslednjePrijavljivanje)
    values((select  Id from Osoba where JMB = '4587654584876'), 'admin', 'admin', '2020-01-01');

-- Instrument
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Violina Strad Student', 'žičani', '2005', 3500.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Violina Strad Pro', 'žičani', '2015', 7000.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Violina Strad Virtuoso', 'žičani', '2014', 20000.00);

insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Stanway and Sons Grand Piano', 'kombinovani', '2005', 120000.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Yamaha Concert Piano', 'kombinovani', '2000', 50000.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Fazoli Grand Piano', 'kombinovani', '2018', 95000.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Yamaha klavinova', 'kombinovani', '2010', 2000.00);

insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Klarinet Gemax', 'duvački', '2005', 2000.00);
insert into Instrument (Naziv, Vrsta, GodinaProizvodnje, NabavnaCijena )
    values ('Timpan Percus', 'udaraljke', '2005', 1500.00);

-- Instrument Prodaja
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Student'), 4200.00,10,10);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Pro'), 8500.00,10,10);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Virtuoso'), 25000.00,10,10);

insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Stanway and Sons Grand Piano'), 150000.00,5,5);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Yamaha Concert Piano'), 70000.00,5,5);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Fazoli Grand Piano'), 120000.00,5,5);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Yamaha klavinova'), 2800.00,15,15);

insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Klarinet Gemax'), 2500.00,10,10);
insert into InstrumentProdaja (Id, MaloprodajnaCijena, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Timpan Percus'), 2000.00,7,7);

-- Instrument Iznajmljivanje
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Student'), 250.00 ,10 ,10);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Pro'), 800.00,10,10);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Violina Strad Virtuoso'), 3500.00, 10, 10);

insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Stanway and Sons Grand Piano'), 10000.00,5,5);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Yamaha Concert Piano'), 8000.00,5,5);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Fazoli Grand Piano'), 25000.00,5,5);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Yamaha klavinova'), 500.00,15,15);

insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Klarinet Gemax'), 250.00,10,10);
insert into InstrumentIznajmljivanje (Id, CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina)
    values((select Id from Instrument where Naziv = 'Timpan Percus'), 250.00,7,7);

-- Radnja
insert into Radnja (IdMjesto, Naziv, Adresa, ZiroRacun, Banka, Email, Telefon)
    values (1,'Sonnata Shop','Bulevar Stepe Stepanovića 25','4266589522545845','SberbankBanjaLuka','contact@sonata.com','051254857');

-- Radni sati
insert into RadniSati (IdOsoba, poslednjaPrijava, poslednjaOdjava)
    values (1,'2020-05-07' ,'2020-05-07');
insert into RadniSati (IdOsoba, poslednjaPrijava, poslednjaOdjava)
    values (2,'2020-05-05', '2020-05-05');

-- Vrsta placanja
insert into VrstaPlacanja (Naziv, Oznaka)
    values ('Gotovina', 'GOT');
insert into VrstaPlacanja (Naziv, Oznaka)
    values ('Debitna kartica', 'DEBKAR');
insert into VrstaPlacanja (Naziv, Oznaka)
    values ('Kreditna kartica', 'KREDKAR');
insert into VrstaPlacanja (Naziv, Oznaka)
    values ('Ček', 'CHE');

-- Racun
insert into Racun (IdOsoba, IdVrstaPlacanja, DatumVrijemeIzdavanja, UkupanIznos, Popust)
    values(2, 1, '2020-08-08', 250, 0.1);
insert into Racun_ima_InstrumentProdaja (IdRacun, IdInstrument, Kolicina)
    values (1,1,1);

-- Ugovor
insert into Ugovor (IdKlijent, IdZaposeni, DatumSklapanja, PlacanjeNaRate, PeriodIznajmljivanja, Otplaceno, Potpisan, Opis, BrojRata, ProduzavanjeUgovora)
values(3, 1, '2020-05-05', 1, 10, 0, 0, 'Iznajmljivanje klavira.',10,0);
insert into Ugovor_ima_InstrumentIznajmljivanje (IdUgovor, IdInstrument, Kolicina)
values (1, 2, 1);

-- Ugovor uplata
insert into Ugovor_uplata (IdUgovor, IdVrstaPlacanja, IdZaposleni, Svrha, Datum, Vrijeme, Komentar)
values (1, 1, 2, 'Rata za iznajmljivanje', '2020-05-05','12:45' ,'Bez popusta');







