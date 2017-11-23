﻿using System.Collections.Generic;

namespace Quiz.Questions.Jeopardy
{
    internal class QuestionsJeopardy
    {
        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3, string wrongAnswer4 = null)
        {
            var result = Common.Get(Category.Geek, difficultyLevel, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3, wrongAnswer4);
            return result;
        }

        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                //gregt decide which questions to use
                Get(DifficultyLevel.Medium, "\"DOS\" stands for these 3 words?",
                    "disk operating system",
                    "device operating system",
                   "drive operating system",
                    "disc operating software"),
                Get(DifficultyLevel.Medium, "2-word term for restarting a computer without turning off the power?",
                    "warm boot",
                    "boot up",
                    "boot down",
                    "hard boot"),
                Get(DifficultyLevel.Medium, "A common way of linking computers in the office is this type of local area networking technology, which uses a Cat5 cable with a special connector?",
                    "ethernet",
                    "extranet",
                    "twin core and earth",
                    "ducting"),
                Get(DifficultyLevel.Medium, "According to Moore's Law, named for a founder of Intel, these double in power roughly every 18 months?",
                    "computer chips",
                    "disc drives",
                    "mice",
                    "monitors",
                    "humans"),
                //Get(DifficultyLevel.Medium, "Android's 4.1 O.S.  called this?",
                //    "Jelly Bean",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
               Get(DifficultyLevel.Medium, "At the 1939 New York World's Fair, what animal was the robot Elektro was accompanied by Sparko?",
                    "a dog",
                    "a cat",
                    "a mouse",
                    "a elephant"),
                //Get(DifficultyLevel.Medium, "Coherant & Xenix are 2 of these, part of the abbreviation in the better-known MS-DOS?",
                //    "operating systems",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "Copying info from a computer to a CD is called burning; doing the reverse is this other destructive term?",
                   "ripping",
                    "stealing",
                    "copying",
                    "burning"),
                Get(DifficultyLevel.Medium, "CTR, the Computing-Tabulating-Recording Company, took on this current 3-letter name in 1924?",
                   "IBM",
                    "jvc",
                   "ici",
                    "htc"),
                Get(DifficultyLevel.Medium, "Dan Bricklin developed VISICALC, the first of these programs?",
                    "spreadsheet",
                    "powerpoint",
                   "visio",
                    "calculator"),
                //Get(DifficultyLevel.Medium, "Despite the name, the San Jose headquarters of this maker of the creative cloud isn't built of clay bricks	?",
                //    "Adobe	",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Device that stealth aircraft technology is designed to trick?",
                //    "radar",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Dioxide of this element, symbol Cr, is used to make recording tape for cassettes?",
                //    "chromium",
                //    "magnet",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Established in Mountain View in 1956, Shockley Semiconductor helped put this element in the name of a \"valley\"?",
                //    "silicon",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "Even before all the polls closed, CBS used this huge computer to predict the result of the 1952 presidential election?",
                    "UNIVAC",
                    "watson",
                    "analytical engine",
                   "big blue",
                   "abacus"),
                //Get(DifficultyLevel.Medium, "First built in 1960, it's also been called an optical maser?",
                //    "laser",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "GOES, INSAT & METEOSAT are satellites used for this purpose?",
                //    "Weather Forecasting",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Hubert Booth, not Herbert Hoover, developed the first practical electric one of these in 1901?",
                //    "Vacuum cleaner",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "imgur.com has a button to make this four-letter cultural reference that often spreads online?",
                //    "a meme",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In 1960 Theodore Maiman used this gem in his laser?",
                //    "Ruby",
                //    "diamond",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "In 1981 this company introduced the PC, its first home computer?",
                    "IBM",
                    "microsoft",
                    "apple",
                    "tesla",
                     "google"),
                //Get(DifficultyLevel.Medium, "In 1983 Apple's Lisa computer gave PCs this device that moves the cursor around the screen	?",
                //    "mouse",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In 1993 Intel introduced this new chip, which had 3.1 million transistors?",
                //    "Pentium",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In 1995 Wells Fargo became the first bank whose customers could securely view their accounts here?",
                //    "online",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In 2014 Facebook agreed to pay $2 billion for Oculus, a maker of this immersive technology?",
                //    "virtual reality	",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In chat rooms, \"YMMV\" is this disclaimer often used in car ads; it basically lets you off the hook for anything you say?",
                //    "your mileage may vary",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "In computerese, it's what the P stands for in the abbreviation HTTP?",
                    "protocol",
                  "promise",
                    "passive",
                    "private"),
                //Get(DifficultyLevel.Medium, "In the abbreviation JPEG, the \"P\" is this 12 - letter adjective?",
                //    "Photographic",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "It's a big smartphone, it's a small iPad, it's this 7-letter hybrid word?",
                    "phablet",
                    "fablet",
                   "padlet",
                   "padphone"),
                //Get(DifficultyLevel.Medium, "It's a measure of speed:BPS?",
                //    "bytes per second",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "It's the brains of the operation:CPU?",
                //    "central processing unit",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "Most modern supercomputers run on this operating system developed by Linus Torvalds?",
                   "Linux",
                    "iOS",
                   "OSx",
                    "Windows"),
               Get(DifficultyLevel.Medium, "On a single digit LED readout, number shown when all 7 LEDs are lit?",
                   "8",
                    "1",
                   "7",
                    "1024",
                     "zero"),
                //Get(DifficultyLevel.Medium, "On August 12, 1981 the world saw the first IBM personal computer using this Microsoft operating system?",
                //    "MS-DOS",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "On Feb. 17, 2009 this type of TV broadcast technology will end in the U.S.; we're going digital?",
                //    "analog",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "On Feb. 29, 2008 Blu - Ray emerged as the new video disc choice as this Japanese co. abandoned its HD - DVD format?",
                //    "Toshiba",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Reddit is known for hosting online interviews where you can AMA, short for this?",
                //    "ask me anything",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Seen here is an icon for this 3 - letter service that feeds you updates on your favorite web sites?",
                //    "RSS",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "Send me that report as a PDF, this \"format\"?",
                    "portable document format",
                    "printable document format",
                    "published document format",
                    "protected document format"),
                //Get(DifficultyLevel.Medium, "smugmug.com lets you share these & back them up?",
                //    "pictures(or photographs)",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"G\" in .gif & .png stands for these?",
                //    "graphics",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"HT\" in both HTTP & HTML stands for this?",
                //    "hypertext",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"P\" in jpeg?",
                //    "photographic",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "The 'S' in DSL is digital what line?",
                   "subscriber",
                   "service",
                   "speed",
                   "secure"),
                Get(DifficultyLevel.Medium, "What does LAN stand for?",
                    "local area network",
                    "linked area network",
                    "large area network",
                    "lost area network"), //, "lost all nerds"),
                //Get(DifficultyLevel.Medium, "What does RAID stand for?",
                //    "redundant array of inexpensive disks",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "which digit number that means \"File Not Found\"?",
                    "404",
                    "201",
                    "501",
                int.MaxValue.ToString()   ),
                Get(DifficultyLevel.Medium, "Wi-Fi technology uses these waves that brought us \"The Chase & Sanborn Hour\" in the 1930s?",
                    "radio waves",
                    "magic",
                    "bluetooth",
                    "radar"),
                Get(DifficultyLevel.Medium, "You can feel your way around a game using the Dualshock controller for which video game console?",
                    "PlayStation",
                    "Xbox",
                    "Atari",
                    "Wii"),
                //Get(DifficultyLevel.Medium, "A type of hacker who ethically reports security problems is called this, a proverbial accessory of cowboy heroes?",
                //    "white hat",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Automaton is sometimes just a fancy name for one of these mechanical beings?",
                //    "a robot",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "what was ASIMO?",
                //    "a robot that differentiates multiple voices using 8 microphones & Hark software?",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "In 1991 Apple introduced this media player//would you like to download the latest version?",
                //    "QuickTime",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"B\" in COBOL?",
                //    "business",
                //    "binary",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"D\" in a DoS attack?",
                //    "denial",
                //    "distributed",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The \"RT\" in \"RTOS\"?",
                //    "real-time",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Cesium was the first element found by this process using the band of colored light produced by a prism?",
                //    "Spectroscopy",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "The February 2008 decision to abandon HD DVD technology gave a market victory to this rival video format?",
                   "Blu-ray",
                   "beta max",
                   "vhs",
                   "avi"),
                //Get(DifficultyLevel.Medium, "The forerunner to the Internet known as the ARPANET was a 1960s network by this U.S. government dept.?",
                //    "Defense",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The IBM \"computer\" of 1928 stored its data on these?",
                //    "Punch cards",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The Nomad Jukebox Zen Xtra is a device which plays music in this alphanumeric format?",
                //    "MP3",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The ROM of your computer's CD-ROM stands for this?",
                //    "read-only memory",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The second \"T\" in HTTP?",
                //    "transfer or transport",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "The smallest units of information stored in a computer, they form bytes?",
                //    "bits",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Thinking Machines Corp.pioneered this processing// as the geometric name indicates, many processors work side by side?",
                //    "parallel processing",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                Get(DifficultyLevel.Medium, "This 2-letter Windows computer operating system was introduced in October 2001?",
                    "XP",
                   "ce",
                    "nt",
                   "10"),
                //Get(DifficultyLevel.Medium, "This 4-letter word is \"warm\" when the computer's power is already on, \"cold\" when it's off?",
                //    "boot",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This Apple product that was rolled out in 2010 has a 9.7-inch screen & is 1/2 inch thick?",
                //    "the iPad",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This chipmaker, the world's largest, has announced \"systems on a chip\" measuring 22 nanometers?",
                //    "Intel	",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This company whose name is synonymous with copying introduced the first hand - held mouse in 1973?",
                //    "Xerox",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This computer device slowly takes you online?",
                //    "a modem",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This computer was introduced in 1984 & came with a MacWrite text program & a MacPaint program for graphics?",
                //    "Apple Macintosh",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This photo co.created the EasyShare printer with prints that are less expensive &last 100 years?",
                //    "Kodak",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This popular Internet service provider began as QCS, Quantum Computer Services?",
                //    "AOL(America Online)",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This process that maximizes disk space is so named because it joins up pieces of files that were stored separately?",
                //    "defrag (or defragmenting)	",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This programming language was named for calculating - machine inventor Blaise?",
                //    "PASCAL",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This removable item used for data storage was introduced in 1971; the first one was 8 inches square?",
                //    "floppy disk",
                //    "compact disc",
                //    "flash drive",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "This type of \"net\" developed by Xerox has helped local area networks communicate since the 1970s?",
                //    "ethernet",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "Useful for connecting devices, USB is short for Universal Serial this?",
                //    "Bus",
                //    "button",
                //    "bytes",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "We can geek - up your computer by installing a printer, digital camera or any other external device, which is called this in computer speak, from the Greek for \"to carry around\"?",
                //    "a peripheral",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "We're gonna go old school and use keyboard characters to translate my image into this computing code?",
                //    "ASCII",
                //    "Todo1",
                //    "Todo2",
                //    "Todo3"),
                //Get(DifficultyLevel.Medium, "When a device can be attached to your computer & install itself, it's PnP, short for this?",
                //    "Plug and Play",
                //    "push and pull",
                //    "todo2",
                //    "Todo3"),
            };

            return gatewayResponses;
        }

    }
}