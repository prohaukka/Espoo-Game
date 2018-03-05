﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Politician {

    //TAGET FRÅN https://fi.wikipedia.org/wiki/Luokka:Suomen_ministerit

    string[] politicianForenames = new string[]{
        "Arvo",
        "Aleksi",
        "Matti",
        "Aukusti",
        "Pekka",
        "Paavo",
        "Santeri",
        "Carl Göran",
        "Claes",
        "Vilho",
        "Eero",
        "Toivo",
        "Sirkka-Liisa",
        "Paavo",
        "Atte",
        "Ilmari",
        "Jalo",
        "Matti",
        "Jouni",
        "Arne",
        "Eva",
        "Gustav",
        "Uuno",
        "Reino",
        "Kaj",
        "Einar",
        "Jalmar",
        "Mikko",
        "Tarja",
        "Kaarina",
        "Leo",
        "Karl-Erik",
        "Östen",
        "K. J.",
        "Jan-Erik",
        "Eeli",
        "Eero",
        "Katri-Helena",
        "Margrit",
        "Kusti",
        "Tarja",
        "Ahti",
        "Alexander",
        "Åke",
        "Kristian",
        "Ragnar",
        "Maria",
        "K. F.",
        "Tuula",
        "Pekka",
        "Eero",
        "Leo",
        "Satu",
        "Erkki",
        "Arvo",
        "Heidi",
        "P. V.",
        "Olli-Pekka",
        "Veikko",
        "Albert",
        "Kalevi",
        "Lauri",
        "Kaarlo",
        "Kauko",
        "Pentti",
        "Rudolf",
        "Susanna",
        "Väinö",
        "Ilmari",
        "Terttu",
        "Jorma",
        "Emil",
        "Eemil",
        "Liisa",
        "Jyri",
        "Tuulikki",
        "Erkki",
        "Lauri",
        "Veikko",
        "Toivo",
        "Tytti",
        "Einari",
        "Liisa",
        "Toivo",
        "Matti",
        "Jan-Magnusson",
        "Viikku",
        "Kauko",
        "Antti",
        "Aulis",
        "Kalle",
        "Nestori",
        "Väinö",
        "Lauri",
        "Osmo",
        "Esa",
        "Jouko",
        "Meeri",
        "Yrjö",
        "Viljami",
        "Orvokki",
        "Toimi",
        "Siivo",
        "Eetu",
        "Seija",
        "Tanja",
        "Reino",
        "Irma",
        "Paavo",
        "Anna-Liisa",
        "Kalle",
        "Matti",
        "J. W.",
        "Ilmari",
        "K. E.",
        "Eino",
        "Krista",
        "Lauri",
        "Kalevi",
        "Kauno",
        "Juho",
        "Matti",
        "Gunnar",
        "Martti",
        "Juha",
        "Anna-Liisa",
        "Verner",
        "Arvo",
        "Erik",
        "Heikki",
        "Jari",
        "Niilo",
        "Väinö",
        "Magnus",
        "Henrik",
        "Eino",
        "Pekka",
        "Hertta",
        "Eeva",
        "Merja",
        "Urho",
        "Seppo",
        "Olavi",
        "Marja",
        "Alli",
        "Jermu",
        "Magnus",
        "Sakari",
        "Paula",
        "Pauli",
        "Yrjö",
        "Tyyne",
        "Matti",
        "Juhani",
        "Urpo",
        "Väinö",
        "Niilo",
        "Valdemar",
        "Olavi",
        "Seppo",
        "Lars",
        "Suvi",
        "Erkki",
        "Bertel",
        "Eemil",
        "Heimo",
        "Tuula",
        "Jussi",
        "Kalle",
        "O. W.",
        "Sinikka",
        "Mikko",
        "Matti",
        "Eemil",
        "Erkki",
        "Aino",
        "Arvo",
        "Hannes",
        "Niilo A.",
        "Olavi",
        "Armas-Eino",
        "Olavi J.",
        "Sigurd",
        "Mauri",
        "Yrjö",
        "Lauri",
        "Eero",
        "Hanna",
        "Sinikka",
        "Valde",
        "Aarno",
        "Ville",
        "Martti",
        "Torsten",
        "Ole",
        "Aarne",
        "Onni",
        "Lennart",
        "Olof",
        "Esko"
    };
    string[] politicianSurnames = new string[]{
        "Aalto",
        "Aaltonen",
        "Ahde",
        "Aho",
        "Ahtiala",
        "Aitio",
        "Alkio",
        "Aminoff",
        "Andersson",
        "Annala",
        "Antikainen",
        "Antila",
        "Anttila",
        "Arhimäki",
        "Arola",
        "Auer",
        "Aura",
        "Aura",
        "Backman",
        "Berner",
        "Biaudet",
        "Björkstrand",
        "Brander",
        "Brelilin",
        "Bärlund",
        "Böök",
        "Castren",
        "Collan",
        "Cronberg",
        "Dromberg",
        "Ehrnrooth",
        "Ekholm",
        "Elfving",
        "Ellilä",
        "Enestam",
        "Erkkilä",
        "Erkko",
        "Eskelinen",
        "Eskman",
        "Eskola",
        "Filatov",
        "Frederikson",
        "Frey",
        "Gartz",
        "Gestrin",
        "Granvik",
        "Guezenina",
        "Haapasalo",
        "Haatanen",
        "Haavisto",
        "Hahl",
        "Happonen",
        "Hassl",
        "Haukipuro",
        "Hautala",
        "Hautala",
        "Heikkinen",
        "Heinonen",
        "Helle",
        "von Hellens",
        "Heimilä",
        "Hietanen",
        "Hillilä",
        "Hjerppe",
        "Holappa",
        "Holsti",
        "Huovinen",
        "Hupli",
        "Hustich",
        "Huttu-Juntunen",
        "Huuhtanen",
        "Huunonen",
        "Hynninen",
        "Hyssälä",
        "Häkämies",
        "Hämäläinen",
        "Härmä",
        "Ihalainen",
        "Ihamuotila",
        "Ikonen",
        "Isohookana-Asunmaa",
        "Jaakkola",
        "Jaakonsaari",
        "Janhonen",
        "Janhunen",
        "Jansson",
        "Joukahainen",
        "Juhantalo",
        "Junes",
        "Junttila",
        "Juntila",
        "Kaasalainen",
        "Kaasalainen",
        "Kaijalainen",
        "Kaipainen",
        "Kaitila",
        "Kajanoja",
        "Kalavainen",
        "Kallinen",
        "Kalliokoski",
        "Kangas",
        "Kankaanniemi",
        "Kantala",
        "Karjalainen",
        "Karkinen",
        "Karpela",
        "Karpola",
        "Karvikko",
        "Kastari",
        "Kasurinen",
        "Kauppi",
        "Kekkonen",
        "Keto",
        "Killinen",
        "Kilpeläinen",
        "Kilpi",
        "Kiuru",
        "Kivekäs",
        "Kivistö",
        "Kleemola",
        "Koivisto",
        "Koivunen",
        "Korhonen",
        "Korhonen",
        "Korkeaoja",
        "Korpinen",
        "Korsbäck",
        "Korsimo",
        "Koskenmaa",
        "Koski",
        "Koskinen",
        "Kosola",
        "Kotilainen",
        "Kull",
        "Kullberg",
        "Kuusi",
        "Kuusi",
        "Kuusinen",
        "Kuuskoski",
        "Kyllönen",
        "Kähönen",
        "Kääriäinen",
        "Lahtela",
        "Lahti",
        "Lahtinen",
        "Laine",
        "Lavonius",
        "Lehto",
        "Lehtomäki",
        "Lehtosalo",
        "Leino",
        "Leivo-Larsson",
        "Lepistö",
        "Leppälä",
        "Leppänen",
        "Leskinen",
        "Liakka",
        "Liljeström",
        "Lindblom",
        "Lindblom",
        "Lindeman",
        "Lindén",
        "Lindfors",
        "Lindh",
        "Linna",
        "Linna",
        "Linnainmaa",
        "Linnamo",
        "Lohi",
        "Louhivuori",
        "Luja-Penttilä",
        "Luopajärvi",
        "Luttinen",
        "Luukka",
        "Makkonen",
        "Malkamäki",
        "Manner",
        "Manninen",
        "Mannio",
        "Martikainen",
        "Martola",
        "Mattila",
        "Mattsson",
        "Miettinen",
        "Murto",
        "Murtomaa",
        "Mäkinen",
        "Mäntylä",
        "Mönkäre",
        "Nevalainen",
        "Niini",
        "Niinistö",
        "Niskala",
        "Nordström",
        "Norrback",
        "Nuorvala",
        "Närvänen",
        "Oesch",
        "Ojala",
        "Ollila"
    };

    public LocalPolitics.Parties politicalParty;
    public string politicianName;
    public int popularity = Random.Range(5,20);// of 50
    public int controversy = Random.Range(5, 20);// of 50

    public Politician(LocalPolitics.Parties party) {
        this.politicalParty = party;
        this.politicianName = GeneratePoliticianName();
    }
    string GeneratePoliticianName()
    {
        return politicianForenames[Random.Range(0, politicianForenames.Length)] + " " + politicianSurnames[Random.Range(0, politicianSurnames.Length)];
    }
}
