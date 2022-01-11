﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedGenerator
{
    internal class Constants
    {
        public static readonly string[] Firstnames =
            new[] { "Ada", "Alice", "Amanda", "Amy", "Andrea", "Angel", "Angelia", "Angelita", "Angie", "Augusta", "Avis", "Baker", "Banks", "Barnes", "Battle", "Beach", "Bennett", "Betty", "Black", "Bolton", "Bowen", "Bradley", "Brooks", "Bruce", "Bullock", "Bush", "Carmen", "Carroll", "Cassandra", "Cathryn", "Chambers", "Chavez", "Cheri", "Christi", "Cindy", "Cleveland", "Coleman", "Contreras", "Cooke", "Corinne", "Cox", "Craft", "Curry", "Dale", "Dana", "Daphne", "Davenport", "Deann", "Deanne", "Debbie", "Dena", "Dennis", "Diaz", "Dina", "Dixie", "Dolores", "Dora", "Doreen", "Dunlap", "Durham", "Elliott", "Eloise", "Elva", "English", "Erna", "Espinoza", "Estela", "Eva", "Ewing", "Faye", "Fern", "Florence", "Florine", "Franklin", "Frieda", "Frost", "Fulton", "Galloway", "Gamble", "Gardner", "Gena", "George", "Glass", "Glenda", "Goff", "Gonzalez", "Goodman", "Greene", "Gross", "Guadalupe", "Hardin", "Harrington", "Harrison", "Hawkins", "Hazel", "Heidi", "Henderson", "Hensley", "Herring", "Hilda", "Holland", "Hood", "Horton", "House", "Hughes", "Hull", "Hurst", "Ina", "Isabel", "Jaclyn", "Jami", "Janell", "Janie", "Jean", "Jeannette", "Jefferson", "Jenny", "Jessie", "Jewell", "Jo", "Jodi", "Johanna", "Joyce", "Judith", "Kathryn", "Keisha", "Keith", "Kelley", "Kennedy", "Kerri", "Kim", "Klein", "Kristi", "Kristie", "Kristin", "Kristina", "Lamb", "Lambert", "Lancaster", "Lane", "Lawrence", "Leola", "Lewis", "Lillian", "Lillie", "Lindsey", "Little", "Lloyd", "Loretta", "Lowe", "Lowery", "Luella", "Macias", "Mack", "Madge", "Mara", "Maria", "Marie", "Marilyn", "Marquez", "Maureen", "Mccray", "Mckay", "Mcmahon", "Mcneil", "Megan", "Melanie", "Melba", "Mendez", "Mercer", "Meredith", "Meyer", "Miles", "Millie", "Minerva", "Miranda", "Molina", "Moon", "Morin", "Mullen", "Muriel", "Myrtle", "Nadia", "Nancy", "Nelda", "Nicole", "Nielsen", "Noble", "Noemi", "Norma", "Ochoa", "Odom", "Odonnell", "Olive", "Ora", "Owens", "Pam", "Parker", "Patterson", "Patton", "Patty", "Paul", "Pauline", "Peck", "Pitts", "Polly", "Pratt", "Pruitt", "Pugh", "Rachelle", "Randall", "Randi", "Raquel", "Reba", "Reese", "Renee", "Reyna", "Rhonda", "Rios", "Rivera", "Robert", "Rojas", "Rose", "Rowland", "Sadie", "Sampson", "Sandra", "Sanford", "Savannah", "Selena", "Sellers", "Serena", "Sharpe", "Sheila", "Short", "Snyder", "Solis", "Sonja", "Sosa", "Spencer", "Stacie", "Stanley", "Stefanie", "Stone", "Susan", "Talley", "Tami", "Tamra", "Tania", "Tara", "Terrell", "Therese", "Thompson", "Tiffany", "Tina", "Tisha", "Todd", "Toni", "Tracy", "Tran", "Tricia", "Valeria", "Vance", "Vanessa", "Vasquez", "Velma", "Vivian", "Ward", "Ware", "Watkins", "Weiss", "Wells", "Wendy", "Whitney", "Witt", "Wood", "Woods", "Yolanda", "Zelma" };
        public static readonly string[] Lastnames =
            new[] { "Adams", "Adkins", "Aguilar", "Albert", "Alston", "Alvarado", "Alvarez", "Andrews", "Ayers", "Bailey", "Ball", "Barnett", "Barrera", "Barron", "Barry", "Beach", "Bell", "Bernard", "Best", "Bishop", "Blair", "Blake", "Blevins", "Bond", "Booth", "Bowen", "Boyd", "Boyer", "Boyle", "Brennan", "Briggs", "Britt", "Burgess", "Burnett", "Burns", "Burton", "Calhoun", "Camacho", "Cameron", "Cantrell", "Carney", "Carrillo", "Carroll", "Case", "Casey", "Castaneda", "Castro", "Chase", "Clark", "Clarke", "Clemons", "Cole", "Coleman", "Combs", "Conrad", "Contreras", "Copeland", "Cote", "Cox", "Craig", "Cross", "Cruz", "Cummings", "Curtis", "Dalton", "Dejesus", "Delaney", "Delgado", "Dennis", "Dodson", "Dorsey", "Douglas", "Dudley", "Duran", "Durham", "Dyer", "England", "Everett", "Ewing", "Farrell", "Faulkner", "Ferrell", "Floyd", "Fowler", "Francis", "Frazier", "Frederick", "Frost", "Gallegos", "Galloway", "Gamble", "Garza", "Gay", "Gentry", "Gibson", "Gilmore", "Glass", "Glenn", "Glover", "Gordon", "Green", "Greer", "Guthrie", "Hahn", "Haley", "Hamilton", "Hancock", "Harding", "Harris", "Hartman", "Harvey", "Hawkins", "Hayes", "Haynes", "Hebert", "Hendricks", "Herman", "Herrera", "Herring", "Hicks", "Holder", "Hood", "Hooper", "Hopkins", "Hopper", "House", "Howard", "Hubbard", "Huber", "Hudson", "Huffman", "Hurst", "Hutchinson", "Jacobs", "Jefferson", "Jennings", "Jimenez", "Johnson", "Juarez", "Kaufman", "Kent", "Kirby", "Kline", "Koch", "Lancaster", "Leblanc", "Lee", "Leon", "Lewis", "Logan", "Long", "Lowe", "Lynn", "Macias", "Maddox", "Marsh", "Marshall", "Martin", "Mason", "Massey", "Matthews", "Maynard", "Mcbride", "Mcclain", "Mcclure", "Mcconnell", "Mccoy", "Mccullough", "Mcfadden", "Mcgee", "Mcintosh", "Mcintyre", "Mckee", "Mcmahon", "Mcmillan", "Mendoza", "Mercado", "Meyers", "Montgomery", "Mooney", "Morgan", "Morris", "Morrison", "Morrow", "Mueller", "Mullins", "Munoz", "Nielsen", "Nolan", "Norton", "Obrien", "Oconnor", "Odonnell", "Oliver", "Osborne", "Owen", "Pace", "Palmer", "Payne", "Pennington", "Pittman", "Pitts", "Poole", "Pope", "Price", "Ramirez", "Reed", "Reese", "Reyes", "Richard", "Riddle", "Rios", "Rivera", "Robbins", "Robertson", "Robinson", "Robles", "Rocha", "Rodgers", "Rosa", "Rose", "Roth", "Rowe", "Rush", "Santos", "Sawyer", "Sellers", "Sharp", "Shaw", "Shepherd", "Singleton", "Skinner", "Sloan", "Sosa", "Soto", "Stafford", "Stanley", "Stark", "Steele", "Stein", "Stephens", "Stewart", "Stuart", "Sweeney", "Sykes", "Tate", "Thornton", "Tillman", "Vance", "Vaughn", "Velazquez", "Villarreal", "Vincent", "Vinson", "Wade", "Wall", "Walsh", "Waters", "Watts", "Weaver", "Webb", "Webster", "Weiss", "Wilkerson", "Wilkins", "Williamson", "Wolfe", "Wood", "Woodward", "Workman", "York", "Zamora" };
        public static readonly string[] Companies =
            new[] { "Initech", "Kineticut", "Power Drivers", "Ingenious", "Nurali", "Inventure", "Premiant", "Ceprene", "Luxuria", "Solgan", "Rockabye", "Slax", "Cytrek", "Exotechno", "Zipak", "Qot", "Synkgen", "Kyaguru", "Rodemco", "Asimiline", "Ebidco", "Podunk", "Enteroflex", "Xiix", "Verbus", "Nipaz", "Biotica", "Matrixity", "Kaggle", "Undertap", "Extragene", "Jamnation", "Elentrix", "Ovium", "Spacewax", "Comvene", "Empirica", "Stralum", "Heliko", "Kage", "Idealis", "Atomica", "Geeknet", "Emtrak", "Exerta", "Geekol", "Infotrips", "Locazone", "Micronaut", "Tourmania", "Neocent", "Zerbina", "Calcula", "Multiflex", "Datagene", "Comveyer", "Schoolio", "Netagy" };

        public static readonly string LoremIpsum = "Classic Lorem Ipsum Filler Text:Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Fusce ac turpis quis ligula lacinia aliquet.Mauris ipsum. Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh.Quisque volutpat condimentum velit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Nam nec ante.Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.Sed lectus. Integer euismod lacus luctus magna.Integer id quam.Morbi mi. Quisque nisl felis, venenatis tristique, dignissim in, ultrices sit amet, augue.Proin sodales libero eget ante.Yar Pirate IpsumBounty belaying pin quarterdeck scuttle grog blossom red ensign hands pillage coxswain heave down. Pressgang long clothes walk the plank pirate driver parley heave down bilge execution dock overhaul. Crack Jennys tea cup scallywag Pirate Round rutters belay bowsprit bring a spring upon her cable Brethren of the Coast clap of thunder Jack Tar.Furl Buccaneer blow the man down take a caulk tender tackle booty lateen sail killick gangway. Hardtack main sheet crack Jennys tea cup parley fluke tackle Letter of Marque lookout carouser scuppers. Coffer grapple wench no prey, no pay keel lookout Yellow Jack scourge of the seven seas Blimey fire in the hole.Splice the main brace heave down hulk provost killick Letter of Marque bilge rat flogging grog blossom Chain Shot.Warp to go on account gaff scallywag line man-of-war hands crack Jennys tea cup weigh anchor Sink me. Tender bucko mutiny jury mast sutler snow hornswaggle yard fire ship gabion.Pompy IpsumPommy ipsum 'tis you 'avin a laugh that's ace complete mare roast beef pulled out the eating irons, two weeks on't trot farewell gravy cheese and chips jellied eels middle class River Song, jammy git make a brew fish and chips one feels that golly bloke.Bottled it gosh up the duff bow ties are cool queer as a clockwork orange, jellied eels bit of a Jack the lad doolally Northeners get away with ya, well fit completely starkers treacle.Bad Wolf not some sort of dosshouse corgi tad doofer fork out working class, blighty pork scratchings every fortnight rambunctious bow ties are cool.Marvelous rivetting stuff bent as a nine bob note taking the mick owt terribly Sonic Screwdriver, it's me peepers a bit wonky jolly hockey sticks the fuzz on his bill. Cor blimey' naff one would like curry sauce lost her marbles bloody shambles down South what a load of cobblers because there was nothing on the gogglebox see a man about a dog, bangers and mash easy peasy yorkshire mixture bog off goggledegook chinwag nuthouse cornish pasty. Ey up pigeons in Trafalgar Square clotted cream on the beat posh nosh real ale come hither man and his whippet jolly, oo ecky thump I'd reet fancy a you mean it ain't me noggin' bog off and thus tosser what a load of cobblers.Biscuits numpty trouble and strife absolute know your onions ridicule grab a jumper, well chuffed twiglets pie-eyed twiglets squirrel. Know your onions guinness Big Ben scally I'm off to Bedfordshire fork out, snotty nosed brat and thus eton mess.Kate and Will scones one would like the old bill hadn't done it in donkey's years, have a gander Shakespeare indeed horses for courses lost her marbles, throw a paddy therewith bread and butter pudding.Manky houlligan Dr.Watson clock round the earhole crumpets The Hounds of Baskerville gobsmacked golly, well fit corgi knackered willy bent as a nine bob note ee bah gum cor blimey', devonshire cream tea off t'shop teacakes daft cow a cuppa make a brew.I could reet fancy a real ale pikey, round our gaff.DeLorean IpsumSilence Earthling.my name is Darth Vader. I'm am an extra-terrestrial from the planet Vulcan. No no no no no, Marty, both you and Jennifer turn out fine. It's your kids, Marty, something has got to be done about your kids.Great Scott. Let me see that photograph again of your brother.Just as I thought, this proves my theory, look at your brother. Well gee, I don't know. Marty, such a nice name.Hey Marty, I'm not your answering service, but you're outside pouting about the car, Jennifer Parker called you twice. Say that again. Calvin, why do you keep calling me Calvin? Marty, you didn't fall asleep, did you? I'm too loud. I can't believe it.I'm never gonna get a chance to play in front of anybody.Alright, okay listen, keep your pants on, she's over in the cafe. God, how do you do this? What made you change your mind, George? Yeah I know, If you put your mind to it you could accomplish anything.That Biff, what a character.Always trying to get away with something.Been on top of Biff ever since high school.Although, if it wasn't for him- I noticed you band is on the roster for dance auditions after school today. Why even bother Mcfly, you haven't got a chance, you're too much like your own man. No McFly ever amounted to anything in the history of Hill Valley. It was meant to be. Anyway, if Grandpa hadn't hit him, then none of you would have been born.Fillerati Text (Herman Melville, H.G.Wells, etc) I could not help it, but I began to feel suspicious of this \"dark complexioned\" harpooneer. At any rate, I made up my mind that if it so turned out that we should sleep together, he must undress and get into bed before I did.Supper over, the company went back to the bar-room, when, knowing not what else to do with myself, I resolved to spend the rest of the evening as a looker on.Presently a rioting noise was heard without. Starting up, the landlord cried, \"That's the Grampus's crew. I seed her reported in the offing this morning; a three years' voyage, and a full ship. Hurrah, boys; now we'll have the latest news from the Feegees.\"A tramping of sea boots was heard in the entry; the door was flung open, and in rolled a wild set of mariners enough. Enveloped in their shaggy watch coats, and with their heads muffled in woollen comforters, all bedarned and ragged, and their beards stiff with icicles, they seemed an eruption of bears from Labrador. They had just landed from their boat, and this was the first house they entered. No wonder, then, that they made a straight wake for the whale's mouth—the bar—when the wrinkled little old Jonah, there officiating, soon poured them out brimmers all round. One complained of a bad cold in his head, upon which Jonah mixed him a pitch-like potion of gin and molasses, which he swore was a sovereign cure for all colds and catarrhs whatsoever, never mind of how long standing, or whether caught off the coast of Labrador, or on the weather side of an ice-island.The liquor soon mounted into their heads, as it generally does even with the arrantest topers newly landed from sea, and they began capering about most obstreperously.I observed, however, that one of them held somewhat aloof, and though he seemed desirous not to spoil the hilarity of his shipmates by his own sober face, yet upon the whole he refrained from making as much noise as the rest. This man interested me at once; and since the sea-gods had ordained that he should soon become my shipmate (though but a sleeping-partner one, so far as this narrative is concerned), I will here venture upon a little description of him. He stood full six feet in height, with noble shoulders, and a chest like a coffer-dam. I have seldom seen such brawn in a man. His face was deeply brown and burnt, making his white teeth dazzling by the contrast; while in the deep shadows of his eyes floated some reminiscences that did not seem to give him much joy. His voice at once announced that he was a Southerner, and from his fine stature, I thought he must be one of those tall mountaineers from the Alleghanian Ridge in Virginia. When the revelry of his companions had mounted to its height, this man slipped away unobserved, and I saw no more of him till he became my comrade on the sea. In a few minutes, however, he was missed by his shipmates, and being, it seems, for some reason a huge favourite with them, they raised a cry of \"Bulkington! Bulkington! where's Bulkington?\" and darted out of the house in pursuit of him.It was now about nine o'clock, and the room seeming almost supernaturally quiet after these orgies, I began to congratulate myself upon a little plan that had occurred to me just previous to the entrance of the seamen.Corporate IpsumLeverage agile frameworks to provide a robust synopsis for high level overviews. Iterative approaches to corporate strategy foster collaborative thinking to further the overall value proposition. Organically grow the holistic world view of disruptive innovation via workplace diversity and empowerment.Bring to the table win-win survival strategies to ensure proactive domination. At the end of the day, going forward, a new normal that has evolved from generation X is on the runway heading towards a streamlined cloud solution. User generated content in real-time will have multiple touchpoints for offshoring.Capitalise on low hanging fruit to identify a ballpark value added activity to beta test. Override the digital divide with additional clickthroughs from DevOps. Nanotechnology immersion along the information highway will close the loop on focusing solely on the bottom line.";
    }
}
