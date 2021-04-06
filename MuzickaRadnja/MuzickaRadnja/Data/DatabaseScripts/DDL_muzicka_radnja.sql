-- Zelimir Maletic
-- Projektni zadatak - Muzicka radnja
-- Baze podataka 2020
-- ETF Banja Luka

drop schema  if exists  muzicka_radnja;
create schema muzicka_radnja default  character set utf8;
use muzicka_radnja;

-- Radnja
create table Mjesto(
    Id int(5) unsigned zerofill auto_increment,
    Naziv varchar(45) not null ,
    Oznaka varchar(10) unique ,
    -- KEYS
    primary key (Id)
)ENGINE = InnoDB;

create table Radnja(
    Id int(2) unsigned zerofill auto_increment,
    IdMjesto int unsigned not null ,
    Naziv varchar(45) not null ,
    Adresa varchar(45),
    ZiroRacun varchar(16),
    Banka varchar(45),
    Email varchar(45),
    Telefon varchar(20),
    -- KEYS
    primary key (Id),
    foreign key (IdMjesto)
        references Mjesto(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;


-- Instrumenti
create table Instrument(
    Id int(6) unsigned zerofill auto_increment,
    Naziv varchar(45) not null ,
    Vrsta varchar(25) not null ,
    GodinaProizvodnje year,
    NabavnaCijena double not null ,
    -- KEYS
    primary key (Id)
)engine = InnoDB;

create table InstrumentProdaja(
    Id int(6) unsigned zerofill,
    MaloprodajnaCijena double not null ,
    DostupnaKolicina int unsigned not null ,
    UkupnaNabavnaKolicina int unsigned not null ,
    -- KEYS
    primary key (Id),
    foreign key (Id)
        references Instrument(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table InstrumentIznajmljivanje(
    Id int(6) unsigned zerofill,
    CijenaIznajmljivanja double not null ,
    DostupnaKolicina int unsigned,
    UkupnaNabavnaKolicina int unsigned,
    -- KEYS
    primary key (Id),
    foreign key (Id)
        references Instrument(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

-- Osobe

create table Osoba(
  Id int(6) unsigned zerofill auto_increment,
  IdMjesto int unsigned not null ,
  Ime varchar(40) not null ,
  Prezime varchar(40) not null ,
  JMB varchar(13) unique not null ,
  BrojTelefona varchar(20),
  Email varchar(45),
  DatumRodjenja date,
  Pol varchar(15),
  -- KEYS
  primary key (Id),
  foreign key (IdMjesto)
        references Mjesto(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table Zaposleni(
  Id int(6) unsigned zerofill,
  KorisnickoIme varchar(20) unique not null ,
  Lozinka varchar(20) not null ,
  DatumZaposlenja date,
  -- KEYS
  primary key (Id),
  foreign key (Id)
        references Osoba(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table Klijent(
  Id int(6) unsigned zerofill,
  DatumUclanjivanja date,
  -- KEYS
  primary key (Id),
  foreign key (Id)
        references Osoba(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

-- Administracija
create table Administrator(
    Id int(6) unsigned zerofill,
    KorisnickoIme varchar(45) unique not null ,
    Lozinka varchar(45) not null ,
    PoslednjePrijavljivanje datetime,
    -- KEYS
    primary key (Id),
    foreign key (Id)
        references Osoba(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table RadniSati(
    Id int unsigned auto_increment,
    IdOsoba int  unsigned not null ,
    poslednjaPrijava datetime not null ,
    poslednjaOdjava datetime not null ,
    -- KEYS
    primary key (Id),
    foreign key (IdOsoba)
        references Zaposleni(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

-- Prodaja
create table VrstaPlacanja(
    Id int(3) unsigned zerofill auto_increment,
    Naziv varchar(45) not null ,
    Oznaka varchar(10) not null ,
    -- KEYS
    primary key (Id)
)ENGINE = InnoDB;

create table Racun(
    Id int unsigned auto_increment,
    IdOsoba int unsigned not null ,
    IdVrstaPlacanja int unsigned not null ,
    DatumVrijemeIzdavanja datetime not null ,
    UkupanIznos double not null ,
    Popust double default 0.0,
    -- KEYS
    primary key (Id),
    foreign key (IdVrstaPlacanja)
        references VrstaPlacanja(Id)
        on update cascade on delete restrict,
    foreign key (IdOsoba)
        references Zaposleni(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table Racun_ima_InstrumentProdaja(
    IdRacun int unsigned,
    IdInstrument int unsigned,
    Kolicina int unsigned not null ,
    -- KEYS
    primary key (IdRacun, IdInstrument),
    foreign key (IdRacun)
        references Racun(Id)
        on update cascade on delete restrict,
    foreign key (IdInstrument)
        references InstrumentProdaja(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

-- Iznajmljivanje

create table Ugovor(
    Id int unsigned auto_increment,
    IdKlijent int unsigned not null ,
    IdZaposeni int unsigned not null ,
    DatumSklapanja date not null ,
    PlacanjeNaRate tinyint default true not null,
    PeriodIznajmljivanja int not null ,
    Otplaceno tinyint default false not null ,
    Potpisan tinyint default false not null ,
    Opis text(150),
    BrojRata int unsigned not null ,
    ProduzavanjeUgovora int unsigned default 0,
    -- KEYS
    primary key (Id),
    foreign key (IdKlijent)
        references Klijent(Id)
        on update cascade on delete restrict ,
    foreign key (IdZaposeni)
        references Zaposleni(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table Ugovor_ima_InstrumentIznajmljivanje(
    IdUgovor int unsigned,
    IdInstrument int unsigned,
    Kolicina int unsigned,
    -- KEYS
    primary key (IdUgovor, IdInstrument),
    foreign key (IdUgovor)
        references Ugovor(Id)
        on update cascade on delete restrict ,
    foreign key (IdInstrument)
        references InstrumentIznajmljivanje(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table Ugovor_uplata(
    Id int unsigned auto_increment,
    IdUgovor int unsigned not null ,
    IdVrstaPlacanja int unsigned not null ,
    IdZaposleni int unsigned not null ,
    Svrha varchar(100),
    Datum date,
    Vrijeme time,
    Komentar text(150),
    -- KEYS
    primary key (Id),
    foreign key (IdUgovor)
        references Ugovor(Id)
        on update cascade on delete restrict ,
    foreign key (IdVrstaPlacanja)
        references VrstaPlacanja(Id)
        on update cascade on delete restrict ,
    foreign key (IdZaposleni)
        references Zaposleni(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;

create table RazduzivanjeInstrumenta(
    Id int unsigned auto_increment,
    IdZaposleni int unsigned not null ,
    IdKlijent int unsigned not null ,
    IdUgovor int unsigned not null ,
    DatumVracanja date not null ,
    OpisOstecenja text(150),
    NaknadaZaOstecenja double default 0.0,
    -- KEYS
    primary key (Id),
    foreign key (IdZaposleni)
        references Zaposleni(Id)
        on update cascade on delete restrict ,
    foreign key (IdKlijent)
        references Klijent(Id)
        on update cascade on delete restrict ,
    foreign key (IdUgovor)
        references Ugovor(Id)
        on update cascade on delete restrict
)ENGINE = InnoDB;
