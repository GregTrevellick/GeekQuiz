﻿using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsJeopardy
    {

        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Get("Among Internet users, the World Wide Web has surpassed the system named for this burrowing rodent?", "gopher", "Todo1", "Todo2", "Todo3"),
                Get("\"DOS\" stands for these 3 words?", "disk operating system", "Todo1", "Todo2", "Todo3"),
                Get("2-word term for restarting a computer without turning off the power?", "warm boot", "boot up", "boot down", "hard boot"),
                Get("A common way of linking computers in the office is this type of local area networking technology, which uses a Cat5 cable with a special connector?", "ethernet", "extranet", "twin core and earth", "ducting"),
                Get("A printing program that puts jobs in a queue to be done one at a time?" "spooler", "Todo1", "Todo2", "Todo3"),
                Get("A single processor sharing multiple jobs is doing this?", "multitasking", "Todo1", "Todo2", "Todo3"),
                Get("According to Moore's Law, named for a founder of Intel, these double in power roughly every 18 months?", "computer chips", "Todo1", "Todo2", "Todo3"),
                Get("Android's 4.1 O.S. is called this?", "Jelly Bean", "Todo1", "Todo2", "Todo3"),
                Get("At the 1939 New York World's Fair, what animal was the robot Elektro was accompanied by Sparko?", "a dog", "Todo1", "Todo2", "Todo3"),
                Get("Before a game's release, Joe Gamer may be asked to play a pre-version usually referred to by this Greek letter?", "beta", "Todo1", "Todo2", "Todo3"),
                Get("Buckminster Fuller used \"energetic synergetic geometry\" to build these structures?", "geodesic domes", "Todo1", "Todo2", "Todo3"),
                Get("Christiaan Huygens got into the swing of things in 1656 by adding this to the clock?", "Pendulum", "Todo1", "Todo2", "Todo3"),
                Get("Coherant & Xenix are 2 of these, part of the abbreviation in the better-known MS-DOS?", "operating systems", "Todo1", "Todo2", "Todo3"),
                Get("Copying info from a computer to a CD is called burning; doing the reverse is this other destructive term?", "ripping", "Todo1", "Todo2", "Todo3"),
                Get("CTR, the Computing-Tabulating-Recording Company, took on this current 3-letter name in 1924?", "IBM", "Todo1", "Todo2", "Todo3"),
                Get("Dan Bricklin developed VISICALC, the first of these programs, similar to an accounting ledger?", "spreadsheet", "Todo1", "Todo2", "Todo3"),
                Get("Despite the name, the San Jose headquarters of this maker of the creative cloud isn't built of clay bricks	?", "Adobe	", "Todo1", "Todo2", "Todo3"),
                Get("Device that stealth aircraft technology is designed to trick?", "radar", "Todo1", "Todo2", "Todo3"),
                Get("Dioxide of this element, symbol Cr, is used to make recording tape for cassettes?", "chromium", "Todo1", "Todo2", "Todo3"),
                Get("Established in Mountain View in 1956, Shockley Semiconductor helped put this element in the name of a \"valley\"?", "silicon", "Todo1", "Todo2", "Todo3"),
                Get("Even before all the polls closed, CBS used this huge computer to predict the result of the 1952 presidential election?", "UNIVAC", "Todo1", "Todo2", "Todo3"),
                Get("First built in 1960, it's also been called an optical maser?", "laser", "Todo1", "Todo2", "Todo3"),
                Get("GOES, INSAT & METEOSAT are satellites used for this purpose?", "Weather Forecasting", "Todo1", "Todo2", "Todo3"),
                Get("Hubert Booth, not Herbert Hoover, developed the first practical electric one of these in 1901?", "Vacuum cleaner", "Todo1", "Todo2", "Todo3"),
                Get("If an atom loses one of these, it becomes a cation, a positively charged ion?", "electron", "Todo1", "Todo2", "Todo3"),
                Get("imgur.com has a button to make this four-letter cultural reference that often spreads online?", "a meme", "Todo1", "Todo2", "Todo3"),
                Get("In 1960 Theodore Maiman used this gem in his laser?", "Ruby", "Todo1", "Todo2", "Todo3"),
                Get("In 1981 this company introduced the PC, its first home computer?", "IBM", "Todo1", "Todo2", "Todo3"),
                Get("In 1983 Apple's Lisa computer gave PCs this device that moves the cursor around the screen	?", "mouse", "Todo1", "Todo2", "Todo3"),
                Get("In 1993 Intel introduced this new chip, which had 3.1 million transistors?", "Pentium", "Todo1", "Todo2", "Todo3"),
                Get("In 1995 Wells Fargo became the first bank whose customers could securely view their accounts here?", "online", "Todo1", "Todo2", "Todo3"),
                Get("In 2014 Facebook agreed to pay $2 billion for Oculus, a maker of this immersive technology?", "virtual reality	", "Todo1", "Todo2", "Todo3"),
                Get("In chat rooms, \"YMMV\" is this disclaimer often used in car ads; it basically lets you off the hook for anything you say?", "your mileage may vary", "Todo1", "Todo2", "Todo3"),
                Get("In computerese, it's what the P stands for in the abbreviation HTTP?", "protocol", "Todo1", "Todo2", "Todo3"),
                Get("In the abbreviation JPEG, the \"P\" is this 12 - letter adjective?", "Photographic", "Todo1", "Todo2", "Todo3"),
                Get("It's a big smartphone, it's a small iPad, it's this 7-letter hybrid word?", "phablet", "Todo1", "Todo2", "Todo3"),
                Get("It's a measure of speed:BPS?", "bytes per second", "Todo1", "Todo2", "Todo3"),
                Get("It's the brains of the operation:CPU?", "central processing unit", "Todo1", "Todo2", "Todo3"),
                Get("Most modern supercomputers run on this operating system developed by Linus Torvalds?", "Linux", "Todo1", "Todo2", "Todo3"),
                Get("On a single digit LED readout, number shown when all 7 LEDs are lit?", "8", "Todo1", "Todo2", "Todo3"),
                Get("On August 12, 1981 the world saw the first IBM personal computer using this Microsoft operating system?", "MS-DOS", "Todo1", "Todo2", "Todo3"),
                Get("On Feb. 17, 2009 this type of TV broadcast technology will end in the U.S.; we're going digital?", "analog", "Todo1", "Todo2", "Todo3"),
                Get("On Feb. 29, 2008 Blu - Ray emerged as the new video disc choice as this Japanese co. abandoned its HD - DVD format?", "Toshiba", "Todo1", "Todo2", "Todo3"),
                Get("Reddit is known for hosting online interviews where you can AMA, short for this?", "ask me anything", "Todo1", "Todo2", "Todo3"),
                Get("Seen here is an icon for this 3 - letter service that feeds you updates on your favorite web sites?", "RSS", "Todo1", "Todo2", "Todo3"),
                Get("Send me that report as a PDF, this \"format\"?", "portable document format", "Todo1", "Todo2", "Todo3"),
                Get("smugmug.com lets you share these & back them up?", "pictures(or photographs)", "Todo1", "Todo2", "Todo3"),
                Get("The \"G\" in .gif & .png stands for these?", "graphics", "Todo1", "Todo2", "Todo3"),
                Get("The \"HT\" in both HTTP & HTML stands for this?", "hypertext", "Todo1", "Todo2", "Todo3"),
                Get("The \"P\" in jpeg?", "photographic", "Todo1", "Todo2", "Todo3"),
                Get("The 'S' in DSL is digital what line?", "subscriber", "Todo1", "Todo2", "Todo3"),
                Get("What does LAN stand for?", "local area network", "linked area network", "large area network", "lost area network"),//, "lost all nerds"),
                Get("What does RAID stand for?", "redundant array of inexpensive disks", "Todo1", "Todo2", "Todo3"),
                Get("which digit number that means \"File Not Found\"?", "404", "Todo1", "Todo2", "Todo3"),
                Get("Wi-Fi technology uses these waves that brought us \"The Chase & Sanborn Hour\" in the 1930s?", "radio waves", "magic", "bluetooth", "radar"),
                Get("You can feel your way around a game using the Dualshock controller for which video game console?", "PlayStation", "Xbox", "Atari", "Wii"),
                Get("A type of hacker who ethically reports security problems is called this, a proverbial accessory of cowboy heroes?", "white hat", "Todo1", "Todo2", "Todo3"),
                Get("Automaton is sometimes just a fancy name for one of these mechanical beings?", "a robot", "Todo1", "Todo2", "Todo3"),
                Get("what was ASIMO?", "a robot that differentiates multiple voices using 8 microphones & Hark software?", "Todo1", "Todo2", "Todo3"),
                Get("In 1991 Apple introduced this media player//would you like to download the latest version?", "QuickTime", "Todo1", "Todo2", "Todo3"),
                Get("The \"B\" in COBOL?", "business", "Todo1", "Todo2", "Todo3"),
                Get("The \"D\" in a DoS attack?", "denial", "Todo1", "Todo2", "Todo3"),
                Get("The \"RT\" in \"RTOS\"?", "real-time", "Todo1", "Todo2", "Todo3"),
                Get("Cesium was the first element found by this process using the band of colored light produced by a prism?", "Spectroscopy", "Todo1", "Todo2", "Todo3"),
                Get("The February 2008 decision to abandon HD DVD technology gave a market victory to this rival video format?", "Blu-ray", "Todo1", "Todo2", "Todo3"),
                Get("The forerunner to the Internet known as the ARPANET was a 1960s network by this U.S. government dept.?", "Defense", "Todo1", "Todo2", "Todo3"),
                Get("The IBM \"computer\" of 1928 stored its data on these?", "Punch cards", "Todo1", "Todo2", "Todo3"),
                Get("The Nomad Jukebox Zen Xtra is a device which plays music in this alphanumeric format?", "MP3", "Todo1", "Todo2", "Todo3"),
                Get("The ROM of your computer's CD-ROM stands for this?", "read-only memory", "Todo1", "Todo2", "Todo3"),
                Get("The second \"T\" in HTTP?", "transfer or transport", "Todo1", "Todo2", "Todo3"),
                Get("The smallest units of information stored in a computer, they form bytes?", "bits", "Todo1", "Todo2", "Todo3"),
                Get("Thinking Machines Corp.pioneered this processing// as the geometric name indicates, many processors work side by side?", "parallel processing", "Todo1", "Todo2", "Todo3"),
                Get("This 2-letter Windows computer operating system was introduced in October 2001?", "XP", "Todo1", "Todo2", "Todo3"),
                Get("This 4-letter word is \"warm\" when the computer's power is already on, \"cold\" when it's off?", "boot", "Todo1", "Todo2", "Todo3"),
                Get("This Apple product that was rolled out in 2010 has a 9.7-inch screen & is 1/2 inch thick?", "the iPad", "Todo1", "Todo2", "Todo3"),
                Get("This chipmaker, the world's largest, has announced \"systems on a chip\" measuring 22 nanometers?", "Intel	", "Todo1", "Todo2", "Todo3"),
                Get("This company whose name is synonymous with copying introduced the first hand - held mouse in 1973?", "Xerox", "Todo1", "Todo2", "Todo3"),
                Get("This computer device slowly takes you online?", "a modem", "Todo1", "Todo2", "Todo3"),
                Get("This computer was introduced in 1984 & came with a MacWrite text program & a MacPaint program for graphics?", "Apple Macintosh", "Todo1", "Todo2", "Todo3"),
                Get("This photo co.created the EasyShare printer with prints that are less expensive &last 100 years?", "Kodak", "Todo1", "Todo2", "Todo3"),
                Get("This popular Internet service provider began as QCS, Quantum Computer Services?", "AOL(America Online)", "Todo1", "Todo2", "Todo3"),
                Get("This process that maximizes disk space is so named because it joins up pieces of files that were stored separately?", "defrag (or defragmenting)	", "Todo1", "Todo2", "Todo3"),
                Get("This programming language was named for calculating - machine inventor Blaise?", "PASCAL", "Todo1", "Todo2", "Todo3"),
                Get("This removable item used for data storage was introduced in 1971; the first one was 8 inches square?", "floppy disk", "Todo1", "Todo2", "Todo3"),
                Get("This type of \"net\" developed by Xerox has helped local area networks communicate since the 1970s?", "ethernet", "Todo1", "Todo2", "Todo3"),
                Get("Useful for connecting devices, USB is short for Universal Serial this?", "Bus", "Todo1", "Todo2", "Todo3"),
                Get("We can geek - up your computer by installing a printer, digital camera or any other external device, which is called this in computer speak, from the Greek for \"to carry around\"?", "a peripheral", "Todo1", "Todo2", "Todo3"),
                Get("We're gonna go old school and use keyboard characters to translate my image into this computing code?", "ASCII", "Todo1", "Todo2", "Todo3"),
                Get("When a device can be attached to your computer & install itself, it's PnP, short for this?", "Plug and Play", "Todo1", "Todo2", "Todo3"),
            };

            return gatewayResponses;
        }

        private static GatewayResponse Get(string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            return Get(DifficultyLevel.Medium, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
        }

        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            var result = Common.Get(difficultyLevel, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
            return result;
        }
    }
}
