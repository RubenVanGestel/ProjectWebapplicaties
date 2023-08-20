
-- Opvullen [Klant]
SET IDENTITY_INSERT EfCoreLocal.dbo.Klanten ON
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(1,'Jean','Peeters','Adelberg',15,3920,'Lommel','JeanPeeters@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(2,'Maria','Janssens','Balendijk',27,3920,'Lommel','MariaJanssens@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(3,'Marc','Maes','Hoogstraat',37,3920,'Lommel','MarcMaes@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(4,'Nathalie','Peeters','Binnensingel',18,3920,'Lommel','NathaliePeeters@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(5,'Patrick','Mertens','Nijshoek',45,3920,'Lommel','PatrickMertens@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(6,'Maarten','Boonen','Blokstraat',29,2440,'Geel','MaartenBoonen@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(7,'An','De Smet','Kalverstraat',37,2440,'Geel','AnDeSmet@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(8,'Emma','Peeters','Molenstraat',17,2440,'Geel','EmmaPeeters@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(9,'Stefanie','Wouters','Gasthuisstraat',19,2440,'Geel','StefanieWouters@gmail.com');
INSERT INTO EfCoreLocal.dbo.Klanten(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(10,'Ruben','De Smet','Ossemeer',26,2440,'Geel','RubenDeSmet@gmail.com');

SET IDENTITY_INSERT EfCoreLocal.dbo.Klanten OFF

-- Opvullen [Medewerker]
SET IDENTITY_INSERT EfCoreLocal.dbo.Medewerkers ON
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(1,'Rita','Maes','Bareelstraat',13,2300,'Turnhout','RitaMaes@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(2,'Nicole','Peeters','Kastelein',05,2300,'Turnhout','NicolePeeters@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(3,'Anne','Claes','Kruishuisstraat',09,2300,'Turnhout','AnneClaes@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(4,'Martine','Goossens','Spoorwegstraat',35,2300,'Turnhout','MartineGoossens@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(5,'Bieke','Willems','Molenstraat',104,2300,'Turnhout','BiekeWillems@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(6,'Karel','Jacobs','Akkerstraat',97,2491,'Balen','KarelJacobs@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(7,'Thomas','Van Gestel','Kromstraat',45,2491,'Balen','ThomasVanGestel@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(8,'David','Boonen','Leopoldlaan',73,2491,'Balen','DavidBoonen@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(9,'Michael','Willems','Broekstraat',41,2491,'Balen','MichaelWillems@gmail.com');
INSERT INTO EfCoreLocal.dbo.Medewerkers(Id,Voornaam,Naam,Straatnaam,Huisnummer,Postcode,Gemeente,EmailAdres) VALUES(10,'Jan','De Smet','Rijsberg',86,2491,'Balen','JanDeSmet@gmail.com');

SET IDENTITY_INSERT EfCoreLocal.dbo.Medewerkers OFF


-- Opvullen [PizzaGrootte]
SET IDENTITY_INSERT EfCoreLocal.dbo.PizzaGroottes ON
INSERT INTO EfCoreLocal.dbo.PizzaGroottes(Id,Naam) VALUES(1,'small');
INSERT INTO EfCoreLocal.dbo.PizzaGroottes(Id,Naam) VALUES(2,'medium');
INSERT INTO EfCoreLocal.dbo.PizzaGroottes(Id,Naam) VALUES(3,'large');
INSERT INTO EfCoreLocal.dbo.PizzaGroottes(Id,Naam) VALUES(4,'XL');
INSERT INTO EfCoreLocal.dbo.PizzaGroottes(Id,Naam) VALUES(5,'XXL');
SET IDENTITY_INSERT EfCoreLocal.dbo.PizzaGroottes OFF


-- Opvullen [Pizza]
SET IDENTITY_INSERT EfCoreLocal.dbo.Pizzas ON
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(1,'margherita',1,8);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(2,'margherita',2,10);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(3,'margherita',3,12);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(4,'margherita',4,13);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(5,'margherita',5,14);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(6,'Peperoni',1,9);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(7,'Peperoni',2,11);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(8,'Peperoni',3,13);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(9,'Peperoni',4,14);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(10,'Peperoni',5,15);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(11,'Bolognese',1,10);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(12,'Bolognese',2,12);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(13,'Bolognese',3,14);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(14,'Bolognese',4,15);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(15,'Bolognese',5,16);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(16,'Kebap',1,11);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(17,'Kebap',2,13);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(18,'Kebap',3,15);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(19,'Kebap',4,16);
INSERT INTO EfCoreLocal.dbo.Pizzas(Id,Naam,GrootteId,Prijs) VALUES(20,'Kebap',5,17);
SET IDENTITY_INSERT EfCoreLocal.dbo.Pizzas OFF

-- Opvullen [Status]
SET IDENTITY_INSERT EfCoreLocal.dbo.Statussen ON
INSERT INTO EfCoreLocal.dbo.Statussen(Id,Naam) VALUES(1,'Besteld');
INSERT INTO EfCoreLocal.dbo.Statussen(Id,Naam) VALUES(2,'in Verwerking');
INSERT INTO EfCoreLocal.dbo.Statussen(Id,Naam) VALUES(3,'Onderweg');
INSERT INTO EfCoreLocal.dbo.Statussen(Id,Naam) VALUES(4,'Geleverd');
SET IDENTITY_INSERT EfCoreLocal.dbo.Statussen OFF

-- Opvullen [Bestelling]
SET IDENTITY_INSERT EfCoreLocal.dbo.Bestellingen ON
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(1,1,2,1,'03-15-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(2,10,6,2,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(3,2,4,1,'03-15-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(4,4,5,1,'03-15-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(5,9,9,3,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(6,3,8,2,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(7,5,6,4,'02-28-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(8,4,2,3,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(9,3,7,2,'03-15-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(10,8,7,3,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(12,5,8,3,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(13,8,10,3,'03-15-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(14,6,1,2,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(15,9,3,4,'03-14-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(16,6,9,3,'03-15-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(17,1,2,4,'02-28-2022',0);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(18,7,3,4,'03-11-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(19,2,5,4,'03-10-2022',1);
INSERT INTO EfCoreLocal.dbo.Bestellingen(Id,KlantId,MedewerkerId,StatusId,Datum,IsBezorging) VALUES(20,7,1,4,'03-13-2022',0);
SET IDENTITY_INSERT EfCoreLocal.dbo.Bestellingen OFF
-- Opvullen [BestellingPizza]

SET IDENTITY_INSERT EfCoreLocal.dbo.BestellingPizzas ON
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(1,1,1,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(2,1,7,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(3,2,19,2);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(4,2,17,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(5,3,12,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(6,4,6,2);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(7,5,2,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(8,6,8,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(9,6,12,2);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(10,6,15,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(11,7,3,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(12,7,4,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(13,8,6,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(14,8,9,2);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(15,9,11,3);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(16,10,13,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(17,11,15,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(18,11,17,1);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(19,12,19,2);
INSERT INTO EfCoreLocal.dbo.BestellingPizzas(Id,PizzaId,BestellingId,Aantal) VALUES(20,12,20,1);
SET IDENTITY_INSERT EfCoreLocal.dbo.BestellingPizzas OFF