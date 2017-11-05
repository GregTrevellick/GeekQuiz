﻿using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsUberspot
    {
        /// <summary>
        /// https://github.com/uberspot/OpenTriviaQA
        /// https://github.com/uberspot/OpenTriviaQA/blob/master/categories/science-technology
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Question> GetQuestions()
        {
            var triviaQuestions = new List<Question>
            {
                new Question
                {
                    DifficultyLevel = DifficultyLevel.Medium,
                    QuestionText = "When was .NET first released?",
                    Answers = new List<Answer>
                    {
                        new Answer {AnswerText = "2000", IsCorrect = false},
                        new Answer {AnswerText = "2001", IsCorrect = false},
                        new Answer {AnswerText = "2002", IsCorrect = true},
                        new Answer {AnswerText = "2003", IsCorrect = false}
                    }
                },
            };

            return triviaQuestions;
        }
    }
}



//#Q Immanuel Kant criticized Emanuel Swedenborg and termed him a “spook hunter”.
//^ True
//A True
//B False

//#Q Clouds are made up of these.
//^ Water droplets and ice crystals
//A Carbon atoms
//B Water droplets and ice crystals
//C Oxygen ions
//D Dust mites

//#Q This formation is a conical hill or mountain. It is formed by mantle material being pressed through an opening in the Earths crust.
//^ A volcano
//A A volcano
//B A hill
//C An earthquake
//D A geyser

//#Q Japan suffers from this event very often. It is the sudden, light or violent movement of the earths surface caused by the release of energy in the earths crust.
//^ Earthquake
//A Volcano
//B Earthquake
//C Tide
//D Tsunami

//#Q It is the only continent that does not have land areas below sea level.
//^ Antarctica
//A Australia
//B South America
//C Antarctica
//D Arctica

//#Q It is the longest river in the world
//^ The Nile
//A Themes
//B The Amazon
//C The Nile
//D Danube

//#Q Why do travelers to La Paz, Bolivia, often become ill as soon as they arrive?
//^ Because of the altitude
//A Because of the high temperature
//B Because of the humidity
//C Because of the soil quality
//D Because of the altitude

//#Q In the US, why do we change our clocks on the daylight saving time dates in April and October?
//^ To conserve energy
//A To conserve energy
//B To increase the hours of the day
//C To extend the working day
//D Because the tourist period in most countries starts in May

//#Q These are places of arid land with really low rainfall and high tempertures variation. Their vegetation is insignificant and the population of people and animals is very limited.
//^ Deserts
//A Oceans
//B Raiforests
//C The equator
//D Deserts

//#Q This is a gemstone made by fossilized tree sap that is at least 30 million years old.
//^ Amber
//A Obsidian
//B Amber
//C Tourmaline
//D Malachite

//#Q This is the largest island on Earth and one third of it is a national park.
//^ Greenland
//A Greenland
//B Madagaskar
//C Australia
//D Alaska

//#Q Which of these organs has no known function in the human body?
//^ appendix
//A tonsils
//B appendix
//C uvula
//D pineal gland

//#Q The main function of this organ of respiration is to transport oxygen from the atmosphere into the bloodstream.
//^ lung
//A stomach
//B diaphragm
//C trachea
//D lung

//#Q This gland is shaped like a butterfly and helps regulate energy in the body.
//^ thyroid
//A parathyroid
//B thyroid
//C adrenal
//D thymus

//#Q The cerebellum section of the brain controls the fine movement and equilibrium, among other things.
//^ True
//A True
//B False

//#Q These organs are very sensitive and often fail in people with very high blood pressure or diabetes.
//^ kidneys
//A pancreas
//B kidneys
//C ovaries
//D lungs

//#Q Tooth enamel is the hardest substance in the body.
//^ True
//A False
//B True

//#Q This is one of the first signs of pregnancy.
//^ Missed period
//A Swollen Feet
//B Missed period
//C Hair loss
//D Waddling

//#Q This doctor takes care of you and your baby during pregnancy.
//^ Obstetrician
//A Psychologist
//B Periodontist
//C Obstetrician
//D Pediatrician

//#Q What is the most common method of child birth?
//^ Vaginal
//A Cesarean
//B Vaginal
//C Water birth
//D In Vitro Fertilization

//#Q The mother determines the sex of the baby.
//^ False
//A False
//B True

//#Q What are common side effects of pregnancy?
//^ All of the these
//A Stretch marks
//B Morning Sickness
//C All of the these
//D Weight gain

//#Q How far along are you approximately, when you feel the baby move for the first time?
//^ 20 weeks
//A 10 weeks
//B 35 weeks
//C 2 weeks
//D 20 weeks

//#Q What is suggested that you not do several hours before you go into labor?  It could get you embarrassed.
//^ Eat food
//A Eat fish
//B Have sex
//C Talk on the phone
//D Eat food

//#Q What is also delivered along with the baby or immediately after its birth?
//^ Placenta
//A Feet
//B Shoulders
//C Placenta
//D Handbook

//#Q These small bodies are considered left overs from the formation of the Solar system some 4.6 billion years ago.
//^ Asteroids
//A Comets
//B Stars
//C Planets
//D Asteroids

//#Q These are lumps of ice and dust.  When they get close enough to the Sun they gradually evaporate.  Jets of gas and dust create long tails that people can see from Earth.
//^ Comets
//A Asteroids
//B Comets
//C UFOs
//D Stars

//#Q This planet is slightly smaller than Earth and its closest neighbor (excluding the Moon).
//^ Venus
//A Venus
//B Uranus
//C Mars
//D Saturn

//#Q This planet is has the largest  group of moons - 31, but it is best known for its ring system.
//^ Saturn
//A Neptune
//B Mars
//C Saturn
//D Venus

//#Q This planet of the Solar System was named after a Greek god of the sea and earthquakes. The name is actually the Roman translation of the gods name.
//^ Neptune
//A Mercury
//B Neptune
//C Pluto
//D Uranus

//#Q As this is the closest planet to the Sun, its temperatures at the surface range between -300 and 800 F (hot enough for lead to melt).
//^ Mercury
//A Neptune
//B Mercury
//C Pluto
//D Venus

//#Q The surface of this planet is unique, it is the only one which has water in large quantities.
//^ Earth
//A Saturn
//B Pluto
//C Earth
//D Mars

//#Q Which Solar System celestial bodys revolution around the Sun takes 248 years?
//^ Pluto
//A Saturn
//B Pluto
//C Neptune
//D Uranus

//#Q This is the largest planet in our solar system. It is most famous for its Great Red Spot.
//^ Jupiter
//A Mars
//B Neptune
//C Saturn
//D Jupiter

//#Q Miranda, Ariel, Umbriel, Titania, Oberon, Caliban, and Sycorax are names of the icy moons of this planet.
//^ Uranus
//A Uranus
//B Jupiter
//C Saturn
//D Venus

//#Q The popular chat room abbreviation asl or a/s/l stands for age, sex, and location.
//^ True
//A True
//B False

//#Q An icon or animation to represent a participant used in Internet chat and games is referred to as this.
//^ Avatar
//A Bitmap
//B Cookie
//C Applet
//D Avatar

//#Q If you and I are chatting over the Internet and I write LOL, that means that I am doing this.
//^ Laughing
//A Crying
//B Laughing
//C Sleeping
//D Eating

//#Q The terms smiley and emoticon refer to one and the same thing.
//^ True
//A True
//B False

//#Q http://www.123facts.com/ is referred to as this.
//^ URL
//A TCP
//B WAP
//C URL
//D USB

//#Q One of the following pairs (chat abbreviation - its  meaning) is wrong.
//^ TTYL - To Tell You a Lie
//A BRB - Be Right Back
//B ATM - At The Moment
//C TTYL - To Tell You a Lie
//D TIA - Thanks In Advance

//#Q One of these things will not help you to get in touch with your neighbours PC.
//^ Cache server
//A Hub
//B Router
//C Cache server
//D Network card

//#Q If they call me a newbie then I am new to the Internet; and/or new to the subject in general.
//^ True
//A False
//B True

//#Q In chat jargon, the emoticon  [8-] refers to this person.
//^ Frankenstein
//A Elvis
//B Ronald Regan
//C Frankenstein
//D The Pope

//#Q The medical term cardio, deriving from a Greek word, refers to which organ of the human body?
//^ Heart
//A Brain
//B Liver
//C Lungs
//D Heart

//#Q The term arthro is of Greek origin. It refers to which part of the body?
//^ Joint
//A Head
//B Skin
//C Bone
//D Joint

//#Q Gastro is a common medical prefix, derived from the Greek word gastros which means what?
//^ Stomach
//A Gas
//B Brain
//C Cell
//D Stomach

//#Q The word hepato, which derives from Greek, refers to the kidney.
//^ False
//A False
//B True

//#Q Erythrocytes are a type of blood cells, consisting mainly of hemoglobin. What does the word erythro mean?
//^ Red
//A Red
//B Knowledge
//C Cell
//D White

//#Q The term thrombo, which comes from Greek, refers to a blood clot.
//^ True
//A False
//B True

//#Q The word adeno, deriving from Greek, refers to which to what body part?
//^ Gland
//A Flesh
//B Brain
//C Gland
//D Kidney

//#Q The two terms nephro and ren both refer to the kidneys.
//^ True
//A True
//B False

//#Q Onco, coming from the Greek word onkos refers to what?
//^ Tumor
//A Ear
//B Nerve
//C Eye
//D Tumor

//#Q The food colorants, cochineal and carmine, are made from what?
//^ A kind of insect
//A Frogs
//B A kind of insect
//C FDC Red Dye #40
//D None of these

//#Q Jell-O, the popular gelatin dessert, is made in part, from what?
//^ Bones and hides
//A Bones and hides
//B Red ants
//C None of these
//D Horses and cows hooves

//#Q Twinkies, the sponge cake with creamy filling, created by Hostess, have an indefinite shelf life.
//^ False
//A True
//B False

//#Q Which of these statements, related to the effects of eating turkey, is true?
//^ None of these
//A Turkey slows your metabolic rate which makes you drowsy
//B A turkey makes you sleepy as it contains the natural sedative L-tryptophan
//C Increased blood flow to the gastrointestinal tract makes one drowsy
//D None of these

//#Q The traditional Japanese dish, sushi, is always made with raw fish.
//^ False
//A True
//B False

//#Q What food results in negative calories when eaten?
//^ All of these
//A Carrots
//B Celery
//C All of these
//D Radishes

//#Q Chop Suey, a pasta dish consisting of short noodles, was originally made and served in which country?
//^ USA
//A Thailand
//B USA
//C China
//D Vietnam

//#Q Gatorade, a non-carbonated sports drink, was invented by researchers at the University of Florida and named in honor of the Florida Gators, the schools football team.
//^ True
//A False
//B True

//#Q In 2003, the FDA issued a warning about a possible connection between green onions and which disease?
//^ Hepatitis A
//A None of these
//B Gall stones
//C Hepatitis A
//D Cancer

//#Q In the USA, the color of the plastic tags, used to seal bread bags, indicates on what day the loaves were baked.
//^ True
//A True
//B False

//#Q Death of heart tissues due to loss of blood supply correctly describes the condition known as Myocardial Infarction.
//^ True
//A True
//B False

//#Q This progressive generative disease of the brain results in loss of cognitive ability and uncontrolled movements, called chorea, the Greek word for dance.
//^ Huntingtons Disease
//A Alzheimers Disease
//B Myasthenia Gravis
//C Multiple Sclerosis
//D Huntingtons Disease

//#Q Which of these is best describes the cause of Parkinsons disease?
//^ A decrease in a neurotransmitter
//A A brain injury
//B Changes in the myelin sheath of the neuron
//C Decreased blood flow to the brain
//D A decrease in a neurotransmitter

//#Q If your physician tells you that you have Presbycusis due to the normal process of aging, he may suggest that you need which of these?
//^ Hearing aid
//A Dentures
//B Glasses
//C A wheelchair
//D Hearing aid

//#Q Which of these medical terms means difficulty in swallowing.
//^ dysphagia
//A dyspepsia
//B dysuria
//C dyspnea
//D dysphagia

//#Q Does the condition known as Hypoglycemia imply that blood sugar levels in the body are too high?
//^ No
//A Yes
//B No

//#Q If you have hyperthyroidism, your body is overproducing what hormone?
//^ Thyroxine
//A Estrogen
//B Thyroxine
//C Glucagon
//D Thyrocalcitonin

//#Q Which of these most accurately describes the medical term, necrosis?
//^ Death of living tissue
//A Irregular heartbeat
//B Death of living tissue
//C Decrease in white blood cells
//D Liver damage

//#Q Your physician has ordered an electroencephalogram (EEG), the graphic recording of the electrical activity of what organ?
//^ Brain
//A Muscles
//B Liver
//C Heart
//D Brain

//#Q In the US, what was the average street cost of a lid (3/4 ounce bag) of marijuana in the mid 1970s?
//^ $15.00
//A $20.00
//B $10.00
//C $15.00
//D $5.00

//#Q Marijuana is known by many names, including all of these but one. Which is the odd name?
//^ Janu
//A Mary Jane
//B Weed
//C Pot
//D Janu

//#Q What is marijuanas primary active ingredient?
//^ THC
//A THC
//B TCB
//C TAC
//D TBC

//#Q How many different chemicals can be found in marijuana?
//^ More than 400
//A 150
//B Less than 5
//C More than 400
//D 200

//#Q According to anonymous researches, conducted in the USA in 2002, most teenagers aged 12-17 have at least tried Marijuana.
//^ False
//A False
//B True

//#Q Which side effect is not related to the use of marijuana?
//^ Violent behaviour
//A Silly and causeless giggling
//B Red, bloodshot eyes
//C Dizziness and staggering
//D Violent behaviour

//#Q Marijuana is produced from parts of the male cannabis plants.
//^ False
//A True
//B False

//#Q With the passage of the Marijuana Tax Act, the United States effectively banned recreational and medicinal use of cannabis. What year was this act adopted?
//^ 1937
//A 1945
//B 1937
//C 1972
//D 1965

//#Q By amending its Opium Act in 1976, the government of which country decided to treat possession of up to 30 grams of marijuana as an activity not for prosecution, detection or arrest?
//^ Holland
//A Columbia
//B Holland
//C Canada
//D USA

//#Q What US state enacted Proposition 215, the Compassionate Use Act, which allowed sick and dying patients to legally use marijuana for medicinal purposes?
//^ California
//A Alabama
//B Hawaii
//C California
//D Ohio

//#Q The sphygmomanometer is a device invented by Samuel Siegfried Karl Ritter von Basch, used to measure what?
//^ Blood pressure
//A Blood pressure
//B Myopia
//C Intensity of headaches
//D Heart murmurs

//#Q This disorder, from a Greek word meaning failure to put in order, is characterised by lack of muscular coordination, and often occurs when parts of the nervous system which control movement are damaged.
//^ Ataxia
//A Narcolepsy
//B Dyslexia
//C Hyperkinesis
//D Ataxia

//#Q This disorder is the abnormal accumulation of cerebrospinal fluid in the ventricles of the brain.
//^ Hydrocephalus
//A Spina bifida
//B Multiple sclerosis
//C Epilepsy
//D Hydrocephalus

//#Q Tourette syndrome is a neurological disorder, characterized by tics -- involuntary, rapid, movements or vocalizations.
//^ True
//A False
//B True

//#Q This is the colloquial equivalent of the medical term Herpes zoster, which is used to define a condition, caused by the varicella zoster virus.
//^ Shingles
//A Cold sores
//B Sementia
//C Mumps
//D Shingles

//#Q Pre-eclampsia, thought to be caused by inflammatory mediators, is a medical condition associated with which of these?
//^ Pregnancy
//A Pregnancy
//B Eye infections
//C Brain tumor
//D Bronchitis

//#Q Down Syndrome, named after Dr. John Langdon Down, is actually a chromosomal defect.
//^ True
//A True
//B False

//#Q What medical term is synonym of jaundice, a condition characterized by yellowing of the skin, sclera and mucous membranes?
//^ Icterus
//A Icterus
//B Ascites
//C Anorexia
//D Nausea

//#Q The presence of gallstones in the gallbladder is defined by what medical term?
//^ Cholelithiasis
//A Dysentery
//B Hepatitis
//C Cholelithiasis
//D Cirrhosis

//#Q Arthralgia is a severe heart disorder.
//^ False
//A False
//B True

//#Q The term encephalon, defined as the brain of a vertebrate, derives from a Greek word which means what?
//^ In the head
//A In the mind
//B Forehead
//C In the backbone
//D In the head

//#Q Carcino is a word of Greek origin which refers to the small intestines.
//^ False
//A True
//B False

//#Q The term blepharo derives from a Greek word and refers to which part of the body?
//^ Eyelid
//A Artery
//B Larynx
//C Eyelid
//D Lungs

//#Q An inguinal hernia occurs in the groin, the area between the abdomen and thigh.
//^ True
//A False
//B True

//#Q Which of these medical terms refers to air passages in the lungs?
//^ Bronchial tubes
//A Neurons
//B Axons
//C Terminals
//D Bronchial tubes

//#Q The word phlebo is of Greek origin, which comes from the root phlein, meaning to gush or to overflow.  What part of the body does this word refer to?
//^ Veins
//A Aorta
//B Arteries
//C Capillaries
//D Veins

//#Q The medical prefix bucco refers to which part of the head?
//^ Cheek
//A Forehead
//B Eye
//C Cheek
//D Nose

//#Q The medical prefix oophoro, which derives from Greek, refers to which part of the body?
//^ Ovary
//A Muscle
//B Uterus
//C Abdomen
//D Ovary

//#Q The prefix neuro, which in Greek means sinew or string, is related to the nervous system.
//^ True
//A True
//B False

//#Q The prefix of Greek origin, oto is used in medical terminology to refer to what body part?
//^ Ear
//A Nose
//B Mouth
//C Ear
//D Eye

//#Q Scientists differentiate what three basic types of memory, based on the duration of memory retention?
//^ Sensory memory, short-term memory, and long-term memory
//A Episodic memory, procedural memory, and semantic memory
//B Temporary memory, average memory, and permanent memory
//C Momentary memory, short-term memory, and permanent memory
//D Sensory memory, short-term memory, and long-term memory

//#Q To which of these essential human abilities is memory closely related?
//^ All of these
//A All of these
//B Learning
//C Understanding
//D Speaking

//#Q Procedural Memory, a category of the long-term memory, refers to which of these basic human abilities?
//^ The ability to acquire and develop skills
//A The ability to gain and store general knowledge and information
//B The ability to consciously retrieve stored facts and information
//C The artistic and creative abilities
//D The ability to acquire and develop skills

//#Q Typically, how many random items can human short-term memory store?
//^ 6-8
//A 3-4
//B 9-11
//C 6-8
//D 15-17

//#Q Déjà Vu is one of the curios brain phenomenon. Which of these most accurately describes the term?
//^ A sensation of something seen or experienced before
//A A sensation of something seen or experienced before
//B A spontaneous involuntary creation of a false memory
//C A sudden flash of a long forgotten memory
//D The feeling that something familiar was never seen before

//#Q Nearly everybody has experienced the tip-of-the-tongue situation when one is eagerly trying to think of a relatively familiar fact, name or word and is just about to recall it, but it constantly eludes him.  What is the explanation of this strange experience?
//^ Another item is blocking the recollection
//A Aging brain cells
//B Mineral deficiency
//C Unpleasant experience associated with the memory
//D Another item is blocking the recollection

//#Q Which of these most accurately explains the controversial issue of  false memories?
//^ Memories formed under the influence of misleading suggestions and clues
//A Memories formed under the influence of misleading suggestions and clues
//B None of these
//C Memories lacking coherent and logical rationale
//D Memories causing false sensations

//#Q One of the most basic characteristics of our memory is the ability to forget, which is considered to be this type of function.
//^ Adaptive function
//A Developing function
//B Adaptive function
//C Cognitive function
//D Protective function

//#Q Amnesia, the loss of significant amount of important information, is a memory impairment which happens as a result of which of these?
//^ All of these
//A Specific malfunctions in the brain
//B Physical injury
//C Psychological trauma
//D All of these

//#Q In the study of memory, what does the term mnemonist refer to?
//^ Individual with exceptional memory
//A Individual with exceptional memory
//B Individual with severe memory disorders
//C Individual who tends to create false memories
//D Individual who has recovered from amnesia

//#Q What is the main cause for most pandemics in history?
//^ The domestication of animals
//A The domestication of animals
//B Human negligence
//C Genetic experiments
//D The bad hygiene of the people

//#Q During which war did the first known pandemic take place?  It dates back to 430 BC.
//^ The Peloponnesian War
//A The Peloponnesian War
//B The Punic Wars
//C The Persian Wars
//D The Trojan War

//#Q Which Roman emperor died of Antonine plague? This plague was actually named after him.
//^ Marcus Aurelius
//A Marcus Aurelius
//B Vespasian
//C Claudius
//D Augustus

//#Q Is there a cure for the plague?
//^ Yes
//A Yes
//B No

//#Q At this stage of the plague, one of the the symptoms is the presence of black patches on the skin.
//^ Septicemic Plague
//A Plague of Justinian
//B Septicemic Plague
//C Pneumonic Plague
//D Bubonic Plague

//#Q This disease had 7 pandemics and is still causing epidemics.
//^ Cholera
//A Plague
//B Cholera
//C Typhus
//D Influenza

//#Q This terrible disease killed as much as 5% of the worlds population and affected almost 20% in just six months.
//^ Spanish Flu
//A Spanish Flu
//B Measles
//C Bubonic plague
//D Cholera

//#Q The smallpox isnt dangerous.
//^ False
//A True
//B False

//#Q Which of these countries did cholera affect most?
//^ Russia
//A USA
//B Italy
//C Russia
//D France

//#Q Cancer is considered a pandemic.
//^ False
//A False
//B True

//#Q This is one of the most common health problems that comes from being overweight.
//^ High blood pressure
//A Fainting
//B High blood pressure
//C Vertigo
//D Low blood pressure

//#Q In the USA, obesity is the second leading cause of preventable death after this one.
//^ Smoking
//A Stress
//B Drugs
//C Pollution
//D Smoking

//#Q How many people are overweight around the world?
//^ More than 1 billion
//A More than 3 million
//B More than 1 million
//C More than 5 million
//D More than 1 billion

//#Q When starting a diet you have to consume at least this number of calories per day, otherwise you will lose muscle.
//^ 1200
//A 2000
//B 1000
//C 1500
//D 1200

//#Q Which of the following has the most fat?
//^ American Blue Cheese
//A Cottage Cheese
//B Feta
//C American Blue Cheese
//D Parmesan

//#Q Body Mass Index (BMI) is the relation between body mass and height.  If your BMI is in this range then you are considered overweight.
//^ 25 to 29.9
//A 25 to 29.9
//B 20 to 24.9
//C 15 - 19.9
//D 10 - 14.9

//#Q This is the most recommended activity that helps prevent or fight obesity.
//^ Getting exercise
//A Quitting alcohol
//B Getting exercise
//C Eating salads only
//D Drinking a lot of water

//#Q At what time in a womans life is she most likely to gain the most weight?
//^ During pregnancy
//A After the age of 60
//B During pregnancy
//C Before her menstruation
//D During menopause

//#Q Women become overweight easier than men.
//^ True
//A False
//B True

//#Q What does being obese in some countries with food shortages symbolizes?
//^ Wealth
//A Wealth
//B Wisdom
//C Divinity
//D Well-being

//#Q Jason has 3 quarters, 8 nickels, 6 dimes and 3 pennies. How much money does he have?
//^ $1.78
//A $0.35
//B $1.78
//C $2.58
//D $1.93

//#Q What is the next number in the following sequence: 42, 48, 54, __?
//^ 60
//A 64
//B 50
//C 58
//D 60

//#Q In the following division problem, the quotient is 2: 

//12 / 6 = 2.
//^ True
//A True
//B False

//#Q 6 is a multiple of 2 and 3, 9 is a multiple of 3 only, 10 is a multiple of 5 and what other number?
//^ 2
//A 10
//B 2
//C 15
//D 5

//#Q How would you write 236,598 out in words?
//^ Two hundred, thirty-six thousand, five hundred ninety-eight
//A Two million, thirty-six thousand, five hundred ninety-eight
//B Two hundred, thirty-six thousand, five hundred ninety-eight
//C Three hundred, thirty-six thousand, six hundred ninety-eight
//D Two hundred, three thousand, five hundred ninety-seven

//#Q The eyes of males are bigger than those of females.
//^ True
//A False
//B True

//#Q The eyes of a baby weigh about 1/400 of its entire body mass. How much do the eyes of an adult weigh?
//^ 1/4000 of the body mass
//A 1/1000 of the body mass
//B 1/4000 of the body mass
//C 1/20000 of the body mass
//D 1/10000 of the body mass

//#Q An adult salivates this much per day, on average.
//^ 1 liter(1/4 gallons)
//A 2 liters(1/2 gallons)
//B 0.1 liters(0.026gallons)
//C 1 liter(1/4 gallons)
//D 1.2 liters(0.32 gallons)

//#Q How long are the intestines of an average adult? (large and small)
//^ approx 8-9 meters(26-29.5 feet)
//A approx 1-2 meters(3-6.5 feet)
//B approx 19-20 meters(62-65 feet)
//C approx 8-9 meters(26-29.5 feet)
//D approx 15-16 meters(49-52.5 feet)

//#Q The growth hormone is released from this gland.
//^ Hypophysis
//A Pancreas
//B Hypophysis
//C Adrenal Gland
//D Pineal Gland

//#Q How many teeth does an average human have?
//^ 32
//A 28
//B 29
//C 34
//D 32

//#Q What can microexpressions, a type of tiny fleeting facial expressions, help you understand about the person you are talking with?
//^ All of these
//A Their real attitude towards the topic
//B Their emotional state
//C Whether they are telling the truth or not
//D All of these

//#Q Which one of these statements about facial microexpressions is not true?
//^ Microexpressions can be easily read by any person.
//A Microexpressions are involuntary.
//B Microexpressions can be controlled with certain types of chemicals.
//C Microexpressions contain much more information than common expressions.
//D Microexpressions can be easily read by any person.

//#Q Kismet, a complicated technological achievement, is a very important step in the understanding of human facial expressions and their role in socialising. What is actually Kismet?
//^ A sociable humanoid robot
//A A technique for enhancing the ability of the face to conduct emotions
//B A set of tiny devices implanted under the skin, which detect microexpressions
//C A sociable humanoid robot
//D An advanced computer system, designed to analyze microexpressions

//#Q What British naturalist published the first major scientific study on facial communication in 1872?
//^ Charles Darwin
//A Leonardo Da Vinci
//B Alfred Brehm
//C James Edward Smith
//D Charles Darwin

//#Q In medicine, which of these brain disorders does the term prosopagnosia refer to?
//^ The Inability to recognize faces
//A The inability to express emotions
//B Misinterpretation of basic human expressions
//C Total indifference to others expressions
//D The Inability to recognize faces

//#Q In which of these countries is showing negative facial expressions considered impolite and is therefore avoided?  Negative expressions are instead usually masked with smile or laughter.
//^ Japan
//A Peru
//B Kenya
//C Indonesia
//D Japan

//#Q What emotional state does the gesture of narrowed eyes convey?
//^ Threat, distrust
//A Threat, distrust
//B Satisfaction, joy
//C Sadness, frustration
//D Anger, excitement

//#Q Experiments prove that men are usually better at decoding facial expressions than women.
//^ False
//A True
//B False

//#Q Laughter is one of the first expressions of emotions babies learn to convey.  At about what age do babies start to laugh?
//^ 4 months
//A 12 months
//B 7 months
//C 18 months
//D 4 months

//#Q This organ contains many bacteria, which begin to digest surrounding organs immediately after death.
//^ Intestines
//A Liver
//B Stomach
//C Intestines
//D Rectum

//#Q A large number of flies can appear around a dead body within the first 24 hours of death.  This is mainly because the flies lay eggs on the body, this multiplying their numbers.
//^ True
//A True
//B False

//#Q In average conditions, approximately how many hours does it take for the dead bodys temperature to equalize with the surrounding environment?
//^ 24
//A 12
//B 48
//C 26
//D 24

//#Q Which of the following happens three days after the moment of death?
//^ The body starts to swell
//A The body starts to shrink
//B The body starts to emit smell
//C The body starts to swell
//D The nails are so loose that they can be pulled off

//#Q Because of the substance present in these structures of the human body, they can be preserved for centuries avoiding decomposition.
//^ Teeth
//A Teeth
//B Nails
//C Eyelashes
//D Eyeballs

//#Q Which part of the body is decomposed last, but before the bones?
//^ Hair
//A Cartilages
//B Hair
//C Nails
//D Gall Bladder

//#Q The term rigor mortis means this.
//^ Stiffness of death
//A Stiffness of death
//B Swollen corpse
//C Blue corpse
//D Blue death

//#Q The skin goes purple and waxy about one hour from time of death.
//^ False
//A False
//B True

//#Q A death erection is a post-mortem erection which occurs when a male individual dies vertically or face-down.  What causes this condition?
//^ Gravity causes the genitalia to fill up with blood
//A Having intercourse before death
//B Gravity causes the genitalia to fill up with blood
//C The body swells up
//D Bladder and Intestines empty

//#Q The face of the person becomes difficult to recognize 24 hours after death.
//^ True
//A False
//B True

//#Q Due to this, there is almost no atmosphere on the Moon.
//^ Weak gravity
//A Lack of oxygen
//B Cold temperature
//C Excessive sunshine
//D Weak gravity

//#Q The side of the Moon that we see is this.
//^ The same every night
//A Different every night
//B Different every two weeks
//C Different every month
//D The same every night

//#Q The distance between the Moon and the Earth is approximately this much.
//^ 238,897 miles (384,467km)
//A 238,897 miles(384,467km)
//B 62,000 miles(100,000km)
//C 155,342 miles(250,000 km)
//D 260,975 miles(420,000 km)

//#Q The Moon is changing its position it relation to the Earth. In what way?
//^ Moving away
//A Getting closer
//B Moving along the Earths Y axis
//C Moving away
//D Moving along the Earths X axis

//#Q Which factor ensures that many of the craters on the Moons surface remain well preserved in comparison to those on Earth?
//^ The lack of atmosphere
//A The strong solar rays
//B The rotating movement
//C The lack of atmosphere
//D The influence of Earths gravity

//#Q When was the Moon formed?
//^ About 4.5 billion years ago
//A About 5.7 billion years ago
//B About 4.5 billion years ago
//C About 300,000 years ago
//D About 1 billion years ago

//#Q Moons shape is not quite round. What does it resemble?
//^ Egg
//A Egg
//B Kiwi
//C Pear
//D Lemon

//#Q A compass cannot be used on the Moon.  What factor is responsible for this?
//^ Lack of a magnetic field
//A Lack of a magnetic field
//B Influence of Earths gravity
//C Asteroid impacts
//D Lack of gravity on the Moon

//#Q The Moon is taken into consideration when calculating the day of this religious celebration.
//^ Easter
//A Thanksgiving
//B Memorial Day
//C Christmas
//D Easter

//#Q The Moons diameter is approximately this long.
//^ 2,154 miles(3,476 km)
//A 2,796 miles(4,500 km)
//B 2,154 miles(3,476 km)
//C 5,567 miles(8,960 km)
//D 7,145 miles(11,500 km)

//#Q A large exposition at the Royal Observatory, Greenwich is devoted to horology, a science that studies what?
//^ time
//A time
//B navigation
//C lenses
//D comets

//#Q These animals are the subject of study of coleopterology, which is a subfield of entomology.
//^ beetles
//A jaguars
//B tigers
//C snakes
//D beetles

//#Q A King Cobra and a frog would be subjects of study of what science?
//^ herpetology
//A autecology
//B astacology
//C reptology
//D herpetology

//#Q This species, considered to have colonized almost every landmass on Earth, is studied by myrmecology.
//^ ants
//A bees
//B ants
//C flies
//D hornets

//#Q This material on the surface of a lithosphere is the subject of study of pedology.
//^ soil
//A turf
//B rock
//C rain
//D soil

//#Q This country, known for the worlds longest continuously used written language system, is the subject of study of sinology.
//^ China
//A China
//B Singapore
//C Japan
//D Korea

//#Q What national symbols are subject of study of vexillology?
//^ flags
//A flags
//B seals
//C national emblems
//D coat of arms

//#Q What is the subject of study of thanatology, personified in Greek mythology by Thanatos?
//^ death
//A death
//B plague
//C birth
//D grave

//#Q This astral body, known as Earths only natural satellite, is the subject of study selenology.
//^ Moon
//A Sun
//B Venus
//C Jupiter
//D Moon

//#Q This contractile tissue of the body is the subject of study of myology.
//^ muscles
//A blood cells
//B bones
//C hairs
//D muscles

//#Q What term is used to designate a hurricanes calm, low-pressure center around which winds of high velocity spin?
//^ Eye
//A Outer rim
//B Eye wall
//C Rain bands
//D Eye

//#Q A swallow hole is an unnatural depression in earths surface formed by the collapse of a large building.
//^ False
//A True
//B False

//#Q What term refers to electric power produced by running or falling water?
//^ Hydroelectric power
//A Nuclear power
//B Aquatic power
//C Hydrothermal power
//D Hydroelectric power

//#Q What term do scientists use to denote the gradual warming of the planet due to absorption of infrared radiation by the atmosphere?
//^ Greenhouse effect
//A Greenhouse effect
//B Ozone depletion
//C Atmospheric termoincrease
//D Global dimming

//#Q The geological area called The Ring of Fire is located along the borders of the Pacific Ocean.
//^ True
//A False
//B True

//#Q Will two tectonic plates sliding away from each other result in an earthquake?
//^ Yes
//A Yes
//B No

//#Q Sinkholes, natural depressions in the surface topography, may vary largely in size.
//^ True
//A True
//B False

//#Q There are many different theories of how the Milky Way galaxy was born.
//^ True
//A True
//B False

//#Q These biological poisons damage bio systems on contact. The injuries they cause resemble burns.
//^ Corrosives
//A Oxidizers
//B Halides
//C Corrosives
//D Neurotoxins

//#Q Arsenic poisoning mainly disrupts this system.
//^ Digestive system
//A Cardiovascular system
//B Digestive system
//C Endocrine system
//D Nervous system

//#Q Poisoning by this substance is often referred to as painters colic.
//^ Lead
//A Lead
//B Thallium
//C Barium
//D Chromium

//#Q Nicotine can be found in tomatoes, potatoes, green peppers, coca plants and tobacco.
//^ True
//A True
//B False

//#Q Troops who are likely to be attacked with chemical weapons often carry auto-injectors with this substance.
//^ Atropine
//A Solanine
//B Digoxin
//C Digitoxin
//D Atropine

//#Q Strychnine poisoning produces some of the most terrifying and painful symptoms imaginable.
//^ True
//A False
//B True

//#Q Three of these snakes produce venom, lethal to humans.  Which one does not?
//^ Desert Kingsnake
//A King Cobra
//B Desert Kingsnake
//C Mamba
//D Rattlesnake

//#Q In medical parlance, what is an A-line?
//^ Arterial line
//A Anatomic line
//B Analog line
//C Afferent line
//D Arterial line

//#Q After reading the following, what will a doctor conclude? Pt presents 3 d S/P TURP, with c/o HA x 2 d.
//^ The patient has a headache.
//A The patient has a headache.
//B The patient recently had abdominal surgery.
//C The patient has no current complaints.
//D The patient is female.

//#Q What do abbreviations Rx, Tx, Hx and Sx mean?
//^ Prescription, Treatment, History and Symptom
//A Pharmacy, Treatment Room, Hospital and Sanitorium
//B Renal, Thyroid, Uterine and Splenic
//C Prescription, Treatment, History and Symptom
//D Rectal, Thyroglossal, Hepatic and Splenic

//#Q In medical jargon, what are PMH, PSH, SH and FH?
//^ Past medical history, Past surgical history, Social history and Family history
//A Past medical history, Past surgical history, Social history and Family history
//B Post-medical healing, Post-surgical healing, Surgical healing and Functional healing
//C Posterior middle hyoid, Posterior superior hyoid, Superficial hyoid and Foramen hyoidium
//D Patient mental hospital, Patient surgical hospital, Social hospital, and Female hospital

//#Q If the doctor writes, CNs 2-12 intact, which of the following would be true?
//^ The patient is able to close and open the eyes.
//A The patient is a man.
//B The cervical nerves are all functioning normally.
//C The patient is able to close and open the eyes.
//D All of the lymph nodes in the cervical chain are normal.

//#Q In medical parlance, what is an AKA?
//^ The removal of a limb
//A An alcoholic
//B An antibiotic
//C The removal of a limb
//D A patient

//#Q If the doctor orders an EKG, what part of the body is going to be examined?
//^ Heart
//A Heart
//B Brain
//C Peripheral Nerves
//D Abdomen

//#Q In medical jargon, FH: CAD (M), DM (F) implies what?
//^ The patients mother had heart disease and the patients father had diabetes.
//A The patients mother died of an aneurysm, and the patients father died of a myocardial infarction.
//B The patients mother had a stroke, and the patients father had diabetes mellitus.
//C The patients mother had heart disease and the patients father had diabetes.
//D The patients mother was an engineer and the patients father was a computer programmer.

//#Q In medical terms, what is a CVA?
//^ A stroke
//A An aneurysm
//B A type of accountant
//C A heart attack
//D A stroke

//#Q At a party, a doctor asked a nurse: Are you an RN or an LPN?  The nurse replied: Im an RN. I got my BSN at Georgetown. Are you an MD or a DO?  The doctor replied: Im a DO. Which of the following statements can be concluded from this conversation?
//^ The doctor was trained in osteopathic manipulation.
//A The doctor is going to get lucky tonight.
//B The doctor is not really a doctor at all.
//C The doctor was trained in osteopathic manipulation.
//D The doctor is a chiropractor.

//#Q If you were taking a course in entomology, what would you be studying?
//^ Insects
//A Rocks
//B Snakes
//C Mold
//D Insects

//#Q This science studies signs, both individually and grouped in sign systems.
//^ Semiology
//A Anthology
//B Semiology
//C Linguistics
//D Theology

//#Q Etymologists study the history of languages and how the forms and meanings of different words changed.
//^ True
//A True
//B False

//#Q What part of the human body does the science periodontics study?
//^ Gums and mouth
//A Gums and mouth
//B Eyes
//C Finger and toes
//D Ears

//#Q Ichthyology is the study of biting insects such a fleas, mosquitoes and wasps.
//^ False
//A False
//B True

//#Q What scientists study recent or fossilized skeletal remains in order to find traces of ancient diseases?
//^ Paleopathologists
//A Mycologists
//B Parapsychologists
//C Paleopathologists
//D Epidemiologists

//#Q People who suffer from this condition tend to be self-destructive. They may use drugs, or engage in promiscuous sexual activities.
//^ Borderline Personality Disorder
//A Obsessive Compulsive Disorder
//B Panic Disorder
//C Borderline Personality Disorder
//D Generalized Anxiety Disorder

//#Q People with this disorder engage in idiosyncratic behaviors, such as wearing an odd-looking hat every day, or wearing their pants backwards.
//^ Schizotypal Personality Disorder
//A Antisocial Personality Disorder
//B Narcissistic Personality Disorder
//C Schizotypal Personality Disorder
//D Histrionic Personality Disorder

//#Q This disorder, also known as manic depression, involves high risk of death through suicide.
//^ Bipolar Disorder
//A Dependent Personality Disorder
//B Antisocial Personality Disorder
//C Bipolar Disorder
//D Schizophrenia

//#Q People suffreing from this mental illness manifest a psychiatric condition as a physical complaint.
//^ Somatization Disorder
//A Agoraphobia
//B Kleptomania
//C Somatization Disorder
//D Munchausen Syndrome

//#Q A person with this disorder has fluctuating levels of orientation.
//^ Delirium
//A Dementia
//B Psychosis
//C Delusional State
//D Delirium

//#Q An old adage states, Neurotics build castles in the sand. Psychotics live in them.  Which one of the following disorders is not considered a neurosis?
//^ Schizoid Personality Disorder
//A Schizoid Personality Disorder
//B Obsessive-Compulsive Disorder
//C Panic Disorder
//D Agoraphobia

//#Q According to statistics, which of the following people is most likely to commit suicide?
//^ A middle-aged divorced man.
//A A recovering alcoholic.
//B A middle-aged divorced man.
//C A middle-aged divorced woman living alone.
//D A teenage boy who smokes marijuana.

//#Q Depression can cause brain damage.
//^ True
//A False
//B True

//#Q Three of the following four disorders are actually different names for the same disease. Which is the odd one?
//^ Maniac
//A Antisocial Personality
//B Psychopath
//C Maniac
//D Sociopath

//#Q People with this disorder have difficulty engaging in everyday human interaction.
//^ Autism
//A Autism
//B Huntingtons Disease
//C Cerebral Palsy
//D Addisons Disease

//#Q Located in the upper anterior portion of the chest cavity, the thymus is an organ belonging to which system of the human body?
//^ Lymphatic System
//A Endocrine system
//B Integumentary system
//C Lymphatic System
//D Nervous system

//#Q Which are the endocrine systems so-called instant messengers used to affect distant cells within specific organs?
//^ Hormones
//A Nephrons
//B Neurons
//C Acids
//D Hormones

//#Q In humans, which of these organs belongs to the integumentary system?
//^ Skin
//A Skin
//B Tonsils
//C Liver
//D Pharynx

//#Q Mucus is a slippery secretion of the lining of various membranes typical for which system of the human body?
//^ All of these
//A All of these
//B Reproductive system
//C Digestive system
//D Respiratory system

//#Q Which of the following is not a function of the circulatory system?
//^ Excretion of unwanted substances
//A Excretion of unwanted substances
//B Stabilizing body temperature
//C Maintaing pH
//D Transport of vital substances

//#Q Comparing a newborn babys skeletal system to an adults skeletal system, we will find out that the baby has about 60 bones more that the already completely developed person.
//^ True
//A True
//B False

//#Q Emphysema is a chronic disease affecting the organs of which system of the body?
//^ Respiratory system
//A Respiratory system
//B Skeletal system
//C Urinary system
//D Digestive system

//#Q In humans, the nervous system is divided into a central nervous system and a peripheral nervous system. The peripheral nervous system has two more divisions. The first one is the autonomic nervous system. What is the second one?
//^ Somatic nervous system
//A Sympathetic nervous system
//B Parasympathetic nervous system
//C Enteric nervous system
//D Somatic nervous system

//#Q In the female body the breasts are organs of the reproductive system.
//^ True
//A False
//B True

//#Q Australopithecus were early hominids that differed in many ways from modern-day humans -- they were short, and their brain-case was much smaller. In 1924, Raymond Dart found the first remains of an Australopithecus on this continent.
//^ Africa
//A Africa
//B Australia
//C Asia
//D Europe

//#Q The most complete Australopithecus skeleton, dubbed Lucy,  was found in 1974.  She was 1.10m (3 7) tall and weighed about 30kg (66lbs).  Anthropologists named the skeleton after this Lucy.
//^ Lucy from The Beatles song Lucy in the Sky with Diamonds
//A Lucille Ball from the TV show I Love Lucy
//B Lucy of Lucy Clothing Manufacturers
//C Lucy from The Beatles song Lucy in the Sky with Diamonds
//D Actress Lucy Liu

//#Q Ancient footsteps found in Tanzania prove that there were bipedal hominids as early as 3.8 million years ago.
//^ True
//A False
//B True

//#Q Although the Australopithecus were much more intelligent and sophisticated than other animals at that time, they were still closer to monkeys than humans. Later, a new genus developed -- the Homo genus. The first Homo genus specie diverged from the Australopithecus and was called this.
//^ Homo habilis
//A Homo sapiens
//B Homo erectus
//C Homo neanderthalensis
//D Homo habilis

//#Q There is evidence that Sinanthropus pekinensis used tools and was able to light a fire. Unfortunately, the teeth of the Sinanthropus are still considered medicine and are sold in some pharmacies in its home country.
//^ China
//A China
//B Zimbabwe
//C France
//D Japan

//#Q There are theories that Neanderthals actually buried their dead.
//^ True
//A True
//B False

//#Q About 230,000 years ago one highly sophisticated and relatively intelligent specie of the Homo genus appeared; homo Neanderthalus was very well adapted to cold - it was short and muscular (many modern day heavy-weight champions would envy an average Neanderthal) and had a large nose. In 1983 the hyoid bone of a Neanderthal was found and that raised many disputes. What did this tiny bone prove?
//^ That Neanderthals probably had sophisticated language
//A That Neanderthals were cannibals
//B That Neanderthals probably had sophisticated language
//C That they were possibly more intelligent than modern people
//D That they were vegetarians

//#Q Neanderthals are the ancestors of modern-day humans.
//^ False
//A False
//B True

//#Q Which part of a building is also a computer operating system name?
//^ Windows
//A Doors
//B Windows
//C Balcony
//D Loggia

//#Q Which animal can be connected to a computer USB port?
//^ Mouse
//A Dog
//B Mouse
//C Rat
//D Cat

//#Q Which of these is a popular database name?
//^ Oracle
//A Mosque
//B Oracle
//C Shrine
//D Church

//#Q Which bathroom item is also a communication protocol?
//^ SOAP
//A BRUSH
//B GEL
//C SOAP
//D COMB

//#Q Which wall is used for computer protection in the Internet or other networks?
//^ Firewall
//A Firewall
//B Wooden wall
//C Brickwall
//D Protective wall

//#Q Which celestial body is also a name of a big American vendor of computers, computer components and software?
//^ Sun
//A Sun
//B Venus
//C Moon
//D Pluto

//#Q Which commercial building can also store data?
//^ Warehouse
//A Warehouse
//B Super market
//C Store
//D Shop

//#Q The name of which animal group is also a collective name for software errors?
//^ Bugs
//A Insects
//B Spiders
//C Ants
//D Bugs

//#Q Which of these is a computer for bulk data processing?
//^ Mainframe
//A A-frame
//B Body-on-frame
//C Window-frame
//D Mainframe

//#Q Which hat is a distribution of the Linux operating system?
//^ Red Hat
//A Black Hat
//B White Hat
//C Red Hat
//D Blue Hat

//#Q The name of which Native American group is also a name of an open source organization?
//^ Apache
//A Iroquois
//B Navajo
//C Cherokees
//D Apache

//#Q The name of which island is also a computer programming language name?
//^ Java
//A Cuba
//B Jamaica
//C Java
//D Malta

//#Q How many bones (on average) does the human body contain?
//^ 206
//A 207
//B 206
//C 208
//D 205

//#Q A tendon is a tough band of fibrous connective tissue that connects a muscle to a bone.
//^ True
//A False
//B True

//#Q This extremely vital nerve is responsible for such varied tasks as heart rate, gastrointestinal peristalsis and sweating. It also controls quite a few muscle movements in the mouth, including speech and keeping the larynx open for breathing.
//^ Vagus nerve
//A Oculomotor nerve
//B Vagus nerve
//C Facial nerve
//D Hypoglossal nerve

//#Q This organ, which is the largest gland in the human body, plays a major role in metabolism and has a variety of functions, including glycogen storage, plasma protein synthesis, and drug detoxification.
//^ Liver
//A Gall Bladder
//B Pancreas
//C Liver
//D Kidney

//#Q Which statement correctly describes the superior vena cava?
//^ It is a large, yet short vein that carries de-oxygenated blood from the upper half of the body to the hearts right atrium.
//A II is the large vein that carries de-oxygenated blood from the lower half of the body into the heart.
//B It is the largest artery in the human body, originating from the left ventricle of the heart and bringing oxygenated blood to all parts of the body
//C It is a vein that carries oxygen-rich blood from the lungs to the left atrium of the heart and is the only vein in the post-fetal human body that carries oxygenated blood.
//D It is a large, yet short vein that carries de-oxygenated blood from the upper half of the body to the hearts right atrium.

//#Q Diarthrosis joints permit a variety of movement and can be divided into six classes. The femur and hip connection would be considered which joint class?
//^ Ball-and-socket joint (enarthrosis, spheroidal joint)
//A Ball-and-socket joint (enarthrosis, spheroidal joint)
//B Hinge joint (ginglymus)
//C Pivot joint (trochoid joint, rotary joint)
//D Condyloid joint (condyloid articulation, ellipsoidal joint)

//#Q There is no square root of two.
//^ False
//A False
//B True

//#Q There are twelve apples on a table. You take four. How many apples do you have now?
//^ 4
//A 12
//B 8
//C 0
//D 4

//#Q What is the only number with no reciprocal?
//^ 0
//A 1
//B -1
//C 0
//D Pi

//#Q Octo is a prefix meaning eight.  An Octopus has eight legs. An octagon has exactly 8 sides.  An Octogenarian is at least 8 decades old.  What is the eighth month?
//^ August
//A November
//B August
//C October
//D September

//#Q How fast is a mile a minute?
//^ 60 miles an hour
//A The speed of the fastest human runner
//B 60 kilometers and hour
//C 60 yards an hour
//D 60 miles an hour

//#Q The Shaanxi earthquake is regarded as the deadliest recorded earthquake, killing approximately 830,000 people. It occurred on February 14, 1556 in this country.
//^ China
//A Thailand
//B Japan
//C Russia
//D China

//#Q Teleseisms are ground motions caused by a distant earthquake.
//^ True
//A False
//B True

//#Q The theory of plate tectonics explains the movement of lithospheric plates. Tectonics comes from the Greek word tekton, meaning this.
//^ one who constructs
//A one who destroys
//B one who constructs
//C one who floats
//D one who moves

//#Q Earthquakes that occur at the boundaries of tectonic plates are called interplate. The less frequent type of earthquakes, called this, occur in the interior of the lithospheric plates.
//^ Intraplate
//A Innerplate
//B Non-interplate
//C Ultraplate
//D Intraplate

//#Q The Good Friday Earthquake, which occurred on March 27, 1964, is the most powerful earthquake in U.S. history. It killed approximately 13,000 people.
//^ False
//A False
//B True

//#Q The Mercalli scale classifies the intensity of earthquakes by examining this aspect.
//^ The effects of the earthquake on people and structures
//A The energy a quake generates
//B The degree of shift at the Equator
//C The effects of the earthquake on people and structures
//D The effect of the earthquake on 1 liter of water spread over a surface of 1 square meter

//#Q The San Francisco earthquake is one of the most ill-famed earthquakes in history.  It happened in this year.
//^ 1906
//A 1908
//B 1916
//C 1910
//D 1906

//#Q Seismic waves are classified in four types - P-waves (primary), S-waves (secondary), Love waves (surface waves) and this type.
//^ Rayleigh waves
//A F-waves
//B L-waves
//C Rayleigh waves
//D Richter waves

//#Q This earthquake occurred on August 17, 1999, and had a magnitude of 7.4. The reported number of casualties was approximately 17,000. Where did this disaster take place?
//^ Turkey
//A China
//B Spain
//C Turkey
//D The United States

//#Q The 2004 Indian Ocean earthquake was an undersea earthquake that generated a tsunami, which claimed the lives of more than 150,000 people (this is true). The earthquake lasted nearly ten minutes.
//^ True
//A False
//B True

//#Q Elder mothers have higher chances of conceiving twins.
//^ True
//A True
//B False

//#Q A mother will give birth to this kind of twins if a single fertilized egg splits after conception.
//^ Monozygotic twins
//A Monozygotic twins
//B Dizygotic twins
//C Conjoined twins
//D Twins of two

//#Q The first recorded successful operation to separate a pair of conjoined twins took place in this year.
//^ 1689
//A 1889
//B 1976
//C 1689
//D 1989

//#Q The term Siamese twins comes from the famous case of Eng and Chang Bunker, who were conjoined twin brothers, born in Thailand in 1811.
//^ True
//A True
//B False

//#Q The chances of having twins in the 21st century are ...?
//^ 3 in 100
//A 15 in 100
//B 3 in 100
//C 10 in 100
//D 5 in 100

//#Q The case of identical twins of different sex is extremely rare. The development of their gender starts 5 weeks after the moment of conceiving.
//^ False
//A True
//B False

//#Q A twin fetus which does not develop during pregnancy is called this.
//^ Vanishing twin
//A Conjoined twin
//B Vanishing twin
//C Multiple twin
//D Fraternal twin

//#Q This celebrity had a twin brother who died at birth.
//^ Elvis Presley
//A Madonna
//B Michael Jackson
//C Elton John
//D Elvis Presley

//#Q The family of Fyodor Vassilyev from Russia had a record number of children. His wife gave birth to this number of twin couples.
//^ 16
//A 28
//B 16
//C 9
//D 23

//#Q It is said that twins develop their own language, called this.
//^ Idioglossia
//A Idioglossia
//B Sindarin
//C Quenya
//D Klingon

//#Q If a doctor prescibes a medicine and the prescription reads, Instill 2 - 3 gtts in OD bid.  What does OD mean?
//^ Right eye
//A Left ear
//B Right ear
//C Right eye
//D Left eye

//#Q What color is Arterial Blood?
//^ Bright Red
//A Purple
//B Bright Red
//C Reddish Purple
//D Dark Red

//#Q What lobe in the brain is responsible for retaining verbal memory?
//^ Left Temporal Lobe
//A Left Parietal Lobe
//B Left Temporal Lobe
//C Right Temporal Lobe
//D Right Parietal Lobe

//#Q The aorta carries deoxygenated blood from the heart to the rest of the body.
//^ False
//A True
//B False

//#Q Which of the following disorders is not of the Endocrine System?
//^ Parkinsons Disease
//A Parkinsons Disease
//B Hyperthyroidism
//C Diabetes
//D Osteoporosis

//#Q The XY chromosome(s) determines that an embryo is developed into a baby girl.
//^ False
//A True
//B False

//#Q Which part of th eye captures light rays and converts the rays into electrical impulses?
//^ Retina
//A Retina
//B Iris
//C Cornea
//D Pupil

//#Q How many vertebrae make up the thoracic region of the spinal column?
//^ 12
//A 5
//B 7
//C 10
//D 12

//#Q The ileum is located in this part of the body.
//^ Small Intestine
//A Small Intestine
//B Spinal cord
//C Brain
//D Large intestine

//#Q This country has more Internet Service Providers than any other non-English speaking country.
//^ Czech republic
//A Russia
//B Czech republic
//C Romania
//D Brazil

//#Q Development of a global computer network was first proposed in this year, by J.C.R. Licklider.
//^ 1962
//A 1972
//B 1982
//C 1962
//D 1952

//#Q This was the first popular WWW browser. Microsofts Internet Explorer is also based on it.
//^ NCSA Mosaic
//A Opera
//B lynx
//C NCSA Mosaic
//D Netscape Navigator

//#Q Cables are essential for the transfer of data. The first cable to transfer instantaneous communications across the ocean was laid in this year.
//^ 1858
//A 1950
//B 1924
//C 1908
//D 1858

//#Q It was the Internets progenitor and the first large geographically separated network.
//^ ARPANET
//A ARPANET
//B NSFNET
//C UUCP
//D CSNET

//#Q The first e-mail message was sent in this year by Ray Tomlinson.
//^ 1971
//A 1979
//B 1964
//C 1983
//D 1971

//#Q This person wrote HTTP, the language in which browsers and web servers communicate.
//^ Tim Berners-Lee
//A Steve Jobs
//B Bill Gates
//C Tim Berners-Lee
//D Douglas Engelbart

//#Q This is how long it took the Internet to attract 50 million users.
//^ 4 years
//A 4 years
//B 20 years
//C 10 years
//D 5 years

//#Q This program pretends to be useful, while executing malicious code.
//^ Trojan horse
//A Logic bomb
//B Worm
//C Trojan horse
//D Virus

//#Q In 1995, this famous American computer outlaw was caught while stealing electronic mail and software.  In 1996 he released the book Takedown: The Pursuit and Capture of Americas Most Wanted Computer Outlaw -- By The Man
//^ Kevin Mitnick
//A Robert Morris
//B Vladimir Levin
//C Tsutomu Shimomura
//D Kevin Mitnick

//#Q About 95% of the rocks which form the upper part of the Earths crust are Igneous Rocks.
//^ True
//A False
//B True

//#Q Gold carats measure purity, whereas diamond carats measure this quality.
//^ Weight
//A Color
//B Weight
//C Hardness
//D Clarity

//#Q When magma cools and becomes solid below Earths surface, the resultant rocks are called Plutonic, but when when magma reaches the surface and crystallizes there, formed rocks are called this.
//^ Volcanic
//A Volcanic
//B Mercuric
//C Surfaced
//D Veneric

//#Q The Lunar seas are actually plains of gabbro and this rock. The same rock is also a main component of the surface of Mars.
//^ Basalt
//A Basalt
//B Obsidian
//C Andesite
//D Granulite

//#Q This moon is the most volcanic object in the solar system. Its volcanoes erupt sulfur, sulfur dioxide and silicate rock,  constantly resurfacing it.
//^ Io
//A Titania
//B Io
//C Ganymede
//D Europa

//#Q What do we call this sequence of numbers:  1, 1, 2, 3, 5, 8, 13, 21, 34, 55 ...?
//^ Fibonacci
//A Lucas
//B Gauss
//C Euler
//D Fibonacci

//#Q What was the name of the man who invented logarithms?
//^ John Napier
//A Rene Descartes
//B John Napier
//C Blaise Pascal
//D Robert Recorde

//#Q Sir Isaac Newton developed his calculus and physics at what college?
//^ None
//A Oxford
//B None
//C Trinity
//D Cambridge

//#Q Who was the teacher of Plato?
//^ Socrates
//A Thales
//B Socrates
//C Aristotle
//D Archimedes

//#Q Who wrote the first textbook on Geometry?
//^ Euclid
//A Thales
//B Euclid
//C Archimedes
//D Van Nostrand

//#Q In order to boost their math department , the University of Virginia, a great school, imported the great British mathematician J.J. Sylvester to become a part of the school.  He  agreed.  Almost everyone loved him, his lectures, his motivational talks, etc. Everyone, except for the only student who got a C from him. Besides some lewd talk and anti-semitic rants, the student took a stump and attacked Sylvester. What happened next ?
//^ Sylvester beat the heck out of the student.Sylvester was a good 40 older than the student, but took no guff.
//A The students father demanded a duel with Sylvester because he had had the student arrested. Sylvester left for France the next night.
//B The student was arrested for assault, sent to prison for three years. Sylvester returned to England physically broken.
//C Sylvester beat the heck out of the student.Sylvester was a good 40 older than the student, but took no guff.
//D After a short beating, Sylvesters students broke up the fight. Sylvester spent a month in the hospital and returned to his duties.

//#Q What sign flew over the school of Aristotle?
//^ Let no one unfamiliar with geometry enter
//A Know Thyself
//B Es Will De garnish helfen
//C Let no one unfamiliar with geometry enter
//D All for Knowledge

//#Q Of all of the Postulates of Euclid, one stood out as a big sticking point. To this day it involves such things as space travel, physics, and triangles. Which postulate was it?
//^ 5
//A 2
//B 3
//C 4
//D 5

//#Q We all know what acute angles, obtuse angles, right angles, and straight angles are, but what is a reflex angle?
//^ An angle greater than 180 degrees but less than 360 degrees.
//A The angle a telescope makes with the Earth
//B An angle greater than 180 degrees but less than 360 degrees.
//C Any angle greater than 360 degrees
//D The angle you need to look a fish in the eye.

//#Q How many of these statements are true: 
//- negative one has no square root
//- the logarithm of negative one is negative
//- the reciprocal of negative one is positive one
//- positive one to the negative one power is one.
//^ 1
//A 1
//B 3
//C 2
//D 0

//#Q If a woman has these pains, they almost always disappear when she becomes pregnant.
//^ Arthritic pains
//A Stomach aches
//B Neural pains
//C Arthritic pains
//D Migraine pains

//#Q This organ expands up to 500 times its normal size during the pregnancy.
//^ The uterus
//A The stomach
//B The uterus
//C The ovaries
//D The bladder

//#Q During this month of the pregnancy women go through a lot of mood swings like being easily irritated or start crying when they hear a song on the radio.
//^ 1st month
//A 7th month
//B 1st month
//C 9th month
//D 4th month

//#Q The fingerprints of the baby begin forming in this week of pregnancy. The baby also starts grasping and sucking its thumb at this time.
//^ 18th
//A 21st
//B 35th
//C 18th
//D 10th

//#Q This common side effect is caused by the hormone, progesterone, which relaxes the valve that separates your esophagus from your stomach, allowing gastric acids to seep back up, which causes this uncomfortable sensation.
//^ Heartburn
//A Heartburn
//B Back pain
//C Constipation
//D Nausea

//#Q After week 27 you can do the following experiment: switch on a flashlight against your belly and the baby will move towards the light.   What allows this to happen?
//^ it opens its eyes
//A its head can move
//B its hearing started functioning
//C its brain started growing quickly
//D it opens its eyes

//#Q During pregnancy the following symptoms happen to what part of the body: grow larger, tender, swollen, and darkened areolas.
//^ Breast
//A Hands
//B Breast
//C Stomach
//D Face

//#Q A common complaint among pregnant women are swollen legs.  Feet actually swell because of this.
//^ Water retention
//A Tight Shoes
//B Constipation
//C Indigestion
//D Water retention

//#Q During what period does your sleep become almost impossible and interrupted.
//^ The third trimester
//A The second trimester
//B The first month of the pregnancy
//C The first trimester
//D The third trimester

//#Q During the last period of the pregnancy, the fetus drops towards the opening of the pelvis and this part of the body changes its shape.
//^ The abdomen
//A The hips
//B The abdomen
//C The breasts
//D The uterus

//#Q The human facial skull consists of double as well as single bones. Which of the following bones is not a facial bone?
//^ Calcaneus
//A Zygomatic bone
//B Calcaneus
//C Vomer bone
//D Mandible

//#Q What is the other name for the Achilles tendon, which acts as a connection between the calf and the heel in humans?
//^ Calcaneal tendon
//A Glenohumeral joint
//B Calcaneal tendon
//C Teres major
//D Chordae tendinae

//#Q When the arm is bent in the elbow joint humans use the biceps branchii musle and the triceps is used when it is extended. What is the name of the muscle that abducts the arm in the shoulder?
//^ Deltoid muscle
//A Teres minor muscle
//B Deltoid muscle
//C Latissimus dorsi muscle
//D Pectoralis major

//#Q What is the function of the thalamus, a part of the human brain with an egg-like shape?
//^ It deals with the various types of sensory information.
//A It deals with the various types of sensory information.
//B It regulates the organisms automatic functions.
//C It helps humans to keep their balance.
//D It is not known.

//#Q The extrapyramidal system in human brain, which consists of related neurons is not responsible for what?
//^ The aural memory
//A Decrease of the erratic motions
//B Muscle tone
//C Stability of the human body
//D The aural memory

//#Q This gland, located in the base of the human skull, is the central gland in the endocrine regulation and is as large as a pea.
//^ The pituitary gland
//A The thyroid gland
//B The thymus
//C The pituitary gland
//D Erbers gland

//#Q What are the main components of the stomach juice, which is secreted by gastric glands?
//^ Hydrochloric acid, enzymes and mucus
//A Enzymes and hydrochloric acid
//B Mucus and hydrochloric acid
//C Hydrochloric acid, enzymes and mucus
//D Enzymes and lymph

//#Q Two large vessels enter the right atrium of the human heart - the superior and inferior vena cava. They carry blood from the whole body and that is why this blood is dark red.
//^ True
//A False
//B True

//#Q The human heart has its own automation but its activity is regulated by the needs of the whole body. The nerves which accelerate the heart rate are called parasympathetic.
//^ False
//A False
//B True

//#Q Pathogenic microorganisms which get into the human body are called antigens because they cause the formation of antibodies. The antibodies are produced by what blood cells?
//^ Lymphocites
//A Keratinocytes
//B Lymphocites
//C Thrombocytes
//D Erythrocytes

//#Q Cryptozoology is a branch of Zoology, which deals with what?
//^ Animals that are considered to exist but there is no proof for their existence
//A The animals in the order Acarina - mites and ticks
//B Marine animals
//C Spiders and arachnids
//D Animals that are considered to exist but there is no proof for their existence

//#Q Which term denotes the classification of organisms, based on their evolutionary descent?
//^ Phylogenetics
//A Ornithology
//B Neuroethology
//C Paleontology
//D Phylogenetics

//#Q This ancient Greek philosopher, who taught Alexander the Great, wrote a book on zoology entitled History of Animals.
//^ Aristotle
//A Aristotle
//B Plato
//C Socrates
//D Democritus

//#Q The term ethology, which refers to the study of animal behaviour, derives from a Greek word, which means what?
//^ Custom
//A Behaviour
//B Custom
//C Life cycle
//D Environment

//#Q What is the literal meaning of the word ecology, which derives from Greek?
//^ study of the household
//A study of life
//B None of these
//C study of the household
//D study of nature

//#Q What is the definition of the biological term ecotone, which in Greek means a place where ecologies are in tension?
//^ A transition area between two adjacent ecological communities
//A A transition area between two adjacent ecological communities
//B A natural unit that consists both of living and nonliving parts, interacting to form a stable system
//C Graphical representation of an ecosystem
//D Separation of groups of organisms as a result of changes in their ecology or in the environment where they live

//#Q What biological term refers to the organs, whose function is considered to have been lost or reduced during evolution?
//^ Vestigial organs
//A Undeveloped organs
//B Obsolete organs
//C Vestigial organs
//D Stunted organs

//#Q What is the definition of ontogeny (morphogenesis), one of the branches of developmental biology?
//^ A study that describes the organism from the embryo to adulthood
//A The study that deals with the relations between predators and their prey
//B A study that describes the organism from the embryo to adulthood
//C The relationships of groups of  organisms as reflected by their evolutionary history
//D The study that deals with the marine mammals

//#Q The formation of toes in salamanders, animals that typically have no such organs, is an example for what?
//^ Atavism
//A Atavism
//B Biometry
//C Disturbance
//D Biota

//#Q This Swedish botanist and physician, considered one of the fathers of modern ecology, initiated the method of binomial classification.
//^ Carolus Linnaeus
//A Alfred Nobel
//B Carolus Linnaeus
//C Nils Gabriel Sefstrom
//D Johan August Arfwedson

//#Q The word physics derives from the Greek - φ�?σις (phusis), which means this.
//^ Nature
//A Nature
//B Earth
//C Matter
//D Force

//#Q Laws of physics are properties, common to all material systems.
//^ True
//A True
//B False

//#Q The culture of physics research differs from the other sciences in the separation of these two.
//^ Theory and experiment
//A Abstract and real
//B Microscopic and macroscopic
//C Theory and experiment
//D Visible and invisible

//#Q One of these major subtopics is not part of classical mechanics.
//^ Kinetic theory
//A Chaos theory
//B Kinetic theory
//C Lagrangian mechanics
//D Fluid dynamics

//#Q Law of Inertia is also referred to as this.
//^ Newtons First Law
//A Newtons First Law
//B Newtons Third Law
//C Fundamental law of dynamics
//D Newtons Second Law

//#Q Plancks constant (h) is equal to this.
//^ 6.626068 × 10^(-34) m^2 kg / s
//A 6.626068 × 10^(-34) m^2 kg / s
//B 1.67262171 x 10^(-27) kg
//C 1.05457168 x 10^(-34) J s
//D 10973731.568 525 m^(-1)

//#Q This is the number of fundamental interactions.
//^ 4
//A 4
//B 2
//C 8
//D 6

//#Q These two additive primary colors should be combined in order to get the color yellow.
//^ Green and red
//A Green and red
//B Blue and green
//C White and red
//D Red and blue

//#Q Which of these most accurately describes the term, Solar System?
//^ The planetary system which our Sun along with the nine planets and other non-stellar objects form
//A A system of non-stellar objects orbiting a star
//B A system comprised of a star or group of stars
//C A system of one or more stars and non-stellar objects, connected in close gravitational association
//D The planetary system which our Sun along with the nine planets and other non-stellar objects form

//#Q Contrary to this celestial bodys true nature, the term asteroid means what according to its greek origins?
//^ Star-like
//A Cone-shaped
//B Planet-like
//C Drifting freely
//D Star-like

//#Q Where can an asteroid belt, a region of greatest concentration of orbiting asteroids, be found nearest to Earth?
//^ Between Mars and Jupiter
//A Between Jupiter and Saturn
//B Between Mars and Jupiter
//C Between Uranus and Neptune
//D Beyond Pluto

//#Q Which of these is a celestial body, which produces the effect known as shooting star?
//^ Meteoroid
//A Meteoroid
//B Asteroid
//C Comet
//D Another planets satellite

//#Q Hypergiants, the largest stars known to scientists, have a mass up to how many times that of the Sun?
//^ 100
//A 30
//B 10
//C 100
//D 2

//#Q Distances in the universe are enormous compared to those we are used to, so scientists use light years for measurement.  Approximately how many miles does a light year represent?
//^ Six trillion miles
//A Six zillion miles
//B Six trillion miles
//C Six million miles
//D Six billion miles

//#Q In astrophysics, which theorem defines what parameters black holes are characterized by?
//^ Black holes have no hair
//A No-ghost theorem
//B Brouwers Fixed point theorem
//C Hairy ball theorem
//D Black holes have no hair

//#Q In astronomy, the term binary star refers to which of these?
//^ A system of two stars both orbiting around their centers of mass
//A A large star which has drawn smaller star to orbit
//B A star made up from both matter and antimatter
//C A system of two stars both orbiting around their centers of mass
//D A star emitting electromagnetic waves at two different frequencies

//#Q What celestial formations are considered to be the birthplaces of stars?
//^ Nebulae
//A Galactic halos
//B Nebulae
//C Spiral galaxies
//D Galaxy cluster clouds

//#Q The discovery of cosmic object 2003 UB313 caused much stir in astronomers circles. Its discoverers declared 2003 UB313 to be what?
//^ The tenth planet in the Solar system
//A The tenth planet in the Solar system
//B A new galaxy
//C A possible black hole near the edge of the Solar system
//D A planetary system with signs of intelligent life

//#Q Which set contains triangular numbers?
//^ 1, 3, 6, 10, 15, 21, 28
//A 1, 10, 100, 1000, 10000, 100000, 1000000
//B 1, 2, 3, 5, 7, 11, 13, 17
//C 1, 4, 9, 16, 25, 36, 49
//D 1, 3, 6, 10, 15, 21, 28

//#Q Which set contains only  prime numbers?
//^ 2, 3, 5, 7,11,13, 17
//A 2, 3, 5, 7,11,13, 17
//B 1, 4, 11, 13, 15, 17
//C 2, 3, 5, 7, 9, 11, 37
//D 1, 3, 5, 7, 9, 11, 13

//#Q Johann Regiomontanus first introduced the plus sign, + , in this year.
//^ 1456
//A 1656
//B 1556
//C 1456
//D 1756

//#Q When was the multiplication sign, x, first used?
//^ 1631
//A 1731
//B 1631
//C 1531
//D 1831

//#Q In 1938, Edward  Kasner wrote a 1  followed by 100 zeros and showed it to his baby nephew.  What the baby said became the name of that written number. What did the kid say?
//^ Googol
//A Giggle
//B Dada
//C Gaga
//D Googol

//#Q What do mathematicians call any rectangular table of numbers?
//^ A matrix
//A A  Latin square
//B A polynomial
//C A matrix
//D A  factorial

//#Q Calculate 6!
//^ 720
//A 36
//B 21
//C 216
//D 720

//#Q To find the acceleration of a particle what would we do to the velocity ?
//^ Differentiate once
//A Differentiate once
//B Integrate twice
//C Differentiate twice
//D Integrate once

//#Q The sides of a triangle are 1 inch, 2 inches and 3 inches. What is the perimeter of the triangle.
//^ It has no perimeter
//A 6 cubic inches
//B It has no perimeter
//C 6 square inches
//D 6 inches

//#Q In a list of numbers what, is the mode?
//^ The number seen most frequently
//A The number seen most frequently
//B The number of items in the list
//C The biggest number minus the smallest number
//D The middle number

//#Q Where is the main Internet computer located?
//^ Nowhere
//A Greenwich, England
//B New York, New York, USA
//C Geneva, Switzerland
//D Nowhere

//#Q On the Internet, who or what is a server?
//^ The computer on which the programs of a web site run
//A The person who serves the hors doeuvres.
//B The computer on which the programs of a web site run
//C The person who serves the customers of an Internet Service Provider
//D The program which controls a web page

//#Q ICQ is a type of what?
//^ An instant messaging computer program
//A ISP
//B Bulletin Board
//C Intelligence
//D An instant messaging computer program

//#Q The pictures on a web page can be stored in more than one physical location.
//^ True
//A False
//B True

//#Q In Internet parlance, what is a cookie?
//^ Something stored on the client computer by a web pages program
//A Something stored on the client computer by a web pages program
//B Something tasty on a web page
//C Something made up(or cooked) on a web page
//D A portion of a program governing a web page

//#Q Web pages can be viewed on which of these devices?
//^ All of these
//A All of these
//B Cell phone
//C PDA
//D Personal Computer

//#Q What does WWW stand for?
//^ World Wide Web
//A Wild Wonderful World
//B World Wide Web
//C Whole World Web
//D World War Web

//#Q Pornography is illegal on the Internet.
//^ False
//A False
//B True

//#Q Internet Explorer, Opera and Mozilla are examples of what?
//^ Web browsers
//A Internet service providers
//B Hypertext transfer protocols
//C Web browsers
//D Search engines

//#Q In the web address http://www.microsoft.com, the com at the end means what?
//^ Commercial
//A Commercial
//B Complicated
//C Communication
//D Compensated

//#Q These particles form light, as you see it.
//^ Photons
//A Electrons
//B Quarks
//C Leptons
//D Photons

//#Q What is the speed of light in free space?
//^ 186,282 miles per second(~300,000 km/s)
//A 155,342 miles per second(~250,000 km/s)
//B 186,282 miles per second(~300,000 km/s)
//C 124,274 miles per second(~200,000 km/s)
//D 93,205 miles per second(~100,000 km/s)

//#Q What is the main purpose of pulleys?
//^ They decrease the force needed to lift something.
//A They are useless
//B They halve the needed force
//C They double the needed force
//D They decrease the force needed to lift something.

//#Q Astronauts age faster.
//^ False
//A True
//B False

//#Q Who came up with the laws of gravity?
//^ Newton
//A Pythagoras
//B Einstein
//C Newton
//D Archimedes

//#Q Referred to as the father of integral calculus, he initiated the sciences of hydrostatics, static mechanics and pycnometry (the measurement of the volume or density of an object). He was killed by a Roman soldier who did not know who he was.
//^ Archimedes
//A Isaac Newton
//B Pythagoras
//C Carl Friedrich Gauss
//D Archimedes

//#Q This device is used for dispersing light, reflecting it or refracting it.
//^ prism
//A sphere
//B monocle
//C prism
//D lens

//#Q He first developed the principle of relativity.
//^ Galileo
//A Michelson-Morley
//B Galileo
//C Einstein
//D H.A.Lorentz

//#Q The National Aeronautics and Space Administration was established on July 29, 1958 under which U.S.  President?
//^ Dwight Eisenhower
//A Dwight Eisenhower
//B Harry Truman
//C John Kennedy
//D Lyndon Johnson

//#Q On May 5, 1961, this man became the first U.S. astronaut in space.
//^ Alan Shepard
//A Buzz Aldrin
//B Neil Armstrong
//C John Glenn
//D Alan Shepard

//#Q In 2001, NASA sent this unmanned spacecraft to orbit Mars in search of signs of water and volcanic activity on the surface.
//^ Mars Odyssey
//A Mars Exploration Rover
//B Mars Reconnaissance Orbiter
//C Mars Pathfinder
//D Mars Odyssey

//#Q On January 19, 2006 NASA launched the unmanned mission New Horizons to explore Pluto, on a one-way trip of how many years?
//^ 9
//A 4
//B 9
//C 15
//D 13

//#Q The Vision for Space Exploration is the U. S. space program was announced on January 14, 2004 by President George W. Bush. According to this program, the moon will be explored by manned missions by what year?
//^ 2020
//A 2010
//B 2011
//C 2020
//D 2025

//#Q The International Space Station is a joint project of five space agencies, including NASA. Which Space Agency is not part of the project?
//^ China National Space Administration
//A Russian Federal Space Agency
//B Canadian Space Agency
//C China National Space Administration
//D Japan Aerospace Exploration Agency

//#Q The mission statement of NASA is to understand and protect our home planet; to explore the Universe and search for life; and to inspire the next generation of explorers.
//^ True
//A False
//B True

//#Q Which is the largest planet in the Solar System?
//^ Jupiter
//A Mars
//B Saturn
//C Venus
//D Jupiter

//#Q Which planet has been described as a sister planet to Earth?
//^ Venus
//A Mercury
//B Saturn
//C Venus
//D Mars

//#Q Which planet has been demoted from its planet status by scientists like Neil Tyson, Director of the Hayden Planetarium?
//^ Pluto
//A Neptune
//B Pluto
//C Uranus
//D Mercury

//#Q Which planet was named after the ancient Romans’ king of the gods?
//^ Jupiter
//A Mars
//B Jupiter
//C Neptune
//D Saturn

//#Q Which planet of the Solar System has been nicknamed The Red Planet?
//^ Mars
//A Mercury
//B Mars
//C Neptune
//D Venus

//#Q Which planet was named after the Roman god of war?
//^ Mars
//A Uranus
//B Mercury
//C Mars
//D Saturn

//#Q Io and Europa are two of the larger satellites of which Solar System planet?
//^ Jupiter
//A Pluto
//B Venus
//C Saturn
//D Jupiter

//#Q Which planet of the Solar System is nicknamed the Blue Planet?
//^ Earth
//A Earth
//B Neptune
//C Venus
//D Saturn

//#Q Which of the following planets is closest to the Sun?
//^ Mercury
//A Venus
//B Mars
//C Mercury
//D Earth

//#Q What is the distinctive feature of the sixth planet of the Solar System (counted from the Sun)?
//^ Its equatorial rings
//A Its gigantic craters
//B Its active volcanoes
//C Its equatorial rings
//D Its silver coloring

//#Q Which of the following Solar System planets are designated as gas planets?
//^ All of these
//A Saturn
//B All of these
//C Neptune
//D Jupiter and Neptune

//#Q Which planet of the Solar System is also known as The Evening Star?
//^ Venus
//A Mars
//B Venus
//C Earth
//D Uranus

//#Q Which of the following Solar System planets was not named after a Greek or Roman God?
//^ Earth
//A Mercury
//B Saturn
//C Uranus
//D Earth

//#Q Which is the largest of the so-called terrestrial planets of the Solar System?
//^ Earth
//A Mars
//B Venus
//C Earth
//D Jupiter

//#Q What does AFK mean in Internet slang?
//^ away from computer keyboard
//A almost french kissed
//B as far as i know
//C all friends are kooks
//D away from computer keyboard

//#Q What does BTDT mean in instant messaging language?
//^ been there, done that
//A but I thought you didnt tell
//B boy thats dirty talk
//C been there, done that
//D better than doing time

//#Q What does HAND mean in instant messaging language?
//^ have a nice day
//A hot always, never dull
//B handsome and nearly divine
//C have a nice day
//D had a neat dream

//#Q What does KIT mean in instant messaging language?
//^ keep in touch
//A kiss it tenderly
//B kook in training
//C keep in touch
//D kitchen

//#Q What does NP mean in instant messaging language?
//^ no problem
//A noogie patrol
//B no parents
//C no problem
//D new puppy

//#Q What does POS mean in instant messaging language?
//^ parent over shoulder
//A please open soon
//B passing off as stupid
//C parent over shoulder
//D pressing on solo(going it alone)

//#Q What does SYS mean when used in instant messaging ?
//^ see you soon
//A still your spouse
//B see your sister
//C system is down
//D see you soon

//#Q What does TIA mean in instant messaging language?
//^ thanks in advance
//A thats it already
//B thanks in advance
//C tony is awesome
//D typist is away

//#Q What does WFM mean when used in instant messaging?
//^ works for me
//A works for me
//B works for money
//C white female methodist
//D with fond memories

//#Q What does ZZZ mean in Internet slang?
//^ tired or bored
//A zz top is great
//B tired or bored
//C zero, zilch, zip
//D theres a bee in my house

//#Q Which time zone encompasses the least number of the continuous 48 United States?
//^ Pacific
//A Pacific
//B Eastern
//C Central
//D Mountain

//#Q Most of the land area of Tennessee is in the Eastern time zone.
//^ False
//A True
//B False

//#Q In which time zone would you find the state of West Virginia?
//^ Eastern
//A Central
//B Pacific
//C Mountain
//D Eastern

//#Q Kansas is entirely in the Central time zone.
//^ False
//A False
//B True

//#Q Idaho is one of many states divided by two different time zones. Which part of the state is in the Pacific time zone?
//^ Northern
//A Southern
//B Western
//C Northern
//D Eastern

//#Q In which time zone(s) is Lake Ontario located?
//^ Eastern
//A Central
//B Eastern
//C Central and Mountain
//D Eastern and Central

//#Q The Four Corners states of Arizona, Utah, New Mexico and Colorado are all in the same time zone.
//^ True
//A False
//B True

//#Q In which time zone(s) would you find the state of Florida?
//^ Eastern and Central
//A Central
//B Central and Mountain
//C Eastern
//D Eastern and Central

//#Q The state of Oregon in entirely in the Pacific time zone.
//^ False
//A False
//B True

//#Q While considered to be part of the Midwest, Ohio is actually in the Eastern time zone.
//^ True
//A False
//B True

//#Q Approximately how many years ago did the formation of the Earth take place?
//^ 4.6 billion years
//A 14.6 billion years
//B 4.6 billion years
//C 46 billion years
//D 4.6 trillion years

//#Q 2007 marked what approximate number of people living on our planet?
//^ 6,600,000,000
//A 60,000,000,000
//B 660,000,000,000
//C 6,600,000,000
//D 6,600,000,000,000

//#Q What continent has the highest human population density on Earth as estimated in 2007?
//^ Asia
//A Europe
//B North America
//C Asia
//D South America

//#Q By 2004, how many people had been outside Earths atmosphere?
//^ About 400
//A About 100
//B About 200
//C About 300
//D About 400

//#Q When was the United Nations founded?
//^ 1945
//A 1947
//B 1948
//C 1945
//D 1946

//#Q Which of these countries joined the United Nations organization in 2006?
//^ Montenegro
//A South Korea
//B Poland
//C None of these
//D Montenegro

//#Q Which of these terms refers to a bone surgeon?
//^ Orthopedist
//A Orthopedist
//B Osteopath
//C Allopath
//D Pediatrician

//#Q This physician has been trained in the diagnosis and management of kidney disease.
//^ Nephrologist
//A Neurologist
//B Nephrologist
//C Urologist
//D Proctologist

//#Q Which type of doctor deals with removing hemorrhoids?
//^ Proctologist
//A Endocrinologist
//B Urologist
//C Vascular surgeon
//D Proctologist

//#Q This kind of doctor is an expert in such diseases as Lupus, Sjogrens Syndrome, and Dermatomyositis.
//^ Rheumatologist
//A Otorrhinolaryngologist
//B Internist
//C Rheumatologist
//D Gastroenterologist

//#Q Which medical specialty largely replaced the old general practice specialty?
//^ Family Practice
//A Internal Medicine
//B General Surgery
//C Obstetrics
//D Family Practice

//#Q Which is the correct version of the joke about these four medical specialists?
//^ A psychiatrist knows nothing and does nothing.An internist knows everything and does nothing.A surgeon knows nothing and does everything.A pathologist knows everything, and does everything--but too late!
//A A psychiatrist knows nothing and does nothing.An internist knows everything and does nothing. A pathologist knows nothing and does everything.A surgeon knows everything, and does everything--but too late!
//B A psychiatrist knows nothing and does nothing. A pathologist knows everything and does nothing.An internist knows nothing and does everything.A surgeon knows everything, and does everything--but too late!
//C A psychiatrist knows nothing and does nothing.  An internist knows everything and does nothing.A surgeon knows nothing and does everything.A pathologist knows everything, and does everything--but too late!
//D A psychiatrist knows nothing and does nothing. A pathologist knows everything and does nothing.A surgeon knows nothing and does everything.An internist knows everything, and does everything--but too late!

//#Q While sitting at home talking with friends, you all of a sudden start slurring your words, and develop an inability to move your right arm and leg. The services of which of the following doctors are you likely to seek first?
//^ Emergency Medicine doctor
//A Neurologist
//B Neurosurgeon
//C Emergency Medicine doctor
//D Psychiatrist

//#Q Which of the following doctors is least likely to ever be on call?
//^ Emergency Physician
//A General Surgeon
//B Anesthesiologist
//C Emergency Physician
//D Family Practitioner

//#Q Which of these doctors is qualified to treat alcohol withdrawal?
//^ All of these
//A Family Practitioner
//B Psychiatrist
//C All of these
//D Internist

//#Q In the United States, which of the following doctors is likely to make the most money?
//^ Radiologist
//A Neurologist
//B Radiologist
//C General Internist
//D Psychiatrist

//#Q What do we call the ratio of a circles circumference to its diameter?
//^ Pi
//A i
//B e
//C Pi
//D log(x)

//#Q What do we call these numbers:  0, 1, 4, 9, 16, 25, 36, 49, etc?
//^ square numbers
//A algebraic numbers
//B cubic numbers
//C square numbers
//D prime numbers

//#Q What do we call the square root of negative one?
//^ i
//A log(x)
//B i
//C e
//D Pi

//#Q What do we call the base for natural logarithms ?
//^ e
//A i
//B e
//C Pi
//D 3^2

//#Q In general, mathematicians consider these three men to have been the greatest mathematicians of all times.
//^ Archimedes, Newton, Gauss
//A Archimedes, Newton, Gauss
//B Newton, Gauss, Einstein
//C Newton, Gauss, Euler
//D Archimedes, Newton, Einstein

//#Q Which of these could be an answer to a math problem involving volume?
//^ 8 cubic inches
//A 8 cubic inches
//B The are all the same
//C 8 inches
//D 8 square inches

//#Q Which great 20th century mathematician died because he refused to eat ?
//^ Kurt Godel
//A Robert Schatten
//B Paul Erdos
//C Kurt Godel
//D Paul Wittenberg

//#Q If you multiplied all the whole numbers together, what would the answer be ?
//^ 0
//A aleph zero
//B infinite
//C infinity
//D 0

//#Q Which of these three sets is the largest: the set of all whole numbers, the set of all even numbers, the set of  all odd numbers?
//^ They are the same size
//A The set of all even numbers
//B The set of all whole numbers
//C They are the same size
//D The set of all odd numbers

//#Q If you flip a fair coin three times what is the probability you will get three heads ?
//^ one out of eight
//A one out of eight
//B one out of six
//C one out of three
//D three out of eight

//#Q Going in a circle counter-clockwise is called left-handed. Why ?
//^ If you turn counter-clockwise your left hand is nearer the center
//A It is the way that hurricane winds blow
//B Newton called it that way so we follow his way
//C It is arbitrary
//D If you turn counter-clockwise your left hand is nearer the center

//#Q Which of the following medications treats depression?
//^ Zoloft (sertraline)
//A Zoloft (sertraline)
//B Augmentin (amoxicillin/clavulanic acid)
//C Benadryl(diphenhydramine)
//D Darvon(propoxyphene)

//#Q Which disease is treated by Synthroid (levothyroxine)?
//^ Hypothyroidism
//A Multiple Sclerosis
//B Congestive Heart Failure
//C Erectile Dysfunction
//D Hypothyroidism

//#Q Ambien (zolpidem) is used to treat which one of the following conditions?
//^ Insomnia
//A Migraine
//B Diabetes
//C Peripheral Neuropathy
//D Insomnia

//#Q Which one of the following medications treats Alzheimers Disease (dementia)?
//^ Aricept(donepezil)
//A Topamax(topiramate)
//B Effexor(venlafaxine)
//C Lanoxin(digoxin)
//D Aricept(donepezil)

//#Q Which of the following disease does Propecia (finasteride) treat?
//^ Hair loss
//A Nicotine addiction
//B Lead poisoning
//C Hair loss
//D Emphysema

//#Q Which of the following medications is for enuresis (bed-wetting)?
//^ DDAVP(Arginine Vasopressin)
//A Senokot(senna)
//B DDAVP(Arginine Vasopressin)
//C Sansert(methysergide)
//D THC(tetrahydrocannabinol)

//#Q Which of the following drugs thins the blood?  (That is, it decreases the ability of the blood to clot.)
//^ Coumadin(warfarin)
//A hydrochlorothiazide
//B Coumadin(warfarin)
//C Lexapro(escitalopram)
//D Biaxin(clarithromycin)

//#Q Valtrex (valacyclovir) treats which one of the following conditions?
//^ Genital herpes
//A Pityriasis alba
//B Genital herpes
//C HPV(genital warts)
//D Syphilis

//#Q Botox (botulinum toxin) is used to treat which one of the following diseases?
//^ Headache
//A Headache
//B Congestive heart failure
//C Pulmonary hypertension
//D Kidney failure

//#Q Which one of the following medications reduces cholesterol?
//^ Lipitor(atorvastatin)
//A erythromycin
//B Lipitor(atorvastatin)
//C Verelan(verapamil)
//D Imitrex(sumatriptan)

//#Q Where is the radial artery located?
//^ Forearm
//A Forearm
//B Abdomen
//C Behind the Knee
//D Neck

//#Q Which of these terms refer to the chambers of the heart -- the two on top and the two on the bottom respectively?
//^ Atria and Ventricles
//A Pericardia and Myocardia
//B Atria and Ventricles
//C Ventricles and Atria
//D Atria and Ventricle, Atria and Ventricle

//#Q All arteries carry oxygenated blood from the heart to the rest of the body.
//^ False
//A False
//B True

//#Q Where is the femoral artery located?
//^ Thigh
//A Thigh
//B Uterus
//C Calf
//D Along the spinal column

//#Q Name the anastomotic loop of vessels near the base of the brain.
//^ Circle of Willis
//A Zygomatic Process
//B Thoracic Circulation
//C Portal Circulation
//D Circle of Willis

//#Q Bones in the wrists are called by what name?
//^ Carpals
//A Tarsals
//B Carpals
//C Phalanges
//D Metatarsals

//#Q Tarsals are located in what part of the body?
//^ Foot or eyelid
//A None of these
//B Foot or eyelid
//C Elbows
//D Hands

//#Q Arterial blood is blue due to oxygenation. Venous blood is bright red and spurts when a person receives a cut.
//^ False
//A False
//B True

//#Q Portal circulation refers to the circulation of blood returning from the body and entering the heart through semilunar portals.
//^ False
//A False
//B True

//#Q Which of the following describes the route of pulmonary circulation?
//^ R.ventricle to R.and L.pulmonary arteries to R L lung
//A L atria to R pulmonary artery to R lung
//B L.ventricle to L pulmonary artery to L lung
//C R ventricle to R pulmonary artery to R lung
//D R. ventricle to R.and L. pulmonary arteries to R  L lung

//#Q How long on average does it take for the suns rays to reach earth?
//^ just over 8 minutes
//A just over 8 hours
//B just over 80 minutes
//C just over 8 seconds
//D just over 8 minutes

//#Q What animal has the broadest visual color spectrum?
//^ Butterfly
//A Elephant
//B American Kestrel Falcon
//C Butterfly
//D Bumblebee

//#Q What place has the maximum amount of sunshine in the US?
//^ Yuma, Arizona
//A Anchorage, Alaska
//B Houston, Texas
//C St Petersburg, Florida
//D Yuma, Arizona

//#Q What is the largest number mentioned in the Bible?
//^ 1,000,000
//A 1,000,000
//B 30,000
//C 400,000
//D 100,000

//#Q Which animal has the longest gestation period?
//^ Black Salamander
//A Polar Bear
//B Black Salamander
//C Dung Beetle
//D Sumatran Rhino

//#Q How often does Halleys comet appear?
//^ Every 76 years
//A Every 100 years
//B Every 30 years
//C Every 25 years
//D Every 76 years

//#Q How much does human hair grow in a year?
//^ 9 inches
//A 9 inches
//B 7 inches
//C 12 inches
//D 4 inches

//#Q Which natural disaster claimed the most lives during the second millennium?
//^ influenza
//A earthquakes
//B influenza
//C tsunami
//D plague

//#Q Right-handed people live longer than left-handed people.
//^ True
//A False
//B True

//#Q Which of the following travels at the speed of light?
//^ All of these
//A All of these
//B Radio rays
//C Gamma rays
//D X rays

//#Q This term is commonly used to refer to a person who becomes overly upset or angry when confronted with an issue.
//^ defensive
//A defensive
//B repressed
//C caustic
//D sublime

//#Q This term refers to a division of the psyche dominated by the pleasure principle.
//^ id
//A id
//B superego
//C libido
//D ego

//#Q This complex is a phase in child development characterized by jealousy and rivalry with the same sex parent.
//^ Oedipal complex
//A Messianic complex
//B Electra complex
//C Castration complex
//D Oedipal complex

//#Q Sublimation means channeling an urge in another direction.
//^ True
//A True
//B False

//#Q This syndrome or disorder occurs after a very traumatic event and has intense symptoms such as reliving the event over and over.
//^ Post Traumatic Stress Disorder
//A Seasonal Affect Syndrome
//B Bi-Polar Disorder
//C Post Traumatic Stress Disorder
//D Attention Deficit Disorder

//#Q Of the four nucleotides that make up Deoxyribo-Nucleic Acid (DNA), which of the following is a purine?
//^ Adenine
//A Adenine
//B Cytosine
//C Proline
//D Thymine

//#Q How many paired DNA chromosomes are there in a human male?
//^ 23
//A 23
//B 18
//C 20
//D 24

//#Q Which of the following models of double-stranded DNA replication proved to be correct?
//^ Semiconservative replication
//A Semiconservative replication
//B Semidispersive replication
//C Conservative replication
//D Dispersive replication

//#Q What is the name for a unit of DNA usually consisting of regulatory regions and a protein-encoding region?
//^ Gene
//A Chromosome
//B Gene
//C Codon
//D Transcript

//#Q Transcription is the process of creating what from the DNA template?
//^ RNA
//A RNA
//B Fatty Acids
//C Protein
//D A Double Helix

//#Q How many nucleotides of DNA does it take to encode a single amino acid in a given protein?
//^ 3
//A 10
//B 3
//C 25
//D 1

//#Q This class of enzyme can cut DNA at a specific place, making biotechnology possible.
//^ Restriction Enzyme
//A Restriction Enzyme
//B Bayton Enzyme
//C Electrophoretic Enzyme
//D Limiting Enzyme

//#Q What is the three-letter acronym for the Nobel-winning process which allows DNA to be amplified?
//^ PCR
//A HCV
//B ATP
//C PCR
//D SRC

//#Q What makes retroviruses such as HIV so unusual with respect to DNA?
//^ They start with RNA and encode DNA, the reverse of what cells do.
//A Their DNA reads 3 to 5, the opposite direction from cellular DNA.
//B They capture the cellular DNA and transfer it to other cells.
//C They have no DNA, but their protein components directly encode for RNA.
//D They start with RNA and encode DNA, the reverse of what cells do.

//#Q When Dr. Craig Venters private company, Celera, declared that they would beat the Human Genome Project in sequencing all human DNA, what did Venter tell Dr. Francis Collins, director of the HGP?
//^ You can do mouse.
//A The private sector always wins.
//B You can do mouse.
//C Just send me all your grant money.
//D Why dont you try something easier?

//#Q The Golgi apparatus found in most eukaryotic cells participates in the sorting and modification of what type of organic compounds?
//^ Proteins
//A Water molecules
//B Carbohydrates
//C Lipids
//D Proteins

//#Q The cell has up to several thousands of these tiny organelles scattered in its cytoplasm. They are often called cellular power plants, because they convert organic materials into energy.
//^ Mitochondria
//A Mitochondria
//B Vacuoles
//C Chloroplasts
//D Ribosomes

//#Q Plastids are major cell organelles found in which of these groups of organisms?
//^ Plants and algae
//A Algae
//B Plants
//C Plants and animals
//D Plants and algae

//#Q The process of photosynthesis is carried out by which of these major cell organelles?
//^ Chloroplasts
//A Mitochondria
//B Ribosomes
//C Chloroplasts
//D Vacuoles

//#Q Which of these is not among the vacuoles functions in the cell?
//^ Production of ATP
//A Exporting unwanted substances
//B Capturing food materials
//C Production of ATP
//D Maintaining the internal pH

//#Q Typical for the animal cells only, lysosomes are organelles built in the Golgi apparatus that contain what type of enzymes?
//^ Digestive enzymes
//A Inhibitors
//B Digestive enzymes
//C Amylase enzymes
//D Restriction enzymes

//#Q Which organelle makes up the cells translational apparatus that translates Messenger RNA (mRNA) into polypeptide chains?
//^ Ribosome
//A Lysosome
//B Mitochondrion
//C Ribosome
//D Golgi apparatus

//#Q Cell nuclei have two primary functions in the cell. The first is to to store genetic information needed for cellular division. What is the second one?
//^ To control chemical reactions
//A To maintain an acidic internal pH
//B To remove unwanted structural debris surrounding the cell
//C To control chemical reactions
//D To maintain internal hydrostatic pressure

//#Q Which of the following organelles is typical for animal cells only?
//^ Melanosome
//A Nucleolus
//B Vacuole
//C Melanosome
//D Golgi apparatus

//#Q Which one of these organelles is a part of the endomembrane system of eukaryotic cells?
//^ Endoplasmic reticulum
//A Chloroplast
//B Mitochondrion
//C Endoplasmic reticulum
//D Nucleus

//#Q It is said that the average person has about six pounds of skin.
//^ True
//A True
//B False

//#Q What kind of cells carry oxygen around your body?
//^ red blood cells
//A fat cells
//B red blood cells
//C oxygen cells
//D blue cells

//#Q Name he glands that produce hormones.
//^ endocrine glands
//A salivary glands
//B sweat glands
//C endocrine glands
//D oil glands

//#Q This term refers to the organs that fill your abdominal cavity and chest.
//^ viscera
//A immune system
//B circulatory system
//C cementum
//D viscera

//#Q What is the biggest artery in the human body?
//^ aorta
//A umbilical
//B pulmonary
//C systemic
//D aorta

//#Q What part of the nervous system regulates involuntary actions such as heartbeat or digestion?
//^ autonomic nervous system
//A central nervous system
//B peripheral nervous system
//C involuntary nervous system
//D autonomic nervous system

//#Q Dental caries, commonly known as a cavity, is one of the most common health disorders, second only to this one.
//^ Cold
//A Cold
//B Mumps
//C Fever
//D Sore throat

//#Q A caries is formed as a result of food debris. Food remnants mix with saliva and bacteria, and result into this mixture that glues to the teeth.
//^ Plaque
//A Starch
//B Dirt
//C Amalgam
//D Plaque

//#Q Plaque and bacteria begin to accumulate approximately this long after eating.
//^ 20 minutes
//A 20 minutes
//B 30 minutes
//C 5 minutes
//D 60 minutes

//#Q This is one of the first symptoms of dental caries.  It is most pronounced when consuming sweet, hot or cold foods and liquids.
//^ Toothache
//A Numbness
//B Bad breath
//C Toothache
//D Saliva overproduction

//#Q Cavities are generally painless. However, if not treated, they enlarge and eventually become painful as they reach the internal structure of the tooth, especially this part.
//^ Dentin
//A Dentin
//B Enamel
//C Calculus
//D Root

//#Q Sugar is a major reason for tooth decay.   Due to the high content of sugar in most carbonated drinks, you can diminish the risk of tooth decay by sipping through a straw.
//^ False
//A True
//B False

//#Q Fruit juices cause about as much harm to your teeth as Colas do.
//^ True
//A True
//B False

//#Q Despite its natural origins, this food is particularly bad for your teeth; it is sticky and contains concentrated fruit sugar.
//^ Dried fruits
//A Puree
//B Chocolate Milk
//C Dried fruits
//D Juice

//#Q This substance is a substitute for sugar that can help prevent tooth decay. It decreases plaque formation and blocks the bacteria from producing the acids that cause cavities.
//^ Xylitol
//A Aspartame
//B NutraSweet
//C Xylitol
//D Dentin

//#Q This substance is naturally present in water. It keeps the enamel strong and can stop or even reverse the process of tooth decay.
//^ Fluoride
//A Nitrite
//B Nitrate
//C Chlorine
//D Fluoride

//#Q You might not be successful at exterminating microbes - they have been around this long.
//^ 3.8 billion years
//A 5 billion years
//B 3.8 billion years
//C 7 billion years
//D 3 billion years

//#Q Bacteria consist of this number of cells.
//^ 1
//A Billions
//B 3
//C 1
//D Millions

//#Q People use a kind of microbe to make this.
//^ Bread
//A Mineral water
//B Bread
//C Orange juice
//D Plastics

//#Q Of all the microbes on Earth, only about this many have been identified.
//^ 5 %
//A 1 %
//B 5 %
//C 2 %
//D 10 %

//#Q Lactic acid bacteria help achieve this.
//^ Keep vegetables fresher
//A Preserve pollen aroma
//B Keep vegetables fresher
//C Prevent milk from turning into yogurt
//D Keep honey diluted in water

//#Q Bacillus Thuringiensis, which is usually found naturally in the soil, is used as this.
//^ Insecticide
//A Beer additive
//B Food additive
//C Insecticide
//D Wine ferment agent

//#Q There are billions of these microscopic creatures in your bed and they feed on this.
//^ Dead skin cells
//A Wood
//B Dead skin cells
//C Cotton fibres
//D Sweat

//#Q This is why Mycobacterium Tuberculosis, the bacteria which causes tuberculosis is called the literary microbe.
//^ Many writers caught tuberculosis
//A There is a lot to read about it
//B It is discussed in many scientific books
//C It is mentioned in many literary works
//D Many writers caught tuberculosis

//#Q There is proof that microbes existed on this planet.
//^ Mars
//A Pluto
//B Mars
//C The Sun
//D Neptune

//#Q Microbes are generally considered to be this.
//^ Both harmless and deadly.
//A Harmless
//B Illness-causing
//C Deadly
//D Both harmless and deadly.

//#Q After Hurricane Katrina, evacuees from Louisiana, Mississippi, and Alabama were granted two months of food stamps and free gasoline from the Texas Department of Health and Human Services.
//^ False
//A False
//B True

//#Q It has been revealed that some debit cards issued to Hurricane Katrina evacuees were used for purchasing luxury or entertainment items.
//^ True
//A True
//B False

//#Q In 2004, a National Geographic article foretold the formation of the flood that devastated New Orleans after Hurricane Katrina.
//^ True
//A False
//B True

//#Q The White House rejected Louisiana governor Kathleen Blancos request to declare an emergency before Hurricane Katrina had struck.
//^ False
//A True
//B False

//#Q After Hurricane Katrina’s strike, reverend Jesse Lee Peterson, a nationally syndicated African American host of a radio talk show, criticized New Orleans African Americans for both blaming the federal government and expecting handouts from it.
//^ True
//A False
//B True

//#Q Former first lady Barbara Bush made the following remark about the New Orleans refugees, housed in the Houston Astrodome: And so many of the people in the arena here, you know, were underprivileged anyway, so this, this is working very well for them.
//^ True
//A False
//B True

//#Q Pat Robertson, the host of the 700 Club TV program, stated that Hurricane Katrina was caused by Gods anger over the selection of lesbian comedienne Ellen Degeneres to host the upcoming Emmy Awards.
//^ False
//A False
//B True

//#Q The disastrous 2005 Atlantic hurricane season broke the 1933 record of 21 named storms.
//^ True
//A False
//B True

//#Q In the 2005 hurricane season, there were 13 hurricanes of the overall number of 27 registered storms, which broke the record of 12, set in 1969.
//^ False
//A False
//B True

//#Q In 2005, Katrina became the strongest hurricane on record in the Atlantic Basin with a pressure of 882 millibars breaking the old record set by Gilbert (888 mb) in 1988.
//^ False
//A False
//B True

//#Q What is a difficult patient in medical jargon?
//^ A patient who upsets the doctor or the office staff in some way
//A A patient who upsets the doctor or the office staff in some way
//B A patient who has a disease which is difficult to treat
//C A patient who is terminal
//D An insane patient

//#Q What is called a capitated plan in the medical fields?
//^ An insurance plan, which pays the doctor a certain amount per month
//A A treatment plan which relates to the patients head.
//B An insurance plan, which pays the doctor a certain amount per month
//C An insurance plan, which only covers up to a certain amount per visit
//D A treatment plan which has a definite endpoint.

//#Q What does the term a positive review of systems refer to?
//^ To every symptom question, the patient says yes
//A To every symptom question, the patient says yes
//B The patient reviews his symptoms well
//C A favorable review of systems
//D To every symptom question, the patient says no

//#Q If the nurse writes NKDA on your chart, what does it mean?
//^ You told the nurse you are not allergic to any medications.
//A Your vital signs are WNL (within normal limits).
//B You told the nurse you are not allergic to any medications.
//C You did not pay your bill.
//D You missed an appointment.

//#Q If the nurse approaches the doctor and says, Doctor, theres a code in the lobby, what is the doctor likely to do?
//^ Tell the nurse to call 911
//A Say thank you and resume what he was doing
//B Go home because the office is closed for the day
//C Pull out his wallet
//D Tell the nurse to call 911

//#Q Choose the correct ordering of these medical jobs abbreviations, in increasing order of salary.
//^ MA, LPN, RN, PA, MD
//A MA, LPN, PA, RN, MD
//B MA, PA, LPN, RN, MD
//C MA, LPN, RN, PA, MD
//D LPN, MD, PA, MA, RN

//#Q In medical practice, what is the purpose of a chaperon?
//^ To protect doctors against lawsuits by patients for inappropriate sexual advances
//A To distract the patient when the doctor is performing a painful procedure
//B To keep male and female patients apart
//C To keep male and female employees from behaving inappropriately in the office
//D To protect doctors against lawsuits by patients for inappropriate sexual advances

//#Q Which of the following abbreviations pertains to a diagnosis?
//^ ICD-9 Code
//A EM Code
//B CPT Code
//C ICD-9 Code
//D G-code

//#Q In medical jargon, what is a Well Woman Exam?
//^ A routine gynaecologic exam
//A A full physical examination on a female adult who has no medical problems
//B An exam on the doctor by a female who is well
//C An exam on a female which finds herself to be well
//D A routine gynaecologic exam

//#Q Why do two patients sometimes have appointments with the same doctor at the same time?
//^ Because of no-shows
//A Because the doctors time is more valuable than the patients time
//B Usually due to a scheduling error
//C Because of no-shows
//D To make the patients angry

//#Q Which sitcom aired on ABC from 1952 to 1966 after a ten-year run on radio?
//^ Ozzie and Harriet
//A Friends
//B The Simpsons
//C Frasier
//D Ozzie and Harriet

//#Q Which of the following comedies has been on TV the most number of years?
//^ The Simpsons
//A The Simpsons
//B Seinfeld
//C Ozzie and Harriet
//D M* A*S* H

//#Q This is considered the first  American sitcom with a gay character.
//^ The Corner Bar
//A The Nancy Walker Show
//B Soap
//C Barney Miller
//D The Corner Bar

//#Q In what year was the word bastard first used on TV?
//^ 1974
//A 1964
//B 1974
//C 1960
//D 1984

//#Q Which show was the first to have an episode which dealt with abortion?
//^ Maude
//A Room 222
//B All in the Family
//C Good Times
//D Maude

//#Q In which country was the term television coined?
//^ France
//A Canada
//B The USA
//C The United Kingdom
//D France

//#Q What year marked the first broadcast of a baseball game?
//^ 1939
//A 1949
//B 1939
//C 1946
//D 1929

//#Q Who was the first US President to address the nation on TV?
//^ Truman
//A Hoover
//B Truman
//C Eisenhower
//D FDR

//#Q The first scheduled TV  broadcasts, which began in 1928, originated in which US state?
//^ New Jersey
//A California
//B New Jersey
//C New York
//D Massachusetts

//#Q Which company paid for the first TV ad?
//^ Bulova (watches)
//A Dawn (dishwashing detergent)
//B Bulova (watches)
//C Colgate (toothpaste)
//D Tide (laundry detergent)

//#Q Which was the first soap opera broadcast on an American television network?
//^ Faraway Hill
//A Faraway Hill
//B Halls of Ivy
//C Love of Life
//D Love of Ivy

//#Q Which of these television networks came first?
//^ NBC
//A NBC
//B CBS
//C ABC
//D Fox

//#Q Which of the following was the first womens advocacy show?
//^ Leave It To The Girls
//A Leave It To The Girls
//B The Ladies Hour
//C The Ladies Home Journal Hour
//D Girl Talk

//#Q Which game show was hit by a scandal in 1958?
//^ Twenty-One
//A Twenty-One
//B Jeopardy
//C The $64,000 Challenge
//D The $64,000 Question

//#Q This popular police show, which ran from 1951 to 1959, is famous for its very quick paced and to the point dialogue. It starred Jack Webb as police detective Joe Friday, badge#714.
//^ Dragnet
//A Dragnet
//B Los Angeles Precinct
//C The Streets of San Francisco
//D Men on the Streets

//#Q What was the occupation of TV personality Harry Volkman?
//^ TV weatherman
//A TV weatherman
//B TV variety show host
//C TV news caster
//D TV game show host

//#Q Containers used for disposing of needles and other sharp objects must be all of the following except which one?
//^ Recyclable
//A Disposable
//B Clearly Marked bio-hazard
//C Puncture resistant
//D Recyclable

//#Q For which of the following tubes is the blood to additive ratio most critical?
//^ Light Blue stopper
//A Lavender Stopper
//B Light Blue stopper
//C Green Stopper
//D Red Stopper

//#Q Which type of patient is most likely to have an AV fistula or graft?
//^ Dialysis
//A Arthritic
//B Wheelchair-bound
//C Hospice
//D Dialysis

//#Q Which of the following is NOT needed for skin puncture?
//^ povidone-iodine pad
//A Lancet
//B povidone-iodine pad
//C Micro-collection device
//D Gauze pad

//#Q When performing a routine blood draw, the basilic vein is the best choice.
//^ False
//A True
//B False

//#Q The Antecubital Fossa is the major vein in the arm for intended vein puncture.
//^ False
//A True
//B False

//#Q In what type of tube is blood drawn for a substance abuse test?
//^ Red
//A Light blue
//B Dark Green
//C Small Lavender
//D Red

//#Q What vein is usually the first choice when selecting a site for venipuncture?
//^ Median Cubital
//A Median Cubital
//B Accessory Cephalic
//C Cephalic
//D Basilic

//#Q Which part of a cell contains the chromosomes or genetic material?
//^ Nucleus
//A Endoplasmic Reticulum
//B Cytoplasm
//C Golgi Apparatus
//D Nucleus

//#Q How many bones is an adults human skeletal system made up of?
//^ 206
//A 132
//B 318
//C 206
//D 354

//#Q What marrow produces blood cells in the human body?
//^ Red marrow
//A Blue marrow
//B Yellow marrow
//C Green marrow
//D Red marrow

//#Q In some animals life cycle there are several stages of development involving abrupt bodily changes. What is this biological process called?
//^ Metamorphosis
//A Birth
//B Adolescence
//C Growth
//D Metamorphosis

//#Q What do you call the transfer of pollen grains from the anther to the stigma of flowers?
//^ Pollination
//A Reproduction
//B Fertilization
//C Pollination
//D Migration

//#Q What is the smallest basic particle of matter?
//^ Atom
//A Atom
//B Mass
//C Volume
//D Molecule

//#Q What do you call the force which slows down and stops a moving object?
//^ Friction
//A Friction
//B Gravitational force
//C Magnetic force
//D Molecular force

//#Q The Baroque period of architecture is characterized by vivid colours, luxurious materials and elaborate surface textures. Which of these buildings is an example of typical Baroque architecture?
//^ St Peter’s Basilica
//A The Royal Scottish Academy
//B St Peter’s Basilica
//C Solitude Palace
//D Lincoln Memorial

//#Q When a client complained that the roof in his building leaks, this famous architect who had designed the building replied: ‘That’s how you can tell it’s a roof’.  Another work of his was the Guggenheim Museum in New York.
//^ Frank Lloyd Wright
//A Aldo Rossi
//B Frank Lloyd Wright
//C Michael Graves
//D Frank Owen Gehry

//#Q This annually awarded architecture prize is usually referred to as ‘The Nobel Prize for Architecture’.
//^ Pritzker Architecture Prize
//A Thomas Jefferson Medal
//B Aga Khan Award
//C Pritzker Architecture Prize
//D Stirling Prize

//#Q This architecture style is characterized by the use of materials such as stainless steel and aluminium. It aimed at nontraditional elegance that symbolizes wealth and sophistication.  It originated in Europe in 1920s and formed its name in 1925 at the World’s Fair, held in Paris.
//^ Art Deco
//A Archigram
//B Rococo
//C Art Deco
//D Baroque

//#Q Sharply pointed spires, stained glass and pointed arches are typical for this architecture style. It is mainly associated with cathedrals and other religious buildings.
//^ Gothic
//A Rococo
//B Gothic
//C Neo-Grec
//D Art Nouveau

//#Q This Spanish architect designed La Sagrada Familia, one of the most famous buildings in Barcelona.
//^ Antonio Gaudi
//A Carlo Scarpa
//B Mario Botta
//C Alvar Aalto
//D Antonio Gaudi

//#Q There are seven tall buildings in Moscow, regarded as typical examples of Stalinist Architecture. What are these similarly designed buildings referred to?
//^ ‘Stalin’s Seven Sisters’
//A ‘Stalin’s Seven Wonders’
//B ‘Stalin’s Seven Giants’
//C ‘Stalin’s Seven Brothers’
//D ‘Stalin’s Seven Sisters’

//#Q The groundbreaking design of this building was created by Danish architect, Jorn Utzon. It is located by the sea, and its roof resembles white sails.
//^ Sydney Opera House
//A Metropolitan Opera
//B Carnegie Hall
//C La Scala
//D Sydney Opera House

//#Q The construction of this famous building was completed on November 1st, 1800. It was designed by Irish-born architect James Hoban, who was inspired by the Leinster House in Dublin.
//^ The White House
//A Williams Tower
//B Federal Hall
//C The White House
//D The Chrysler Building

//#Q This architectural term, which refers to a free-standing bell-tower, comes from Italian and means a high bell tower.
//^ Campanile
//A Campanile
//B Cellula
//C Mensole
//D Triforium

//#Q In The Wizard of Oz movie, Scarecrow states which very important mathematical theorem?
//^ The Law of Pythagoras
//A Euclids Fifth Postulate
//B The Law of Pythagoras
//C Eulers Theorem
//D Newtons Axiom

//#Q In this movie Ayla, played by Daryl Hannah, teaches her new family to count all the way to ten.
//^ The Clan of the Cave Bear
//A The Clan of the Cave Bear
//B Caveman and Cavewoman
//C Way of the Caveman
//D Land of the Tribe

//#Q In which movie does Edward James Olmos play a teacher in Los Angeles who gets an entire class of low-income, Hispanic students to pass the Advanced Placement Calculus test?
//^ Stand and Deliver
//A Stand and Deliver
//B Proof
//C Stand By Me
//D Pi

//#Q Proof was originally a play about a brilliant mathematician who worries about inheriting her fathers insanity. Which actress was the star of the 2005 movie of the same name?
//^ Gwyneth Platrow
//A Gwyneth Platrow
//B Kate Blanchett
//C Claire Danes
//D Kirsten Dunst

//#Q In this fine movie Dustin Hoffman plays a mathematician who gets tired of being picked on.
//^ Straw Dogs
//A Straw Dogs
//B Sunday Father
//C The Point
//D Sphere

//#Q In which movie does Bud Abbott “prove to Lou Costello that 13 x 7 = 28?
//^ In the Navy
//A Splinters in the Navy
//B Youre in the Navy
//C Francis in the Navy
//D In the Navy

//#Q Which of these is a movie about a mathematician who develops a formula that predicts the prices of stock markets?
//^ The Bank
//A The Bank
//B The Puzzle
//C The Formula
//D The Tricks

//#Q What 1997 movie featured Cartesian co-ordinates (the usual type of graph paper) and factoring numbers?
//^ Cube
//A Cube
//B The Sphere
//C Gleaming the Cube
//D Proof

//#Q In this film, high school student Max Fisher, played by Jason Schwartzman, is asked to use calculus to find the area of an ellipse.
//^ Rushmore
//A Mr.Novak
//B Room 222
//C Rushmore
//D The High School

//#Q In the movie “Little Big League, the hero must solve this problem: John can finish a job in five hours. Mary can finish the same job in three hours. If they work together, how long will it take to finish the job? What is the answer?
//^ 1 and 7/8 hours
//A 1 and 7/8 hours
//B 4 hours
//C 1 and 1/4 hours
//D 2 hours

//#Q Lightning is caused by the increased imbalance of positive and negative charges during storms.
//^ True
//A True
//B False

//#Q A flash of lightning can heat the air around it, which gives off vibrations and expansion of the air thus causing what?
//^ Thunder
//A Thunder
//B Tornadoes
//C Hail
//D Finger lightning

//#Q A lightning bolt can produce what voltage?
//^ 1 billion volts
//A 4 million volts
//B 400 million volts
//C 1 million volts
//D 1 billion volts

//#Q What does the term bolts from the blue mean?
//^ Horizontal lightning that seems to come from no where
//A Horizontal lightning that seems to come from no where
//B Lighting strikes on a clear day
//C Blue vertical lightning bolts
//D Lightning over an ocean

//#Q According to the U.S. National Weather Service, after you see and hear the last flash of lightning and roar of thunder, you should wait how long before presuming outdoor activities?
//^ 30 minutes
//A 1 hour
//B 2 hours
//C 30 minutes
//D 10 minutes

//#Q What did early Greeks believe lightning was?
//^ The weapon of Zeus
//A The weapon of Zeus
//B A warning from Minerva
//C The sign of death
//D A symbol of good fortune

//#Q Which of Santa Klaus reindeers’ name means lightning?
//^ Blitzen
//A Dasher
//B Prancer
//C Blitzen
//D Donner

//#Q Between 1997 and 2006, there were how many reported deaths from lightning?
//^ 437
//A 393
//B 437
//C 750
//D 825

//#Q Which statement concerning whales is true?
//^ Some whales have one blow hole and some have two.
//A All whales have two blow holes.
//B Some whales have one blow hole and some have two.
//C Every whale has exactly one blow hole.
//D Only some whales have blow holes.

//#Q Which of these statements is true?
//^ Humans and elephants are the only mammals that cry.
//A Humans are the only mammals that cry.
//B All land mammals cry.
//C Humans and elephants are the only mammals that cry.
//D All mammals cry.

//#Q What is the meaning of plasmodium?
//^ The parasite that causes malaria
//A The parasite that causes malaria
//B The part of the blood that covers red and white blood cells and platelets
//C The liquid-like substance found in animal and plant cells
//D The gel-like substance that holds fish eggs together

//#Q Quickly calculate 95^2 (i.e. 95X95). What is the result?
//^ 9025
//A 810025
//B 8125
//C 9025
//D 987,654,321

//#Q What molecule has the formula O3?
//^ Ozone
//A Ozone
//B Tritium
//C Deuterium
//D Peroxide

//#Q All dogs are of the same species.
//^ True
//A False
//B True

//#Q Upon what does the loudness of a sound depend?
//^ The amplitude of the wave
//A The pitch of the sound
//B None of these
//C The frequency of the wave
//D The amplitude of the wave

//#Q Which of these is hottest?
//^ a lightning bolt
//A the surface of the sun
//B a lightning bolt
//C the laser used in eye surgery
//D a microwave oven

//#Q All telephones in the USA were shut down on August 2, 1922. Why?
//^ It was the day when Alexander Graham Bell died.
//A The International Brotherhod of Communications Workers went on strike.
//B The electrical workers in New York, Chicago, and Washington went on strike.
//C It was the day when Alexander Graham Bell died.
//D It was the day  for the Orson Welles War of the Worlds radio telecast.

//#Q In 1989, a Mastiff was recognized by the Guinness Book of World Records as the heaviest dog in the world. What was the weight of the dog?
//^ 343 pounds
//A 182 kilograms
//B 173 pounds
//C 298 pounds
//D 343 pounds

//#Q Which of these events occurred in 1589?
//^ Sir John Harington invented the modern flush toilet.
//A Sir Thomas Crapper invented the modern flush toilet.
//B Zacharias Hanssen invented the modern flush toilet.
//C Sir John Harington invented the modern flush toilet.
//D Otto von Guericke invented the modern flush toilet.

//#Q Which of these animals makes the loudest noise?
//^ The humpback whale
//A The humpback whale
//B The Andean condor
//C The whale shark
//D The howling monkey

//#Q Who invented the water thermometer?
//^ Galileo
//A Galileo
//B Fahrenheit
//C Celsius
//D Santorio Santorio

//#Q In which city was Albert Einstein born ?
//^ Ulm
//A Ulm
//B Berlin
//C Bonn
//D Munich

//#Q Einsteins father owned a company that made small magnetos, which he was later forced to sell to this, much larger corporation.
//^ Siemens
//A Bavarian Electrical Supplies , GmbH
//B Siemens
//C Krups
//D BMW

//#Q During WWII, Einstein was paid $25 per day for his consultation on the Manhattan Project.
//^ True
//A False
//B True

//#Q On Friday evenings it was the custom of Jewish families to invite college students over for a home cooked meal. One of the students the Einsteins often ate with introduced Albert to science.  What was his name ?
//^ Max Talmud
//A Max Born
//B Max Malamud
//C Max Silberstein
//D Max Talmud

//#Q In which year was Albert Einstein born?
//^ 1879
//A 1869
//B 1899
//C 1889
//D 1879

//#Q During this year, Einstein had three incredible papers published in the physics journals, and obtained his doctoral degree.
//^ 1905
//A 1905
//B 1912
//C 1907
//D 1929

//#Q In which US city did Einstein live out his last years?
//^ Princeton, New Jersey
//A Cambridge, Massachusetts
//B New Haven, Connecticut
//C Boca Raton, Florida
//D Princeton, New Jersey

//#Q Which type of car did Einstein own while in the USA ?
//^ None
//A Buick
//B Packard
//C Ford
//D None

//#Q What important thing did Einstein do on August 2nd, 1939?
//^ He wrote a letter
//A He proved the Theory of Special Relativity
//B He found the speed of light
//C He wrote a letter
//D He proved E = mc ^ 2

//#Q In 1948 Albert Einstein was offered this new job.
//^ President of Israel
//A Head of the Institute for Advanced Study
//B President of Israel
//C Head Dean of  Princeton University
//D Chief of the Atomic Energy Commission

//#Q In what year did Einstein pass away?
//^ 1955
//A 1960
//B 1955
//C 1954
//D 1956

//#Q Lifting incredibly slowly builds incredibly big muscles. Lifting super slowly produces superlong workouts.
//^ False
//A True
//B False

//#Q If you eat more protein, youll build more muscle.
//^ Somewhat True
//A True
//B No Way
//C Somewhat True
//D False

//#Q Leg extensions are safer for your knees than squats.
//^ False
//A False
//B True

//#Q Sore muscles should be excercised...
//^ Only youre not sore to the touch
//A Never as it might damage the muscle
//B It depends which muscle it is
//C Always as it helps heal the soreness
//D Only youre not sore to the touch

//#Q The fact that stretching prevents injuries is a myth.
//^ True
//A False
//B True

//#Q You need a Swiss ball to build a stronger chest and shoulders.
//^ False
//A True
//B False

//#Q It is better to work out with free weights.
//^ True
//A True
//B False

//#Q Which of the following foods is poorest in carbohydrates?
//^ Pork
//A Cheese
//B Potatoes
//C Pork
//D Milk

//#Q Which of these meals would be most suitable for a low carb diet?
//^ An apple with cottage cheese
//A An apple with cottage cheese
//B Soya sauce
//C A ham sandwich
//D Meat and potatoes

//#Q Trans-fats are definitely unwholesome. Which of these foods is poorest in trans fatty acids?
//^ sunflower oil
//A margarine
//B vegetable shortenings
//C sunflower oil
//D cookies

//#Q What is the building block of green plants that cant be broken down into sugar molecules and passes through the human body undigested?
//^ dietary fiber
//A dietary fiber
//B glucose
//C dextrose
//D fructose

//#Q Which of the following fats contain trans-fats?
//^ Partially hydrogenated fats
//A All types of animal fats
//B Partially hydrogenated fats
//C None of these
//D Non-hydrogenated fats

//#Q Which of these types of fat raises both LDL(bad cholesterol) and HDL(good cholesterol)?
//^ Saturated
//A Saturated
//B Trans
//C Monounsaturated
//D Polyunsaturated

//#Q Which of these is especially rich in omega-3 and omega-6 fatty acids?
//^ Flax seed
//A Brown sugar
//B Chicken
//C Flax seed
//D Wheat gran

//#Q Health specialists still argue about the maximum daily salt intake. But it is for sure that if you overdose on salt, it may affect your health negatively. What is likely to happen if you add too much salt in your diet?
//^ All of these
//A All of these
//B It can cause neurological problems
//C It may bring you high blood pressure
//D It can lead to electrolyte disturbance

//#Q Cod liver oil is often used in many diets and healthy regimes, as a powerful source of omega-3, vitamin A and D. Some medical specialists believe that in the summer months cod liver oil should not be taken, for what reason?
//^ Because cod liver oil contains vitamin D, and the sun also creates vitamin D.If vitamin D is overdosed, your face may become spotty
//A Because Vitamin D becomes toxic when heated
//B None of these
//C Because the pills melt in hot weather and it is easy to overdose
//D Because cod liver oil contains vitamin D, and the sun also creates vitamin D.If vitamin D is overdosed, your face may become spotty

//#Q Which of these people would be able to successfully combine their regimes with a low carb diet without having to violate one of them?
//^ A vegetarian
//A All of these
//B A vegetarian
//C A vegan
//D A fruitarian

//#Q This unit,  named after one of the main discoverers of electromagnetism, is the base unit of electrical current.
//^ Ampere
//A OHM
//B Frequency
//C Ampere
//D Capacitor

//#Q Which term refers to the number of complete cycles of an alternating current that occur per second?
//^ Frequency
//A Watt
//B Frequency
//C Wavelength
//D Ohm

//#Q Which term refers to the efficiency of an electric machine, measured in watt hours or kilowatt hours?
//^ Energy Efficiency
//A OHM
//B Frequency Efficiency
//C Farad
//D Energy Efficiency

//#Q This unit, named after the German physicist who discovered the relation between voltage and current, is the basic unit of electrical resistance.
//^ Ohm
//A Watt
//B Frequency
//C Ohm
//D Resistor

//#Q An insulator is a thin metal strip mounted in a holder. When too much current passes through  it, the metal strip melts and opens the circuit.
//^ False
//A False
//B True

//#Q What is the unit of power that shows how fast a circuit uses electrical energy?
//^ Watt
//A Watt
//B Frequency
//C Voltage
//D Amp

//#Q Moonbounce is a form of wireless communication in which the moon is used as a passive satellite.
//^ True
//A True
//B False

//#Q What is the basic unit of electric pressure, also known as emf?
//^ Volt
//A Current
//B Amp
//C Volt
//D Watt

//#Q This term refers to the distance between repeating units of a wave pattern and is commonly designated by the Greek letter lambda (λ).
//^ Wavelength
//A Amp
//B Wave distance
//C Volt
//D Wavelength

//#Q Lower frequencies have longer wavelengths, while higher frequencies have shorter wavelengths.
//^ True
//A True
//B False

//#Q How much blood does the average adult human have?
//^ 10-12 pints (5-6 liters)
//A 10-12 pints(5-6 liters)
//B 10-12 gallons(38-45 liters)
//C 10-12 quarts(10-11 liters)
//D 4-8 pounds(2-4 kg)

//#Q What substance is added to blood to keep it from clotting until it is needed?
//^ Salt
//A Sugar
//B Ethanol
//C Mecurium
//D Salt

//#Q The members of which profession used to be called leechers” because of the methods they used in the past?
//^ Doctors
//A Pharmacists
//B Doctors
//C Dentists
//D Lawyers

//#Q Barbers traditionally have red and white poles in front of their stores because in the Middle Ages they did the blood letting.
//^ True
//A True
//B False

//#Q Approximately what percentage of humans have blood of the type Rh +?
//^ 85 %
//A 33 %
//B 35 %
//C 85 %
//D 74 %

//#Q What percentage of humans have type O blood?
//^ 45 %
//A 33 %
//B 25%
//C There is no way to tell.
//D 45 %

//#Q Which blood type is called the universal recipient?
//^ AB
//A AB
//B O
//C A
//D B

//#Q Which fictional character had T-Negative blood type?
//^ Mr.Spock
//A King Billy Haraah
//B The Scorpion King
//C Mr.Spock
//D Dr.Who

//#Q Which type of blood cells can be stored the longest?
//^ Erythrocytes (red blood cells)
//A Platelets
//B Blood plasma
//C Erythrocytes(red blood cells)
//D Leukocytes(white blood cells)

//#Q Healthy people over 17 can donate what part of their blood every two weeks?
//^ Platelets
//A Platelets
//B White blood cells
//C Blood serum
//D Red blood cells

//#Q Who was the first physician to demonstrate that arteries carry blood throughout the body?
//^ Galen
//A Galen
//B Valen
//C Valecious
//D Herodotus

//#Q Which of these people is the Austrian biologist and physician who first identified the four basic blood types?
//^ Karl Landsteiner
//A Karl Landsteiner
//B Felix Bernstein
//C William Osler
//D Charles Richard Drew

//#Q In 1658 he became the first person to describe and observe red blood cells (erythrocytes).
//^ Jan Swammerdan
//A William Osler
//B Jan Swammerdan
//C Marcello Malpighi
//D Felix Bernstein

//#Q In 1924 who was the German mathematician who developed a proof showing that blood types were genetic?
//^ Felix Bernstein
//A Franklin McLean
//B Charles R.Drew
//C Felix Bernstein
//D William Osler

//#Q This person developed the first system to produce donatable blood plasma and was the first director of a Red Cross Blood Bank in the USA.
//^ Charles Richard Drew
//A William Osler
//B Felix Bernstein
//C Charles Richard Drew
//D Franklin McLean.

//#Q Which of these statements about Petroleum, sometimes called ‘black gold’, is not true?
//^ It is a renewable resource.
//A It is used for the production of solvents, fertilizers and plastics.
//B It is found in formations in he Earth.
//C It is a fossil fuel.
//D It is a renewable resource.

//#Q In 1863 this entrepreneur and his partners founded Standard Oil, a company which dominated oil production in the USA for decades.
//^ John Rockefeller
//A Howard Hughes
//B John Rockefeller
//C Jean Paul Getty
//D Andrew Carnegie

//#Q In 1991, one of the most serious oil spills in history brought considerable damage to wildlife in the Middle East region. What caused the oil spill?
//^ Iraqi forces deliberately released crude oil from several tankers
//A Iraqi forces deliberately released crude oil from several tankers
//B Tanker Exxon Valdez hit an undersea reef
//C Nowruz Field platform spilled 80 million gallons of oil
//D Ixtoc I oil well suffered a blowout

//#Q The Organization of the Petroleum Exporting Countries (OPEC) is an intergovernmental organization founded at the Baghdad Conference in September 1960, by 5 countries. Which of these countries was not a founding member of the organization?
//^ Algeria
//A Algeria
//B Iraq
//C Venezuela
//D Iran

//#Q This American oil driller, dug the first modern oil well near Titusville, Pennsylvania in 1859.
//^ Edwin Drake
//A Robert Kerr
//B Frank Phillips
//C Edwin Drake
//D Edward Doheny

//#Q This oil field, located south of Beaumont, Texas, and discovered by Anthony Francis Lucas, was the first major oil field in the USA.
//^ Spindletop Oil Field
//A Thunder Horse Field
//B Wilmington Oil Field
//C Spindletop Oil Field
//D Elk Hills Field

//#Q The term ‘petrodollar’, a dollar earned by a country through the sale of oil, was invented in 1973 by this Egyptian-born American professor and economist.
//^ Ibrahim Oweiss
//A Ibrahim Oweiss
//B M.King Hubert
//C Ronald R.Cooke
//D Matthew R. Simmons

//#Q This industrial facility, sometimes called a ‘tank farm’ or a ‘terminal’, is used for the storage of oil.
//^ Oil depot
//A Oil gusher
//B Oil depot
//C Oil barrel
//D Oil well

//#Q The first oil refinery in the world, bombarded in 1943 by US Air Force in operation Tidal Wave, was built in this country in 1856.
//^ Romania
//A Germany
//B Romania
//C Iran
//D Italy

//#Q The Arab-Israeli War in 1973, known as Yom Kippur War, triggered the ‘1973 oil crisis’. What action did the Arab members of OPEC undertake as part of their strategy?
//^ All of these
//A They raised the price of oil
//B They proclaimed an embargo on oil exports to the Netherlands
//C All of these
//D They proclaimed an embargo on oil exports to the United States

//#Q This is the study of winds.
//^ anemology
//A conilogy
//B lithology
//C campanology
//D anemology

//#Q Which term refers to the study of atmospheric dust and its effect on life on Earth?
//^ coniology
//A lithology
//B coniology
//C tricology
//D vexillogy

//#Q What is contrology?
//^ Pilates
//A Pilates
//B the study of freshwater life
//C the study of social controls
//D the study of dates

//#Q What is the study of whales called?
//^ cetology
//A cetology
//B mycology
//C dendrology
//D balinology

//#Q What does dactylology study?
//^ fingerprints
//A rocks
//B the moon
//C fingerprints
//D caves

//#Q What does actinology study?
//^ The study of the effect of light on chemicals
//A fruits and seeds
//B clouds
//C ants
//D The study of the effect of light on chemicals

//#Q What do we call the study of male health and male diseases?
//^ andrology
//A ophiology
//B andrology
//C oology
//D Testrology

//#Q Which word refers to the study of bones?
//^ osteology
//A otology
//B osteology
//C endocrinology
//D neropathp

//#Q Which word means the study of dogs?
//^ cynology
//A cynology
//B onerology
//C carnaology
//D tocology

//#Q What does psephology study?
//^ elections
//A African snakes
//B dreams
//C elections
//D poetry

//#Q What does ludology study?
//^ video games
//A video games
//B postcards
//C wine
//D the moon

//#Q Which statement is incorrect?
//^ Gerontology studies grammar and syntax.
//A Boxology studies schematic layouts and diagrams.
//B Apiology studies bees.
//C Gerontology studies grammar and syntax.
//D Potamology studies rivers.

//#Q English physicist, mathematician, and astronomer Sir Isaac Newton presented his findings on the universal law of gravity in his work commonly referred to as Principia Mathematica, which was published in what year?
//^ 1687
//A 1535
//B 1720
//C 1687
//D 1477

//#Q According to gravity laws, if a bowling ball and a feather are dropped simultaneously from the same height the bowling ball will hit the ground first because it has greater inertia. (In this case we ignore the effects of air resistance.)
//^ False
//A False
//B True

//#Q The gravitational force on the surface of the Sun is greater than the gravitational force on Earths surface. If you weigh 180 lbs or 80 kg on Earth, what would your weight be on the Sun?
//^ 5022 lbs (2270 kg)
//A 440 lbs(200 kg)
//B 1100 lbs(500 kg)
//C 5022 lbs(2270 kg)
//D 2770 lbs(1260 kg)

//#Q Free-fall is defined as a condition in which a falling object experiences acceleration due only to gravity. Therefore, in this case, the only weight acting on an object is its own weight. Which of the following is not an example of an object in free-fall?
//^ A skydiver with an open parachute
//A A skydiver with an open parachute
//B A feather falling through a vacuum tube
//C The Earths orbit around the Sun
//D A space shuttle with the rockets off

//#Q Although gravity has been a subject of much research and scientific work, the actual cause of gravitational forces remains unknown.
//^ True
//A False
//B True

//#Q Although Newtons and Einsteins theories are generally widely accepted and used in many fields of science, there are some researchers who have developed alternative theories of gravity. Which of the following is one of these theories?
//^ Brans-Dicke Theory
//A Special Relativity Theory
//B Electromagnetic Theory
//C Quantum Field Theory
//D Brans-Dicke Theory

//#Q An object in free fall towards the Earth experiences acceleration in velocity due to gravity. This acceleration has what approximate value?
//^ 9.8 meters per a second squared(32 feet per a second squared)
//A 8.1 meters per a second squared(26.6 feet per a second squared)
//B 9.8 meters per a second squared(32 feet per a second squared)
//C 32 meters per a second squared(9.8 meters per a second squared)
//D 26.6 meters per a second squared(8.1 feet per a second squared)

//#Q If we measure the acceleration due to gravity at the top of Mount Everest, it will be less than the acceleration at sea level.
//^ True
//A True
//B False

//#Q Artificial gravity is a simulation of gravity in outer space. There are several means by which artificial gravity can be created. Which of the following is not one of them?
//^ Field generators
//A Magnetism
//B Rotation
//C Acceleration
//D Field generators

//#Q If 2 people are eating the same number of calories per day, the one who eats frequent small meals will lose more weight than the one who eats one large meal per day.
//^ True
//A True
//B False

//#Q A diet high in sugar and starch has more energy, so people who eat such a diet do not get as hungry as people who eat a diet low in sugar and starch.
//^ False
//A True
//B False

//#Q Running a mile burns approximately 100 calories (100 Kcal).
//^ True
//A True
//B False

//#Q How many calories (kcal) is equivalent to one pound?
//^ 3500
//A 1000
//B 2500
//C 2000
//D 3500

//#Q What is the ideal body weight for a six-foot-tall man with average bone structure?
//^ 178 pounds
//A 220 pounds
//B 178 pounds
//C 200 pounds
//D 195 pounds

//#Q What is the ideal body weight for a woman with average bone structure who is 5 feet 5 inches tall?
//^ 125 pounds
//A 138 pounds
//B 125 pounds
//C 115 pounds
//D 135 pounds

//#Q The best diet is a permanent lifestyle change.
//^ True
//A True
//B False

//#Q Low-fat foods contain very little if any sugar.
//^ False
//A True
//B False

//#Q A teenage girl who is very thin and obsesses about losing weight may have an eating disorder.
//^ True
//A True
//B False

//#Q It would be better to skip breakfast entirely than to eat the typical American breakfast of sausage, sweets rolls, pancakes with syrup, and eggs.
//^ True
//A False
//B True

//#Q Which of these correctly defines the mathematical constant pi?
//^ The ratio of a circles circumference to its diameter.
//A The ratio of a circles area to its radius.
//B The ratio of a circles area to its diameter.
//C The ratio of a circles circumference to its diameter.
//D The ratio of a circles circumference to its radius.

//#Q References to measurements of a circular basin in the Bible (Kings 7:23), appears to give what corresponding value for pi?
//^ 3
//A 2.71828
//B 22/7
//C 3.14
//D 3

//#Q What is the exact value of the mathematical constant pi, a real number which is in common use in mathematics, physics, and engineering?
//^ There is no answer
//A 3.14
//B square root of ( 16 / (square root of 3) )
//C 22/7
//D There is no answer

//#Q The mathematical constant Pi can be approximated by taking a series of polygons inscribed in a circle and a series of polygons circumscribed around the circle.  Who was the first to write of this method of calculating pi?
//^ Archimedes
//A Carl Friedrich Gauss
//B Archimedes
//C Sir Isaac Newton
//D Euclid

//#Q The mathematical constant Pi is inherently involved in which of these math problems ?
//^ Squaring the circle
//A Calculating the area of polygons
//B Squaring the circle
//C Calculating the number of years it takes to double your money in an investment
//D Finding the optimum value for the weight of a buildings foundation

//#Q Whose was the proposal to use the 16th letter of the Greek alphabet, π, as a symbol for Archimedes constant, also known as Ludolphs number?
//^ William Jones
//A Isaac Newton
//B Leonhard Euler
//C William Jones
//D Archimedes

//#Q Pi Day is celebrated by many lovers of the mathematical constant, π, on what date?
//^ March 14th
//A May 5th
//B January 13th
//C December 3rd
//D March 14th

//#Q Which of these statements regarding the mathematical constant, pi is incorrect?
//^ By using larger and larger computers we can one day find the exact value of pi
//A Pi is transcendental
//B People compete to see who can memorize the most digits of pi
//C Lars Erickson wrote a symphony based on pi
//D By using larger and larger computers we can one day find the exact value of pi

//#Q As you calculate more and more decimal places for the mathematical constant pi, you will eventually reach Feynmans Point.  Which one of these most accurately defines Feynmans Point?
//^ The place where the decimal value of pi shows three 9s in a row
//A The place where the decimal value of pi shows three 9s in a row
//B The decimal place where we have five nines in a row
//C The decimal place where we have six zeros in a row
//D The last decimal place we know

//#Q Which of these statements regarding the mathematical constant, pi, is incorrect?
//^ There is no zero in the decimal expansion of pi
//A In September of 2002, Dr.Yasumasa Kanada at Tokyo University calculated pi to 1.2411trillion decimal places
//B There is no zero in the decimal expansion of pi
//C 22/7 is a good approximation for the value of pi
//D The first written reference to the ratio of a circles circumference to its diameter was written about 1650 b.c.e

//#Q Waters extraordinary physical properties are a result of its chemical structure - it consists of two hydrogen atoms and one oxygen atom bonded in what type of molecule?
//^ Polar
//A Diatomic
//B Nonpolar
//C Polar
//D Covalent

//#Q Although it is generally described as a transparent liquid, in seas, lakes and other large water bodies, water appears blue.  What property of water is this attributed to?
//^ Water absorbs light in the red range
//A Water reflects light in the red range
//B Water absorbs light in the red range
//C Water refracts light
//D Water radiates in the blue range

//#Q High surface tension, one of waters properties, is crucial for the survival of life on the planet, because it enables what vital process?
//^ Transport of nutrients
//A Dissolving of nutrients
//B Transport of nutrients
//C Recycling of nutrients
//D Formation of nutrients

//#Q Water is a powerful conductor of electricity.
//^ False
//A False
//B True

//#Q A unique property of water is that its solid form, ice, does not sink as may be expected, but floats. What is the reason for this phenomenon?
//^ Lower density of ice compared to liquid water
//A The specific resistance of water to solids
//B Temperature differences between the solid and liquid forms
//C Lower volume of ice compared to liquid water
//D Lower density of ice compared to liquid water

//#Q In meteorology, virga, a weather phenomenon typical for desert regions, is what form of precipitation?
//^ Precipitation that evaporates before reaching the ground
//A Precipitation that evaporates before reaching the ground
//B Highly condensed type of precipitation
//C Precipitation that freezes before reaching the ground
//D Precipitation that has not undergone condensation

//#Q Water is divided into soft and hard, depending on its chemical composition. Hard water washes soap from your hands faster, because of its high contents of what?
//^ Minerals
//A Polar molecules
//B Minerals
//C Free electrons
//D Salts

//#Q Because of its unique properties in interacting with other substances, water is often referred to as the universal what?
//^ Solvent
//A Stabilizer
//B Neutralizer
//C Solvent
//D Oxidant

//#Q The temperature of large bodies of water tends to vary much less, compared to that of land masses, why?
//^ Water can absorb a tremendous amount of heat
//A Water can absorb a tremendous amount of heat
//B Liquids are better heat conductors
//C Water responds more quickly to temperature changes
//D Sunlight penetrates water more easily

//#Q This intricate name, given to water, is a common hoax to misleadingly present water as a dangerous and harmful compound.
//^ Dihydrogen monoxide(DHMO)
//A Decaborane
//B Diborane
//C Disilane
//D Dihydrogen monoxide(DHMO)

//#Q Rain forests are home to approximately what percentage of all the living animal and plant species on the planet?
//^ 65%
//A 12%
//B 24%
//C 65%
//D 80%

//#Q Which of the following is typical for the Rainforest trees and cannot be seen in trees at higher latitudes?
//^ Cauliflory
//A Large leaves
//B Fleshy fruits
//C Cauliflory
//D Thin bark

//#Q Extract from the Periwinkle plant is one of the worlds most powerful drugs, used to fight this disease.
//^ Cancer
//A Cancer
//B Hepatitis B
//C AIDS
//D Psoriosis

//#Q The Toco Toucans strange appearance is due this.
//^ Its bill
//A Its movement
//B Its eyes
//C Its bill
//D Its feathers

//#Q What does the scientific name of the King cobra, Ophiophagus, mean?
//^ Snake eater
//A Royal snake
//B Elephant killer
//C Deadly reptile
//D Snake eater

//#Q The source of the Amazon, the widest river in the world, is located in this area of Peru.
//^ Calillona
//A Arequipa
//B Lima
//C Juliaca
//D Calillona

//#Q 123facts.com is a great site, isnt it? But do you know what the .com part stands for?
//^ Commercial
//A Competition
//B Composition
//C Commercial
//D Communication

//#Q Which domain is used by European Union institutions?
//^ .eu
//A.ue
//B.ee
//C .eu
//D .ec

//#Q Who may use the .gov domain?
//^ US federal agencies
//A Governments of any country (payment goes to UN funds)
//B Governors of US states
//C US federal agencies
//D Governments of any country(free)

//#Q If 123facts.de existed, in which language would the quizzes most likely be written?
//^ German
//A French
//B Danish
//C Spanish
//D German

//#Q What is the most likely suffix of a web page established by a Scottish company or individual?
//^ .uk
//A.gb
//B.sc
//C .uk
//D .br

//#Q The .aq domain name is reserved to which of the following?
//^ Organizations that work in or promote Antarctica
//A Organizations that work in or promote Antarctica
//B Countries that have Arctic Ocean shore (Canada, Greenland, Norway, Russia and USA)
//C Citizens of Antigua and Barbuda
//D Anyone who pays to the appropriate authority of Argentina

//#Q Which domain name is owned by Spain?
//^ .es
//A.es
//B Spain is the only country without a national domain
//C .sp
//D .hi

//#Q If you established Trivia TV and wanted a web site in the .tv domain, which of the following would earn some money?
//^ Tuvalu
//A Tuvalu
//B BBC
//C Taiwan
//D CNN

//#Q Which of the following owns the .fm domain name that is popular among radio stations?
//^ Federated States of Micronesia
//A International Broadcasters Union
//B Federated States of Micronesia
//C France
//D Mexico

//#Q Which country owns the .ie domain name?
//^ Ireland
//A Ireland
//B Northern Ireland (Ulster)
//C Israel
//D Iceland

//#Q What is the most likely suffix of the email address of someone who is Dutch?
//^ .nl
//A .nl
//B .hl
//C .ho
//D .du

//#Q I am from a country in Central Europe. Which domain name do I most likely type to access pages in my native language?
//^ .pl
//A .pg
//B .pk
//C .pa
//D .pl

//#Q What is the chemical symbol for Boron?
//^ B
//A B
//B Bn
//C Br
//D Bo

//#Q What is the chemical symbol for Iron?
//^ Fe
//A In
//B Fr
//C Fe
//D I

//#Q What is the chemical symbol for Lanthanum?
//^ La
//A Ln
//B La
//C L
//D Lt

//#Q What is the chemical symbol for Thorium?
//^ Th
//A Th
//B T
//C Fe
//D Tr

//#Q What is the symbol for Americium?
//^ Am
//A Am
//B Ag
//C Au
//D Ac

//#Q What is the chemical symbol of Einsteinium, a rare earth metal named after Albert Einstein.
//^ Es
//A Es
//B Et
//C Ei
//D E

//#Q What is the chemical symbol for Ytterbium?
//^ Yb
//A Ye
//B Ym
//C Yb
//D Yt

//#Q What is the chemical symbol for Uranium?
//^ U
//A Ua
//B U
//C Ur
//D Un

//#Q What is the chemical symbol for Vanadium?
//^ V
//A V
//B Va
//C Vn
//D Vd

//#Q The lightest baby weighed this much.
//^ 9.87 ounce (280 g)
//A 17.63 ounce(500 g)
//B 0.70 ounce(20 g)
//C 3.88 ounce(110 g)
//D 9.87 ounce(280 g)

//#Q This is the length of the worlds longest documented hair.
//^ 18.37 feet(5.6 m)
//A 13.77 feet(4.2 m)
//B 23.95 feet(7.3 m)
//C 6.56 feet(2.0 m)
//D 18.37 feet(5.6 m)

//#Q The oldest male stripper was that old when the record was documented.
//^ 65
//A 78
//B 65
//C 101
//D 54

//#Q The greatest age to which any man has ever lived is this.
//^ 120 years
//A 134 years
//B 162 years
//C 120 years
//D 104 years

//#Q In 1993 the Scottish hotel-owner Campbell Aird received a bionic organ, which was the first of its kind. This is the organ.
//^ Arm
//A Ear
//B Arm
//C Leg
//D Eye

//#Q This is the length of the longest fingernails.
//^ 24.60 feet(7.5 m)
//A 14.10 feet(4.3 m)
//B 10.49 feet(3.2 m)
//C 24.60 feet(7.5 m)
//D 27.23 feet(8.3 m)

//#Q This is the most rare disease.
//^ Smallpox
//A Smallpox
//B Brain tumor
//C Schizophrenia
//D Glaucoma

//#Q The longest coma lasted approximately this long.
//^ 37 years
//A 2 years
//B 11 months
//C 24 years
//D 37 years

//#Q This is the biggest number of transplanted organs in a person.
//^ 4
//A 7
//B 2
//C 4
//D 11

//#Q Roy C Sullivan survived this number of lighting strikes.
//^ 7
//A 12
//B 7
//C 3
//D 47

//#Q Dinosaurs appeared about 230 million years ago during the Triassic period and became extinct about 160 million years later, during the Cretaceous period. What is the period which marked the peak of dinosaurs reign on land referred to?
//^ Jurassic
//A Dinosaurian
//B Carboniferous
//C Jurassic
//D Permian

//#Q Despite the fierce image movies have attributed to dinosaurs, approximately this percent of dinosaurs fed on plants and were quite peaceful.
//^ 65 %
//A 65 %
//B 20 %
//C 52 %
//D 90 %

//#Q It is interesting to note that contrary to popular belief, by scientific definiton, there were no dinosaurs of this type.
//^ neither flying nor marine dinosaurs
//A flying dinosaurs
//B neither flying nor marine dinosaurs
//C cold-blooded dinosaurs
//D marine dinosaurs

//#Q What was the most impressive feature of the Stegosaurus appearance, which makes it the most easily identifiable dinosaur even for the non-expert observer?
//^ Kite-shaped plates
//A Long neck
//B Kite-shaped plates
//C Enormous tail
//D Long curved horns

//#Q Popularized by the Jurassic Park movie, velociraptors were relatively small carnivorous dinosaurs, which had evolved to be the perfect killers. What feature of their body in particular, helped them become such effective hunters?
//^ An extra claw on their hind limbs
//A A massive jaw
//B A strong tail with spikes
//C Two rows of teeth
//D An extra claw on their hind limbs

//#Q These are compounds that help protect cells from free radicals.
//^ antioxidants
//A calories
//B phytochemicals
//C nutrients
//D antioxidants

//#Q What is the name for all the chemical reactions that take place in the body?
//^ metabolism
//A nutrition
//B metabolism
//C absorption
//D digestion

//#Q Where does the majority of nutrient absorption take place?
//^ small intestine
//A mouth
//B small intestine
//C liver
//D large intestine

//#Q You shouldnt wash berries before you store them.
//^ True
//A True
//B False

//#Q Animal foods generally contain more saturated fats that plant foods.
//^ Yes
//A Yes
//B No

//#Q Which of the following is high in Vitamin E?
//^ Sunflower seeds
//A Liver
//B Eggs
//C Peas
//D Sunflower seeds

//#Q If you needed a good source of iron, this food would be the best.
//^ Liver
//A Peas
//B Broccoli
//C Salt
//D Liver

//#Q About how much of an adult humans body is water?
//^ 60%
//A 40%
//B 60%
//C 30%
//D 70%

//#Q Can overnutrition cause malnutrition?
//^ Yes
//A No
//B Yes

//#Q Consuming too much alcohol can raise fats in the blood.
//^ True
//A True
//B False

//#Q There are 12 astronomical constellations.
//^ False
//A False
//B True

//#Q This term refers to a celestial body that resembles a star but does not emit light, because it is too small to ignite internal nuclear fusion.
//^ Brown Dwarf
//A Neutron Star
//B Brown Dwarf
//C White Dwarf
//D Protostar

//#Q This astronomical term refers to the outermost layer of the sun, which is a low density cloud of plasma, with higher transparency than the inner layers.
//^ Corona
//A Chromosphere
//B Photosphere
//C Corona
//D Solar Wind

//#Q This chemical element is the final element produced by stellar nucleosynthesis and the heaviest element which does not require a supernova for its formation.
//^ Iron
//A Lead
//B Carbon
//C Oxygen
//D Iron

//#Q This star, the second brightest star in the constellation Orion, is a red supergiant.
//^ Betelgeuse
//A Spica
//B Pollux
//C Betelgeuse
//D Sirius

//#Q This constellation in the Northern Hemisphere was named after a Greek mythological figure, whose name is translated as ruler over men.
//^ Andromeda
//A Centaurus
//B Cassiopeia
//C Andromeda
//D Hercules

//#Q Not all rain reaches the Earths surface.
//^ True
//A False
//B True

//#Q Convective rain occurs in regions with what daytime whether?
//^ Hot during the day
//A Dry during the day
//B Cold during the day
//C Hot during the day
//D Moist during the day

//#Q Rain below what pH is considered acid rain?
//^ 5.6
//A 5.6
//B 6.5
//C 6.8
//D 7.5

//#Q Who was the first person to study the shape of a raindrop in 1898?
//^ Philipp Lenard
//A Philipp Drimsev
//B Philipp Lenard
//C Allton Kertsky
//D Raymond Hasdroff

//#Q Too much rainfall can kill plants, just like a drought.
//^ True
//A True
//B False

//#Q What does IC stand for in a computer?
//^ Integrated Circuit
//A Integrated Circuit
//B Integrated Chip
//C InterChip
//D InterCircuit

//#Q What does RAM stand for?
//^ Random Access Memory
//A ReadAble Memory
//B Random Access Memory
//C Raise All Memory
//D Erase All Memory

//#Q What does the ROM part of a CD-ROM stand for?
//^ Read Only Memory
//A Erase Only Memory
//B Read Only Memory
//C Nothing
//D Romial Memory

//#Q How are hard drives and floppy disks read?
//^ Magnetically
//A Laser
//B Beam of Nuclear Radiation
//C Magnetically
//D Sensor

//#Q How are CDs and DVDs read?
//^ Laser
//A Sensor
//B Laser
//C Beam of Nuclear Radiation
//D Magnetically

//#Q Why is Blue Ray better than Red Ray/Laser?
//^ It can read more memory.
//A It is stronger.
//B It gets damaged less.
//C It can read more memory.
//D It has more memory.

//#Q What is the big green board in the computer called?
//^ motherboard
//A motherboard
//B daughter card
//C father card
//D son board

//#Q What are the little green boards in the computer called?
//^ daughter cards
//A son boards
//B daughter cards
//C father cards
//D motherboards

//#Q What is the hottest part of the computer?
//^ CPU
//A Fan
//B RAM
//C CPU
//D Hard Drive

//#Q What is the long term memory of the computer?
//^ Hard Drive
//A Networking Cards
//B RAM
//C Motherboards
//D Hard Drive

//#Q Cultural anthropology was one of the two classical divisions of anthropology. What was the other one?
//^ Physical Anthropology
//A Physical Anthropology
//B Urban Anthropology
//C Variated Anthropology
//D Social Anthropology

//#Q What does the Greek prefix anthro refer to?
//^ Mankind
//A study of
//B Science
//C Sameness
//D Mankind

//#Q What does the Latin prefix homo refer to?
//^ Mankind
//A Sameness
//B Mankind
//C Study of
//D Science

//#Q What does the prefix pithe refer to?
//^ Ape
//A Human
//B Ape
//C Invertebrate
//D Mammal

//#Q Who is considered to be the father of anthropology?
//^ Franz Boas
//A Louis Leakey
//B Franz Boas
//C Robert Bloom
//D Eugene Dubois

//#Q What does australo mean?
//^ South
//A South Africa
//B South
//C The Australian Outback
//D Australia

//#Q What does the suffix lith refer to (as in Neolithic Age)?
//^ Stone
//A Stone
//B Iron
//C Copper
//D Early tools

//#Q What is the meaning of the prefix paleo (as in the Paleolithic Age)?
//^ Old
//A Meso
//B New
//C Modern
//D Old

//#Q What does the term Homo erectus mean?
//^ a man who is able to stand upright
//A a man who is able to stand upright
//B a creature that has the ability to reason
//C a man who can make tools
//D a hominid

//#Q What is the subject of study of paleoanthropology?
//^ ancient human  fossils
//A ancient human  fossils
//B the earliest human discoveries and accomplishments
//C older people
//D old cultures and societies

//#Q In 1924, Raymond Dart discovered a fossil which he called Australopithecanthropus africanis.  What is the meaning of the name?
//^ The ape man from southern Africa
//A None of these
//B The old man from Australia
//C The man from the Mesolithic Age
//D The ape man from southern Africa

//#Q Who found and named  the first Homo Erectus in 1891?
//^ Eugene Dubois
//A Eugene Dubois
//B Franz Boas
//C Louis and Mary Leakey
//D David Johannson

//#Q Which fossil was proved to be a hoax?
//^ Piltdown Man
//A Cro-Magnon Man
//B Neanderthal Man
//C Kennewick Man
//D Piltdown Man

//#Q The earliest known European example of Homo sapiens was discovered in 1868 and was given what name?
//^ Cro Magnon Man
//A Cro Magnon Man
//B Neaanderthal Man
//C Austrlopithecus
//D Peking Man

//#Q The Peking Man is an example of what species of the genus Homo?
//^ Homo erectus
//A Homo sapiens
//B Pithecanthropus
//C Homo erectus
//D Homo habilis

//#Q What does the abbreviation AIDS actually stand for?
//^ Acquired immune deficiency syndrome
//A Acute immune deficiency symptom
//B Acquired immune deficiency syndrome
//C Acute immune deficient syndrome
//D Acquired immune deficient symptom

//#Q In 1981 people with AIDS were diagnosed with the term GRID. What did GRID mean?
//^ Gay-Related Immune Deficiency
//A Great Risk of Immune Disease
//B Grave Risk of Immune Deficiency
//C Gay-Related Immune Deficiency
//D Grievous Ravishing Immune Disease

//#Q Which of the following statements about AIDS is true?
//^ You cant get AIDS from a mosquito bite.
//A AIDS can be transmitted through casual contact with an HIV-positive person.
//B You cant get AIDS through oral sex.
//C HIV does not actually cause AIDS.
//D You cant get AIDS from a mosquito bite.

//#Q The Central Common Chimpanzee, native to Cameroon, is known to be the origin of which of the viruses causing AIDS?
//^ HIV-1
//A HIV-2
//B HIV-1
//C All of these
//D HIV-3

//#Q Who distributed the first red ribbon as an anti-AIDS symbol?
//^ Paul Jabara
//A Freddie Mercury
//B Diana, Princess of Wales
//C Paul Jabara
//D Elton John

//#Q Which of these regions is most affected by AIDS, as about 60% of all the HIV-infected people in the world live there?
//^ Sub-Saharan Africa
//A Latin America
//B Sub-Saharan Africa
//C East Asia
//D Western Europe

//#Q Which line contains only names of people who have or had AIDS?
//^ Magic Johnson, Isaac Asimov
//A Jim Morrison, Bob Marley
//B Magic Johnson, Isaac Asimov
//C Tony Richardson, Kurt Cobain
//D Freddie Mercury, Jimi Hendrix

//#Q What day is internationally recognised and annually observed as World AIDS Day?
//^ December 1
//A June 1
//B April 5
//C December 1
//D May 1

//#Q This non-government anti-AIDS organization was founded by Bono and Bobby Shriver in 2002 with start up capital from Bill Gates.
//^ Debt, AIDS, Trade in Africa
//A Live Aid
//B Debt, AIDS, Trade in Africa
//C Band Aid
//D USA for Africa

//#Q When a heterosexual couple has sex using a latex condom, what can create risk of HIV-infection?
//^ Oil-based lubricants
//A The condoms tentacles
//B Nothing
//C Water-based lubricants
//D Oil-based lubricants

//#Q How many continents are generally considered to be there on Earth?
//^ 7
//A 4
//B 6
//C 5
//D 7

//#Q The Earths atmosphere comprises of which two main elements?
//^ Oxygen and Nitrogen
//A Oxygen and Hydrogen
//B Hydrogen and Oxone
//C Oxygen and Nitrogen
//D Nitrogen and Hydrogen

//#Q What was the name of the Earths first artificial satellite?
//^ Sputnik 1
//A Telstar 1
//B Telos 1
//C Sputnik 1
//D Explorer 1

//#Q How long does it take for the planet Earth to orbit the Sun once?
//^ 365 Days
//A 365 Days
//B 2 Years
//C 8 Months
//D 24 Hours

//#Q How long is one day on planet Earth?
//^ About 24 hours
//A About 26 hours
//B About 24 hours
//C About 36 hours
//D About 22 hours

//#Q Which planet in the Solar System is sometimes referred to as Earths sister planet?
//^ Venus
//A Mercury
//B Mars
//C Pluto
//D Venus

//#Q The Earth orbits the Sun at an average distance of how many million miles?
//^ 93
//A 42
//B 93
//C 89
//D 101

//#Q What percentage of the Earths surface is covered by water?
//^ Roughly 70%
//A Exactly 50%
//B Roughly 25%
//C Roughly 50%
//D Roughly 70%

//#Q Scientists estimate that the Earth and the Solar System were formed how long ago?
//^ 4.5 billion years
//A 100 million years
//B 4.5 billion years
//C 10 billion years
//D 3.5 billion years

//#Q This famous mathematician’s main interest was set theory. He is famous for his diagonal method” of proof.
//^ Cantor
//A Euler
//B Goedel
//C Cantor
//D Gauss

//#Q Although he is known primarily as a physicist, Albert Einstein did make at least one very important contribution to modern mathematics. In which field was this contribution?
//^ Tensor analysis
//A Tensor analysis
//B Differential topology
//C Theory of groups
//D Partial differential equations

//#Q On a plane, a map is drawn so that the border of any two intersecting areas is more than just one point. You wish to color the map so that two intersecting area have different colors.  What is the minimal number of colors you will need to color any such map?
//^ 4
//A 8
//B 3
//C 2
//D 4

//#Q In mathematics, 6!” is read as six factorial”. Calculate 6!
//^ 720
//A 24
//B 720
//C 120
//D 21

//#Q A “combination lock“ has three integers. Each integer is a member of this set: {0, 1, 2, 3, 4,}. How many such locks with different combinations can be made?
//^ 125
//A 21
//B 125
//C 15
//D 120

//#Q A pair of fair dice are rolled and the numbers on the dice are added. What is the probability that you will roll a seven?
//^ 6 out of 36
//A 6 out of 36
//B 7 out of 36
//C 13 out of 36
//D 2 out of 6

//#Q What function is equal to its derivative?
//^ y = e ^ x
//A y = e ^ x
//B y = log x
//C y = cos x
//D y = sin x

//#Q Which mathematician proved that every angle can be trisected?
//^ No one ever could
//A Aristarcus
//B Euclid
//C No one ever could
//D Gauss

//#Q What do mathematicians call a quadrilateral with exactly one pair of parallel sides?
//^ A trapezoid
//A A trapezoid
//B A square
//C A rectangle
//D An ellipse

//#Q If you multiply any six consecutive whole numbers the product will be divisible by 8.
//^ True
//A True
//B False

//#Q Both Newton and Leibnitz claimed credit for inventing” calculus. Which statement about calculus is true?
//^ Whoever invented it, we use Leibnitz notation.
//A Whoever invented it, we use Leibnitz notation.
//B Gauss really invented it.
//C Euler really invented it.
//D Whoever invented it, we use Newton’s notation.

//#Q Find the mode of this list of numbers: 0,0,0,1,0,3,6,8,0.
//^ 0
//A 1
//B 0
//C 2
//D 3

//#Q Who was the first US President to publish a mathematical proof?
//^ James Garfield
//A Benjamin Pierce
//B Thomas Jefferson
//C James Garfield
//D Herbert Hoover

//#Q The testes contain very fine coiled tubes known as the seminal vesicles.
//^ False
//A False
//B True

//#Q What maintains the male secondary sex characteristics?
//^ androgen
//A epididymis
//B androgen
//C vas deferens
//D testes

//#Q What is the male reproductive organ which secretes an alkaline fluid?
//^ prostate gland
//A seminal vesicle
//B prostate gland
//C cowpers gland
//D penis

//#Q The seminal vesicle opens into which of the following?
//^ urethra
//A vas deferens
//B cowpers gland
//C penis
//D urethra

//#Q Urine and semen are expelled in the urethra.
//^ True
//A False
//B True

//#Q What is the symbol for Vanadium?
//^ V
//A Vd
//B V
//C Vn
//D Va

//#Q What is the symbol for Polonium?
//^ Po
//A Pl
//B Pn
//C P
//D Po

//#Q What is the symbol for Magnesium?
//^ Mg
//A Mg
//B M
//C Mn
//D Ma

//#Q What is the symbol for Niobium?
//^ Nb
//A Ni
//B N
//C Nb
//D No

//#Q What is the symbol for Gold?
//^ Au
//A Au
//B Ao
//C G
//D Gd

//#Q What is the symbol for Cobalt?
//^ Co
//A Co
//B Ct
//C C
//D Cb

//#Q What is the symbol for Iron?
//^ Fe
//A Fe
//B I
//C Ir
//D Fi

//#Q What is the symbol for Thallium?
//^ Tl
//A Ta
//B Tl
//C Th
//D T

//#Q What is the symbol for Helium?
//^ He
//A He
//B Hi
//C Hl
//D H

//#Q What is the symbol for Copper?
//^ Cu
//A Cp
//B Cu
//C Co
//D C

//#Q Grasslands cover this part of land on Earth.
//^ 1/5th
//A 1/2th
//B 1/17th
//C 1/10th
//D 1/5th

//#Q Scallops live a sedentary live and never move around.
//^ False
//A False
//B True

//#Q Deserts are advancing and taking over the land. For instance, in Mali the desert is advancing at this speed.
//^ 11 miles per year
//A 37 miles per year
//B 4 miles per year
//C 11 miles per year
//D 23 miles per year

//#Q The Antarctic ozone hole reached one of its largest ever sizes in September 2000 when it was 11.5 million square miles (29,784,863 square km).
//^ True
//A False
//B True

//#Q Which of these products takes more than 30 years to biodegrade?
//^ Nylon fabric
//A Cigarette filters
//B Leather shoes
//C Nylon fabric
//D Paper

//#Q Acid rain is defined as rain with a pH of below this.
//^ 5.6
//A 8.6
//B 5.6
//C 2.6
//D 11.6

//#Q Many credit this book by Rachel Carson with launching the environmentalist movement.
//^ Silent Spring
//A Soft Spring
//B Silent Spring
//C White Spring
//D Our Spring

//#Q Wood, water, air, wax, natural gas, paper, cardboard and leather are all renewable resources.
//^ False
//A True
//B False

//#Q Every day this number of species of plants and animals become extinct.
//^ 50 - 100
//A 140 - 200
//B 50 - 100
//C 250 - 350
//D 10 - 20

//#Q In the winter of 1998-1999 this U.S. state broke the record of Mt. Ranier from 1971-1972 for the largest amount of cumulative snowfall in history.
//^ Washington
//A Washington
//B Maine
//C Montana
//D Alaska

//#Q In Africa, a certain type of chimpanzees have been observed making snowballs.
//^ True
//A True
//B False

//#Q What term is used by skiers to describe wet granular snow?
//^ Corn
//A Goobers
//B Corn
//C Clumps
//D Snow peas

//#Q Choose the statement about watermelon snow that is not true.
//^ Watermelon snow is created when the suns rays reflect off of it.
//A Watermelon snow is pink in color.
//B Watermelon snow is created when the suns rays reflect off of it.
//C Watermelon snow is caused by red colored algae.
//D Watermelon snow smells like watermelon.

//#Q What is the known top speed that a snow avalanche can reach?
//^ 60 mph (95 km/h)
//A 85 mph(135 km/h)
//B 45 mph(72 km/h)
//C 30 mph(48 km/h)
//D 60 mph(95 km/h)

//#Q During World War I approximately how many soldiers died as a result of avalanches?
//^ 60,000
//A 25,000
//B 60,000
//C 10,000
//D 40,000

//#Q What scale is used only to describe hurricanes forming in the Atlantic Ocean and northern Pacific Ocean?
//^ Saffir-Simpson Hurricane Scale
//A Saffir-Simpson Hurricane Scale
//B Hamilton-Norwood scale
//C Beaufort scale
//D Fujita scale

//#Q Which of these is classified on the Hamilton-Norwood scale?
//^ male hair loss
//A fatigue
//B male hair loss
//C blood pressure
//D headache

//#Q What is the name of the scale created by an entomologist who had been stung by almost every type of bee, ant, and wasp?
//^ Schmidt Sting Pain Scale
//A Kardashev Sting Pain Scale
//B Shwan Sting Pain Scale
//C Schmidt Sting Pain Scale
//D Ludwig Sting Pain Scale

//#Q Who proposed a general method of classifying how technologically advanced a civilization is?
//^ Kardashev
//A Fujita
//B Tanner
//C Malinas
//D Kardashev

//#Q The Scoville scale is used to measure the hotness of what?
//^ Chilli peppers
//A Magma
//B Sun rays
//C Chilli peppers
//D Internal combustion engines

//#Q This scale was originally used to determine the level of consciousness after head trauma.
//^ Glasgow Coma Scale
//A Johnson Coma Scale
//B Barnes Akathisia Coma Scale
//C Miller Coma Scale
//D Glasgow Coma Scale

//#Q The absolute hardness of a diamond  measures 1500, on which scale?
//^ Mohs scale of mineral hardness
//A Grubers scale of mineral hardness
//B Hans scale of mineral hardness
//C Abels scale of mineral hardness
//D Mohs scale of mineral hardness

//#Q What scale is used by astronomers to rate the potential hazard of impact of a near-earth object?
//^ Palermo Technical Impact Hazard Scale
//A Boston Impact Hazard Scale
//B Palermo Technical Impact Hazard Scale
//C Genoa Technical Impact Hazard Scale
//D Urbino Impact Hazard Scale

//#Q Which of the following is a description of an earthquake with magnitude 4.9 according to the Richter Scale?
//^ Noticeable shaking of indoor items, rattling noises.Significant damage unlikely.
//A Can cause serious damage in areas several hundred miles across.
//B Often felt, but rarely causes damage.
//C Microearthquakes, not felt.
//D Noticeable shaking of indoor items, rattling noises. Significant damage unlikely.

//#Q What scale measures the sexual orientation from 0 (exclusively heterosexual) to 6 (exclusively homosexual?
//^ Kinsey Scale
//A Johnas scale
//B Kinsey Scale
//C James Scale
//D Jacobs Scale

//#Q The term hurricane indicates a tropical storm which occurs in the northern hemisphere, whereas this term refers to the southern hemisphere.
//^ Cyclone
//A Disturbance
//B Typhoon
//C Depression
//D Cyclone

//#Q A tropical storm with sustained winds exceeding 33 meters per second, which occurs in the Northwest Pacific Ocean west of the dateline, is called this.
//^ Typhoon
//A Severe tropical cyclone
//B Hurricane
//C Typhoon
//D Severe cyclonic storm

//#Q One of the factors necessary for the formation of a tropical cyclone is a warm sea surface to a certain depth.  As a minimum, how warm should the sea surface be and to what depth?
//^ 26.5 C (79.7 F) to a depth of 50 meters(164 ft)
//A 5.5 C(41.9 F) to a depth of  100 meters(328 ft)
//B 15 C(59 F) to a depth of 25 meters(82 ft)
//C 26.5 C(79.7 F) to a depth of 50 meters(164 ft)
//D 35.5 C(95.9 F) to a depth of  100 meters(328 ft)

//#Q Worldwide, tropical cyclone activity peaks towards the end of which season and why?
//^ Summer, because water temperatures are warmest
//A Summer, because water temperatures are warmest
//B Spring, due to the rapid worming of water
//C Fall, as temperature rapidly falls, waters remain warm
//D Winter, due to the delta between air and water temperatures

//#Q The Fujita scale rates a tornados intensity by the damage it inflicts on human-built structures, this scale classifies hurricanes by the intensity of their sustained winds.
//^ Saffir-Simpson scale
//A Saffir-Simpson scale
//B Beaufort scale
//C Kardashev scale
//D Hamilton-Norwood scale

//#Q Which of the following statements best describes a storm surge?
//^ Onshore rush of water associated with a low pressure weather system
//A Onshore rush of water associated with a low pressure weather system
//B Sudden and rapid increase of the intensity of a storm
//C Expansion of the hurricanes eye
//D Windstorm characterized by a twisting, funnel-shaped cloud

//#Q While the number of storms in the Atlantic has increased in past years, this does not seem to be a global trend.
//^ True
//A True
//B False

//#Q Anemometers, from the Greek word anemos meaning wind, can be used to measure this.
//^ Winds Pressure and Velocity
//A Winds Pressure and Velocity
//B Winds Moisture and Velocity
//C Winds Velocity
//D Winds Pressure

//#Q In a tropical cyclone, this area is characterized with the strongest winds, the tallest clouds, and the heaviest rain.
//^ Eyewall
//A Eye
//B Warm core
//C Outflow
//D Eyewall

//#Q Which of these economic terms does not denote restriction of international trade, i.e. the free flow of goods between nations?
//^ The General Agreement on Tariffs and Trade
//A Trade quotas
//B The General Agreement on Tariffs and Trade
//C Non-tariff trade barriers
//D Import tariffs

//#Q What factor is the reason for economists to believe that countries are gradually becoming more economically interdependent?
//^ All of these
//A There are many multinational corporations that design, manufacture, and sell products around the world.
//B Global trade is largely aided by the constant progress of technologies.
//C All of these
//D Financial markets in many countries have been opened to participants from foreign countries.

//#Q International trade is an important part of world economy.  Which statement about international trade is not true?
//^ Large countries depend more on trade than smaller countries do.
//A Globalization is a process closely related to international trade.
//B Large countries depend more on trade than smaller countries do.
//C Communist and socialist nations tend to aspire to complete lack of international trade (autarky).
//D Free trade is most strongly supported by the economically powerful nation in the world.

//#Q In economics, the Law of Supply is the direct opposite of the Law of Demand. Which of the following correlations best describes the Law of Supply?
//^ The higher the price, the larger the quantity supplied.
//A If the price is high, demand will exceed supply.
//B If the price is low, supply will always be inadequate for the demand.
//C The higher the price, the lower the quantity supplied.
//D The higher the price, the larger the quantity supplied.

//#Q Suppose that an increase in the price of good Y results in an increase in the demand for good X. This phenomenon is an example of which effect in economics?
//^ The substitution effect
//A The income effect
//B The supply effect
//C The substitution effect
//D The demand effect.

//#Q Having in mind the demand and supply laws, what will happen to the equilibrium of price and quantity of automobiles if wages of workers manufacturing them increase?
//^ Price will increase; quantity will decrease.
//A Price will increase; quantity will decrease.
//B Price will decrease; quantity will increase.
//C Price will increase; quantity will increase
//D Price will decrease; quantity will decrease

//#Q Elasticity is a term in economics which refers to the proportional change in two variables related to each other. For example, if you earn $80,000 a year and use cable TV service that costs you $100 per year, your demand for the cable service is likely to be what?
//^ Inelastic
//A Inelastic
//B Perfectly inelastic
//C Elastic
//D Perfectly elastic

//#Q The phenomenon that leads individual consumers and producers to equilibrium with the market is defined by which term in economics?
//^ The invisible hand
//A The invisible hand
//B The free-rider problem
//C The price ceiling
//D Government regulations

//#Q An effective minimum price imposed by the government, called price floor in economics, is usually expected to result in what?
//^ Surplus
//A Surplus
//B Increased demand
//C Decreased supply
//D Shortage

//#Q What is the nearest star to the Sun?
//^ Proxima Centuori
//A Deneb
//B Vega
//C Proxima Centuori
//D Polaris

//#Q In 1928, the International Astronomical Union divided the sky into how many official constellations?
//^ 88
//A 77
//B 99
//C 55
//D 88

//#Q What is the apparent path of the sun around the sky called?
//^ Ecliptic
//A Revolution
//B Zodiac
//C Corona
//D Ecliptic

//#Q At how many approximate degrees does Venus appear from the sun?
//^ 46
//A 78
//B 35
//C 46
//D 55

//#Q Name the point where an objects orbit passes through the plane of Earths orbit.
//^ Node
//A Node
//B Apogee
//C Prominence
//D Perigee

//#Q The moon phases are the result of the moons rotation around the Earth, causing us to see different parts of the moons surface lit by the sun.
//^ True
//A True
//B False

//#Q What is the name for a band of the celestial sphere centered on the ecliptic and encircling the sky?
//^ Zodiac
//A Vernal Equinox
//B Zodiac
//C Photosphere
//D Corona

//#Q Summer Solstice is the point on the celestial sphere where the sun is at its most northerly point.
//^ True
//A False
//B True

//#Q What is perihelion?
//^ the orbital point of the closest approach to the sun
//A the orbital point of the closest approach to the sun
//B the orbital point of greatest distance from the sun
//C the darkening of the moon when it moves through the Earths shadow
//D any planet visible in the sky just after sunset

//#Q How long can a total lunar eclipse last?
//^ 1 hour  40 minutes
//A 1 hour  40 minutes
//B 4 hours  30 minutes
//C 2 hours  30 minutes
//D 3 hours  20 minutes

//#Q In December 2004, the discovery of the deepest coral reef in the United States was confirmed.  It is also the deepest coral reef in the world.
//^ False
//A True
//B False

//#Q A coral island, that consists of a coral reef, enclosing a depression in the centre is called this.
//^ Atoll
//A Patch
//B Atoll
//C Lagoon
//D There is no common name

//#Q What happened to the tropical coral reefs during the 1998 and 2004 El Nino weather phenomenons?
//^ Many of them were bleached or even killed
//A Many of them were bleached or even killed
//B Some of them exploded
//C They all thrived
//D Nothing as they were all deep underwater

//#Q The implementation of MPAs is one way to protect the coral reefs from destruction. What does MPA stand for in this context?
//^ Marine Protected Area
//A Marine Preservation Act
//B Magnetospheric Plasma Analyzer
//C Mammal Protection Act
//D Marine Protected Area

//#Q This country is the worlds largest exporter of corals.
//^ Indonesia
//A India
//B Australia
//C Indonesia
//D Thailand

//#Q This is a natural healing method that uses the reflex points of the feet, which correspond to different organs and areas of the body.
//^ Reflexology
//A Reflexology
//B Oriental Massage Therapy
//C Aromatherapy Massage
//D Relaxation Massage

//#Q What is the most common reason for getting a massage?
//^ Relaxation
//A Relaxation
//B Joint pain
//C Healing
//D Back pain

//#Q Smooth strokes are enhanced by this substance, which is often used during a massage.
//^ Oil
//A Butter
//B Oil
//C Spirits
//D Powder

//#Q This technique is used to relax soft tissue. It is done using both hands, exercising light pressure.
//^ Effleurage
//A Tapotement
//B Friction
//C Petrissage
//D Effleurage

//#Q An ancient Chinese book called The Inner Canon of Huangdi recommends breathing exercises, massage of the skin and flesh, and exercises of hands and feet as a remedy for complete paralysis, chills, and fever. Who was the author of this ancient book?
//^ The Yellow Emperor
//A Yu the Great
//B Emperor Yao
//C The Red Emperor
//D The Yellow Emperor

//#Q As massage relaxes the body, relieves pain and reduces stress, it contributes to this.
//^ Better sleep
//A Better sleep
//B Hair growth
//C Stronger bones
//D Open mindedness

//#Q There are different types of massage. Approximately how many?
//^ More than 150
//A More than 50
//B More than 20
//C More than 300
//D More than 150

//#Q This is a new type of massage, introduced in 1990 by Hemi Hoani Fox. It originates from the Hawaiian Lomi-Lomi Nui dance and is believed to increase the energy flow within the body and mind.
//^ MA-URI massage
//A MA-URI massage
//B Zhi Ya massage
//C Tui Na massage
//D Shiatsu

//#Q In this year massage therapy and bodywork were officially offered for the first time as a basic medical service, in Atlanta, GA.
//^ 1996
//A 1990
//B 1999
//C 1996
//D 1987

//#Q As of the beginning of the new millennium, this was  the approximate number of Americans who receive a massage annually.
//^ 20,000,000
//A 15,000
//B 150,000
//C 20,000,000
//D 3,000,000

//#Q What is the predominant mood of a person with anxiety?
//^ Fear
//A Anger
//B Sadness
//C Fear
//D Loneliness

//#Q People with anxiety usually know they have anxiety.
//^ False
//A True
//B False

//#Q Which of the following lists of symptoms is typical of a person with depression?
//^ Fatigue, difficulting concentrating, loss of interest in usual activities, poor appetite, guilt, and insomnia
//A Seeing things that arent there, hearing voices when no one is present, and displaying emotions different from those that one is actually feeling.
//B Irritability, fatigue, insomnia, difficulty concentrating, restlessness, and headaches
//C Racing thoughts, decreased need for sleep, euphoric mood, risk-taking behaviors, and irritability
//D Fatigue, difficulting concentrating, loss of interest in usual activities, poor appetite, guilt, and insomnia

//#Q Which of the following sleep disorders is more typical of a person with depression?
//^ Late insomnia (difficulty staying asleep)
//A Parasomnia(nightmares, sleepwalking, or other violent behaviors while sleeping)
//B Early insomnia(difficulty getting to sleep)
//C Sleep apnea
//D Late insomnia(difficulty staying asleep)

//#Q People with depression usually know they are depressed.
//^ True
//A False
//B True

//#Q Which of the following people is generally at the highest risk of suicide?
//^ A divorced, unemployed man living alone
//A A depressed housewife with a disabled child
//B An anxious stockbroker
//C A divorced, unemployed man living alone
//D A single mother with 4 children who is on welfare

//#Q Which of the following medications is effective for both depression and anxiety?
//^ Paxil(paroxetine)
//A Buspar(buspirone)
//B Paxil(paroxetine)
//C Xanax(alprazolam)
//D Wellbutrin(bupropion)

//#Q Depression and anxiety are considered mood disorders.  Which of the following is also considered a mood disorder?
//^ Bipolar Disorder
//A Bipolar Disorder
//B Schizophrenia
//C Schizotypal Personality Disorder
//D Narcissism

//#Q Which of the following disorders is NOT a form of anxiety?
//^ Cyclothymia
//A Cyclothymia
//B Body Dysmorphic Disorder
//C Somatization Disorder
//D Panic Disorder

//#Q Of the following medications for anxiety, which is potentially addictive?
//^ Ativan(lorazepam)
//A Prozac(fluoxetine)
//B Ativan(lorazepam)
//C Buspar(buspirone)
//D Effexor(venlafaxine)

//#Q A scheme, commonly used by anatomists, divides the abdominal surface and abdominopelvic cavity into nine separate regions by four planes. One of this is the Lumbar region. It is located between the ribs and the flaring portions of the hip bones which is flanking the epigastric region.
//^ False
//A False
//B True

//#Q What system of the human body provides a site for blood cell formation?
//^ Skeletal
//A Cardiovascular
//B Skeletal
//C Integumentary
//D Endocrine

//#Q A cells life cycle is the series of changes the cell goes through from the time it is formed until it reproduces itself. It includes two stages. What are these two stages?
//^ Cell division and interphase
//A Interphase and cytokinesis
//B Cytokinesis and mitosis
//C Cell division and interphase
//D Mitosis and meiosis

//#Q Cells are the building blocks of life. In humans and other multicellular organisms, cells depend on one another and cooperate to maintain homeostasis in the body. Groups of cells that are similar in structure and function are called tissues. What tissue protects the underlying tissues in areas subjected to abrasion?
//^ Stratified squamous epithelium
//A Transitional epithelium
//B Simple columnar epithelium
//C Pseudostratified columnar epithelium
//D Stratified squamous epithelium

//#Q Architecturally, our skin is a wonder. It is tough yet pliable, a characteristic that enables it to withstand constant insult from outside agents. Is the skin considered a system of the human body despite its extent and complexity?
//^ Yes
//A No
//B Yes

//#Q Bone surfaces are not featureless and smooth but are scarred with an array of bumps, holes, and ridges called bone markings.   What is the name of a bone marking which is very large, blunt and irregularly shaped?
//^ Trochanter
//A Crest
//B Tuberosity
//C Trochanter
//D Tubercle

//#Q If I am a superficial muscle of the human body having two prominent bellies, then where am I located?
//^ Leg
//A Leg
//B Hip
//C Head
//D Arm

//#Q In the human body, the pulmonary circulation differs in many ways from systemic circulation because it does not serve the metabolic needs of the body tissues. Which of the following is the true sequence of the pulmonary circulation?
//^ Right atrium - right ventricle - pulmonary arteries - arterioles - capillaries - venules - pulmonary veins - left atrium - left ventricle
//A Pulmonary trunk - left pulmonary artery - lobar arteries of the left lung - right atrium - right pulmonary artery - left ventricle
//B Right atrium - right ventricle - pulmonary arteries - arterioles - capillaries - venules - pulmonary veins - left atrium - left ventricle
//C Left ventricle - left lung - right lung - lobar arteries of the left atrium - pulmonary trunk
//D Left atrium - left pulmonary artery - left pulmonary veins - lobar arteries of the left lung - left ventricle - left ventricle

//#Q The digestive system provides the body with the nutrients essential for health. The organs of this system ingest, digest, and absorb food and eliminate the undigested remains as feces. The oral cavity, parotid gland, sublingual gland, tongue, pharynx, larynx and oesophagus are constituents of this system.
//^ False
//A False
//B True

//#Q What is the name of the flat panel monitors that became increasingly popular around 2005?
//^ LCD
//A DLP
//B LCD
//C Plasma
//D LSD

//#Q What is the name for a port used to connect peripheral devices (such as keyboards, mouses and digital cameras) to a computer?
//^ USB
//A USB
//B Jack
//C Floppy Drive
//D BUS

//#Q Which one of these is an operating system?
//^ Vista
//A Norton Anti-Virus
//B Office -  Professional edition
//C Vista
//D Microsoft

//#Q What capabilities are indicated when the specifications read DVD±RW/CD-RW?
//^ The computer is able to read and rewrite to CDs and DVDs.
//A No capabilities are indicated.This is a programming language.
//B There are two disc drives, one for DVD and one for CD.
//C The computer is able to read and rewrite to CDs and DVDs.
//D The DVD and CD drive is removable

//#Q The correct way to measure the size of a widescreen monitor or laptop display is by length of the longer side.
//^ False
//A False
//B True

//#Q GigaBytes or GB is the measurement used to determine the processor speed.
//^ False
//A False
//B True

//#Q The companies Intel and AMD are primarily known for their development and manufacturing of what?
//^ Processors
//A Processors
//B Video Cards
//C Software
//D Ram

//#Q A computer that has wireless 802.11b/g or a Nic card needs nothing else to connect to the Internet.
//^ False
//A False
//B True

//#Q If a computer has an integrated sound card, you will not need speakers to hear sounds (such as music or sound effects) through your system.
//^ True
//A False
//B True

//#Q Which one of these items is more valuable as far as meeting the requirements for 3-D Gaming is concerned?
//^ PCI Express video card
//A HDMI 1080p
//B Bluetooth
//C Integrated(or on board) video
//D PCI Express video card

//#Q Which of the following types of brain cells amplify the neural signals and maintain homeostasis?
//^ glial cells
//A axons
//B glial cells
//C neurons
//D spindle cells

//#Q The meninges, a system of membranes that envelop the central nervous system, consist of three layers. Which of the following is not  a name of a layer?
//^ grey mater
//A dura mater
//B pia mater
//C archanoid mater
//D grey mater

//#Q Which of the following is part of the frontal lobe, an area at the front of each cerebral hemisphere?
//^ precental gyrus
//A fusiform gyrus
//B cingulate sulcus
//C precental gyrus
//D cingulate gyrus

//#Q Which term refers to the cephalic disorder, characterised by absence of the celebral hemispheres?
//^ hydranencephaly
//A ethmocephaly
//B lissercephaly
//C anencephaly
//D hydranencephaly

//#Q Which of the following is not part of the group of brain-supplying arteries, known as the circle of Willis?
//^ basilar artery
//A anterior communication artery
//B basilar artery
//C internal carotid artery
//D posterior communication artery

//#Q There are twelve cranial nerves, two of which do not join the brainstem. Which are these two nerves?
//^ olfactory and optical
//A maxillary and mandibular
//B vagus and accessory
//C olfactory and optical
//D trigeminal and trochlear

//#Q This scientist, winner of the 1908 Nobel Prize in Physiology or Medicine, was the first to notice the existence of blood-brain barrier.
//^ Paul Ehrlich
//A Edwin Goldman
//B Dr.Marian Diamond
//C Walter Dandy
//D Paul Ehrlich

//#Q Which of the following is part of the brainstem, a stalk of the brain below the celebral hemispsheres?
//^ pons
//A neocortex
//B telecephanon
//C pons
//D hypothalamus

//#Q Fred Gage and Peter Ericksson discovered and announced that adult human brain produces new brain cells. In what year did they make their discovery?
//^ 1998
//A 1998
//B 1992
//C 1997
//D 2000

//#Q Which part of the brain, located inside the temporal lobe, is associated with memory formation?
//^ hippocampus
//A hippocampus
//B subthalamus
//C amygladala
//D hypothalamus

//#Q This evolutionary theory, proposed by the inimitable Stephen J. Gould and Niles Eldridge, argues that evolution occurs not gradually but rapidly after periods of stasis and in isolated, localized areas.
//^ Punctuated Equilibrium
//A Random Genetic Drift
//B Popcorn Evolution
//C Punctuated Equilibrium
//D Natural Selection

//#Q This three million year old skeleton known as “Lucy” was discovered in 1974 and is almost 40% complete. Lucy was a small, chimp-like hominid but walked upright like modern humans. She is a member of this species.
//^ Australopithecus Afarensis
//A Homo Floresiensis
//B Australopithecus Afarensis
//C Peking Woman
//D Homo Ergaster

//#Q What is the total collection of traits that determine the physical and behavioral aspects of an organism called?
//^ Phenotype
//A Alleles
//B Phenotype
//C DNA Markers
//D Genotype

//#Q In 1912, a jawbone and fragments of a skull were discovered and originally named “dawn-man”.  It wasn’t until 41 years later that it was exposed as a hoax. This darling of creationist skepticism is known as what?
//^ Piltdown Man
//A Neanderthal
//B Hobbit Man
//C Peking Man
//D Piltdown Man

//#Q Prior to Darwin’s theory, the most influential line of thought regarding the variety of life forms was a creationist doctrine that likened the biological functions in an organism to the intricate workings of a watch. Which Christian apologist put forth the “Watchmaker Analogy?
//^ William Paley
//A William Paley
//B Sir Richard Dawkins
//C William Henry Green
//D John Law

//#Q The evolutionary process where beneficial inherited traits become more prevalent in the succeeding generations of organisms, and unfavorable ones less common, is called what?
//^ Natural Selection
//A Natural Selection
//B Random Genetic Drift
//C Gene Flow
//D Macro Evolution

//#Q This monastic egghead pioneered the study of genetics, which eventually explained the mechanisms of speciation through genetic mutation. Who is the “father of modern genetics?”
//^ Gregor Mendel
//A James Watson
//B Gregor Mendel
//C Jean-Baptiste Lamarck
//D Francis Crick

//#Q The “peppered moth” is a prime example of micro evolution, where the moth’s color changed over a span of 200 years to match the soot-darkened trunks of the trees it inhabits. The darker moths survived because they were less conspicuous than their white counterparts to the birds that preyed on them.  What is the term associated with the coloration change demonstrated in the peppered moth?
//^ Industrial Melanism
//A Industrial Melanism
//B Revolutionary Adaptation
//C Natural Pigmentism
//D Genetic Blackening

//#Q This animals evolutionary lineage is the best documented and the most clearly understood.
//^ Horse
//A Human
//B Horse
//C Dog
//D Shark

//#Q During his famous voyage to the Galapagos Islands, Charles Darwin studied differences in a specific animal’s anatomy, his observations setting the stage for his eventual theory of evolution. What animal’s anatomy did Darwin study?
//^ Finch beaks
//A Mockingbird talons
//B Monkey paws
//C Finch beaks
//D Iguana tails

//#Q Which of these is an output device that produces audible sound?
//^ Speaker
//A Printer
//B Microphone
//C Speaker
//D Monitor

//#Q A modem is both an input and an output device.
//^ True
//A False
//B True

//#Q A flatbed scanner enables users to put a text or a computer-generated image on paper or on another medium, such as a transparency.
//^ False
//A False
//B True

//#Q Keyboards are used for the input of text and characters.
//^ True
//A True
//B False

//#Q A printer is an input device used to scan photos, pictures, texts and other printed material.
//^ False
//A False
//B True

//#Q In trigonometry, the tangent is defined as what?
//^ The sine divided by the cosine
//A The ratio of the side adjacent to the angle to the side opposite the angle
//B The reciprocal of the cosine
//C The sine divided by the cosine
//D The negative logarithm of the cotangent

//#Q In geometry, which angles are called opposite?
//^ Equal angles
//A Angles complements of each other
//B Angles reciprocals of each other
//C Angles supplements of each other
//D Equal angles

//#Q What does the equation y = mx + b represent?
//^ A line
//A A hyperbola
//B A line
//C A parabola
//D A circle

//#Q Which of these represents the locus of points, the sum of whose distances from two given points is equal?
//^ An ellipse
//A An ellipse
//B A parabola
//C A circle
//D A hyperbola

//#Q If you are solving a word problem for 2 unknowns, how many equations will you need?
//^ 2
//A 3
//B 4
//C 1
//D 2

//#Q What is the path taken by a bullet fired from a rifle into the air (ignoring friction)?
//^ A parabola
//A A straight line
//B A logarithmic line
//C An exponential line
//D A parabola

//#Q Choose the statement which best describes the Pythagorean Theorem.
//^ The square of the hypotenuse of a right triangle equals the sum of the squares of the other two sides.
//A The hare will never catch up to the tortoise.
//B Parallel lines do not intersect.
//C There exist no whole numbers a, b and c for which the sum of the cubes of a and b equals the cube of c.
//D The square of the hypotenuse of a right triangle equals the sum of the squares of the other two sides.

//#Q Which of the following statements about quadrilaterals (4-sided figures) is true?
//^ A square is a type of parallelogram.
//A A parallelogram is a type of trapezoid.
//B A rhombus is a type of rectangle.
//C A rectangle is a type of square.
//D A square is a type of parallelogram.

//#Q In geometry, what is the value of the number which is represented by the Greek letter pi (π)?
//^ The ratio of the circumference of a circle to its diameter
//A The ratio of the circumference of a circle to its radius
//B The ratio of the circumference of a circle to its diameter
//C The ratio of the diameter of a circle to its radius
//D Exactly 3.14159

//#Q Which of the following is an arithmetic progression?
//^ 2, 4, 6, 8...
//A 1, 1, 2, 3, 5...
//B 2, 4, 8, 16...
//C 1, 2, 3, 5, 7, 11...
//D 2, 4, 6, 8...

//#Q Because of the lack of atmosphere, the craters on most celestial bodies from the solar system remain preserved for hundreds of millions or billions of years. The largest known crater within the solar system is located on which natural satellite?
//^ The Moon
//A The Moon
//B Titan
//C Deimos
//D Io

//#Q Larger than Pluto and Mercury, this natural satellite is the largest moon of the entire solar system.
//^ Ganymede
//A Titan
//B Callisto
//C Ganymede
//D Europa

//#Q Which is the planet with the biggest number of natural satellites in the solar system?
//^ Jupiter
//A Uranus
//B Neptune
//C Jupiter
//D Saturn

//#Q Which of these characteristics makes Saturns moon Titan unique among all moons in the solar system?
//^ It is the only moon to have a dense atmosphere.
//A It is the only moon that is considered a captured object.
//B It is the only moon with active volcanoes on its surface.
//C It is the only moon to have a retrograde orbit.
//D It is the only moon to have a dense atmosphere.

//#Q There have been numerous debates over whether this moon, discovered in 1978, should be considered a satellite or a separate planet.
//^ Charon
//A Nereid
//B Nix
//C Umbriel
//D Charon

//#Q Which of the four Galilean moons of Jupiter is noted as the most volcanically active body in the solar system?
//^ Io
//A Europa
//B Io
//C Callisto
//D Ganymede

//#Q Named after the leading sylph in Alexander Popes poem Rape of the Lock, the moon Ariel is the natural satellite of which planet of the solar system?
//^ Uranus
//A Jupiter
//B Uranus
//C Neptune
//D Saturn

//#Q This celestial body is the darkest of Uranus larger moons and its most distinctive feature is a large equatorial ring of bright material (supposedly a crater) named Wunda, which contrasts with the rest of the planet’s dark surface.
//^ Umbriel
//A Umbriel
//B Oberon
//C Titania
//D Ariel

//#Q What is the symbol for Hydrogen?
//^ H
//A Hy
//B Hr
//C H
//D Hd

//#Q What is the symbol for Nickel?
//^ Ni
//A N
//B Nc
//C Nk
//D Ni

//#Q What is the symbol for Krypton?
//^ Kr
//A Kp
//B K
//C Ky
//D Kr

//#Q What is the symbol for Boron?
//^ B
//A Bo
//B Bn
//C Br
//D B

//#Q What is the symbol for Neon?
//^ Ne
//A No
//B Nn
//C Ne
//D N

//#Q What is the symbol for Sulfur?
//^ S
//A Sf
//B Su
//C S
//D Sl

//#Q What is the symbol for Bismuth?
//^ Bi
//A Bs
//B B
//C Bi
//D Bm

//#Q What is the symbol for Platinum?
//^ Pt
//A Pt
//B Pl
//C P
//D Pa

//#Q What is the symbol for Cadmium?
//^ Cd
//A Cm
//B Cd
//C C
//D Ca

//#Q What is the symbol for Ruthenium?
//^ Ru
//A R
//B Rh
//C Ru
//D Rt

//#Q Which branch of botany is concerned with the study of trees and woody plants?
//^ Dendrology
//A Forestology
//B Topiary
//C Dendrology
//D Arboretology

//#Q The earliest trees on the planet were a type of ferns and are considered to have appeared in which period of Earths geological history?
//^ Paleozoic
//A Paleozoic
//B Cenozoic
//C Precambrian
//D Mesozoic

//#Q The botanical term bonsai, deriving from Japanese, refers to which of these?
//^ A technique for miniature growing trees
//A A technique for miniature growing trees
//B A species of miniature trees
//C A type of fertilizer that reduces the size of trees
//D A region in Japan where miniature trees grow

//#Q The baobab, a genus of trees typical for arid areas, is known to be used by Indigenous Australians as a source of water, food and medical remedy. In the 1890s however, a large, hollow baobab located near Derby, Western Australia was adapted for what usage?
//^ Prison
//A Prison
//B Town hall
//C Kindergarten
//D Warehouse

//#Q Mark the incorrect statement about sequoias, which are among the largest and oldest trees on the planet.
//^ Sequoias can reach up to 150 m (490 ft) in height.
//A Sequoias are evergreen trees.
//B Sequoias are monoecious trees.
//C Sequoias can reach up to 150 m(490 ft) in height.
//D Sequoias can live for more than 2000 years.

//#Q The Bodhi tree, located near Bodh Gaya in India, is of great importance to the followers of Buddhism, because it is considered to be related to the spiritual teacher, Buddha, in what way?
//^ Buddha found enlightenment under this tree.
//A Buddha died under this tree.
//B God Vishnu spoke to him for the first time under this tree.
//C It is Buddhas birth place.
//D Buddha found enlightenment under this tree.

//#Q The General Grant tree in Kings Canyon National Park, USA, the only living object to be declared a National Shrine, is of what tree species?
//^ Giant Sequoia
//A American Beech
//B Red Pine
//C White Oak
//D Giant Sequoia

//#Q Methuselah, a Great Basin Bristlecone tree located in the Inyo National Forest in California, is remarkable for what reason?
//^ It is the oldest known living organism.
//A It is the most publicized living organism.
//B It is the tallest known living organism.
//C It is the oldest known living organism.
//D It is the largest living organism.

//#Q In the city of Athens, Georgia, USA , there is a White Oak tree with more rights than any other tree.  What is so special about this tree?
//^ It owns itself.
//A Touching it is against the law.
//B It owns itself.
//C It owns a human being.
//D It has the right to vote.

//#Q The Diamond Tree, a giant Karri tree located south of Manjimup, Western Australia, has been of practical use to the natives since 1939, serving as what?
//^ Fire look-out platform
//A Fire look-out platform
//B Accommodation for native homeless
//C Military watch tower
//D Warehouse

//#Q Excavations and research prove that pi was known as early as 20th century BC, when ancient Babylonian mathematicians used what value value for it?
//^ 25/8
//A 104348/33215
//B 22/7
//C 3.12
//D 25/8

//#Q The sequence of numbers, appearing within pis value has been an issue of interest for many professional mathematicians and math lovers. Such pi explorers have found that what occurs at decimal position 2440?
//^ We get the first appearance of  666.
//A We reach the last decimal place to which our largest computers can calculate pi.
//B We reach the last decimal place where computer ENIAC calculated pi in 1949.
//C We reach the extent to which pi was known by 1750.
//D We get the first appearance of  666.

//#Q The irrational mathematical constant, Pi has its own architectural monument in London, which was decorated with William Shanks version of the first 700 decimal places in 1937.
//^ False
//A False
//B True

//#Q After years of calculations and observations of the results, mathematicians have found which of these statements about the mathematical constant pi to be true?
//^ The digits of pi are equally distributed.
//A The digits of pi eventually reach a point where they repeat their pattern.
//B The digits of pi are equally distributed.
//C The number of 3s is larger than any other digit in pi.
//D The number of 5s is larger than any other digit in pi.

//#Q Pi is an issue of interest for mathematicians and math lovers from all over the world. In Japanese, what does the expression En syu ritsu refer to?
//^ The Japanese term for pi
//A Mitsubishis motto for the quest for finding better values of pi
//B The largest computer in Japan used for finding even greater values for pi
//C The Japanese term for an infinite number
//D The Japanese term for pi

//#Q In what famous math problem, first posed in the 18th century by a French mathematician, is pi involved?
//^ Buffons Needle Problem
//A Buffons Needle Problem
//B The travelling salesman problem
//C Zenos Paradox of the Tortoise
//D Zenos Paradox of Achilles

//#Q The mathematical constant Pi has an important role in calculating the period of a pendulum.
//^ True
//A False
//B True

//#Q Who was first to prove that beside an irrational number, pi is also transcendental number (i.e. is not a root to any polynomial equation with rational coefficients)?
//^ Ferdinand von Lindemann
//A Archimedes
//B Leonhard Euler
//C Augustin Cauchy
//D Ferdinand von Lindemann

//#Q The irrational constant pi is not only popular in the math science, but also in science fiction. Which of these TV series has an episode, in which pi plays a significant role?
//^ Star Trek
//A Lost in Space
//B Firefly
//C Star Trek
//D The X-Files

//#Q In what way is this popular sentence connected to the constant, pi: Sir, I send a rhyme excelling in sacred truth and rigid spelling.
//^ It is a mnemonic device for the approximate value of pi.
//A The value of pi is encoded in the position of each letter in the alphabet.
//B It is a mnemonic device for the approximate value of pi.
//C It is the beginning of a long poem describing the history of pi.
//D It was written by Albert Einstein when he first discovered the irrationality of pi.

//#Q Which programming language is based on Horn clauses?
//^ Prolog
//A Erlang
//B Lisp
//C PL/I
//D Prolog

//#Q What was the maximum amount of memory that could be installed on the 1975 PDP-11/70, one of the most powerful of the popular PDP-11 series, produced by Digital Equipment Corporation?
//^ 4 MB
//A 512 KB
//B 4 MB
//C 16 MB
//D 64 MB

//#Q In 1936 Alan Turing described the a-machine (later renamed Turing Machine) as a device that can simulate the logic of a computer.
//^ True
//A False
//B True

//#Q The fundamental book The C Programming Language was written in 1978 by BWK and what other computer scientist?
//^ DMR
//A DRM
//B DMR
//C MDR
//D RMD

//#Q The program components named coroutines generalize the widely known subroutines by allowing multiple return values.
//^ False
//A True
//B False

//#Q The halting problem computability theory was solved in what year?
//^ It cannot be solved for all possible cases.
//A It cannot be solved for all possible cases.
//B 1937
//C 1956
//D 1980

//#Q The water cycle is the continuous movement of water above and below the surface of the planet. What is this process also known as?
//^ Hydrologic cycle
//A Hydroscopic cycle
//B Hydrologic cycle
//C Hydrographic cycle
//D Hydrodynamic cycle

//#Q Which of effect of these is the main reason for the existence of the water cycle on Earth?
//^ The Sun
//A Thermal energy in the Earths core
//B Gravitational forces
//C The Moon
//D The Sun

//#Q Water can be found in three main states on Earth. Which of the following is not one of them?
//^ Crystal
//A Ice
//B Liquid
//C Crystal
//D Vapor

//#Q Which of these is not one of the state-changing processes through which water goes in nature?
//^ Concentration
//A Concentration
//B Condensation
//C Precipitation
//D Sublimation

//#Q Evapotranspiration is a term connected to which of these groups?
//^ Plants
//A Plants
//B Animals
//C Water basins
//D Rocks

//#Q Which of the following is not possible to happen to water in its different states?
//^ All of these are possible
//A Vapor to condense into clouds
//B Ice to sublimate into water vapor
//C Snow to sublimate into water vapor
//D All of these are possible

//#Q Which line contains only types of precipitation?
//^ Graupel, sleet, snow, hail
//A Snow, vapor, fog drip, hail
//B Rain, fog drip, runoff, sleet
//C Graupel, sleet, snow, hail
//D Snow, ice, hail, rain

//#Q On which of these factors does the total amount of water on Earth at a certain moment depend?
//^ None of these
//A None of these
//B Time of the day
//C Distance from the Sun
//D Season

//#Q Ice caps and glaciers are the second largest water reservoirs on Earth after oceans. What percent of the planet’s water do they hold?
//^ 2 %
//A 18 %
//B 10 %
//C 2 %
//D 5 %

//#Q What would be the Earth like without evaporation?
//^ Warmer
//A Cooler
//B None of these
//C Greener
//D Warmer

//#Q How many people die of air pollution around the world each year?
//^ 3 million
//A 500,000
//B 50,000
//C 1 million
//D 3 million

//#Q This pollutant causes inflammation of the lungs, impaired breathing, coughing, chest pain, nausea, and throat irritation and permanent damage to lung tissue in long term exposure.
//^ Smog
//A Smog
//B Greenhouse gas
//C Carbon dioxide
//D Ozone

//#Q This gas is produced mainly by automobiles. It hiders the bodys ability to carry oxygen in the blood, causing serious problems for people with cardiovascular diseases.
//^ Carbon monoxide
//A Acid sulfates
//B Carbon oxide
//C Carbon monoxide
//D Carbon dioxide

//#Q This type of pollutant causes acidification of rivers, lakes and also damages tree foliage and degrades soil quality.
//^ Acid rain
//A Acid rain
//B The melting of the poles
//C The Ozone hole
//D Global warming

//#Q Pollution has damaged this great Chinese ancient attraction and it continues to disintegrate.
//^ The Terracotta Warriors
//A The Terracotta Warriors
//B The Forbidden City
//C Tiananmen Square
//D The Great Wall

//#Q Modern cars pollute much less than cars did in the 60s. Today, it takes this many modern cars to produce the same amount of air pollution as a car from the 60s.
//^ 20
//A 20
//B 5
//C 10
//D 35

//#Q When burning fuel for energy, small particles are thrown into the air that are visible in the form of smoke.  It is called this type of pollution.
//^ Black carbon pollution
//A Outdoor pollution
//B Water pollution
//C Indoor pollution
//D Black carbon pollution

//#Q The average temperature around the world has climbed during the previous century due to global warming by this much.
//^ 1 degree Fahrenheit
//A 3 degrees Fahrenheit
//B 4 degrees Fahrenheit
//C 1 degree Fahrenheit
//D 2 degrees Fahrenheit

//#Q This defect of Earths atmosphere, caused by industrial pollution, lets more radiation reach the surface of our planet.
//^ The Ozone Hole
//A The Greenhouse Hole
//B The Smoke Hole
//C The Ozone Hole
//D Smog Tear

//#Q The distribution of this substance into water is often deadly for seabirds as it destroys the structure of its feathers.  Thus cold water quickly reaches the skin and the bird often freezes to death.
//^ Oil
//A Carbon dioxide
//B Carbon monoxide
//C Oil
//D Pesticides

//#Q Osteology is an important part of physical and forensic anthropology. What does an osteologist study?
//^ bones
//A skulls
//B blood
//C dead bodies
//D bones

//#Q What does a philologist study?
//^ language
//A signs and  symbols
//B art
//C detectives
//D language

//#Q What does a cetologist study?
//^ whales
//A wine
//B words
//C art
//D whales

//#Q Which word means the study of drug action?
//^ pharmacology
//A enology
//B pharmacology
//C chirology
//D physiognosy

//#Q If you studied petrology, where would your interests lie?
//^ rocks
//A petroleum
//B microbes
//C rocks
//D veins

//#Q Which of these is the study of cells?
//^ cytology
//A protozoology
//B cellogy
//C cytology
//D ecology

//#Q Which of these is the study of knowledge?
//^ epistimology
//A rheology
//B epistimology
//C pulicology
//D dialitology

//#Q Which of these is the study of Mars?
//^ areology
//A areology
//B ombrology
//C marsology
//D astrolgelogy

//#Q What does an auxologist study?
//^ growth
//A money
//B growth
//C flags
//D meteorites

//#Q Which is the correct pairing?
//^ oneirology - the study of dreams
//A symbology - the study of percussion instruments
//B oncology - the study of microbes
//C graminology - the study of grammar
//D oneirology - the study of dreams

//#Q Which ancient Greek historian is considered the Father of History?
//^ Herodotus
//A Socrates
//B Plato
//C Herodotus
//D Demitrios

//#Q Because of introducing a classification scheme for distinguishing living organisms, Carolus Linnaeus is known as the father of what field of science?
//^ Taxonomy
//A Zoology
//B Palentology
//C Botany
//D Taxonomy

//#Q This person is considered as the Father of Computer, as he invented a counting machine called The Difference Engine.
//^ Charles Babbage
//A John Vincent Atanasoff
//B Blaise Pascal
//C Charles Babbage
//D Argani Alunan

//#Q Who is regarded as the Father of Mathematics?
//^ Archimedes
//A Euclid
//B Ernest Rutherford
//C Archimedes
//D Rene Descartes

//#Q Edgar Allan Poe is known to be the father of detective stories. What was he often characterized as?
//^ Alcoholic
//A Womanizer
//B Homosexual
//C Melancholic
//D Alcoholic

//#Q Myorrhexis is a very painful condition and can occur when you overexert. What is characteristic of this condition?
//^ Rupture or tearing of a muscle.
//A Softening of a bone.
//B A vertebra is out of its joint or is dislocated
//C Rupture or tearing of a muscle.
//D Degeneration of cartilage.

//#Q What is the medical term for a nosebleed?
//^ Rhinorrhagia
//A Rhinorrhagia
//B Rhinitis
//C Rhinomycosis
//D Rhinodynia

//#Q The endocrine system is made up of glands. Aden(o) means glands; adren(o) means the adrenal glands. What term means enlargement of the adrenal glands?
//^ Adrenomegaly
//A Adrenalitis
//B Adrenomegaly
//C Adrenotoxin
//D Adrenopathy

//#Q What is the closest point to the sun in the Earths orbit called?
//^ Perihelion
//A Aphelion
//B Summer Solstice
//C Autumnal Equinox
//D Perihelion

//#Q The moon orbits eastward around the Earth.
//^ True
//A False
//B True

//#Q During a new moon phase, is the moon visible?
//^ No
//A No
//B Yes

//#Q During which lunar phase is the moon least visible?
//^ Waxing Crescent
//A First Quarter
//B Full Moon
//C Waxing Crescent
//D Waxing Gibbous

//#Q Did Galileo Galilei invent the first telescope?
//^ No
//A Yes
//B No

//#Q When was the Hubble Space Telescope put into orbit by the Space Shuttle?
//^ 1990
//A 1991
//B 1992
//C 1990
//D 1993

//#Q The stars remain in the sky during the day.
//^ True
//A True
//B False

//#Q During  first quarter moon, what time does the moon rise?
//^ noon
//A dawn
//B midnight
//C noon
//D sunset

//#Q What unit in the metric system do astronomers use to measure the wavelength of light?
//^ nanometer
//A nanometer
//B eccentricity
//C photon
//D equant

//#Q In order to be classified as a Category 5 hurricane, the storm must have what winds speeds?
//^ 155mph
//A 135mph
//B 125mph
//C 145mph
//D 155mph

//#Q About how many lightning bolts strike the Earth each second?
//^ 100
//A 1,500
//B 100
//C 1,000
//D 3,000

//#Q This construction in the United States is struck by lightning around 500 times a year.
//^ Empire State Building
//A Pentagon
//B Statue of Liberty
//C Empire State Building
//D Golden Gate Bridge

//#Q Warm weather brings high pressure systems.
//^ False
//A False
//B True

//#Q Who created the Fujita scale in the late 1960s?
//^ Theodore Fujita
//A Patrick Fujita
//B Calvin Fujita
//C Theodore Fujita
//D Alvin Fujita

//#Q Its the middle of July. You are in Louisville, KY, USA and you cross over the Ohio River into Jeffersonville, IN. You have effectively gone:
//^ Backwards in Time
//A Forward in Time
//B Time Stands Still
//C Backwards in Time
//D You have broken the time continuum

//#Q In the summer months, a clock located in Indianapolis, IN, USA will show a different time than a clock located in Paducah, KY.
//^ False
//A True
//B False

//#Q A worker at a Riverboat Casino in Ohio near Cincinnati gets off the late shift at 12 Midnight, and arrives home in Indiana at Midnight. This worker lives about an hour away. Is this possible?
//^ Yes
//A No
//B Yes

//#Q Youre crossing Hoover Dam from Nevada into Arizona (USA) during the Winter months (after Oct 31st).  Will you change Time Zones?
//^ Yes
//A No
//B Yes

//#Q You live in Ossining, NY, USA  and you call your friend in Honolulu, Hawaii. Its the month of May. How many hours time difference are there between these 2 locales?
//^ 6 Hours Difference
//A 6 Hours Difference
//B 4 Hours Difference
//C 3 Hours Difference
//D 5 Hours Difference

//#Q Referring to the previous question, if its 6:00 P.M. in Ossining, NY, what time is it in Honolulu, Hawaii?
//^ 12 Noon
//A 3:00 PM
//B 12 Midnight
//C 12 Noon
//D Time to surf, Brah!

//#Q Its your Birthday, and youre in Tokyo. Later that calendar day, you board a flight for Los Angeles. Will you be able to celebrate your birthday twice?
//^ Yes
//A Yes
//B No

//#Q The state of Tennessee, USA has 2 Time Zones.
//^ True
//A True
//B False

//#Q A flight attendant lands at OHare Airport in Chicago, in the winter months, and drives to Gary, Indiana. Will he or she have to reset his/ her watch upon arrival in Gary?
//^ No
//A No
//B Yes

//#Q Which of the following fast food meals has the most calories?
//^ Subways 12 inch Double Meat Classic Tuna Sub on white
//A McDonalds Chicken Selects Premium Breast Strips (10 pc)
//B Subways 12 inch Double Meat Classic Tuna Sub on white
//C KFCs Popcorn Chicken - Family
//D McDonalds Deluxe Breakfast

//#Q Subways 12-inch Cold Cut Combo Sub on white bread is higher in calories, fats and carbohydrates then Hardees Big Roast Beef.
//^ True
//A False
//B True

//#Q Which of the following meals is the best source of fibers?
//^ Arbys Market Fresh Ultimate BLT Wrap
//A Arbys Market Fresh Ultimate BLT Wrap
//B Subway Chicken Bacon Ranch Wrap (with cheese)
//C Wendys Crispy Chicken Nuggets (5 pieces)
//D Taco Bell Fiesta Taco Salad

//#Q Blimpie’s Best 12-inch Sub on wheat is higher in total calories, carbohydrates, and fats than a McDonalds Big Mac.
//^ True
//A True
//B False

//#Q Which of the following fast food items provides the consumer with the greatest amount of calories from fat?
//^ Dominos Garlic Sauce
//A Whopper Jr. With Cheese
//B Dominos Garlic Sauce
//C Hardees 1/3 LB Mushroom and Swiss Thickburger
//D Taco Bell Nachos BellGrande

//#Q Hardees medium sized Strawberry Shake (Hand-dipped) is higher in fats and total calories than Wendys medium sized Frosty Dairy Dessert.
//^ False
//A False
//B True

//#Q Which of these salads has the lowest amount of carbohydrates and sugar?
//^ Burger King Fire-Grilled Chicken Caesar Salad
//A Wendys Chicken BLT Salad
//B Burger King Fire-Grilled Chicken Caesar Salad
//C Arbys Market Fresh Santa Fe Salad
//D Taco Bell Fiesta Taco Salad

//#Q One slice (139g) of Dominos Classic Hand Tossed Veggie Feast pizza has more calories than Arbys Ham Biscuit (Breakfast Sandwich).
//^ True
//A False
//B True

//#Q Which of the following sauces provides the highest percent of calories from fat?
//^ Arbys Light Mayonnaise Packet
//A Burger Kings Honey Flavored Dipping Sauce
//B Hardees Pancake Syrup
//C McDonalds Barbeque Sauce
//D Arbys Light Mayonnaise Packet

//#Q The number of total calories, carbohydrates, fats, and sodium per serving is reported to be highest in which of the following meals?
//^ Hardees Kids Meal - Slammers
//A Burger King WHOPPER JR.
//B Hardees Kids Meal - Slammers
//C McDonalds Cheeseburger
//D Wendys Jr. Hamburger

//#Q Silver and gold are in the same group on the periodic table. What group are they in and what are their atomic symbols, respectively?
//^ Group 11, Ag and Au
//A Group 12, Ag and Au
//B Group 14, Au and Ag
//C Group 13, Au and Ag
//D Group 11, Ag and Au

//#Q Inert gases are found in Group 18 of the Periodic Table. Which is the inert gas with atomic number 54?
//^ Xe
//A Rn
//B Xe
//C Kr
//D Ar

//#Q Lanthanoids and actinoids are not included with the rest of the periodic table for convenience. Which series of elements are found in these two series, respectively?
//^ La - Yb, Ac - No
//A Ba - Lu, Ra - Lr
//B La - Yb, Ac - No
//C La - Ac, Ac - Lu
//D Fr - La, Cs - Ac

//#Q Which element was NOT discovered at the University of California in Berkeley, CA, USA?
//^ Yb
//A Es
//B Fm
//C Cf
//D Yb

//#Q The element with the symbol Sg is named after an American nuclear chemist and Nobel prize winner, Glenn T. Seaborg.
//^ True
//A False
//B True

//#Q This element was discovered in 1825 by Hans Christian Oersted and is used in the production of cans for soft drink.
//^ Al
//A Ai
//B Am
//C An
//D Al

//#Q The mathematical constant e, one of the most important numbers in mathematics, is equal to which of these fractions?
//^ none of these
//A 22/7
//B 278/10
//C 271828/10000
//D none of these

//#Q Which of these statements best describes the mathematical constant  e?
//^ It is a transcendental and irrational number.
//A It is a transcendental number.
//B It is an algebraic transcendental and irrational number.
//C It is a transcendental and irrational number.
//D It is a rational transcendental number.

//#Q Why was the letter e” chosen to denote the important mathematical constant e?
//^ It stands for exponential.
//A It was arbitrarily chosen by Latin scholars.
//B Its the first letter of a mathematicians name.
//C It stands for exponential.
//D The first 4 letters of the alphabet were already taken.

//#Q e^(pi*i) +1 = 0 is an important formula, involving the key mathematical constant e, which is popularly known as what?
//^ Eulers Equation
//A Eulers Equation
//B Einsteins Equation
//C The Hyperbolic Cosine Law
//D Newtons Equation

//#Q The constant e is present in countless fields of mathematics but its most significant function is related to its use in what?
//^ The base of natural logarithms
//A The characteristics of unitary matrices
//B The base of natural logarithms
//C The mantissa of common logarithms
//D The limiting value of the sum of the squares of the odd numbers

//#Q What significant discovery about the nature of the constant e did French mathematician Charles Hermite make in 1873?
//^ e is transcendental.
//A e is algebraic.
//B e is transcendental.
//C e^pi is transcendental.
//D e is irrational

//#Q What is the derivative of y in this function related to the exponential constant e: If y=e^x?
//^ e^x
//A e^x
//B e^x +x
//C e^pi
//D e

//#Q In Roman numerals, what is the symbol for 1000?
//^ M
//A L
//B M
//C C
//D D

//#Q Change the Roman numeral XL to a Hindu-Arabic numeral.
//^ 40
//A 40
//B 70
//C 50
//D 60

//#Q Identify the property used in this addition equation: 678 + 45 = 45 + 678.
//^ Commutative property
//A Associative property
//B Distributive property
//C Identity property
//D Commutative property

//#Q Which is the mathematical property used in this addition equation: (57 + 63) + 14 = 57 + (63 + 14)?
//^ Associative property
//A Commutative property
//B Distributive Property
//C Associative property
//D Identity Property

//#Q What is the name of the property used in this addition equation: 12 + 0 = 12?
//^ Identity property
//A Associative property
//B Distributive property
//C Commutative property
//D Identity property

//#Q What is the greatest common factor (GCF) of 24 and 36?
//^ 12
//A 16
//B 12
//C 6
//D 14

//#Q What is the least common multiple (LCM) of 5, 6, and 10?
//^ 30
//A 20
//B 30
//C 10
//D 15

//#Q What kind of fractions are 4/4, 9/8, and 7/4?
//^ Improper fractions
//A Proper fractions
//B Improper fractions
//C Similar fractions
//D Dissimilar fractions

//#Q Which of these are considered the two developers of the modern calculus?
//^ Newton and Leibnitz
//A Newton and Gauss
//B Euler and Cauchy
//C Newton and Euler
//D Newton and Leibnitz

//#Q What are the two basic processes in calculus?
//^ Integration and derivation
//A Finding maxima and minima and solving second degree equations
//B Composition and convolution
//C Integration and derivation
//D Solving equations of sixth and seventh degrees

//#Q When we find the extrema of a function we use this.
//^ The first derivative
//A The solution of the sixth degree equation
//B The solution of the second degree equation
//C The first derivative
//D The third derivative

//#Q Which statement is not  true about functions?
//^ A function is always written as a polynomial.
//A For some functions we can not find a maximal value.
//B A function is always written as a polynomial.
//C A function is a type of relationship between two sets.
//D A one-to-one relationship is a type of function.

//#Q When you study calculus, you usually also study this branch of geometry.
//^ Analytic geometry
//A Bolyai geometry
//B Discrete geometry
//C Analytic geometry
//D Riemannian geometry

//#Q In calculus we never use complex (or imaginary) numbers.
//^ False
//A False
//B True

//#Q Consider this infinite series: 1/2+1/4+1/8+1/16+1/32 +.... If we add all these terms, what do we get?
//^ 1
//A 3/4
//B You cannot add an infinite series of numbers
//C 0
//D 1

//#Q After the proof of a mathematical theorem we often see the letters Q.E.D. Do these letters stand for Quite easily Done.?
//^ No
//A Yes
//B No

//#Q What is the minimum value of the function y= x^2+3x-1?
//^ -13 / 4
//A 13 / 4
//B - 13 / 4
//C - 3 / 2
//D 3 / 2

//#Q Guess the missing number from the following sequence: 3,6,7,14,15 ___, 31,62, 63. 126, 127.
//^ 30
//A 30
//B 17
//C 16
//D 28

//#Q What is the missing number in the following sequence:  4, 20, 24, ___, 44, 60, 64?
//^ 40
//A 28
//B 40
//C 30
//D 32

//#Q What number is missing from the following sequence:  5,10,20, ___, 50, 55, 110?
//^ 25
//A 25
//B 30
//C 40
//D 35

//#Q Guess the missing number from the following sequence: 12, 24, 48, ___, 120, 240, 264?
//^ 96
//A 80
//B 60
//C 96
//D 72

//#Q Find the missing number in the following sequence: 6, 18, 36, ___, 216, 648, 1296.
//^ 108
//A 108
//B 180
//C 72
//D 54

//#Q Find the missing number in the following sequence: 11, 16, 32, ___, 74, 79, 158.
//^ 37
//A 64
//B 38
//C 37
//D 69

//#Q Guess the missing number in the following sequence: 15, 30, 40, ___, 90, 180, 190.
//^ 80
//A 55
//B 45
//C 50
//D 80

//#Q Find the missing number in the following sequence:  8, 16, 28, 44, ___, 88, 116, 148, 184.
//^ 64
//A 48
//B 56
//C 64
//D 52

//#Q Guess the missing number in the following sequence: 3, 6, 18, 36, ___, 216, 234, 468, 1404.
//^ 72
//A 108
//B 54
//C 72
//D 39

//#Q Find the missing number in the following sequence: 10, 20, 100, ___, 280, 560, 640.
//^ 200
//A 110
//B 200
//C 180
//D 270

//#Q The term clone, originally used in botany before it entered molecular genetics, means what in Greek?
//^ Twig
//A Twin
//B Copy
//C Root
//D Twig

//#Q Cloning, the process of creating an identical copy of an organism, is only attainable by artificial means.
//^ False
//A False
//B True

//#Q Which of the following statements about the process of cloning is not true?
//^ Cloning produces a completely identical copy of an organism.
//A Scientists use more than one method for cloning.
//B Cloning can be used therapeutically, to create replacement organs or tissue.
//C Cloning could be theoretically used to bring extinct species back to life
//D Cloning produces a completely identical copy of an organism.

//#Q How many unsuccessful attempts did it take to finally create Dolly, the first successfully cloned mammal?
//^ 276
//A 76
//B 276
//C 19
//D 154

//#Q Prometea, an example of successfully cloned mammal, was what type of animal?
//^ Horse
//A Cat
//B Pig
//C Rabbit
//D Horse

//#Q The first successful experiment in which a cloned animal embryo reached an adult state, was carried out in what year?
//^ 1952
//A 1952
//B 1907
//C 1973
//D 1926

//#Q Substance vital for treating what hereditary blood defect that occurs almost exclusively in males, has been produced by cloning?
//^ Hemophilia
//A Anemia
//B Hemoglobinopaties
//C Hemophilia
//D Thalassemia

//#Q What prevents scientists from fulfilling one of science fiction writers dreams - to clone a dinosaur?
//^ The need for a mother from a closely related species
//A The lack of knowledge about their embryonal development
//B The need for a mother from a closely related species
//C The difference in environmental conditions now and then
//D Lack of live dinosaur tissue

//#Q Cloning and the boundless possibilities it offers is a challenging topic for scriptwriters imagination. All but one of these science fiction movies involve cloning in their plots.
//^ The Green Mile
//A Jurassic Park
//B The 6th Day
//C The Green Mile
//D The House of the Scorpion

//#Q Which of these can be defined as a clones biological mother and father?
//^ None of these
//A None of these
//B The egg cell donor and the surrogate mother
//C The egg cell donor and the surrogate mother
//D The genetic material donor and the egg cell donor

//#Q Who was the first person to orbit the Earth?
//^ Yuri Gagarin
//A Georgi Dobrovolski
//B Yuri Gagarin
//C Neil Armstrong
//D Kerim Kerimov

//#Q In 2005, this famous Russian cosmonaut set a record for total time, spent in space.
//^ Sergei Krikalev
//A Anatoly Solovyev
//B Sergei Krikalev
//C Valeriy Polyakov
//D Sergei Avdeyev

//#Q What is the name of the dog, that became the first earthling to enter orbit?
//^ Laika
//A Lisichka
//B Laika
//C Rover
//D Belka

//#Q In  April 28, 2001, this famous American multimillionaire became the first space tourist.
//^ Dennis Tito
//A Mark Shuttleworth
//B Charles Simonyi
//C Gregory Olsen
//D Dennis Tito

//#Q Which Russian astronaut became the first person to be married in space, while he was on the International Space Station?
//^ Yuri Malenchenko
//A Vladimir Dezhurov
//B Yuri Gidzenko
//C Sergei K.Krikalev
//D Yuri Malenchenko

//#Q The crew of which Apollo mission spent the longest time on the Lunar surface?
//^ Apollo 17
//A Apollo 9
//B Apollo 7
//C Apollo 12
//D Apollo 17

//#Q Along with Neil  Armstrong and Michael Collins, who was the third member of the Apollo 11 crew?
//^ Buzz Aldrin
//A James A.Lovell, Jr
//B William Anders
//C Fred Haise
//D Buzz Aldrin

//#Q Who was the pilot of SpaceShipOne, the spaceplane that completed the first privately funded human spaceflight?
//^ Mike Melvill
//A Mike Melvill
//B Peter Siebold
//C Doug Shane
//D Brian Binnie

//#Q What was nationality of Vladimir Remek - the first cosmonaut from a country other than the Soviet Union or the United States?
//^ Czechoslovak
//A Hungarian
//B Bulgarian
//C Czechoslovak
//D Pole

//#Q What was the name of the first monkey to go in outer space?
//^ Albert I
//A Albert I
//B Gordo
//C Sam
//D Bonny

//#Q In 1905, this British scientist suggested the word genetics to describe the study of inheritance.
//^ William Bateson
//A Hennig Brand
//B Karl Pearson
//C William Bateson
//D Adam Sedgwick

//#Q Chromatin, found in the nucleus of a cell, consists of a complex of Deoxyribonucleic acid (DNA), the gene-carrying molecule. Which of the following types of chromatin is rich in genes?
//^ euchromatin
//A heterochromatin
//B euchromatin
//C facultative heterochromatin
//D constitutive heterochromatin

//#Q Which of the following statements about the Deoxyribonucleic acid (DNA), the molecule of heredity, is correct?
//^ Its molecule is a double helix
//A Its molecule is a single - stranded
//B It encodes information from RNA
//C Its molecule is a double helix
//D It carries information to the Ribonucleic acid(RNA)

//#Q The entire hereditary information of an organism held in the Deoxyribonucleic acid (DNA), is defined by which term?
//^ genome
//A proteome
//B genome
//C cryptome
//D regulome

//#Q A chromosome is a very long piece of Deoxyribonucleic acid (DNA) which contains genes. Which term refers to the number of chromosomes per cell in a species?
//^ euploid number
//A monoploid number
//B euploid number
//C haploid number
//D aneuploid number

//#Q This genetic disorder is characterized by the premature fusion of the bones of the skull, which affects the shape of the head and face.
//^ Pfeiffer syndrome
//A Pfeiffer syndrome
//B Angelman syndrome
//C Joubert syndrome
//D Klinefelter syndrome

//#Q Genes are the units of heredity in living organisms. Variants of the same gene are known under what name?
//^ alleles
//A albumins
//B nucleotides
//C myosins
//D alleles

//#Q Deoxyribonucleic acid (DNA), the molecule of heredity, is doubled in what stage of cell division?
//^ S phase
//A G2 phase
//B S phase
//C M phase
//D G1 phase

//#Q This cell structure exists only when the long pieces of Deoxyribonucleic acid (DNA), called chromosomes, replicate themselves.
//^ chromatid
//A flagelle
//B chromatid
//C centrosome
//D microtubule

//#Q This chemical element has a smell similar to garlic and is part of the structure of Deoxyribonucleic acid (DNA), the molecule that carries genes.
//^ phosphorus
//A iodine
//B sulfur
//C potassium
//D phosphorus

//#Q A card is selected at random from a regular poker deck of cards. The  jokers have been eliminated. What is the probability that the selected card is a diamond?
//^ 1 in  4
//A 1 in  4
//B 1 in 13
//C 1 in 26
//D 1 in 52

//#Q Two cards are randomly selected from a regular 52-card deck. What are the odds that they are both red?
//^ 25 out of 102
//A 1 in 4
//B 25 out of 102
//C 1 in 2
//D 1 in 26

//#Q What are  the odds that you will be killed by lightning in the USA?
//^ 2, 320, 000 to 1
//A 360, 200, 000 to1
//B 2, 320, 000 to 1
//C 23, 200, 000 to 1
//D 506, 000 to 1

//#Q A regular fair  pair of  dice is rolled. What is the probability that the role  will be a 7?
//^ 1 in 6
//A 7 in 6
//B 1 in 6
//C 6 in 7
//D 7 in 36

//#Q Mr. A  picks three cards from a 52-card deck. Mr. B rolls a pair of dice once. Mr. C rolls three dice. Mr. A must pick three aces. Mr. B must roll a 13. Mr. C must roll a  two. Who has the best odds?
//^ Mr.A
//A Mr.A
//B The odds are equal
//C Mr.C.
//D Mr.B

//#Q A combination lock has a  combination consisting of  three numbers. Each number could be 0,1,2,3,4,....39. How many different combinations are possible?
//^ 40 X 40 X 40 = 40 ^ 3
//A 40 X 40 X 40 = 40 ^ 3
//B 40  X 3 = 120
//C 39X 3 = 117
//D 3 X3 X 3X.........= 3 ^ 40

//#Q For some reason, you  are playing craps. The person rolling wants Little Joe. What is he hoping for?
//^ a 4
//A a 12
//B a 2
//C a 4
//D a 14

//#Q Which casino game gives you the best chance of winning? (We assume that no cheating is involved.)
//^ Blackjack
//A Keno
//B Slot machines
//C Blackjack
//D Craps

//#Q If you bet on a number in roulette in a fancy casino in Monaco or in an average casino in the USA, your odds of winning are the same.
//^ False
//A True
//B False

//#Q A  nine-digit number is selected at random. What are the odds that it will be your social security number (in the USA)?
//^ 1 in 1, 000, 000, 000
//A 1 in 9
//B 9 in 1, 000, 000, 000
//C 1 in 1, 000, 000, 000
//D 1 in 9, 000, 000, 000

//#Q On average, how many tornadoes are reported in the United States annually?
//^ 800 - 1, 000
//A 2, 000 - 2, 500
//B 3, 500 - 4, 000
//C 3, 000 - 3, 200
//D 800 - 1, 000

//#Q In the southern part of the United States, what months are peak season for tornadoes?
//^ March - May
//A March - May
//B June - August
//C January - Feburary
//D September - December

//#Q Tornadoes are transparent at first until dust and debris are picked up.
//^ True
//A True
//B False

//#Q Buildings can explode due to low pressure that comes with tornadoes.
//^ False
//A True
//B False

//#Q What time of the day do tornadoes most often strike?
//^ 3 p.m. - 9p.m.
//A 12 a.m. - 1 p.m.
//B 10 p.m. - 3 a.m.
//C 2 a.m. - 12 p.m
//D 3 p.m. - 9p.m.

//#Q When a tornadoe warning is issued, you should get in your car and try to outrun the storm to get to safety.
//^ False
//A False
//B True

//#Q There are four laws governing thermodynamics.  The zeroth is concerned with thermal equilibrium of three systems, the first law describes that the total energy of the universe remains constant and the second law tells us that entropy of a non-equilibrium system will increase over time.  What does the third law of thermodynamics describe?
//^ As temperature approaches absolute zero, the entropy of a system approaches a constant(zero).
//A As temperature approaches absolute zero, the entropy of a system approaches a constant(Avogadros number).
//B As temperature approaches absolute zero, the entropy of a system approaches critical mass.
//C As temperature approaches absolute zero, the entropy of a system approaches a constant(zero).
//D As temperature approaches absolute zero, the entropy of a system approaches infinity.

//#Q According to the electromagnetic spectrum, which region is the most energetic?
//^ gamma
//A infrared
//B gamma
//C ultra - violet(UV)
//D radio

//#Q Duality in quantum mechanics is used to describe these two concepts.  The Schrodinger equation is in fact the essence of duality.  Which two concepts are described in duality?
//^ particles and waves
//A solids and liquids
//B temperature and volume
//C liquids and gases
//D particles and waves

//#Q Molecular electronic transitions (n to Π* or Π to Π*) are are usually caused by the input of infrared radiation.
//^ False
//A True
//B False

//#Q This is an early computation device used in the 12th century by the Chinese.
//^ Abacus
//A Abacus
//B Pascaline
//C Napiers Bone
//D Jacquards Loom

//#Q Was the Pascaline invented by Blaise Pascal?
//^ Yes
//A No
//B Yes

//#Q What computational device was designed by Charles Babbage?
//^ Difference Engine
//A Difference Engine
//B Abacus
//C Pascaline
//D Holleriths Punch Card

//#Q What computational device was invented in 1617?
//^ Napiers bones
//A Abacus
//B Napiers bones
//C Jacquards Loom
//D Analytical engine

//#Q Who developed a punch card that was used with mechanical tabulating machines in the 1890 U.S. Census?
//^ Dr.Herman Hollerith
//A Dr.Herman Hollerith
//B John Napier
//C Joseph Marie Jacquards
//D Blaise Pascal

//#Q What year was the Pascaline invented?
//^ 1645
//A 1601
//B 1636
//C 1886
//D 1645

//#Q The Leibniz Calculator was invented in 1692.
//^ True
//A True
//B False

//#Q The muscular system composes what percent of total body weight?
//^ 35 % -50 %
//A 25 % -35 %
//B 35 % -50 %
//C 10 % -15 %
//D 60 % -70 %

//#Q Which skeletal muscle is used in blowing, whistling, and smiling?
//^ Buccinator
//A Orbicularis oculi
//B Mandibular
//C Buccinator
//D Masseter

//#Q Which skeletal muscle raises or throws back the shoulders, assists in moving the head to one side or another, and helps hold the head erect?
//^ Trapezius
//A Platysma
//B Latissimus dorsi
//C Trapezius
//D Sternocleidomastoid

//#Q Which skeletal muscle extends the foot, and is used to stand on tiptoes?
//^ Gastrocnemius
//A Gastrocnemius
//B Hamstrings
//C Soleus
//D Tibialis anterior

//#Q Identify the true statement regarding cardiac muscle.
//^ It contracts moderately fast in response to stimulation of nerve impulses.
//A It contracts moderately fast in response to stimulation of nerve impulses.
//B It is attached to the skeleton and moves its parts.
//C It contract quickly in response to stimulation of nerve impulses.
//D It is voluntary.

//#Q Identify a true characteristic of the smooth muscle tissue.
//^ It contracts slowly in response to nerve stimulation impulses.
//A It is a muscle only found in the stomach.
//B It contracts quickly in response to nerve stimulation impulses.
//C It is voluntary.
//D It contracts slowly in response to nerve stimulation impulses.

//#Q Which skeletal muscle moves the scapula forward, as in pushing something?
//^ Serratus anterior
//A Soleus
//B Sartorius
//C Sternocleidomastoid
//D Serratus anterior

//#Q What term refers to wasting away or degeneration of a muscle?
//^ Atrophy
//A Dystrophy
//B Trophy
//C Atrophy
//D Hypertrophy

//#Q What word denotes the ability of the muscle to transmit impulses?
//^ Conductivity
//A Irritability
//B Extensibility
//C Elasticity
//D Conductivity

//#Q Identify a true characteristic of skeletal muscle.
//^ It is striated, made up of long slender, striped cells.
//A It is found in the stomach and intestines.
//B It is non - striated, composed of spindle shaped cells.
//C It is involuntary.
//D It is striated, made up of long slender, striped cells.

//#Q What sea creature has 3 hearts and 8 tentacles?
//^ octopus
//A sea worm
//B crab
//C octopus
//D squid

//#Q A young goat is called a kid.
//^ True
//A True
//B False

//#Q What does a caterpillar turn into?
//^ butterfly or moth
//A butterfly or moth
//B butterfly
//C moth
//D larva

//#Q What is the national flower of Wales?
//^ Daffodil
//A Daisy
//B Daffodil
//C Rose
//D Posy

//#Q What continent are tigers native to?
//^ Asia
//A South America
//B Africa
//C Europe
//D Asia

//#Q If Kermit the Frog were a live animal, would he be considered an amphibian?
//^ Yes
//A Yes
//B No

//#Q The word buck is used for what male animal?
//^ All of these
//A Antelope
//B All of these
//C Deer
//D Rabbit

//#Q What does a koala eat?
//^ eucalyptus leaves
//A banyan tree
//B bamboo
//C eucalyptus leaves
//D rice

//#Q What continent is the aardvark native to?
//^ Africa
//A Australia
//B America
//C Africa
//D Asia

//#Q Nag is slang for what animal?
//^ Horse
//A Snake
//B Newt
//C Pony
//D Horse

//#Q When a patient presents with a sore throat, which of the following diagnoses may indicate immediate intubation?
//^ Epiglottitis
//A Mononucleosis
//B Quinsy
//C Epiglottitis
//D Peri - tonsillar Abscess

//#Q All of the following medications are contraindicated during pregnancy, EXCEPT which one?
//^ Nitrofurantoin
//A Tetracycline
//B Valproic Acid
//C Nitrofurantoin
//D Methotrexate

//#Q If a patient over the age of 50 presents with shoulder-and pelvic-girdle muscle pain, and you suspect a diagnosis of Polymyalgia Rheumatica, what question should you ask to rule out another diagnosis which often accompanies this one?
//^ Does your jaw hurt when you chew ?
//A Do you get short of breath ?
//B Does your jaw hurt when you chew ?
//C Does it ever seem that your heart is beating fast ?
//D Do you have tingling in your feet or toes ?

//#Q If a patient has chest pain and ST elevation in nearly all leads of the EKG, what is the likely diagnosis?
//^ Pericarditis
//A Acute Myocardial Infarction
//B Pulmonary Embolism
//C Pericarditis
//D Pneumothorax

//#Q All of the following are treatments for rheumatoid arthritis EXCEPT which one?
//^ Carbamazepine
//A Carbamazepine
//B Hydroxychloroquine
//C Gold
//D Prednisone

//#Q Which of the following opiates is most likely to cause seizures?
//^ Meperidine
//A Morphine
//B Hydromorphone
//C Meperidine
//D Oxycodone

//#Q Treatment of asthma with a long-acting beta agonist is inadvisable unless you are also treating the asthma with a steroid.
//^ True
//A True
//B False

//#Q All of the following are common causes of elevated liver enzymes EXCEPT which one?
//^ Cholelithiasis
//A HMG Co - enzyme - A Reductase Inhibitors
//B Alcohol abuse
//C Cholelithiasis
//D Fatty Liver

//#Q Which of the following is a possible cause of sudden-onset shortness of breath?
//^ Both of these
//A Neither of these
//B Acute myocardial infarction
//C Both of these
//D Pulmonary embolism

//#Q Which of the following is INCORRECT?
//^ Esophoria need not be addressed before the age of 3.
//A Esophoria need not be addressed before the age of 3.
//B Umbilical hernias almost always resolve spontaneously by the age of 5.
//C Acute otitis media in a child need not be treated with an antibiotic.
//D In epispadias the urethral meatus is superior to its normal location.

//#Q Which of the following patients should have the lowest goal low-density lipoprotein?
//^ A 30 - year - old woman with type 2 diabetes
//A A 60 - year - old man with erectile dysfunction and a family history of coronary artery disease
//B A 30 - year - old woman with type 2 diabetes
//C A 55 - year - old man with colon cancer
//D A 50 - year - old cigarette - smoking woman with familial hypercholesterolemia

//#Q Which of the following tests would be appropriate to confirm the diagnosis of B12 deficiency in a patient whose B12 level is at the low end of the normal range?
//^ Methylmalonic Acid level
//A Methylmalonic Acid level
//B Urine Catecholamines
//C Folic Acid level
//D Haptaglobin level

//#Q It is certainly feasible to practice medicine without ever prescribing opiate medications.
//^ False
//A True
//B False

//#Q Name the first four planets of the Solar System in order of their distance from the Sun?
//^ Mercury, Venus, Earth, Mars
//A Mercury, Venus, Earth, Mars
//B Mars, Venus, Earth, Mercury
//C Jupiter, Venus, Mars, Earth
//D Saturn, Pluto, Jupiter, Earth

//#Q Which of these is represented by the chemical formula C12 H22 O11?
//^ sugar
//A sugar
//B salt
//C oxygen
//D baking soda

//#Q Mixing baking soda and vinegar in a closed container causes a tiny explosion.
//^ True
//A True
//B False

//#Q What is the largest planet in the solar system?
//^ Jupiter
//A Neptune
//B Jupiter
//C Mars
//D Venus

//#Q What is the chemical formula for baking soda?
//^ NaHCO3
//A Co3
//B NaHCO3
//C C3H8
//D C12 H22 O11

//#Q What is the atomic number of the chemical element chlorine?
//^ 17
//A 28
//B 83
//C 17
//D 9

//#Q The name of which country is derived from the Latin word for silver?
//^ Argentina
//A Ecuador
//B Argentina
//C El Salvador
//D Albania

//#Q What star is closest to the sun?
//^ Proxima Centauri
//A Procima Beta
//B Proxima Centauri
//C Alpha Centauri
//D Proxima Alpha

//#Q The first examples of early Byzantine architecture, found in Ravenna and Constantinople, date from the reign of which Byzantine emperor?
//^ Justinian I
//A Justinian I
//B Justin II
//C Tiberius II
//D Haraclius

//#Q The long body of the church Hagia Irene in Istanbul (former Constantinople) is covered by two domes.
//^ True
//A True
//B False

//#Q St Volodimyr Cathedral, an example of Neo-Byzantine architecture, is located in which Eastern European city?
//^ Kiev
//A Sofia
//B Kiev
//C St Petersburg
//D Moscow

//#Q The dome of Hagia Sophia in Istanbul (former Constantinople) is supported by how many massive piers?
//^ 4
//A 3
//B 2
//C 5
//D 4

//#Q The Church of the Holy Sepulchre, also called the Church of the Resurrection, is an example of Byzantine architecture, located in which city?
//^ Jerusalem, Israel
//A Moscow, Russia
//B Rome, Italy
//C Istanbul, Turkey
//D Jerusalem, Israel

//#Q The Byzantine church of Hagia Irene was the seat of the Bishop of Constantinople until what year?
//^ 415
//A 738
//B 404
//C 415
//D 564

//#Q The church of Hagia Irene, a Byzantine church, was converted into a mosque by Sultan Mehmed the Conquerer.
//^ False
//A False
//B True

//#Q Elmali Kilise, a rock sanctuary built in Byzantine style, dates back to the Comnenan period and is located in which district?
//^ Cappadocia
//A Athens
//B Sicily
//C Istanbul
//D Cappadocia

//#Q St Marks Basilica, a prominent example of Byzantine architecture, is located in which Italian city?
//^ Venice
//A Milan
//B Rome
//C Venice
//D Florence

//#Q Unlike most animals eyes, the eyes of fish and snakes usually have a fixed lens size. How do these animals eyes focus then?
//^ By telescoping the lens
//A By rotating the lens
//B By telescoping the lens
//C By tilting the lens
//D By bending the lens

//#Q Which of these species has the most complex color vision known?
//^ The Mantis shrimp
//A The Tarantula
//B The Bengal tiger
//C The Great white shark
//D The Mantis shrimp

//#Q What is the maximum angle of field of vision compound eyes can have?
//^ 360 degrees
//A 290 degrees
//B 360 degrees
//C 310 degrees
//D 200 degrees

//#Q Almost all organisms on Earth have a vision restricted to small range of the electromagnetic spectrum (between 320 and 800 nm). This is considered to be a consequence of which of these evolutionary facts?
//^ Life emerged underwater
//A Life emerged on another planet
//B The atmosphere had different composition when life emerged
//C At the time when life emerged, the electromagnetic spectrum was different
//D Life emerged underwater

//#Q If compared to a camera, what part of the human eye is its aperture?
//^ Pupil
//A Iris
//B Pupil
//C The cones
//D Optic nerve

//#Q Iridology is a branch of ophthalmology that deals with diseases and treatment of the human iris.
//^ False
//A False
//B True

//#Q Which of these activities can cause permanent damage to the eyes?
//^ None of these
//A Reading in poor light
//B Prolonged reading
//C None of these
//D Reading small print

//#Q In order to achieve the widest possible field of view, these animals have their two eyes positioned on opposite sides of their heads.
//^ Prey animals
//A Prey animals
//B Predatory animals
//C Underwater animals
//D None of these

//#Q Stereopsis is a process in visual perception giving the organism a sensation of what?
//^ Depth
//A Color
//B Width
//C Depth
//D Movement

//#Q Chameleons have some of the most distinctive eyes among the reptiles. The two separately moving and focusing eyes of a chameleon give it a full 360-degree arc of vision around its body, but can they also ensure sharp clear focusing on one single object?
//^ Yes
//A No
//B Yes

//#Q What does the metric prefix kilo mean?
//^ 1000
//A 1000
//B 10000
//C 100
//D 1000000

//#Q Which three nations have not officially adopted the metric system?
//^ The USA, Liberia, Myanmar
//A The USA, Jamaica, Libya
//B The USA, the United Kingdom, Malawi
//C The USA, Jamaica, Burma
//D The USA, Liberia, Myanmar

//#Q Who was the first person to propose the idea of a metric system?
//^ Simon Stevin
//A Gabriel Mouton
//B Simon Stevin
//C Napoleon
//D King Louis XIV

//#Q Which was the first nation to adopt a metric system?
//^ France
//A Italy
//B Austria
//C France
//D Vatican City

//#Q In the metric system, what unit is used to measure temperature?
//^ degrees Kelvin
//A degrees Fahrenheit
//B degrees Centigrade(Celsius)
//C degrees Rankine
//D degrees Kelvin

//#Q What unit is used in the metric system for measuring time?
//^ the second
//A the second
//B the Ohm
//C the grad
//D the cell phone

//#Q What does the  prefix milli mean?
//^ 1 / 1000
//A 1000
//B 1 / 100000
//C 1 / 1000
//D 1 / 100

//#Q What does the metric prefix nano mean?
//^ 1 / 1, 000, 000, 000
//A 1, 000, 000
//B 1, 000, 000, 000
//C 1 / 1, 000, 000, 000
//D 10

//#Q Many computer drives have a capacity of a terabit. How many bits are in one terabit?
//^ 1, 000, 000, 000, 000
//A 1, 000
//B 10
//C 8
//D 1, 000, 000, 000, 000

//#Q There is a unit called a Yottagram. How many grams are in one Yottagram?
//^ 10 ^ 24
//A 10 ^ 12
//B 10 ^ 24
//C 10 ^ 18
//D 10 ^ -12

//#Q Which nation issued the first metric currency - a unit that was divided in 100 parts?
//^ The USA
//A Italy
//B France
//C Spain
//D The USA

//#Q The Kasson Metric Act of 1866 made the Metric System the official system of the USA, although it was repealed in 1873.
//^ False
//A False
//B True

//#Q Thomas Jefferson was a leading opponent of the metric system.
//^ False
//A True
//B False

//#Q What does XML stand for?
//^ extensible markup language
//A excellent markup language
//B extensive markup language
//C easy markup language
//D extensible markup language

//#Q When did the Nintendo system debut in the U.S.A.?
//^ 1985
//A 1998
//B 1980
//C 1985
//D 1970

//#Q The giant sub atomic particle collider, capable of reproducing the big bang conditions, is located in which research facility?
//^ CERN
//A NASA
//B CERN
//C None of these
//D KAOS

//#Q This engineer, called the father of supercomputing, has been credited with creating the supercomputer industry.
//^ Seymour Gray
//A Seymour Gray
//B Charles Babbage
//C Bill Gates
//D Steve Jobs

//#Q Why did the U.S.A. launch the Galileo space probe?
//^ to explore Jupiter
//A to explore Pluto
//B to explore Mercury
//C to explore Jupiter
//D to explore the sun

//#Q HCl has pH close to which one of these?
//^ 2
//A 2
//B 4
//C 14
//D 7

//#Q What is the reaction called when an acid and a base are mixed together?
//^ neutralization
//A single replacement
//B double replacement
//C neutralization
//D synthesis

//#Q Which two of these are produced when an acid and a base are mixed together?
//^ water and a salt
//A water and a salt
//B water and another base
//C HCl and NaOH
//D water and another acid

//#Q Bases corrode metal.
//^ False
//A False
//B True

//#Q What happens to an indicator when touched by an acid or a base?
//^ the color changes
//A it vibrates
//B it dissolves
//C the color changes
//D it corrodes

//#Q If HCl and NaOH are combined, what compound is produced other than water?
//^ NaCl
//A NaCl
//B HNa
//C HOH
//D ClOH

//#Q The pH of solids in solid form can be measured using indicator paper.
//^ False
//A False
//B True

//#Q A ionic compound with H (hydrogen) in the front is most likely to be which of the following?
//^ acid
//A acid
//B base
//C water
//D indicator

//#Q What is soap?
//^ a base with a bitter taste
//A an acid with a sour taste
//B an acid with a bitter taste
//C a base with a sour taste
//D a base with a bitter taste

//#Q What is the range of the pH scale?
//^ (0 or 1) --14
//A 14-- 20
//B(0 or 1)-- 14
//C 0-- 7
//D - 7-- 0

//#Q Fill in the missing letter in this chain that has to do with the Solar System we live in: M, V, E, M, J, _, U, N.
//^ S
//A R
//B P
//C S
//D B

//#Q What is the name of the Galaxy that our Solar System is a part of?
//^ Milky Way
//A Milky Way
//B The Large Magellanic Cloud
//C Andromeda
//D Hollywood

//#Q Approximately how long is one astronomical unit (1 a.u.)?
//^ 149,597,000 km / 92,955,266 miles
// A 174,000,000 km / 108,118,587 miles
//  B 8,000,000 km / 4,970,969 miles
//   C 149,597,000 km / 92,955,266 miles
//    D 878,000,000 km / 545,563,907 miles

//# Q Which of these values signifies the greatest temperature?
//^ One degree Celsius
//A One degree Fahrenheit
//B One degree Celsius
//C One degree Rankine
//D One degree Kelvin

//#Q What does the abbreviation THEL stand for?
//^ Tactical high energy laser
//A Thermabaric harmonic emergent light
//B Thermobaric high energy light
//C Titanium harmonic emergent laser
//D Tactical high energy laser

//#Q “Wattle and daub is a method of construction.
//^ True
//A True
//B False

//#Q Why are recoilless guns recoilless?
//^ Their barrels are open at both ends.
//A Their barrels are open at both ends.
//B They are loaded with missiles not cannon balls.
//C They are made of very heavy metals.
//D They are not placed on wheels.

//#Q Which statement is true about airplanes?
//^ To dive, elevators are down.
//A To dive, elevators are up.
//B To dive, ailerons are down.
//C To dive, elevators are down.
//D To dive, ailerons are up.

//#Q Taxonomy of vertebrates divides fishes into what two basic groups?
//^ Jawed and jawless
//A Gilled and non-gilled
//B Mammalian and non-mammalian
//C Nematodes and non-nematodes
//D Jawed and jawless

//#Q What makes almost 99% of the visible universe?
//^ Plasma
//A Nitrogen
//B Quasars
//C Plasma
//D Solids

//#Q What is an endothermic chemical reaction?
//^ A chemical reaction in which energy is used up
//A A chemical reaction in which energy is released
//B A chemical reaction in which energy is used up
//C A chemical reaction in which oxides are produced
//D A chemical reaction in which carbon compounds are involved

//#Q The sky appears to be blue because of the refraction of light.
//^ False
//A True
//B False

//#Q A plane travels at 176 miles per hour for 4 hours from Chicago due East. What is the planes velocity?
//^ 176 mph East
//A 176 mph
//B 44 mph East
//C 176 mph East
//D 5.5

//#Q The Metal Storm weapons, that can fire tens of thousands of rounds a minute, were developed where?
//^ Australia
//A Belgium
//B Australia
//C Livermore, California
//D Piscatawny, New Jersey

//#Q What do we call cells with a nucleus?
//^ Eukaryotic
//A Mitochondrial
//B Golgi
//C Eukaryotic
//D Prokaryotic

//#Q When buying a prebuilt (Dell, Gateway, Acer, HP etc...) computer with a hard drive capacity of 250 GB, what will the functional capacity of the hard drive display as when looking at the properties of C drive?
//^ 232.8 GB
//A 232.8 GB
//B 240 GB
//C 250 GB
//D 249.9 GB

//#Q If a computer system displays less memory than what is installed, what are the most likely causes for this discrepancy? ( example: a system comes with 2 GB of RAM installed but system info displays 1896 MB of RAM)
//^ There are a full 2 GB of ram installed, however other devices(video card etc) have been designated a portion of the system RAM to function.
//A There are a full 2 GB of ram installed, however other devices(video card etc) have been designated a portion of the system RAM to function.
//B System has 2 separate 1 GB sticks installed to equal 1896 MB of Ram.If a single 2B stick was installed it would read correctly.
//C RAM measurements are similar to the hard drive discrepancy in that a GB definition difference exists between the manufacturer and the operating system.
//D The manufacturer rounds up to the measurement to the nearest GB for ease of sale.The Operating system reads the actual amount of the chip(s).

//#Q Generally computers are sold with RAM in 1GB denominations. Is it generally possible to add RAM to the system later to have 1.5 GB of RAM?
//^ Yes
//A No
//B Yes

//#Q When running a 32-bit operating system which amount of RAM can you not functionally upgrade your system to?
//^ 4 GB
//A 4 GB
//B 3.5 GB
//C 1 GB
//D 3 GB

//#Q An LCD monitor with a DVI or VGA connector can be connected to a laptop computer with the same connectors, as a second monitor.
//^ True
//A True
//B False

//#Q Which one of the following is indicative of Direct Disc Labeling capabilities?
//^ LightScribe
//A LightScribe
//B SATA 3.0Gb / s
//C Sharpie enabled
//D DL DVD±RW / CD - RW

//#Q What is FireWire?
//^ a method of transporting data between two digital devices
//A a quality mouse by Logitech
//B a method of transporting data between two digital devices
//C a peer to peer sharing website for music and file sharing
//D a movie

//#Q This Microsoft operating system, formerly codenamed Blackcomb and Vienna, is intended to succeed Windows Vista.
//^ 7
//A Mojave
//B Vista
//C Mac OS X Leopard
//D 7

//#Q If a wireless network is set up in a home, yet the signal is weak in certain areas, you may buy one of these to increase the existing signal strength.
//^ Repeater
//A Repeater
//B Modem
//C Router
//D Satellite Dish

//#Q Windows Vista commercials have boasted of the Record Live Television capability of the operating system. What is necessary to use this function?
//^ TV Tuner Card
//A Optical Drive
//B Cable Box
//C Digital Television
//D TV Tuner Card

//#Q What is the number of amino acids commonly associated with the mammalian protein?
//^ 20
//A 25
//B 23
//C 20
//D 46

//#Q All mammalian amino acids have which Greek letter designating their relation to the carbon atom to which different groups are attached?
//^ Alpha
//A Delta
//B Sigma
//C Beta
//D Alpha

//#Q The carbon atom in amino acids has four elements/groups attached to it in all amino acids (except for proline). Which of the following is not among these four?
//^ Methyl group
//A Carboxyl group
//B R - group(including another hydrogen)
//C Methyl group
//D Hydrogen

//#Q On average, only one baby in 10,000,000 is born with a tooth.
//^ False
//A False
//B True

//#Q A rodents teeth will grow continuously for its entire lifetime.
//^ True
//A False
//B True

//#Q Which of these people was a dentist?
//^ Paul Revere
//A Thomas Alva Edison
//B Samuel F.B.Morse
//C Paul Revere
//D DeWit Clinton

//#Q What is true about elephant tusks?
//^ They are highly developed incisors.
//A They are highly developed canine teeth.
//B They are not teeth.
//C They are not really made of ivory.
//D They are highly developed incisors.

//#Q Which of these animals only has molars?
//^ Adult aardvarks
//A Adult penguins
//B Adult aardvarks
//C Adult  wolves
//D Adult minnows

//#Q Which of these animals have no teeth?
//^ Turtles
//A snails
//B Turtles
//C Hares
//D Wombats

//#Q Which of these are heterodonts?
//^ Humans
//A Snails
//B Humans
//C Turtles
//D Sharks

//#Q Which mammal has the most teeth?
//^ The spinner dolphin
//A The spinner dolphin
//B The tiger seal
//C The dingo
//D The giant armadillo

//#Q Select the incorrect statement.
//^ Over 80 % of an elephants tusk is visible - the rest lies inside the gums.
//A Over 80 % of an elephants tusk is visible - the rest lies inside the gums.
//B Aside from the elephant, the walrus has the largest tusks.
//C The tusks of a male elephant grow about 18 cm a year.
//D Biologists have found that the tooths weight and its need for muscular development has greatly influenced the development of the mammalian skull.

//#Q Every mammal has teeth.
//^ False
//A False
//B True

//#Q The narwhale has two teeth in its upper jaw, one of which develops into a horn-like protrusion (this is true).
//It is almost always the left one that  becomes the horn.
//^ True
//A False
//B True

//#Q The most common  fossil is the tooth.
//^ True
//A True
//B False

//#Q Consider all animals that ever lived. Which animal had the longest teeth?
//^ The straight - tusked elephant
//A The Malaysian elephant.
//B The straight - tusked elephant
//C The mammoth
//D The Asian elephant

//#Q What is the weight of the smallest known bird egg on the planet?
//^ 0, 5 grams
//A 2, 5 grams
//B 5 grams
//C 0, 5 grams
//D 1 gram

//#Q Eggs have a very high nutrition value. Which of the following substances is not present within an egg?
//^ Chlorophyll
//A Chlorophyll
//B Phosphorus
//C Vitamin D
//D Choline

//#Q Which of the following is the Latin word for egg?
//^ Ovum
//A Ovum
//B Avis
//C Cancer
//D Rana

//#Q The egg of this animal contains the largest existing single cell.
//^ Ostrich
//A Ostrich
//B Komodo dragon
//C Platypus
//D Emu

//#Q Which of the following is not true about the bird eggshell?
//^ The eggshell does not contain protein.
//A The normal bird eggshell is porous.
//B The eggshell does not contain protein.
//C The eggshell consists of roughly 95 % calcium carbonate crystals.
//D The bird eggshell is covered by a structure called cuticle.

//#Q How many hours approximately does an eggshell formation take in an average laying hen?
//^ About 20 hours
//A About 48 hours
//B About 5 hours
//C About 20 hours
//D Less than 2 hours

//#Q How long does it take for a platypus egg to develop completely and hatch?
//^ 28 days of internal formation and 10 days of external incubation
//A 28 days of internal formation and 10 days of external incubation
//B 15 days of internal formation and 35 days of external incubation
//C 24 hours of internal formation and 15 days of incubation
//D The eggs develop within 7 days in the mothers uterus and the babies are hatched almost immediately after laying

//#Q Which of these expression does not refer to a yolkless egg?
//^ Vain egg
//A Vain egg
//B Wind egg
//C Dwarf egg
//D Cock egg

//#Q Which of the following is not true about the egg yolk?
//^ It contains 75% of the protein of the egg.
//A It contains 75% of the protein of the egg.
//B It is placed in a yolk sac.
//C Its usual color varies from pale yellow to deep orange.
//D It contains almost 100% of total amount of fat and cholesterol in the egg.

//#Q What is the main protein found in the egg white?
//^ Ovalbumin
//A Ovalbumin
//B Fibrin
//C Gluten
//D Phosphoprotein

//#Q One famous analog computer was the water integrator, which functioned by manipulation of water through a room of pipes and pumps, where the water levels represented numbers, and the rate of flow represented mathematical operations.  Which country built the water integrator?
//^ Soviet Union
//A Soviet Union
//B Great Britain
//C USA
//D Germany

//#Q This English mathematician, logician and cryptographer is widely regarded as the father of modern computer science.
//^ Alan Turing
//A Alan Turing
//B Max Newman
//C Ada Lovelace
//D John Atanasoff

//#Q Which was the first implemented high-level general purpose programming language?
//^ Fortran
//A Cobol
//B BASIC
//C Fortran
//D Pascal

//#Q In the 1950s, these electronic components replaced vacuum tubes in the production of computers.
//^ transistors
//A diodes
//B chips
//C transistors
//D processors

//#Q In their third generation computers flourished, thanks Jack St. Clair Kilbys and Robert Noyces independent invention.  What did they invent?
//^ integrated circuit (or microchip)
//A the transistor
//B the first computer program
//C integrated circuit (or microchip)
//D computer memory

//#Q This computer engineer and co-founder of Apple Computer is often credited with developing the first mass-market home computers.
//^ Steve Woz Wozniak
//A Steve Jobs
//B Bill Gates
//C John Vincent Atanasoff
//D Steve Woz Wozniak

//#Q Which was the first version of Microsoft Windows to support Plug and Play?
//^ Windows 95
//A Windows 3.11
//B Windows 95
//C Windows XP
//D Windows 3.0

//#Q If the optimal body habitus for hot climates is tall and slender, what is one possible condition explaining pygmies?
//^ Humidity
//A Ice ages
//B Humidity
//C Rain
//D Low atmospheric preasure

//#Q Which of the following is correct?
//^ Primates include Monkeys, Pro-Simians, and Apes.  Apes include Orangutans, Gorillas, Chimpanzees and Humans.
//A Primates include Gorillas, Monkeys and Humans.Monkeys include Pro-Simians and Chimpanzees.
//B Primates include Monkeys, Pro-Simians, and Apes.  Apes include Orangutans, Gorillas, Chimpanzees and Humans.
//C Primates include Apes and Pro-Simians.Pro-Simians include Humans.Apes include Gorillas, Orangutans and Monkeys.
//D Primates include Humans, Pro-Simians and Apes.Apes include Orangutans, Gorillas, and Monkeys.

//#Q Which of the following modern diseases evolved as a protection against malaria?
//^ Sickle Cell Anemia
//A Asthma
//B Sickle Cell Anemia
//C Lactose Intolerance
//D Tay Sachs

//#Q Which of the following primates is the closest related to humans?  (That is, this primate has more DNA in common with humans than any other living creature does.)
//^ Chimpanzee
//A Lemur
//B Chimpanzee
//C Gorilla
//D Orangutan

//#Q African Americans are more likely to suffer from hypertension (high blood pressure) than European Americans.  Why?
//^ Enslaved individuals were transported from Africa in the holds of ships, and given very little water.Those whose bodies conserved salt were more likely to survive the journey.  Salt exacerbates high blood pressure.
//A Enslaved individuals were transported from Africa in the holds of ships, and given very little water.Those whose bodies conserved salt were more likely to survive the journey.  Salt exacerbates high blood pressure.
//B Rap music raises blood pressure.
//C African Americans eat more salty food than European Americans do.
//D In tropical climates, one sweats a lot.  This results in water loss, which lowers blood pressure.  Africans therefore conserve salt more efficiently than Europeans.  In the United States, however, where it is cooler, this characteristic leads to high bloo

//#Q Dark skin contains melanin, which is a dark pigment in the skin.  The purpose for melanin is to protect the skin from harmful effects of ultraviolet sunlight, which include skin cancer.  What evolutionary advantage does light skin have?
//^ Light skin lets in more sunlight.  Sunlight catalyzes the formation of Vitamin D.
//A Light skin lets in more sunlight, which allows a person in colder climates to get warm more easily.
//B Light skin lets in more sunlight.  Sunlight catalyzes the formation of Vitamin D.
//C Light skin tans more easily.  This makes the person more attractive and therefore facilitates mating.
//D Light skin is more attractive, which makes the person better able to attract a mate.

//#Q Mitochondrial DNA has been analyzed to estimate the ancestral lineage of various species around the world, including primates.  Which of the following statements about mitochondria is true?
//^ Mitochondria are descended from once-separate, single-celled organisms which invaded a cell, stuck around, then lost their ability to live independently.
//A Mitochondrial DNA does not mutate.
//B Mitochondria function in the cell to break down waste products.
//C Mitochondria are descended from once-separate, single-celled organisms which invaded a cell, stuck around, then lost their ability to live independently.
//D Mitochondrial DNA is only inherited by males.

//#Q The Arecibo Observatory, located approximately 12 miles south-southwest from Arecibo, Puerto Rico, is notable for owning the worlds largest single-aperture telescope of this type.
//^ Radio telescope
//A Dioptric telescope
//B Radio telescope
//C Catadioptric telescope
//D Catoptric telescope

//#Q The main purpose of the observatory located on the north shore of Big Bear Lake in the San Bernardino Mountains, California is studying what?
//^ The Sun
//A Pulsars
//B Black holes
//C The Moon
//D The Sun

//#Q The Hubble Space Telescope in orbit around the Earth has become one of the most important telescopes in the history of astronomy since its launch in 1990. It doesnt work in which one of these wavelength regimes?
//^ Radio
//A Optical
//B Ultraviolet
//C Near-infrared
//D Radio

//#Q Which of the following historical sites did not serve as a kind of observatory in the past?
//^ The Great Sphinx of Giza, Egypt
//A Abu Simbel, Egypt
//B The Great Sphinx of Giza, Egypt
//C Stonehenge, Great Britain
//D Kokino, Republic of Macedonia

//#Q Which of these islands is known as the location of numerous important world observatories?
//^ Hawaii
//A Okinawa
//B Cyprus
//C Hawaii
//D Madagascar

//#Q This observatory, located at Mauna Kea, Hawaii, uses two telescopes equipped with adaptive optics.
//^ W.M.Keck Observatory
//A Paranal Observatory
//B W.M.Keck Observatory
//C Observatorio Nacional de Llano del Hato
//D Roque de los Muchachos Observatory

//#Q The Very Large Array (VLA) is a radio astronomy observatory located on the Plains of San Augustin, USA, consisting of what number of separate radio antennae?
//^ 27
//A 35
//B 12
//C 27
//D 19

//#Q NASAs Chandra space observatory launched on July 23, 1999 uses what type of telescopes?
//^ X-ray telescopes
//A Optical telescopes
//B Infrared telescopes
//C X-ray telescopes
//D Radio telescopes

//#Q The Yerkes Observatory in Williams Bay, Wisconsin, established in 1897 by George Ellery Hale, works with a 102 cm (40 inch) refracting telescope.
//^ True
//A True
//B False

//#Q Cerro Tololo Inter-American Observatory is a complex of astronomical telescopes and instruments, located on the territory of which country?
//^ Chile
//A Peru
//B Chile
//C Spain
//D Brazil

//#Q All planets, comets and asteroids orbit around the Sun.  What percentage of the Solar Systems mass does the Sun account for?
//^ 99.8%
//A around one-half
//B 99.8%
//C 86.2%
//D around 10%

//#Q This tasteless, colorless and odorless chemical element makes up most of the Suns volume (approx. 92%).
//^ Hydrogen
//A Chromium
//B Magnesium
//C Oxygen
//D Hydrogen

//#Q The surface temperature of the Sun is 5,780 K, which makes it white.  Why does the Sun appear yellow from the surface of the Earth?
//^ because of the blue color of the sky
//A due to the electromagnetic radiation
//B because of the distance the light travels
//C because of the blue color of the sky
//D because of our eyes inability to see light  in that range

//#Q The Sun was once regarded as a small and insignificant star, but is now believed to be brighter than approximately 85% of the stars in the galaxy.
//^ True
//A True
//B False

//#Q The Sun is a main sequence star and as such generates energy by this process, joining hydrogen nuclei together into helium.
//^ nuclear fusion
//A nuclear spallation
//B isomerisation
//C nuclear fusion
//D induced gamma emission

//#Q The Sun is located at the center of our galaxy.
//^ False
//A True
//B False

//#Q This commercially available non-toxic gas makes up 25% of the Suns mass.  It is used in deep diving to reduce the effects of narcosis.
//^ helium
//A nitrogen
//B hydrogen
//C helium
//D carbon

//#Q What is referred to as the solar apex?
//^ the direction the Sun travels through space
//A the highest point the Sun reaches during the day
//B the warmest day of the year as measured on the equator
//C the direction the Sun travels through space
//D the highest UV reading taken from the earths surface

//#Q Ancient Greek astronomer Aristarchus was the first person to present the theory that the sun is at the center of the solar system (heliocentrism).  However in the 16th century, this Polish astronomer was first to formulate a scientifically based heliocentric study.
//^ Nicolaus Copernicus
//A Giovanni Cassini
//B Thomas Harriot
//C Nicolaus Copernicus
//D Galileo Galilei

//#Q Most cultures have a solar diety, someone who represents the Sun.  Who is the chief solar diety in Hinduism?
//^ Surya
//A Krishna
//B Brahman
//C Ishvara
//D Surya

//#Q This is the most diverse and abundant group of organisms on Earth. Its members reproduce so fast that they can double their number as quickly as every 10 minutes.
//^ Bacteria
//A Bacteria
//B Viruses
//C Algae
//D Fungi

//#Q Which of the following is the natural habitat of the bacteria?
//^ All of these
//A The air and sea water
//B All of these
//C Earths surface and fresh water
//D Underground and the icebergs

//#Q A virus is a unicellular infectious agent consisting of genetic material encapsulated in a protective protein coat.
//^ False
//A True
//B False

//#Q The members of only one of these types of microorganisms have a cell nucleus. Which are they?
//^ Algae
//A Algae
//B Viruses
//C Archaea
//D Bacteria

//#Q Name the longest bone in the body.
//^ Femur
//A Femur
//B Fibula
//C Tibia
//D Humerus

//#Q The scapula is part of the spine near the hip.
//^ False
//A True
//B False

//#Q Name the ligament that attaches to the head of the femur and the acetabulum.
//^ Ligamentum Teres
//A Ligamentus Trigemini
//B Ligamentum Tores
//C Ligamentus Iliopsoas
//D Ligamentum Teres

//#Q The largest semilunar cartilages, also called the menisci, are located in this part of the body.
//^ Knee
//A Knee
//B Jaw
//C Shoulder
//D Hip

//#Q What is the most common reason for water waste?
//^ Showers
//A Washing Machines
//B Showers
//C Dish Washers
//D Brushing your teeth

//#Q In an average household, on a daily basis most people forget the fan or lights on?
//^ True
//A False
//B True

//#Q Which of these is an efficient way to save trees?
//^ Using less electricity
//A Using the washing machine
//B Using less water
//C Killing animals instead
//D Using less electricity

//#Q Can you donate any electrical items to a recycling dump place?
//^ Yes
//A No
//B Yes

//#Q Which of these can help produce pencils, without cutting down trees?
//^ jeans
//A leaves
//B benches
//C jeans
//D branches

//#Q The water bottle is the most popular type of drink container found in garbage cans.
//^ False
//A True
//B False

//#Q Can you recycle food scraps?
//^ Yes
//A Yes
//B No

//#Q The planet Mars is named after which of the following?
//^ Roman God of War
//A A Candy Bar
//B Roman God of Peace
//C Roman God of War
//D Greek God of the Sea

//#Q Mars has two natural satellites. What are their names?
//^ Phobos and Deimos
//A Phobos and Deimos
//B Vulcan and Apollo
//C Tom and Jerry
//D Zeus and Hara

//#Q Mars takes about how many Earth days to travel once around the Sun?
//^ 687
//A 243
//B 687
//C 466
//D 890

//#Q The atmosphere of Mars is mostly composed of what element?
//^ Carbon Dioxide
//A Methane
//B Oxygen
//C Hydrogen
//D Carbon Dioxide

//#Q What was the name of the first spacecraft to study Mars?
//^ Mariner 4
//A Viking 1
//B Mars 2
//C Viking 2
//D Mariner 4

//#Q Mars has the tallest known mountain in the Solar System. What is its name?
//^ Olympus Mons
//A Arsia Mons
//B Syrtis Major
//C Olympus Mons
//D Tharsis

//#Q Located along the Martian equator, Valles Marineris is a canyon much bigger than the Grand Canyon on Earth. How long is it?
//^ 4,000 km long.
//A 4,000 km long.
//B 750 km long.
//C Just under 500 km long.
//D 2,500 km long.

//#Q What type of weather pattern on Mars can obscure the surface from view?
//^ Dust Storms
//A Thunder Storms
//B Dust Storms
//C Hurricanes
//D Snow Storms

//#Q What astronomer was the first to see canali on the surface of Mars?
//^ Giovanni Shiaparelli
//A Sir Isaac Newton
//B Giovanni Shiaparelli
//C Galileo
//D Percival Lowell

//#Q When was fibromyalgia recognized as an illness by the American Medical Association?
//^ in the 1980s
//A in the 1990s
//B in the 1960s
//C in the 1970s
//D in the 1980s

//#Q Fibromyalgia is most common in women.
//^ True
//A True
//B False

//#Q Which of the following is not a common symptom of fibromyalgia?
//^ Low red blood count
//A Fatigue
//B Sleep disturbances
//C Pain
//D Low red blood count

//#Q Fibromyalgia can be diagnosed with a simple blood test.
//^ False
//A False
//B True

//#Q Fibromyalgia is a disorder of the central nervous system.
//^ True
//A True
//B False

//#Q Low doses of antidepressants can be used to treat fibromyalgia patients.
//^ True
//A False
//B True

//#Q There is no generally accepted cure for fybromyalgia.
//^ True
//A False
//B True

//#Q Which of the following areas of the body is not considered a tender point in the diagnosis of fibromyalgya?
//^ Ankles
//A Knees
//B Shoulder Blades
//C Ankles
//D Hips

//#Q May 13th is the National Fibromyalgia Associations Fibromyalgia Awareness Day.
//^ False
//A False
//B True

//#Q People suffering from fibromyalgia may be genetically predisposed.
//^ True
//A False
//B True

//#Q The United States had 50 deaths from the Ebola Virus in the period from 1976 to 2006.
//^ False
//A False
//B True

//#Q What disease took many lives in Russia, Poland and Romania during World War I ?
//^ Typhus
//A Malaria
//B Typhus
//C Smallpox
//D Cholera

//#Q The Spanish Flu took the lives of over 40,000 people between 1918 and 1920.
//^ False
//A True
//B False

//#Q From what disease did former U.S. President James K. Polk die in 1849?
//^ Cholera
//A Cholera
//B Chicken Pox
//C Malaria
//D Flu

//#Q In 1655 the Bubonic Plague hit India and China causing mass casualties.
//^ False
//A False
//B True

//#Q In 1952, this disease struck the U.S. and became the worst epidemic in the nations history at that time.
//^ Polio
//A Small Pox
//B Malaria
//C Whooping Cough
//D Polio

//#Q Which one of these objects does Perseus contain?
//^ NGC 1499
//A M45
//B M101
//C NGC 1499
//D PSR 0329+54

//#Q What kind of Galaxy is the Milky Way?
//^ Barred Spiral
//A Elliptical
//B Spiral
//C Barred Spiral
//D Irregular

//#Q Which of these will our Sun eventually become?
//^ Planetary Nebula
//A Neutron Star
//B Black Hole
//C Emission Nebula
//D Planetary Nebula

//#Q What is the most distant object you can see unaided under the best possible conditions?
//^ Triangulum Galaxy(M33)
//A Triangulum Galaxy(M33)
//B Andromeda Galaxy(M31)
//C The Large Magellanic Cloud
//D The Whirlpool Galaxy(M51)

//#Q Ophiuchus is on the ecliptic.
//^ True
//A False
//B True

//#Q Which ancient Greek astronomer cataloged 48 of the constellations?
//^ Ptolemy
//A Plato
//B Aristotle
//C Ptolemy
//D Aristarchus

//#Q What is a fast-spinning neutron star that emits pulses of radio waves called?
//^ Pulsar
//A Millisecondar
//B White Dwarf
//C Pulsar
//D Magnetar

//#Q Which quasar is the brightest as seen from Earth?
//^ 3C 273
//A PSR0031-07
//B PKS0405-123
//C OQ 172
//D 3C 273

//#Q Which transit of planets against the Sun obscures the most of its disk?
//^ Transit of Jupiter, viewed from Saturn
//A Transit of Jupiter, viewed from Saturn
//B Transit of Earth, viewed from Mars
//C Transit of Uranus, viewed from Neptune
//D Transit of Saturn, viewed from Uranus

//#Q In which constellation did the brightest (Apparent magnitude -9) supernova occur?
//^ Lupus
//A Crater
//B Lupus
//C Antlia
//D Hydra

//#Q Which of these most closely describes a Mira Variable?
//^ A red star that pulsates once more than 100 days and changes by more than a magnitude
//A A variable that is in the constellation of Mensa
//B A star that suddenly brightens, dims, then is never as bright again
//C A red variable with an extreme change in brightness with a short pulsation period
//D A red star that pulsates once more than 100 days and changes by more than a magnitude

//#Q Which planet has an apparent magnitude of  -2.8 to -1.6?
//^ Jupiter
//A Venus
//B Mercury
//C Jupiter
//D Mars

//#Q Which of these smoking devices operates by water-filtration and direct heat?
//^ All of these
//A Hookah
//B All of these
//C Water pipe
//D Hubble-bubble

//#Q This 2003 independent film, directed by Jim Jarmusch, consists of eleven short stories, which focus on coffee and cigarettes.
//^ Coffee and Cigarettes
//A Buttermilk and Cigarettes
//B 200 Cigarettes and Black Coffee
//C None of these
//D Coffee and Cigarettes

//#Q Approximately how many different chemicals does a smoker inhale with one drag on the cigarette?
//^ over 4000
//A about 2000
//B about 200
//C over 4000
//D between 500 and 1000

//#Q Which is the first US national antismoking coalition, formed in 1964?
//^ National Interagency Council on Smoking and Health
//A Action on Smoking and Health
//B National Interagency Council on Smoking and Health
//C None of these
//D National Clearinghouse for Smoking and Health

//#Q The World No Tobacco Day, a global event sponsored by the World Health Organization, is held annually on which day?
//^ May 31
//A May 31
//B March 31
//C April 31
//D January 1

//#Q This type of tobacco is the mildest of all blending tobaccos and has the highest level of natural dextrose.
//^ Virginia
//A Perique
//B Burley
//C Latakia
//D Virginia

//#Q This rare, slow burning, strong-tasting tobacco is used as a component of many blended pipe tobaccos, but is too strong to be smoked pure.
//^ Perique
//A Havana
//B Virginia
//C Perique
//D Cavendish

//#Q Which of these cigarette brands is produced by Philip Morris International?
//^ All of these
//A LM
//B All of these
//C Marlboro
//D Parliament

//#Q What caused the death of Wayne McLaren and David McLean, famous for appearing in many Marlboro television and print advertisements?
//^ Lung cancer
//A Lung cancer
//B Car crash
//C Horse accident
//D Fire caused by a cigarette

//#Q How many fluid ounces do 48 quarts equal?
//^ 1,536
//A 1,563
//B 1,536
//C 1,635
//D 1,653

//#Q How many eggs are in 1 gross?
//^ 144
//A 144
//B 96
//C 12
//D 48

//#Q Using the apothecary system, how many grains are in 4 drams?
//^ 240
//A 240
//B 200
//C 180
//D 220

//#Q If a person bought a 5.05 acre tract, how many square feet would be in the 5.05 acre tract?
//^ 219,978
//A 217,800
//B 217,500
//C 219,675
//D 219,978

//#Q A woodcutter chopped down enough trees to have 896 cubic feet of firewood. How many cords did he chop?
//^ 7
//A 6
//B 4
//C 7
//D 5

//#Q A pharmacist was compounding a mixture for a topical antibiotic. Using the apothecary system, how many pounds did he make if the end product resulted in having twenty-four 3.5 ounce tubes?
//^ 7 pounds
//A 6.5 pounds
//B 5.25 pounds
//C 6 pounds
//D 7 pounds

//#Q How many pecks are in 8 bushels?
//^ 32
//A 32
//B 16
//C 36
//D 24

//#Q In order to always have exact change (using U.S. currency) and using the least amount of coins but having at least one of each coin, how many pennies, nickels, dimes and quarters do you have to carry? (The 50 cent piece is excluded).
//^ 3 quarters, 1 dime, 2 nickels, 4 pennies
//A 3 quarters, 1 dime, 2 nickels, 4 pennies
//B 2 quarters, 1 dime, 1 nickel, 4 pennies
//C 3 quarters, 2 dimes, 1 nickel, 4 pennies
//D 2 quarters, 3 dimes, 2 nickels, 4 pennies

//#Q In which unit measuring system do 2,240 pounds equal 1 ton?
//^ British
//A Avoirdupois
//B Both avoirdupois and British
//C British
//D None of these

//#Q A chain is a unit of measure used primarily in profession?
//^ Surveyor
//A A man in control of letting down the anchor on a ship
//B Lumberjacker
//C Fence installer
//D Surveyor

//#Q The human laryngeal prominence got its common name from this biblical figure.
//^ Adam
//A Jacob
//B Abraham
//C Joseph
//D Adam

//#Q The organ of Corti, named after Alfonso Corti, is located in this body part of mammals.
//^ Inner ear
//A Forebrain
//B Inner ear
//C Mammary gland
//D Eye

//#Q In what part of the human body are the Wormian bones, named after Ole Worm, located?
//^ Cranium
//A Thorax
//B Mandible
//C Pelvis
//D Cranium

//#Q What type of cells are the Purkinje cells, named after Czech anatomist Jan Evangelista Purkyne?
//^ Neurons
//A Epithelial cells
//B Osteoblasts
//C Neurons
//D Smooth muscle cells

//#Q What type of glands are the Glands of Montgomery?
//^ Sebaceous glands
//A Lacrimal glands
//B Sebaceous glands
//C Sudoriferous glands
//D Salivary glands

//#Q The Fallopian tubes are part of this system in the human body.
//^ Reproductive system
//A Digestive system
//B Reproductive system
//C Urinary system
//D Respiratory system

//#Q In what internal human organ are the islets of Langerhans located?
//^ Pancreas
//A Spleen
//B Pancreas
//C Liver
//D Kidney

//#Q In what part of the human body is the bundle of His located?
//^ Heart
//A Heart
//B Lungs
//C Testicles
//D Brain

//#Q Clara cells are found in this part of the human body.
//^ Lungs
//A Lungs
//B Tongue
//C Inner ear
//D Eyes

//#Q During what medical procedure can the so-called Korotkoff sounds be perceived?
//^ Taking blood pressure
//A Examining bowel movements
//B Taking blood pressure
//C All of these
//D Ultrasound examination of the fetus

//#Q We all know that the formula of water is H2O but can you remember this important property of water: in the water molecule at what angle is each of the hydrogen atoms from the oxygen atom?
//^ 104.45 degrees
//A 180 degrees
//B 114.5 degrees
//C 90 degrees
//D 104.45 degrees

//#Q What is heavy water made of ?
//^ Two deuterium atoms and one oxygen atom
//A Two hydrogen atoms and two oxugen atoms
//B Two deuterium atoms and one oxygen atom
//C Two oxygen atoms and one hydrogen atom
//D Three hydrogen atoms and one oxygen molecule.

//#Q The USA leads” the world in per capita consumption of water. Which country is second?
//^ Canada
//A China
//B India
//C Canada
//D Brazil

//#Q About 95% of fresh water in the USA is underground. What is the name of the biggest source of fresh water in the USA?
//^ The Ogallala Aquifer
//A The Lake Superior Aquifer
//B The Ogallala Aquifer
//C The Tampa Aquifer
//D The Columbian Aquifer

//#Q On which Chinese river is the 2335 meters (7660 ft) long and 185 meters (616 ft) high Three Gorges Dam located?
//^ The Yangtze
//A The Huang He
//B The Yangtze
//C The Pearl River
//D The Lian

//#Q Control of the Ganges River, sacred to some people, has been much disputed between which two nations?
//^ India and Bangladesh
//A India and Bangladesh
//B India and Myanmar
//C India and Pakistan
//D India and China

//#Q Pure water, if it exists, has this pH.
//^ 7
//A 7
//B 1
//C 14
//D 0

//#Q There are high tides and low tides in the bigger water bodies on Earth. Which statement is true about tides?
//^ Tides are caused by the gravitational forces of both the Moon and the Sun.
//A Tides are caused by x-rays, not gravity.
//B Tides are caused by the gravitational effect of the Sun only.
//C Tides are caused by the gravitational forces of both the Moon and the Sun.
//D Tides are caused by the gravitational effect of the Moon only.

//#Q What is the term for the points in the lunar cycle when the tides range is minimal?
//^ Neap Tide
//A Ebb Tide
//B Adoble Tide
//C Perigean Tide
//D Neap Tide

//#Q Water sticks to itself. What is this property called?
//^ Molecular cohesion
//A Delaification
//B Atomic pedalation
//C Hydrogenation
//D Molecular cohesion

//#Q It is amazing but true that sometimes hot water can freeze faster than cold water. What is this effect called?
//^ Mpemba Effect
//A Deplembes Effect
//B Mpemba Effect
//C Fourier Effect
//D Torricelli Effect

//#Q The 2005 movie Water centered on people from this country.
//^ India
//A Morocco
//B China
//C Chad
//D India

//#Q What does the scientific term virga mean?
//^ Rain that never hits Earth
//A The effect on Mars that makes it appear as if water was on Mars
//B Rain that never hits Earth
//C The salt that remains after sea water has been desalinated
//D Water that has undergone desalination

//#Q It has been proved that drinking only bottled water can have this effect on your health.
//^ Increase in dental problems
//A Increase in body fat
//B Increase in weight
//C Increase in dental problems
//D Increase in heart disease

//#Q Venus is named after the Roman Goddess of what?
//^ Love
//A Truth
//B Lust
//C Love
//D Beauty

//#Q The Planet Venus orbits the Sun once every how many days?
//^ 225
//A 325
//B 200
//C 125
//D 225

//#Q Venus travels around the Sun at an average distance of how many miles?
//^ 67 million miles
//A 120 million miles
//B 67 million miles
//C 1.2 billion miles
//D 38 million miles

//#Q Venus is the third brightest object in the sky after the Sun and what other object?
//^ The Moon
//A Proxima Centuri
//B Aldeberan
//C Sirius
//D The Moon

//#Q Which scientist discovered the atmosphere of Venus?
//^ Mikhail Lomonosov in 1761 A.D
//A Galileo Galilei in 1702 A.D.
//B Pythagoras in 546 B.C.
//C Giovanni Cassini in 1790 A.D.
//D Mikhail Lomonosov in 1761 A.D

//#Q Venus has the densest atmosphere of the Solar System. What gaseous element comprises the bulk of the atmosphere?
//^ Carbon Dioxide
//A Oxygen
//B Neon
//C Carbon Dioxide
//D Helium

//#Q What was the name of the first interplanetary probe to study Venus?
//^ Mariner 2
//A Mariner 1
//B Verona 1
//C Verona 2
//D Mariner 2

//#Q Because of the Greenhouse Effect, Venus has the hottest surface temperature in the Solar System. What is the average temperature on Venus?
//^ 460 Degrees C.
//A 1,200 Degrees C.
//B 135 Degrees C.
//C 460 Degrees C.
//D 800 Degrees C.

//#Q Venus has no natural satellite or moon.
//^ True
//A False
//B True

//#Q What was the first privately financed craft to go into outer space?
//^ SpaceShipOne
//A The SpaceX Dragon
//B MIR
//C SpaceHab
//D SpaceShipOne

//#Q What was the first person to fly a balloon that was filled with hydrogen gas?
//^ Jacques A.C.Charles
//A Count Ferdinand Zeppelin
//B Francois F. DeRozier
//C Joseph Montgolier
//D Jacques A.C.Charles

//#Q What is the difference between a balloon and a zeppelin?
//^ A zeppelin has a rigid frame around the balloon containing the gases.
//A A balloon can only go up and down; it cannot go East-West or left-right.
//B A zeppelin has a pilot or pilots below the gas filled chamber.
//C A zeppelin has a rigid frame around the balloon containing the gases.
//D A zeppelin is filled with specific gases rather than hot air.

//#Q In 1883 Otto Lilienthal became the first person to successfully fly this type of aircraft.
//^ Glider
//A Thermaclimber
//B Glider
//C Graf Zeppelin
//D Heavier than air balloon

//#Q When Charles Lindbergh crossed the Atlantic, he had almost no visibility from his front windows.
//^ True
//A False
//B True

//#Q Schiphol Airport is the main airport of this city.
//^ Amsterdam
//A Brussels
//B Berlin
//C Amsterdam
//D Vienna

//#Q Paul MacCready designed the first working solar plane. What was its name?
//^ Gossamer Penguin
//A Solar Challenger
//B DaVinci Solar Wind
//C Solar Impulse
//D Gossamer Penguin

//#Q Who was the first person to fly solo nonstop around the world in a balloon?
//^ Steve Fossett
//A Heinrich Kubis
//B Steve Fossett
//C Richard Rutan
//D John Alcock

//#Q How fast is Mach 1?
//^ 1207 kilometers per hour
//A 1207 kilometers per hour
//B 1207 meters per hour
//C 1207 feet per second
//D 1207 miles per hour

//#Q What was the name of the first space station?
//^ Salyut
//A MIR
//B Soyuz
//C Skylab 1
//D Salyut

//#Q In 1956, Tennessee businessman David Flexer had this great idea.
//^ Show movies on airline flights
//A Have airlines transport packages on long flights
//B Show movies on airline flights
//C Build a supersonic airplane
//D Have floatation devices aboard airline flights

//#Q In what year was the first in-flight meal served?
//^ 1919
//A 1969
//B 1949
//C 1919
//D 1959

//#Q What is the name of the first in-flight magazine for commercial flights?
//^ Clipper
//A Air News
//B Pan American News
//C Traveller
//D Clipper

//#Q In 1938 Doug Corrigan set out on a flight from New York to California. What nickname did he get after the flight?
//^ Wrong Way Corrigan
//A Day/Night Corrigan
//B California DreaminCorrigan
//C Wrong Way Corrigan
//D All-the-Way Corrigan

//#Q Which airlines  introduced  the frequent flyer program?
//^ American Airlines
//A KLM
//B Delta Airlines
//C Pan American Airlines
//D American Airlines

//#Q In what year did an airplane first hit 200 miles per hour?
//^ 1922
//A 1944
//B 1922
//C 1955
//D 1933

//#Q Who was the first US Senator to fly on the Space Shuttle?
//^ Jake Garn
//A Bill Bradley
//B Jake Garn
//C Tom McMillan
//D John Glenn

//#Q Who was the first actor to attain the rank of Brigadier General in the US Air Force?
//^ James Stewart
//A William Bendix
//B Kirk Douglas
//C James Stewart
//D Clark Gable

//#Q What distinction does Dennis Tito hold?
//^ He was the first tourist in space.
//A He was the first tourist in space.
//B He was the first person to fly the Shuttle, shoot down an enemy  fighter, and fly a balloon across the Atlantic.
//C He was the first person to fly the Shuttle three times.
//D He was the first person to make a space walk.

//#Q Which of these particles has a negative charge?
//^ Electron
//A Neutron
//B Electron
//C Proton
//D Posititron

//#Q This person is given credit for coining the term surfing the internet.
//^ Jean Armour  Polly
//A Marvin Minsky
//B Tim Lee-Berniers
//C Jean Armour  Polly
//D Gregory Chaitin

//#Q Who helped invent the blender?
//^ Fred Waring
//A Carl Sontheimer
//B Fred Waring
//C Carl Frederick Winson
//D Gene Armor Polly

//#Q The Earths atmosphere is about 78.8 % nitrogen and almost 21 % oxygen. This element is the third most abundant comprising about 0.93 % of the atmosphere.
//^ Argon
//A Helium
//B Krypton
//C Phosphorous
//D Argon

//#Q Which is the highest layer of the Earth’s atmosphere?
//^ Exosphere
//A Iconosphere
//B Ectosphere
//C Exosphere
//D Endosphere

//#Q Which of these units for distance is the longest?
//^ 1 par sec
//A 1 par sec
//B 1 light year
//C 1 galactic year
//D 1 astronomical unit

//#Q Find the correct statement about cyclones.
//^ In the Northern Hemisphere cyclones move in a counterclockwise direction.
//A Cyclones always carry hot air.
//B In the Northern Hemisphere cyclones move in a counterclockwise direction.
//C Cyclones are high pressure systems.
//D In cyclones air moves away from the center.

//#Q Which of the following terms describes a dark layer of clouds that bring rain or snow?
//^ Nimbostratus
//A Stratocumulus
//B Cirrus
//C Nimbostratus
//D Altocumulus

//#Q This is a synonym for neutron star.
//^ Pulsar
//A White Dwarf
//B Black hole
//C Pulsar
//D Questars

//#Q Which type of mirror produces an image that is smaller than the original?
//^ Concave
//A Convex
//B Flat
//C Concave-Convex
//D Concave

//#Q Loudness is measured in decibels. A pneumatic drill at about 40 feet gives about 85 decibels. How many decibels result from an airplane taking off 200 feet (60 m) away?
//^ 120
//A 110
//B 300
//C 95
//D 120

//#Q The poles of magnets are able to point the way because of ferromagnetic materials deep inside the Earth’s core.
//^ False
//A False
//B True

//#Q Scientists are using this animal to try and find a vaccine for leprosy.
//^ Armadillos
//A Armadillos
//B Poison dart frogs
//C Sea Urchins
//D Bats

//#Q What is the lightest element that is a metal?
//^ Lithium
//A Titanium
//B Lithium
//C Cobalt
//D Boron

//#Q The first fly by” for the planet Mars occurred in this year.
//^ 1965
//A 1975
//B 1955
//C 1945
//D 1965

//#Q In math and science a double tilda is often used as  a symbol. Which is symbolized by a double tilde?
//^ Is approximately equal to
//A Has the same atomic number as
//B Has the same first derivative as
//C Is approximately equal to
//D Has the same atomic weight as

//#Q The first artificial satellite to orbit Mars orbited the planet for 12 months beginning in this year.
//^ 1971
//A 1981
//B 1991
//C 2001
//D 1971

//#Q Which of these waves have the highest wave length?
//^ Radio waves
//A Microwaves
//B Infra -red waves
//C X-rays
//D Radio waves

//#Q Dinosaurs can be divided into two groups: Ornithschians and Saurischians. The difference between them is mainly in the structure of this part of their bodies.
//^ Hips
//A Eyes
//B Hips
//C Teeth
//D Toes

//#Q Which of these living creatures appearred on Earth first?
//^ Fish
//A Fish
//B Reptiles
//C Seed plants
//D Birds

//#Q What was the animal featured in the insignia of the Apollo 11 mission, the first mission to land a human being on the Moon?
//^ An eagle
//A A hawk
//B An eagle
//C A bear
//D A lion

//#Q Who was the President of the United States at the time when Apollo 11 landed on the Moon?
//^ Richard Nixon
//A John F.Kennedy
//B Lyndon B. Johnson
//C Gerald Ford
//D Richard Nixon

//#Q What was the name of the command module of Apollo 11?
//^ Columbia
//A Columbia
//B Eagle
//C Georgia
//D Thunder

//#Q Which of the three astronauts from Apollo 11 remained in the command module while the other two separated along with the lunar module?
//^ Michael Collins
//A Neil Alden Armstrong
//B Michael Collins
//C Edwin Eugene Buzz Aldrin, Jr.
//D All of these

//#Q How did Edwin Eugene Buzz Aldrin, Jr. get his nickname Buzz?
//^ His sister gave it to him.
//A He was given that nickname because he was an engineer.
//B His sister gave it to him.
//C He was extremely talkative as a child, to the point of being annoying.
//D His beloved grandfather called him Buzz.

//#Q Which of the three astronauts from Apollo 11 has lost a child in 1962?
//^ Neil Armstrong
//A Both Collins and Armstrong
//B Neil Armstrong
//C Edwin Eugene Buzz Aldrin, Jr.
//D Michael Collins

//#Q How much time did the astronauts from Apollo 11 spend on the lunar surface?
//^ 2½ hours
//A About 60 minutes
//B 5 hours
//C 35 minutes
//D 2½ hours

//#Q Which of these objects did the astronauts from Apollo 11 leave on the Moon surface during their mission?
//^ All of these
//A Two drawings of the Western and Eastern Hemispheres of the Earth
//B All of these
//C The signature of the American president, and their own signatures
//D An American flag

//#Q Buzz Aldrin made a guest star appearance in an episode of The Simpsons. What was his comment when Homer Simpson showed no recognition of him being the second man to walk on the Moon?
//^ Second comes right after first!
//A Second comes right after first!
//B Hey, I was just a second late!
//C Im famous, the rest is history.
//D How many times have you been on the Moon?

//#Q On May 1, 2009, the three astronauts from Apollo 11 were granted this exceptional award.
//^ Congressional Gold Medal
//A All of these
//B Purple heart
//C Congressional Gold Medal
//D Presidential Medal of Freedom

//#Q Electrooculography is a medical procedure which inspects the potential of which bodily organ?
//^ Retina
//A Retina
//B Inner ear
//C Adrenal glands
//D Taste buds

//#Q On which part of the body is the surgical procedure osteotomy performed?
//^ Bones
//A Duodenum
//B Tonsils
//C Smooth muscle tissue
//D Bones

//#Q Sigmoidoscopy is a medical examination of which internal organ?
//^ Large intestine
//A Gallbladder
//B Brain cavity
//C Large intestine
//D Uterus

//#Q What is transplanted during the medical procedure xenotransplantation?
//^ Tissues from one species to another
//A Organs from one person to another
//B Blood from one person to another
//C All of these
//D Tissues from one species to another

//#Q Tympanoplasty is a type of reconstructive surgery performed on which part of the body?
//^ Eardrum
//A Fingers or toes
//B Eardrum
//C Skull bones
//D Knees

//#Q Genioplasty or mentoplasty is a cosmetic surgery procedure which aims at improving the appearance of which part of the body?
//^ Chin
//A Chin
//B Buttocks
//C Genitals
//D Knees

//#Q Nephrectomy is a surgical removal of which internal organ?
//^ Kidney
//A Kidney
//B Thyroid gland
//C Pancreas
//D Spleen

//#Q Blepharoplasty is a cosmetic surgery procedure which aims at improving the appearance of which body part?
//^ Eyelids
//A Forehead
//B Neck
//C Lips
//D Eyelids

//#Q What body part is involved in the medical procedure called orchiopexy?
//^ Testicle
//A Teeth
//B Tendons
//C Navel
//D Testicle

//#Q Debridement is a medical procedure which is administered in which case?
//^ All of these
//A Infected tissue
//B Presence of dead tissue
//C All of these
//D Damaged tissue

//#Q The first successful experiment with nuclear fission, the process in which the nucleus of an atom splits into two or more smaller nuclei, was conducted in which year?
//^ 1938
//A 1938
//B 1932
//C 1934
//D 1936

//#Q These two physicists received the 1951 Nobel Prize for Physics for their pioneering work popularly known as splitting the atom.
//^ John Cockroft and Ernest Walton
//A Eugene Wigner and Lyman Briggs
//B Lise Meitner and Otto Robert Frisch
//C Leo Szilard and Edward Teller
//D John Cockroft and Ernest Walton

//#Q This is the year in which the worlds first nuclear power plant generating electricity for commercial use was officially connected to the Soviet power grid.
//^ 1954
//A 1954
//B 1956
//C 1953
//D 1955

//#Q This place, popular as the center of the Whiskey rebellion, is the worlds first nuclear powered city.
//^ Pittsburgh, Pennsylvania
//A San Diego, CA
//B Baltimore
//C Pittsburgh, Pennsylvania
//D Washington, D.C.

//#Q This 1903 Nobel Prize laureate  discovered radioactivity in 1896.
//^ Henri Becquerel
//A Wilhelm Conrad Rontgen
//B Henri Becquerel
//C Elihu Thomson
//D Niels Bohr

//#Q The International Nuclear Events Scale, used to signify the grade of nuclear accidents, has how many levels?
//^ 7
//A 6
//B 7
//C 3
//D 10

//#Q The first Peaceful Nuclear Explosion (PNE) blast in the US was conducted in which year?
//^ 1961
//A 1960
//B 1959
//C 1961
//D 1965

//#Q What was the codename of the first US thermonuclear bomb test, carried out in 1954?
//^ Castle Romeo
//A Operation Chariot
//B Castle Romeo
//C Operation Fat Man
//D Operation Argus

//#Q This group of alloys, which is a combination of at least one metal and one or more other elements, is used to clad fuel rods in nuclear plants.
//^ Zircaloy
//A Amalgam
//B Zircaloy
//C Hastelloy
//D Electrum

//#Q This American physicist was the youngest group leader of the Manhattan Project, a joint effort by the US and their WW II allies to develop the first nuclear weapons.
//^ Robert R. Wilson
//A Henry DeWolf Smyth
//B Edward Teller
//C Robert R.Wilson
//D Ernest O. Lawrence

//#Q What is the name of the red supergiant that marks Orions right shoulder?
//^ Betelgeuse
//A Betelgeuse
//B Taneriss
//C Bellatrix
//D Regulus

//#Q Which of the following is the brightest star in the winter night sky of the northern hemisphere?
//^ Sirius
//A Sirius
//B Procyon
//C Strebe
//D Aldeberan

//#Q What is the name of the star cluster that is also known as “The Seven Sisters”?
//^ Pleiades
//A Bennekryse
//B Arcturus
//C Altair
//D Pleiades

//#Q What are the two twin stars in the constellation Gemini?
//^ Castor Pollux
//A Spica  Arcturus
//B Castor Pollux
//C Voltron  Yularis
//D Merak Dubhe

//#Q The North Star, Polaris, is located within which constellation?
//^ Ursa Minor
//A Ursa Minor
//B Ursa Major
//C Canis Lupus
//D Canis Minor

//#Q What is the constellation Ursa Major commonly known as?
//^ The Big Dipper
//A The Big Dipper
//B The Great Fisherman
//C The Lion
//D Hercules

//#Q Which of the following is NOT a constellation of the Zodiac (the ring of constellations that the sun passes through each year)?
//^ The Winged Horse
//A The Fish
//B The Winged Horse
//C The Crab
//D The Archer

//#Q What large and obvious summer asterism do Vega, Deneb, and Altair form?
//^ Summer Triangle
//A Summer Cross
//B Summer Hex
//C Summer Triangle
//D Summer Pyramid

//#Q How many recognized constellations are there in Earth’s entire view?
//^ 88
//A 244
//B 88
//C 106
//D 33

//#Q In what year did 23-year-old American Clyde Tombough discover Pluto, or Planet X, as it was termed then?
//^ 1930
//A 1930
//B 1878
//C 1910
//D 1754

//#Q Although discovered in the United States, Plutos name came from Europe - it was suggested by Falconer Maden, a former librarian at the Oxford University Bodleian Library.
//^ False
//A True
//B False

//#Q Which of these statements is NOT true about Pluto?
//^ It is the largest object of the Solar Systems asteroid belt.
//A It is a dwarf-planet.
//B It is a binary planet.
//C It is a member of the Kupier belt.
//D It is the largest object of the Solar Systems asteroid belt.

//#Q Spectroscopic analysis revealed that Plutos surface is composed mainly of this element.
//^ Nitrogen
//A Oxygen
//B Carbon
//C Ozone
//D Nitrogen

//#Q Which is the wrong statement about the features of Plutos orbit?
//^ At certain moments in time, it crosses Neptunes orbit.
//A In the long term, it is chaotic.
//B At certain moments in time, it crosses Neptunes orbit.
//C It is inclined compared to the plane of other planets orbits.
//D It is elliptical.

//#Q What is unusual about Plutos three known moons compared to other moons in the Solar System?
//^ They are untypically close to Pluto.
//A They orbit Pluto at a very high speed.
//B They are asteroids from another solar system attracted by Pluto and captured by gravitational forces.
//C They are untypically close to Pluto.
//D Their orbits are unusually big and elliptical.

//#Q If one were to look at the sky from Plutos surface, every 17 hours they would observe exceptionally beautiful rises of Charon because of its closeness to Pluto.
//^ False
//A True
//B False

//#Q What feature would Pluto develop if placed as near to the Sun as Earth is?
//^ A comet tail
//A A comet tail
//B A highly elliptic orbit
//C None of these
//D A halo

//#Q Pluto was the ninth planet of the Solar System for 76 years - from its discovery in 1930 until 2006 when it was reclassified as a dwarf planet.
//^ True
//A False
//B True

//#Q The reclassification of Pluto as a dwarf planet in 2006 caused the emerging of what?
//^ New word in English
//A Risings among astronomy teaches in the USA
//B New ethnical conflicts in the Middle East
//C New word in English
//D A sect of violent Pluto followers

//#Q Viruses are so small that you need a special light microscopе to observe most of them.
//^ False
//A True
//B False

//#Q How do viruses reproduce?
//^ By forcing other cells to produce copies of them
//A By transforming other cells into viruses
//B By cell division
//C By maitng
//D By forcing other cells to produce copies of them

//#Q In virology, what does the term vector refer to?
//^ An organism that carries a virus but is not infected by it
//A An organism that carries a virus but is not infected by it
//B An organism infected by a virus
//C A virus that does not parasite on cells but lives independently
//D A virus that spreads through the air

//#Q Bacteriophages are organisms that have the characteristics of both viruses and bacteria.
//^ False
//A False
//B True

//#Q Virus fossils from several thousand years ago show what about the origin of viruses?
//^ None of these
//A None of these
//B They were once small cells that lived parasitically on bigger ones.
//C They appeared and evolved simultaneously with life on Earth.
//D They evolved from bits of DNA that escaped from cells of organisms.

//#Q When infected by a virus, the bodies of animals and humans start producing a special hormone - interferon. How does interferon help the organism fight virus infections?
//^ By killing the infected cells and their neighbouring cells
//A By releasing in the body acids fatal for the viruses
//B By stimulating it to produce antibodies
//C By boosting the production of white blood cells
//D By killing the infected cells and their neighbouring cells

//#Q Which of the following is not one of the defense mechanisms against viruses in humans?
//^ The resistance (R) gene
//A Acid nature of the stomach contents
//B RNA interference
//C Production of antibodies
//D The resistance (R) gene

//#Q Antibiotics are used to treat virus infections in animals and humans but are ineffective in plant virus infections.
//^ False
//A True
//B False

//#Q Which stage of the virus life-cycle restricts it to infecting only a certain species (or group) of organisms?
//^ Attachment to host
//A Assembly of viral particles
//B Replication of the viral DNA or RNA
//C Release of viral particles
//D Attachment to host

//#Q Which of these is not one of the methods used by viruses to make the host cell release the newly produced viruses?
//^ Virosis
//A Apoptosis
//B Budding
//C Virosis
//D Lysis

//#Q Mount Rumpke is the highest point and the biggest landfill in Ohio. Its technical name is The Rumpke Sanitary Landfill.
//^ False
//A True
//B False

//#Q Approximately how many trees does it  take to make one ton of paper?
//^ 17
//A 170
//B 34
//C 1100
//D 17

//#Q The first week of June, 2007 was Recycle Now week in  England. Which of these events was featured in its program?
//^ Beautiful women, parading in bathing suits, made of recycled steel.
//A Building a prison, made of recycled tires.
//B Beautiful women, parading in bathing suits, made of recycled steel.
//C Children, demonstrating how to recycle uranium.
//D Repaving Fleet Street with recycled paper.

//#Q In 2002, a college research team built a 42-foot bridge across the Raritan River. What were the beams for the bridge made from?
//^ Recycled polystyrene cups and milk containers
//A Recycled school erasers
//B Recycled tires
//C Recycled polystyrene cups and milk containers
//D Recycled aluminum cans

//#Q The boat Earthrace made an attempt to break the record for a circumnavigation of the Earth. It also made voyages to promote the use of bio-fuels. Which of these is one of the substances used to make the bio-diesel, that powers the boat?
//^ Liposuctioned body fat
//A Burnt uranium
//B Old computer motherboards
//C Recycled clothing hangers
//D Liposuctioned body fat

//#Q On January 31, 2008, China announced that it will recycle these to resurface roads.
//^ Robbie Williams Cds
//A Robbie Williams Cds
//B Old cars
//C Coal
//D Old  tires

//#Q Which of these companies recycled old sneakers to make tennis courts?
//^ Nike
//A Banta
//B Nike
//C Adidas
//D Reebok

//#Q Isao Miyoshi is a very clever recycler from Japan. What did he recycle?
//^ Dentures
//A Pachinko machines
//B Roulette wheels
//C Dentures
//D Old Macintosh computers

//#Q Fiberfill is used to make ski jackets. What can be recycled to make enough Fiberfill for one ski jacket?
//^ 5 plastic soda bottles
//A 384 pounds of newspaper
//B 5 plastic soda bottles
//C 1045 styrene cups
//D 149 pounds of composted lawn material

//#Q Approximately how much paper does the average American use in one year?
//^ 580 pounds
//A One ton ( 2000 pounds)
//B 3,400 pounds
//C 1,500 pounds
//D 580 pounds

//#Q Approximately what percentage of Americas waste is paper?
//^ 39 %
//A 39 %
//B 14 %
//C 8 %
//D 24 %

//#Q Carbon dioxide is a very common pollutant. Approximately how much carbon dioxide is produced by the average American each year?
//^ 22 tons
//A 22 tons
//B 5 tons
//C 93  tons
//D 1 ton

//#Q Luiz Bispo built a floating house for about $170. How is his house able to float?
//^ It is made out of recycles plastic bottles.
//A It is made out of recycled cigars and cigarettes.
//B It is made out of recycled tires.
//C It recycles carbon dioxide throughout  the house, making it buoyant.
//D It is made out of recycles plastic bottles.

//#Q In olden days urine was recycled.
//^ True
//A True
//B False

//#Q In Mannheim, Germany, people began recycling this.
//^ Dead pets to make fertilizer
//A Coffee grinds to make jewelry
//B Old PCs to make radar equipment  for traffic control
//C Old swords and knives to make I-beams
//D Dead pets to make fertilizer

//#Q In Sussex, England, the Ecopod Company uses recycled paper to make these.
//^ Coffins
//A Coffins
//B Food canisters
//C Apartments
//D Dog houses

//#Q What father-daughter film stars as on-screen father and daughter Moses and Addie in the movie Paper Moon?
//^ Ryan ONeal and Tatum ONeal
//A None of these
//B Paul Newman and Nell Potts
//C Ryan ONeal and Tatum ONeal
//D Henry Fonda and Jane Fonda

//#Q What valley in California is referenced in Jack Londons novel The Valley of the Moon?
//^ Sonoma Valley
//A Death Valley
//B Sierra Valley
//C Deep Springs Valley
//D Sonoma Valley

//#Q Which song, included on Pink Floyds concept album The Dark Side of the Moon, contains the following lyrics:
//And you run and you run to catch up with the sun, but its sinking
//And racing around to come up behind you again
//The sun is the same in the relative way, but youre older
//Shorter of breath and one day closer to death?
//^ None of these
//A On the Run
//B Breathe
//C The Great Gig in the Sky
//D None of these

//#Q The soundtrack for which of these movies does not include the popular song Blue Moon, written by Richard Rodgers and Lorenz Hart?
//^ Bitter Moon
//A Grease
//B Bitter Moon
//C Blue Moon (2002)
//D Notting Hill

//#Q What Academy Award-winning European-born director produced and directed the drama movie Bitter Moon, starring Peter Coyote?
//^ Roman Polanski
//A Emir Kusturica
//B Milos Forman
//C Roman Polanski
//D Pedro Almodovar

//#Q What Australian pop duo performed the 1990s hit To the Moon and Back?
//^ Savage Garden
//A The Seekers
//B Savage Garden
//C Soundgarden
//D INXS

//#Q Name Samuel Coleridges longest poem which contains the lines:
//The moving Moon went up the sky.
//And nowhere did abide.
//^ The Rime of the Ancient Mariner
//A The Rime of the Ancient Mariner
//B Kubla Khan
//C A Vision in a Dream
//D The Pains of Sleep

//#Q What actress won the Academy Award for Best Actress for the portrayal of Loretta Castorini in the romantic comedy Moonstruck?
//^ Cher
//A Olympia Dukakis
//B Sophia Loren
//C Cher
//D Meryl Streep

//#Q Ludwig van Beethoven included the Italian phrase, Quasi una fantasia in the title of his Piano Sonata No. 14, popularly known as the Moonlight Sonata. What does this Italian phrase mean in English?
//^ Almost a fantasy
//A Just a fantasy
//B Almost a fantasy
//C A pure fantasy
//D Reality and fantasy

//#Q Name the alter ego of Marvel Comics fictional character Moon Knight.
//^ Marc Spector
//A Marc Spector
//B Victor Spector
//C Steve Rogers
//D Douglas Ramsey

//#Q What protein is the main component of the hair fiber?
//^ Keratin
//A Fibrin
//B Carnitine
//C Chitin
//D Keratin

//#Q Humans have much smaller amount of hair follicles in their skin per unit area than other primates.
//^ False
//A False
//B True

//#Q What is is average growth rate of normal hair follicles on the human scalp?
//^ 400 µm per day
//A 1 mm per day
//B 100 µm per day
//C 400 µm per day
//D 800 µm per day

//#Q The first facial hair appears in this area during puberty.
//^ Corners of the upper lip
//A Corners of the upper lip
//B Sides of the chin
//C Lower jaw
//D Under the lower lip

//#Q What is the condition of having a unibrow called?
//^ Synophrys
//A Monobrowphism
//B Uniphys
//C All of these
//D Synophrys

//#Q What scientific term denotes body hair?
//^ Androgenic hair
//A Androgenic hair
//B Somatic hair
//C All of these
//D Puberty hair

//#Q One type of hair on the human body is called vellus hair. Where is it located?
//^ All over the body
//A On the pubic bone
//B All over the body
//C On fingers and toes
//D On the scalp

//#Q Lanugo is a term related to hair. What does it mean?
//^ Fine hair that grows on fetuses
//A A parasite that feeds on human hair
//B A medical condition connected with loss of hair
//C A type of grease that Eskimos use to keep their hair conditioned
//D Fine hair that grows on fetuses

//#Q Which of these terms refers to armpit hair?
//^ Axillary hair
//A Pubic hair
//B Guard hair
//C None of these
//D Axillary hair

//#Q What medical term refers to hair loss?
//^ Alopecia
//A Alocasia
//B Preeclampsia
//C All of these
//D Alopecia

//#Q If not controlled, diabetes causes all of the following EXCEPT this one.
//^ Colon cancer
//A Blindness
//B Colon cancer
//C Heart attacks
//D Kidney failure

//#Q Uncontrolled hypertension (high blood pressure) leads to all of the following EXCEPT this one.
//^ Thyroid disease
//A Heart disease
//B Thyroid disease
//C Kidney failure
//D Stroke

//#Q Its normal for blood pressure to be quite elevated during strenuous activity.
//^ True
//A False
//B True

//#Q Blood sugars are checked under 2 conditions: Fasting and Post-prandial. Fasting means after having not eaten (for example in the morning on rising). Post-prandial means after eating. When are post-prandial checks typically taken?
//^ 2 hours after eating
//A 30 minutes after eating
//B 1 hour after eating
//C 2 hours after eating
//D Immediately after eating

//#Q All of the following foods contain cholesterol EXCEPT this food.
//^ Okra fried in vegetable oil
//A Eggs
//B Okra fried in vegetable oil
//C Ice cream
//D Fish

//#Q Which of the following is a normal fasting blood sugar?
//^ Less than 100 mg/dl (5.6 mmol/L)
//A Less than 160 mg/dl(8.9 mmol/L)
//B Less than 140 mg/dl(7.8 mmol/L)
//C Less than 100 mg/dl(5.6 mmol/L)
//D Less than 125 mg/dl(6.9 mmol/L)

//#Q Which of the following is a normal post-prandial blood sugar?
//^ Less than 140 mg/dl(7.8 mmol/L)
//A Less than 140 mg/dl(7.8 mmol/L)
//B Less than 125 mg/dl(6.9 mmol/L)
//C Less than 160 mg/dl(8.9 mmol/L)
//D Less than 200 mg/dl(11.1 mmol/L)

//#Q It has been shown that people with diabetes are less likely to have a heart attack if they take a cholesterol-lowering medication, even if their cholesterol level is perfectly normal already.
//^ True
//A True
//B False

//#Q Normal blood pressure levels are higher for older patients.
//^ False
//A False
//B True

//#Q What does long in the tooth mean?
//^ Old
//A Old
//B Tedious
//C Wise
//D Boring

//#Q The molars of todays African elephant can be longer than a foot.
//^ True
//A True
//B False

//#Q Only three groups of land creatures get cavities - humans, pets kept by humans, and this group.
//^ Bears
//A Rodents
//B Bears
//C Tigers
//D Armadillos

//#Q Which of the following is least likely to cause tooth decay according to The American Dental Association?
//^ simple sugars
//A potato chips
//B breadsticks
//C simple sugars
//D cereals

//#Q Which statement regarding snakes is true?
//^ All snakes have teeth but not all snakes have fangs.
//A All snakes have teeth but not all snakes have fangs.
//B All sea snakes have fangs.
//C All snakes have fangs.
//D All land snakes have fangs.

//#Q Which statement is untrue?
//^ When a gorilla is angry it shows its teeth.
//A When a gorilla is angry it shows its teeth.
//B Mosquitoes have teeth.
//C The Statue of Libertys teeth are 3 feet wide.
//D Lemon sharks grow new teeth every two weeks.

//#Q The first human to have an inch long tooth was a fourth grade student in Ontario, Canada.
//^ True
//A False
//B True

//#Q Orin Scivello is the name of a fictional dentist in this movie that was made into a play. Steve Martin portrayed him in the movie remake.
//^ Little Shop of Horrors
//A Oz
//B Little Shop of Horrors
//C My Family
//D Wicked

//#Q In a 1976 thriller, as Sir Laurence Oliviers character drills into Dustin Hoffmans characters unanesthesied tooth, he asks Hoffmans character this question.
//^ Is it safe?
//A Is it safe?
//B Will they come?
//C Where are the jewels?
//D Where?

//#Q Which of these architectural styles is the earliest?
//^ Greek
//A Gothic
//B Greek
//C Renaissance
//D Roman

//#Q Of these roof types, which one is least likely to have gables?
//^ Hipped Roof
//A Pitched Roof
//B Gambrel Roof
//C Cat Slide Roof
//D Hipped Roof

//#Q Lets say that a statistical analysis of the people of the United States shows that Texans are on average taller, and that Texans also are on average richer. What conclusion can one draw from this result?
//^ There might or might not be a relationship between being tall and being rich.
//A There might or might not be a relationship between being tall and being rich.
//B Being rich leads to being tall.
//C Being tall leads to being rich.
//D If you want to be rich, you should move to Texas.

//#Q Lets say youre conducting a study to see whether a new experimental medication will cause bald men to grow hair. You divide your patients into 2 groups. To one group you give the medication. To the other group, you give a placebo. In this study, the correct terms for the taking of the medication and the growth of hair are the following.
//^ The medication is the independent variable, and the hair growth is the dependent variable.
//A The medication is the dependent variable, and the hair growth is the independent variable.
//B Both the medication and the hair growth are dependent variables.
//C Both the medication and the hair growth are independent variables.
//D The medication is the independent variable, and the hair growth is the dependent variable.

//#Q Lets say youre conducting a survey of the people of the United States to find out how popular the president is. You randomly choose people to call, and make 1,000 phone calls to people scattered across the country. In this study, what is the statistics term for THE PEOPLE IN THE U.S., and what is the statistics term for THE PEOPLE YOU CALLED?
//^ The people of the U.S.are the POPULATION, and the people you called are the SAMPLE.
//A The people of the U.S.are the POPULATION, and the people you called are the SAMPLE.
//B The people of the U.S.are the SAMPLE, and the people you called are the POPULATION.
//C Both the people of the U.S.and the people you called are POPULATIONS.
//D Both the people of the U.S.and the people you called are SAMPLES.

//#Q Lets say you want to know whether a medication is effective for curing the common cold. You take 1,000 people with colds, and divide them into 2 groups of 500. You give the medication to one group, and placebo to the other group. To make this a DOUBLE-BLIND study, what would you have to do?
//^ Conceal from both the patients and the experimenters which pills are medication and which pills are placebo.
//A Conceal from both the patients and the experimenters which pills are medication and which pills are placebo.
//B Dont tell the administrators of the experiment whether theyre giving out medication or placebo.
//C Put blindfolds on the 500 people who get the medication.
//D Dont tell the patients of either group whether theyre getting medication or placebo.

//#Q Statistics is useless, since you can design an experiment to statistically prove anything you want to prove.
//^ False
//A True
//B False

//#Q What does the sentence, Correlation does not imply causation., mean?
//^ The fact that 2 phenomena are correlated does not mean that one of them causes the other.
//A Two wrongs dont make a right.
//B The fact that 2 phenomena are correlated does not mean that one of them causes the other.
//C None of these
//D The fact that one phenomenon causes another phenomenon does not mean that they are correlated.

//#Q Which of the following definitions is the definition of the MODE?
//^ The MODE is the value that has the highest frequency.
//A The MODE is the value that has the highest frequency.
//B The MODE is the value that half of the entries are below and half of the entries are above.
//C The MODE is the largest value.
//D The MODE is the average calculated by adding up all the values and dividing by the number of entries.

//#Q Which of the following definitions is the definition of the MEAN?
//^ The MEAN is the average calculated by adding up all the values and dividing by the number of entries.
//A The MEAN is the value that half of the entries are below and half of the entries are above.
//B The MEAN is the average calculated by adding up all the values and dividing by the number of entries.
//C The MEAN is the value that has the highest frequency.
//D The MEAN is the largest value.

//#Q Which of the following definitions is the definition of the MEDIAN?
//^ The MEDIAN is the value that half of the entries are below and half of the entries are above.
//A The MEDIAN is the value that half of the entries are below and half of the entries are above.
//B The MEDIAN is the value that has the highest frequency.
//C The MEDIAN is the average calculated by adding up all the values and dividing by the number of entries.
//D The MEDIAN is the largest value.

//#Q What is a normal curve?
//^ If the frequency of occurrence of something is clustered around the mean, and its graph is bell-shaped, then this is a NORMAL CURVE.
//A On a race track, if the turning radius of a gradual turn exceeds pi/2, then this is a NORMAL CURVE.
//B If the frequency of occurrence of something is clustered around the mean, and its graph is bell-shaped, then this is a NORMAL CURVE.
//C If an average, mentally healthy individual draws an arc, then the pattern formed is termed a NORMAL CURVE.
//D A woman with an hour-glass figure has a NORMAL CURVE.

//#Q The chemical symbol of Fluorine is Fl.
//^ False
//A False
//B True

//#Q Found in tonic water, quinine is commonly used to treat malaria.
//^ True
//A False
//B True

//#Q Lipitor and Zocor are two popular brand names which fall under what class of cholesterol lowering drugs?
//^ Statins
//A Statins
//B Citrates
//C Hydrochlorides
//D Aminoketones

//#Q What deadly and infectious disease that most often attacks the lungs used to be known as consumption?
//^ Tuberculosis
//A Tuberculosis
//B Measles
//C Whooping Cough
//D Chicken Pox

//#Q Clara Barton was the founder of the American Red Cross, but who founded the International Red Cross in 1863?
//^ Henry Dunant
//A Henry Ford
//B William Durant
//C Alfred Nobel
//D Henry Dunant

//#Q What famous 19th century nurse gained the moniker Lady with the lamp during the Crimean War?
//^ Florence Nightingale
//A Molly Pitcher
//B Florence Nightingale
//C Carrie Nation
//D Mary Mallon

//#Q An important supplement for pregnant women, what is vitamin B9 more commonly known as?
//^ Folic Acid
//A Thiamine
//B Riboflavin
//C Niacin
//D Folic Acid

//#Q In 2009, Thomas R. Frieden, MD assumed office as director of this agency of the U.S. Department of Health and Human Services located just outside of Atlanta, Georgia.
//^ Centers for Disease Control  Prevention (CDC)
//A Mayo Clinic
//B Food and Drug Administration
//C Centers for Disease Control  Prevention (CDC)
//D American Lung Association

//#Q Jonas Salk was the 20th century American medical researcher responsible for developing the highly effective and safe oral polio vaccine.
//^ False
//A False
//B True

//#Q What nervous system ailment, characterized by symptoms of severe lethargy and fatigue, is primarily caused by the lack of vitamin B1 (Thiamine) in the diet?
//^ Beriberi
//A Scurvy
//B Rickets
//C Beriberi
//D Nyctalopia

//#Q What organization won the Nobel Peace Prize in 1999 for its medical care in acute crises and raising international awareness of potential humanitarian disasters?
//^ Doctors Without Borders
//A Amnesty International
//B UNESCO
//C International Red Cross
//D Doctors Without Borders

//#Q Also known for her record-breaking trip around the world, what American journalist faked insanity in order to study a mental institution from the inside?
//^ Nellie Bly
//A Nellie Bly
//B Gertrude Ederle
//C Lizzie Borden
//D Susan B. Anthony

//#Q The planet Jupiter was named after the chief God in Roman Mythology. What is the name of his Greek counterpart?
//^ Zeus
//A Apollo
//B Zeus
//C Ares
//D Hara

//#Q How many Earth years does it take for Jupiter to complete one orbit around the Sun?
//^ 11.8 years
//A 10.5 years
//B 22.4 years
//C 11.8 years
//D 5.5 years

//#Q The planet Jupiter orbits the Sun at an average distance of how many kilometers?
//^ 778,000,000
//A 77,800,000
//B 778,000
//C 778,000,000
//D 7,780,000

//#Q How long is one day on the planet Jupiter?
//^ Just under 10 hours
//A Just over 12 hours
//B 24 hours
//C 55 hours
//D Just under 10 hours

//#Q The planet Jupiter has less than 50 natural satellites.
//^ False
//A False
//B True

//#Q What famous scientist discovered Jupiters four largest satellites?
//^ Galileo Galilei
//A Galileo Galilei
//B Giovanni Cassini
//C Johannes Kepler
//D Robert Hooke

//#Q What element is the atmosphere of Jupiter mostly comprised of?
//^ Hydrogen
//A Neon
//B Helium
//C Hydrogen
//D Argon

//#Q What was the first spacecraft to fly by Jupiter?
//^ Pioneer 10
//A Pioneer 10
//B Voyager 1
//C Pioneer 11
//D Voyager 2

//#Q In what state is there a town called Jupiter?
//^ Florida
//A Georgia
//B Florida
//C Alaska
//D Alabama

//#Q How many genes does the human DNA contain?
//^ About 80 000
//A About 200 000
//B About 80 000
//C About 8 000
//D About 20 000

//#Q Men are considered to be dwarfs in stature if their height is below 130 cm.
//^ True
//A False
//B True

//#Q The human heart is about the size of a fist.
//^ True
//A False
//B True

//#Q The human brain has approximately 14 billion cells.
//^ True
//A True
//B False

//#Q There are approximately 2 million sweat glands in the human body.
//^ True
//A True
//B False

//#Q Women blink more often than men.
//^ True
//A True
//B False

//#Q The smallest cell in the human body is the ovum.
//^ False
//A True
//B False

//#Q What is the largest organ in the human body?
//^ Skin
//A Skin
//B Stomach
//C None of these
//D Large intestine

//#Q Nearly half of all human bones are in the hands and feet.
//^ True
//A False
//B True

//#Q People with red hair are more sensitive to thermal pain.
//^ True
//A True
//B False

//#Q There are more than 500,000 craters on the moon that can be seen from Earth.
//^ True
//A False
//B True

//#Q The diameter of the largest crater on the moon is 1,044 miles across.
//^ False
//A False
//B True

//#Q The volume of the Earths moon is the same as the volume of the Pacific and Indian Oceans combined.
//^ False
//A False
//B True

//#Q The dark spots on the moon that create the man in the moon image are actually basins filled with basalt.
//^ True
//A True
//B False

//#Q The temperature on the Moon reaches 243° F at midday on the lunar equator.
//^ True
//A False
//B True

//#Q You always get to see the same half of the moon.
//^ True
//A False
//B True

//#Q The moon is moving toward the Earth at a rate of 1.5 inches per year.
//^ False
//A False
//B True

//#Q The surface area of the moon is 14,658,000 square miles.
//^ True
//A False
//B True

//#Q Only about 40% of the moons surface is visible from Earth.
//^ False
//A False
//B True

//#Q The moon is not round, but egg shaped.
//^ True
//A True
//B False

//#Q What is the main function of the iris of the eye?
//^ It controls the amount of light that reaches the retina.
//A It protects the sclera from injuries.
//B It protects the lens from injuries.
//C It controls the amount of light that reaches the retina.
//D All of these

//#Q Where exactly is the retina of the eye positioned?
//^ Its lining the inner surface of the eye.
//A Retina is a synonym of pupil.
//B Along the optic nerve.
//C Right behind the pupil
//D Its lining the inner surface of the eye.

//#Q What part of the eye is usually referred to as the white of the eye?
//^ Sclera
//A Conjunctiva
//B Sclera
//C All of these
//D Stroma

//#Q The cornea of the eye is the transparent front part that covers the iris, pupil, and anterior chamber. Which of these statements is true about the cornea?
//^ All of these
//A The cornea does not have blood vessels.
//B All of these
//C Touch of the cornea provokes an involuntary reflex to close the eyelid.
//D It refract most of the light that enters the eye.

//#Q Why is the pupil of the eye black ?
//^ Most of the light that enters the pupil is absorbed by the tissues inside the eye.
//A All of these
//B It contains black pigments.
//C The tissue right behind the pupil is black.
//D Most of the light that enters the pupil is absorbed by the tissues inside the eye.

//#Q Conjunctivitis, referred to as pink eye, is an inflammation of the conjunctiva of the eye. What may be the cause of such inflammation?
//^ All of these
//A Viral infection
//B Bacterial infection
//C Allergic reaction
//D All of these

//#Q Which of the following statements is true about the eyelids?
//^ All of these
//A They protect the eye from drying out and from foreign objects.
//B The skin of the eyelids contains more pigment cells compared to the rest of the skin on the body.
//C The skin of the eyelids is one of the thinnest skin of the whole human body.
//D All of these

//#Q At what stage of the development of the fetus do eyelashes form?
//^ Between the 7th and 8th week
//A Between the 7th and 8th week
//B Around the 26th week
//C Between the 13th and 14th week
//D Around the 20th week

//#Q Which of these is a medical term that refers to crying?
//^ Lacrimation
//A Humoring
//B Lactation
//C Lacrimation
//D Blepharitis

//#Q The average size of a normal human eye is commonly compared to the size of this object.
//^ Golf ball
//A Apricot
//B Walnut
//C Golf ball
//D Cherry tomato

//#Q Which of these is not a type of conic section?
//^ Ray
//A Ray
//B Hyperbola
//C Circle
//D Parabola

//#Q In mathematics, what type of conic section would this equation show: x^2+y^2=9?
//^ Circle
//A Secant
//B Line
//C Ray
//D Circle

//#Q What type of conic section would this mathematical equation produce: (x^2)/4+(y^2)/9=81?
//^ Ellipse
//A Line
//B Circle
//C Ellipse
//D Ray

//#Q What type of conic section would this equation yield: (x^2)/9-(y^2)/4=81?
//^ Hyperbola
//A Hyperbola
//B Ray
//C Line
//D Parabola

//#Q What type of  conic  section wouyld this yield: y=3x^2-9
//^ Parabola
//A Line
//B Parabola
//C Ray
//D Cylinder

//#Q In baseball, when a quarterback throws a pass, the ball follows what type of path?
//^ Parabola
//A Ray
//B Point
//C Line
//D Parabola

//#Q German astronomer Johannes Kepler showed that the planets circle the Sun in this type of path.
//^ Ellipse
//A Ellipse
//B Ray
//C Circle
//D Hyperbola

//#Q What conic section is used to describe electromagnetic waves?
//^ Parabolas
//A Points
//B Lines
//C Ellipses
//D Parabolas

//#Q Many microphones use this shape because of its specific properties.
//^ Parabola
//A Ellipse
//B Parabola
//C Circle
//D Hyperbola

//#Q Which of these statements about conic sections is correct?
//^ Every circle is an ellipse.
//A Every circle is an ellipse.
//B Every parabola is an ellipse.
//C Every cone is a parabola.
//D Every ellipse is a ray.

//#Q Only one of these statements about conic sections is correct. Which one?
//^ A line that intersects a circle at exactly one point is called a tangent.
//A If a line intersects a conic section then it will intersect the conic section in exactly two points.
//B If a line intersects a conic section, it will intersect it at least two points.
//C A line that intersects a circle at exactly one point is called a tangent.
//D A line that intersects a circle at exactly two points is called a tangent.

//#Q What year was the iPod introduced?
//^ 2001
//A 2001
//B 2003
//C 2008
//D 2007

//#Q Was the iPod launched on October 23, 2001?
//^ Yes
//A No
//B Yes

//#Q Who thought of the name iPod?
//^ Vinnie Chieco
//A Jonathan Ive
//B Tony Fadell
//C Steve Jobs
//D Vinnie Chieco

//#Q What year was the iPod touch launched?
//^ 2007
//A 2004
//B 2006
//C 2008
//D 2007

//#Q In April, 2007 it was announced that Apple had sold its one-hundredth million iPod making it the biggest selling digital music player of all time.
//^ True
//A False
//B True

//#Q When did the iPod Shuffle come out?
//^ none of these
//A August 2004
//B December 2002
//C April 2003
//D none of these

//#Q How many songs do 80 gigabyte iPods hold up to?
//^ 20,000
//A 45,000
//B 28,000
//C 20,000
//D 34,000

//#Q All iPods come in one and the same shape.
//^ False
//A True
//B False

//#Q Can you put movies and TV shows on your iPod?
//^ Yes
//A No
//B Yes

//#Q Which of the following is not a level 4 (Transport Layer) network protocol?
//^ RIP
//A TCP
//B RIP
//C UDP
//D SPX

//#Q When you ping a network node, which protocol is being utilized?
//^ ICMP
//A RIP
//B ICBM
//C ARP
//D ICMP

//#Q Which of these commands will return a Windows® computers node IP address, Subnet mask and information on whether it was assigned via DHCP and how long the lease is?
//^ ipconfig /all
//A ifconfig /all
//B ipconfig
//C ipconfig /all
//D ipsec /total

//#Q What does ADSL stand for?
//^ Asymmetrical Digital Subscriber Line
//A Asymmetrical Digital Subscriber Line
//B Asynchronous Digital Subscriber Line
//C Asynchronous Dial-up Subscriber Line
//D A Darn Slow Lan

//#Q Which of the following is best suited for network cable that must run close to electrical lines or florescent lighting?
//^ Fiber optic cable
//A Fiber optic cable
//B UTP
//C STP
//D UDP

//#Q If your cell phone runs out of power, this gadget will come to the rescue. Just plug it into your mobile phones charging port and turn the crank.
//^ SOS Charger
//A Manual Cranker Battery
//B New Cell Phone
//C Lithium Battery Generator
//D SOS Charger

//#Q You will need this type for memory card, if you want to expand yout Nokia 7710.
//^ MMC Card
//A XD Memory Card
//B MMC Card
//C SD Memory Card
//D Compact Flash Card

//#Q Which of these Siemens models has a built-in camera?
//^ SF65
//A SF65
//B M56
//C S56
//D CF62

//#Q This device is pretty useful if you have to walk a mile in the dark.
//^ Mobile LED Light
//A Mobile LED Light
//B Bluetooth Car Handset
//C Mobile UV Money Detector
//D Lithium Battery

//#Q Mercury was named after the Roman Messenger of the gods. What is the name of the corresponding god in Greek mythology?
//^ Hermes
//A Zeus
//B Hermes
//C Hera
//D Apollo

//#Q What is the diameter of planet Mercury?
//^ 4,878 km / 3 031 miles
//A 10,787 km / 6,702 miles
//B 983 km / 610 miles
//C 4,878 km / 3 031 miles
//D 3,576 km / 2 222 miles

//#Q What was the first spacecraft to study the planet Mercury?
//^ Mariner 10
//A Mariner 10
//B Voyager 2
//C Mariner 11
//D Mariner 9

//#Q How long does it take for the planet Mercury to orbit the Sun once?
//^ 88 days
//A 88 days
//B 2 years
//C 44 days
//D 365 days

//#Q What is the most abundant element in Mercurys atmosphere?
//^ Oxygen
//A Nitrogen
//B Helium
//C Boron
//D Oxygen

//#Q What element comprises more than half of Mercurys mass?
//^ Iron
//A Lead
//B Iron
//C Nickel
//D Carbon

//#Q Mercury has a moon called Celsius.
//^ False
//A False
//B True

//#Q The largest known impact crater on Mercury is named what?
//^ Caloris Basin
//A Caloris Basin
//B Olymus Mons
//C Tyco Crater
//D Skinakas Basin

//#Q From our point of view on Earth, Mercury goes through different phases, just like our Moon.
//^ True
//A True
//B False

//#Q What is the mean temperature on the surface of Mercury?
//^ 333 degrees Fahrenheit / 167 degrees Celsius
//A -10 degrees Fahrenheit / -23 degrees Celsius
//B 333 degrees Fahrenheit / 167 degrees Celsius
//C 212 degrees Fahrenheit / 100 degrees Celsius
//D 1,500 degrees Fahrenheit / 815 degrees Celsius

//#Q What is the basic chemical compound that natural pearls consist of?
//^ Calcium carbonate
//A Aluminum carbonate
//B Sodium sulphate
//C Calcium fluoride
//D Calcium carbonate

//#Q Pearls come in many shapes and sizes. What term refers to pearls with irregular shapes?
//^ Baroque pearls
//A Eggplant pearls
//B Baroque pearls
//C All of these
//D Semi-pearls

//#Q A pearl can be produced naturally by almost any shelled mollusk. What triggers the process of pearl formation?
//^ Irritant particles
//A Irritant particles
//B Changes in the chemical composition of the water.
//C Pheromones
//D All of these

//#Q The iridescence of pearls depends on the number and thickness of the nacre layers. Which of these combinations provides the most iridescent pearl?
//^ A large number of layers that are as thin as possible
//A A large number of layers that are as thin as possible
//B Many layers that are as thick as possible
//C A small number of layers that are very thick
//D Fewer layers that are very thin

//#Q Which of these pearls are the most valuable in the world?
//^ Natural pearls that are perfectly spherical
//A Natural pearls with the most unusual shapes
//B Natural pearls that are perfectly spherical
//C Cultured pearls with spherical shape
//D None of these

//#Q Which of these methods is a reliable way to distinguish a natural pearl from a cultured one and a fake one?
//^ All of these
//A Rubbing the pearl on ones teeth
//B X-ray examination
//C All of these
//D Microscopic examination

//#Q What is the name of the largest known pearl on the planet?
//^ All of these
//A Pearl of Allah
//B Pearl of Lao Tze
//C Pearl of Lao Tzu
//D All of these

//#Q What kind of pearls are the so-called Keshi pearls?
//^ Pearls that are produced accidentally, but are not considered natural
//A Very rare natural pearls found only in one place on the planet.
//B Cultured pearls that are very large and precious
//C Fake pearls that are almost indistinguishable from natural pearls
//D Pearls that are produced accidentally, but are not considered natural

//#Q In which of these places natural pearl hunting on a large scale has survived until modern times?
//^ Australia and Bahrain
//A India and China
//B Spain
//C Africa and South America
//D Australia and Bahrain

//#Q In which of these unusual colors can natural pearls come?
//^ All of these
//A Blue
//B Green
//C All of these
//D Purple

//#Q The B vitamins group was once thought to be a single vitamin. There are now eight officially recognized B vitamins referred to as vitamin B complex. Which of the following is not a vitamin from the B group?
//^ B4
//A B12
//B B5
//C B4
//D B1

//#Q The vitamins from the B complex have many functions but generally play most important role in which of these processes of the human body?
//^ Cell metabolism
//A Cell excretion
//B Cell reproduction
//C Cell regeneration
//D Cell metabolism

//#Q To which of these groups of substances do the B vitamins belong?
//^ Water-soluble
//A Fat-soluble
//B Alcohol-soluble
//C Non-soluble
//D Water-soluble

//#Q Which of these is not among the systems of the human body that vitamins of the B group mainly benefit?
//^ Respiratory
//A Cardio-vascular
//B Immune
//C Respiratory
//D Digestive

//#Q Which is the only B vitamin that cannot be obtained from plant products?
//^ B12
//A B7
//B B1
//C B6
//D B12

//#Q Vitamin B2 has which of these interesting properties?
//^ It is fluorescent under UV light.
//A It is can be absorbed only through the skin.
//B It can be found in all three physical conditions of matter.
//C It is fluorescent under UV light.
//D It melts at more than 10 000 degrees C.

//#Q Vitamin B6 is widely distributed in foods and its relatively stable form enables it to remain unchanged even when the products are cooked.
//^ False
//A False
//B True

//#Q The folic acid, a compound especially important during periods of rapid cell division and growth, is commercially known under what name?
//^ Vitamin B9
//A Vitamin B7
//B Vitamin B9
//C Vitamin B1
//D Vitamin B12

//#Q Which of the following is true about the sources of vitamin B5?
//^ It is found in a large variety of foods.
//A It is found only in plant products.
//B It is synthesized in the skin under the influence of the sun rays.
//C It is found only in animal products.
//D It is found in a large variety of foods.

//#Q B1, a vitamin participating in many important cellular processes, is synthesized by animals, plants and some bacteria.
//^ False
//A True
//B False

//#Q Niacin, also known as vitamin B3 or nicotinic acid, is a vitamin that can be synthesized by which organ?
//^ Liver
//A Heart
//B Kidneys
//C Liver
//D Gall-bladder

//#Q Vitamin B12 is a set of complex chemical compounds synthesized in nature only by this group of organisms.
//^ Bacteria
//A Fungi
//B Plants
//C Animals
//D Bacteria

//#Q This vitamin of the B complex, popular also under the name vitamin H, is not included in the recommended daily intake by some health organizations.
//^ Vitamin B7
//A Vitamin B9
//B Vitamin B12
//C Vitamin B15
//D Vitamin B7

//#Q Megaloblastic anemia is a type of anemia in which among the bone marrows red blood cells start to appear many immature and dysfunctional ones. The deficiency of which two vitamins of the B complex group causes this disorder?
//^ B9 and B12
//A B9 and B12
//B B1 and B2
//C B4 and B1
//D B6, B2 and B12

//#Q Biotin deficiency (the lack of vitamin B7) is a rare nutritional disorder that occurs in people from this age group.
//^ All of these
//A Adults
//B Elderly people
//C Infants
//D All of these

//#Q Which of these medical conditions is caused by the ricin found in castor beans?
//^ All of these
//A Death
//B All of these
//C Severe diarrhea
//D Long term organ damage

//#Q The fruit of the poisonous Jerusalem cherry is very similar to which of these?
//^ Cherry tomato
//A Morello cherry
//B Apricot
//C Cranberry
//D Cherry tomato

//#Q In what part of the apple are the toxic compounds cyanogenic glycosides found?
//^ Seeds
//A Seeds
//B Flowers
//C Skin of the fruit
//D Leaves

//#Q What type of medical problems does the consumption of raw seeds of the Common bean commonly cause?
//^ Gastric problems
//A Eyesight problems
//B All of these
//C Kidney failure
//D Gastric problems

//#Q What atomic number does Calcium have?
//^ 20
//A 21
//B 22
//C 20
//D 19

//#Q Which of these is the correct atomic number of the chemical element Actinium?
//^ 89
//A 99
//B 89
//C 79
//D 78

//#Q The atomic number of Argon is 19.
//^ False
//A True
//B False

//#Q The atomic number of the chemical element Tin is 50.
//^ True
//A False
//B True

//#Q What is the atomic number of Neon?
//^ 10
//A 11
//B 13
//C 10
//D 12

//#Q The atomic number of Zinc is 52.
//^ False
//A True
//B False

//#Q Which of these is the correct atomic number of the chemical element Radon?
//^ 86
//A 85
//B 87
//C 88
//D 86

//#Q Oxygens atomic number is 8.
//^ True
//A True
//B False

//#Q What was the star at the center of the Solar System called by the Romans?
//^ Sol
//A Helios
//B Sol
//C Aredid
//D Sun

//#Q Which of these is the surface temperature of the Sun?
//^ 9950 Degrees Fahrenheit
//A 11450 Degrees Fahrenheit
//B 7450 Degrees Fahrenheit
//C 9950 Degrees Fahrenheit
//D 2350 Degrees Fahrenheit

//#Q Which of these parts of the Sun is the warmest?
//^ Corona
//A Corona
//B Photosphere
//C Prominences
//D Chromosphere

//#Q The Sun has how many times the diameter of the Earth?
//^ 110
//A 150
//B 110
//C 100
//D 135

//#Q On average, how long is the sunspot cycle?
//^ 11.1 years
//A 10.4 years
//B 11.1 years
//C 14.8 years
//D 14.8 years

//#Q Which of the listed NASA probes made the closest approach to the Sun?
//^ Helios 2
//A Helios 2
//B SOHO
//C None of these
//D Mariner 10

//#Q The Sun orbits a center of mass.
//^ True
//A True
//B False

//#Q How many Earth masses is the Sun?
//^ 330,000 Earth masses
//A 395,000 Earth masses
//B 330,000 Earth masses
//C 310,000 Earth masses
//D 275,000 Earth masses

//#Q How long is a day on the planet Mars?
//^ 24.6 Earth hours
//A 48 Earth hours
//B 26 Earth hours
//C 12.6 Earth hours
//D 24.6 Earth hours

//#Q What is the size of Mars compared to the size of Earth.
//^ Mars is smaller than Earth.
//A The two planets can not be compared.
//B They are the same size.
//C Mars is smaller than Earth.
//D Mars is bigger than Earth.

//#Q Which statement about the atmosphere Mars is true?
//^ All of these
//A It is quite dusty.
//B It is relatively thin.
//C It contains methane.
//D All of these

//#Q What is the average temperature on the Martian surface?
//^ -23 degrees Celsius
//A 23 degrees Celsius
//B -23 degrees Celsius
//C 0 degree Celsius
//D 100 degrees Celsius

//#Q Is Phobos a satellite of Mars?
//^ Yes
//A No
//B Yes

//#Q Valles Marineris is a polar rift on the surface of Mars.
//^ False
//A False
//B True

//#Q Olympus Mons lies on Mars.
//^ True
//A True
//B False

//#Q Did Voyager obtain the first images of Mars?
//^ No
//A No
//B Yes

//#Q What is the name of the six-wheeled robotic vehicle of the Pathfinder Mission on Mars?
//^ Sojourner
//A Viking
//B Mariner
//C Pathfinder
//D Sojourner

//#Q How long does it take Mars to complete one revolution around the sun?
//^ 687 days
//A 225 days
//B 525 days
//C 456 days
//D 687 days

//#Q Shellfish is rich in vitamin B12, which supports the functions of nerves and mental ability.
//^ True
//A False
//B True

//#Q Which of these fish is a major source of omega-3 fatty acids?
//^ All of these
//A Tuna
//B Salmon
//C Mackerel
//D All of these

//#Q Skimmed milk contains riboflavin (vitamin B2), vitamin A and calcium.
//^ True
//A True
//B False

//#Q Walnuts contain only unsaturated fats and therefore decrease the risk of heart disease.
//^ True
//A True
//B False

//#Q Which of these is present in lentils?
//^ All of these
//A dietary fiber
//B folate
//C All of these
//D vitamin B1

//#Q Which of these is said to be helpful in reducing swelling from bee stings?
//^ Onion
//A Pumpkin
//B Pinto beans
//C Onion
//D Parsley

//#Q Figs are a natural source of potassium and carbohydrates.
//^ True
//A True
//B False

//#Q Which of the following is a major source of iron, which helps carry oxygen to the tissues?
//^ Raisins
//A Broccoli
//B Raisins
//C Lemons
//D Tomatoes

//#Q Apricots contain carotenoids and antioxidants that may help to prevent heart disease.
//^ True
//A False
//B True

//#Q Mangoes are high in prebiotic dietary fiber and vitamin C.
//^ True
//A False
//B True

//#Q Which of the following is a water soluble vitamin also known as riboflavin?
//^ Vitamin B2
//A Vitamin C
//B Vitamin A
//C Vitamin E
//D Vitamin B2

//#Q Niacin, also known as vitamin B3, is required for healthy hair.
//^ True
//A False
//B True

//#Q This vitamin, known as pantothenic acid, is found in some hair and skin care products.
//^ B5
//A C
//B B12
//C B5
//D None of these

//#Q The lack of this vitamin may cause seborrhea and dry skin.
//^ Vitamin B6
//A Vitamin B6
//B Vitamin J
//C Vitamin D
//D Vitamin F

//#Q Which of the following vitamins is known as Folic Acid?
//^ Vitamin B9
//A Vitamin B6
//B Vitamin B9
//C Vitamin B2
//D Vitamin B5

//#Q Vitamin B10 helps to prevents early graying of the hair.
//^ True
//A True
//B False

//#Q Vitamin B12, which is related to hair growth and strength, can be obtained from which food?
//^ All of these
//A All of these
//B Diary products and egg yolks
//C Seafood
//D Meat

//#Q Which of the following statements is true about vitamin C, which is found mostly in citrus fruit and berries?
//^ All of these
//A It keeps blood vessels healthy.
//B All of these
//C It prevents hair loss.
//D It improves blood circulations to the scalp.

//#Q Vitamin A helps to restore the structure of damaged hair.
//^ True
//A False
//B True

//#Q Vitamin E is found in nuts.
//^ True
//A True
//B False

//#Q What is the speed of light in vacuum?
//^ 300 000 km/s
//A 500 000 km/s
//B 300 000 km/s
//C 200 000 km/s
//D 400 000 km/s

//#Q How many times can an electromagnetic wave travel around the world in a single second?
//^ 7
//A 7
//B 3
//C 5
//D 1

//#Q What is the symbol for the speed of light?
//^ c
//A los
//B q
//C sol
//D c

//#Q Is it possible to see around corners?
//^ Yes
//A No
//B Yes

//#Q Did Isaac Newton formulate the famous equation E=mc²?
//^ No
//A No
//B Yes

//#Q What does a convex mirror do?
//^ It deceases the size
//A It increases the size
//B None of these
//C It widens the size.
//D It deceases the size

//#Q What does a concave mirror do with the object that is reflected?
//^ Depends on the on the distance between the object and the mirror.
//A It widens the size of the object.
//B It increases the size of the object.
//C It decreases the size of the object.
//D Depends on the on the distance between the object and the mirror.

//#Q Light slows down in this object and causes it to look bent.
//^ water
//A glass
//B lamp
//C water
//D gas

//#Q Light waves travel in a straight line.
//^ True
//A False
//B True

//#Q Saturn is the Roman name of the Greek Titan Cronus. Who is Cronus son?
//^ Zeus
//A Zeus
//B Neptune
//C Apollo
//D Hera

//#Q Saturn has more then 80 known moons.
//^ False
//A False
//B True

//#Q Saturns largest moon is known by what name?
//^ Titan
//A Titan
//B Europa
//C Ganymede
//D Cronus

//#Q How long does it take Saturn to complete one orbit around the Sun?
//^ just under 30 years
//A just over 20 years
//B 18 years exactly
//C about 15 years
//D just under 30 years

//#Q Pioneer 11 was the first spacecraft to study Saturn in this year.
//^ 1979
//A 1976
//B 1975
//C 1979
//D 1973

//#Q What is the name of the spacecraft that entered Saturns orbit in 2004?
//^ Cassini
//A Pioneer 11
//B Cassini
//C Voyager 2
//D Galileo

//#Q What is the name of the major gap in the ring system around Saturn?
//^ Cassini Division
//A Herschel Gap
//B The Great Gap
//C Galileo Division
//D Cassini Division

//#Q The atmosphere of Saturn consists mainly of what element?
//^ Hydrogen
//A Ozone
//B Hydrogen
//C Methane
//D Helium

//#Q Saturn is visible without any optical aid.
//^ True
//A False
//B True

//#Q On what date was the planet Neptune discovered?
//^ September 23, 1846.
//A September 23, 1846.
//B August 19, 1901.
//C May 3, 1865.
//D December 19, 1888.

//#Q Which two elements comprise the bulk of the atmosphere of Neptune?
//^ Hydrogen and Helium
//A Hydrogen and Methane
//B Helium and Carbon Dioxide
//C Helium and Methane
//D Hydrogen and Helium

//#Q Neptune has rings around it just like Saturn.
//^ True
//A False
//B True

//#Q How many moons does Neptune have?
//^ 13
//A 3
//B 13
//C None
//D 10

//#Q How long does it take Neptune to orbit the Sun once?
//^ 165 years
//A 211 years
//B 165 years
//C 89 years
//D 128 years

//#Q How long is one day on the planet Neptune?
//^ Just over 16 hours
//A Just over 23 hours
//B Just over 16 hours
//C Just under 17 hours
//D Just under 10 hours

//#Q The planet Neptune can be seen with the naked eye.
//^ False
//A False
//B True

//#Q What was the name of the first spacecraft that visited Neptune?
//^ Voyager 2
//A Voyager 1
//B Pioneer 10
//C Pioneer 11
//D Voyager 2

//#Q What is the name of the 1997 sci-fi horror movie, starring Sam Neil, that takes place in orbit around the planet Neptune?
//^ Event Horizon
//A Event Horizon
//B Alien 3
//C The Black Hole
//D Red Planet

//#Q Which is the only stable chemical element whose atom can contain no neutrons at all in its nucleus?
//^ Hydrogen-1
//A Oxygen-1
//B Hydrogen-1
//C There is no such element.
//D Helium-3

//#Q If an atom loses an electron its electromagnetic balance is disturbed and the atom decays releasing  ionizing particles and a large amount of energy.
//^ False
//A False
//B True

//#Q What does the number of neutrons in the nucleus of an atom determine?
//^ The isotope of the element
//A The isotope of the element
//B The bonds the element forms
//C The charge of the ions of the element
//D The element itself

//#Q Which of the following determines to which chemical element a certain atom belongs?
//^ The number of protons
//A The number of protons
//B The number of electrons
//C The number of neutrons
//D None of these

//#Q The word atom comes from the Greek atomos which means what?
//^ Uncuttable
//A Miniature
//B Fast
//C Invisible
//D Uncuttable

//#Q What part of the atoms mass is concentrated in its nucleus?
//^ 99.9 %
//A 90 %
//B 70 %
//C 0,01 %
//D 99.9 %

//#Q What is the name of the device used to measure the mass of atoms?
//^ Mass spectrometer
//A Submolecular weighter
//B Atomometer
//C Mass detector
//D Mass spectrometer

//#Q Which of these does a positive hydrogen ion lack?
//^ Electrons and neutrons
//A Neutrons
//B Electrons
//C Protons
//D Electrons and neutrons

//#Q Although it was thought to be the smallest component of matter, physicists discovered that the atom consists of electrons, protons and neutrons. But even some of these subatomic particles can be broken down further.
//^ True
//A False
//B True

//#Q What does the atomic number of the atom define?
//^ Its number of protons
//A All of these
//B Its number of protons
//C Its electrical charge
//D Its number of isotopes

//#Q Which of these statements is true about parasites in general?
//^ All of these
//A They are usually much smaller that their host.
//B They are highly specialized organisms.
//C All of these
//D They reproduce faster than their host and in much larger quantities.

//#Q What is the exact meaning of the term epiparasite?
//^ A parasite whose host is another parasite
//A A specific type of parasite that lives in the human skin
//B A parasite that is actually beneficial for its host
//C An external parasite that lives on the outside of its hosts body
//D A parasite whose host is another parasite

//#Q What kind of symptoms do parasite infections usually induce in humans?
//^ All of these
//A Joint pain
//B Chronic fatigue
//C Unrestrained hunger
//D All of these

//#Q What kind of animal causes the parasitic Dracunculiasis disease that is endemic to Sub-Saharan Africa?
//^ A worm whose eggs are ingested when drinking contaminated water
//A An insect that injects a plasmodium through its bite
//B A mite that is carried by poultry
//C A lizard that carries dangerous unicellular parasites
//D A worm whose eggs are ingested when drinking contaminated water

//#Q Which of these statements is true about the flea, a well-known external parasite?
//^ All of these
//A They have laterally compressed bodies.
//B All of these
//C They dont have wings.
//D They live on mammals and birds.

//#Q What kind of animal is the primary host of the protozoan Toxoplasma gondii which causes toxoplasmosis?
//^ Cat
//A Pigeon
//B Cat
//C Fly
//D Dog

//#Q What kind of organisms cause the parasitic infection known as ringworm?
//^ Fungi
//A All of these
//B Fungi
//C Mites
//D Intestinal worms

//#Q Which of these diseases is caused by the African tsetse fly?
//^ All of these
//A Nagana
//B Sleeping sickness
//C All of these
//D African trypanosomiasis

//#Q Which of these statements is true about ticks, common ectoparasites and vectors of numerous diseases?
//^ All of these
//A They feed on blood.
//B Young ticks have 6 legs, and mature ticks have 8 legs.
//C They live on mammals, birds, reptiles and amphibians.
//D All of these

//#Q Which of these statements is not true about the head louse, which is an ectoparasite in humans?
//^ It has eight powerful legs specialized for jumping.
//A It cant fly.
//B It has two antennae on its head.
//C It has eight powerful legs specialized for jumping.
//D It feeds on blood.

//#Q This food is rich in omega – 3 fatty acids, magnesium and potassium.
//^ Oatmeal
//A Salmon
//B Dark Chocolate
//C Berries
//D Oatmeal

//#Q Salmon is high in which of these?
//^ All of these
//A protein
//B omega-3 fatty acids
//C All of these
//D vitamin D

//#Q What do avocados contain?
//^ All of these
//A Copper and manganese
//B Vitamins B, vitamin K, vitamin E and vitamin C
//C All of these
//D Omega 3 and omega 6 fatty acids

//#Q Olive oil lowers total cholesterol and LDL levels in the blood.
//^ True
//A True
//B False

//#Q Spinach is extremely rich in antioxidants.
//^ True
//A True
//B False

//#Q Berries are good for the heart.
//^ True
//A False
//B True

//#Q In 650BC the father of medicine, Hippocrates, recommended it to relieve stomach pain.
//^ Linseed
//A Soy
//B None of these
//C Linseed
//D Oatmeal

//#Q Dark chocolate reduces blood pressure while enhancing circulation.
//^ True
//A True
//B False

//#Q Almonds possess cholesterol-lowering properties.
//^ True
//A True
//B False

//#Q Lentils and beans are rich in fiber, omega-3 acids and calcium.
//^ True
//A True
//B False

//#Q This is the microscope part in which the lens is located.
//^ Ocular or eyepiece
//A Objectives
//B Body tube
//C Ocular or eyepiece
//D Mirror

//#Q The diaphragm regulates the amount of light reaching the microscope objective.
//^ True
//A False
//B True

//#Q This part allows the tilting of the microscope at various angles.
//^ Inclination joint
//A Inclination joint
//B Adjustment knob
//C Stage Clip
//D Arm

//#Q What part of the microscope holds the draw tube in place?
//^ Body tube
//A Base
//B Arm
//C Body tube
//D Stage clip

//#Q The fine adjustment knob of the microscope is used to move the body tube when focusing the specimen under the low power objective.
//^ False
//A True
//B False

//#Q This microscope part supports the glass slide and the specimen.
//^ Stage clip
//A Revolving nose piece
//B Stage clip
//C Draw tube
//D Arm

//#Q The common name of the tendo calcaneus or calcaneal tendon of the human body was derived from the name of this Greek mythological hero.
//^ Achilles
//A Odysseus
//B Hercules
//C Heracles
//D Achilles

//#Q In what part of the human body are the cords of Billroth located?
//^ Spleen
//A Diaphragm
//B Spleen
//C Heart
//D Larynx

//#Q In which ody part of the human body can the Darwins tubercle be found in some individuals?
//^ Ear
//A Ear
//B Tongue
//C Nose
//D Eyelid

//#Q In which part of the human body is the so-called Pouch of Douglas located?
//^ Pelvis
//A Pelvis
//B Aorta
//C Stomach
//D Duodenum

//#Q Brocas area is located in the human brain. What is it responsible for?
//^ Speech
//A Hearing
//B Sleep patterns
//C Eyesight
//D Speech

//#Q Where in the human body is the Golgi organ located?
//^ In tendons
//A In tendons
//B Within the brain
//C Within the cell
//D In the eye

//#Q What was the occupation of the person after whom the human sideburns were named?
//^ Soldier
//A Aviator
//B Painter
//C Surgeon
//D Soldier

//#Q What type of anatomical structures does the Circle of Willis consist of?
//^ Arteries
//A Arteries
//B All of these
//C Veins
//D Neurons

//#Q The so-called McBurneys point is located in this part of the human body.
//^ Abdomen
//A Thorax
//B Foot
//C Abdomen
//D Head

//#Q The absence of the protein called Christmas factor, a.k.a. factor IX, from the human body results in this serious disease.
//^ Hemophilia
//A Parkinsons disease
//B Epilepsy
//C Diabetes
//D Hemophilia

//#Q We call visible light the electromagnetic radiation belonging to the what wave range?
//^ 380-750 nm
//A 12,000-15,000 nm
//B 1000-1500 nm
//C 100-520
//D 380-750 nm

//#Q Which of the following is not a property of light?
//^ Viscosity
//A Frequency
//B Polarization
//C Intensity
//D Viscosity

//#Q According to the properties it exhibits, light is defined as what?
//^ Both wave and particles
//A Electromagnetic wave
//B Both wave and particles
//C Living organism
//D Group of particles

//#Q Albert Einstein asserted that the energy of a photon is proportional to what in his study of the photoelectronic effects?
//^ Its frequency
//A Its mass
//B Its speed
//C Its volume
//D Its frequency

//#Q Approximately what is the speed of light in vacuum?
//^ 300 000 km/s
//A 250 000 km/s
//B 1 000 000 km/s
//C 12 000 km/s
//D 300 000 km/s

//#Q Light, just as wind, has the ability to push objects in its path.
//^ True
//A False
//B True

//#Q What property of light might change its value when a beam of light crosses the border between vacuum and another medium or between two different media?
//^ The wavelength
//A None of these
//B The polarization
//C The wavelength
//D The intensity

//#Q Which of these thermal emissions of light is the rarest in nature?
//^ Blue thermal emission
//A They are all equally frequent
//B Blue thermal emission
//C Red thermal emission
//D White thermal emission

//#Q In his Theory of Relativity, Albert Einstein discloses that when you multiply the speed of light by the mass you get what?
//^ The energy
//A The density
//B The volume
//C The frequency
//D The energy

//#Q We watch TV thanks to which of these processes forming light?
//^ Cathodoluminescence
//A Fiboluuminescence
//B Bioluminescence
//C Cathodoluminescence
//D Sololuminescence

//#Q What is the temperature of the core of the sun?
//^ 15,000,000 degrees Celsius
//A 15,000,000 degrees Celsius
//B 70 degrees Celsius
//C 15,000,000 degrees Fahrenheit
//D 1,000 degrees Kelvin

//#Q Jupiter has rings.
//^ True
//A False
//B True

//#Q What are Mercury, Venus, Earth and Mars mostly made of?
//^ rock
//A gas
//B rock
//C none of these
//D ice

//#Q Jupiter has the largest planetary atmosphere in the Solar System.
//^ True
//A True
//B False

//#Q Is Venus the coldest planet in the Solar System?
//^ No
//A Yes
//B No

//#Q How many major planets are there in the Solar System?
//^ 8
//A 10
//B 9
//C 11
//D 8

//#Q What was the second planet from the Sun called by the Greeks?
//^ All of these
//A Aphrodite
//B Phosphorus
//C All of these
//D Hesperus

//#Q Marine 1, launched in 1961, was the first probe to visit another planet.
//^ False
//A False
//B True

//#Q Venus is classified as Earths sister planet.
//^ True
//A True
//B False

//#Q Venus was mistaken for a UFO.
//^ True
//A True
//B False

//#Q Venus has the densest atmosphere in the solar system.
//^ False
//A False
//B True

//#Q What is Venus maximum elongation?
//^ 47.8 Degrees
//A 48.7 Degrees
//B 47.8 Degrees
//C 24.5 Degrees
//D 177.8 Degrees

//#Q Venus is largest when it is at which phase?
//^ Crescent
//A Half
//B Full
//C Crescent
//D Gibbous

//#Q Atoms are so small that they can only be observed with a special type of electronic optical microscope called scanning optical microscope.
//^ False
//A True
//B False

//#Q If we had to measure the width (i.e. the diameter) of a single human hair in carbon atoms, how much would this width be?
//^ 1 million carbon atoms
//A 1 thousand carbon atoms
//B 1 billion carbon atoms
//C 100 thousand carbon atoms
//D 1 million carbon atoms

//#Q The atoms of which type of chemical elements have a complete set of valence electrons - 8?
//^ Noble gases
//A Noble gases
//B Chlorides
//C Salts
//D Alkali metals

//#Q Valence is a characteristics of atoms which defines their ability to do which of the following?
//^ Bind with other atoms
//A Be subject to radioactive decay
//B Move from one molecule to another
//C Fall apart
//D Bind with other atoms

//#Q What did the CERN laboratory in Geneva, Switzerland, produce for the first time in 1996?
//^ Antimatter
//A Antimatter
//B An atom without electrons
//C A black hole
//D An atom without protons

//#Q What does the branch of physics called atomic physics study?
//^ The atom as an isolated system of electrons and a nucleus
//A All of these
//B The atom as an isolated system of electrons and a nucleus
//C Nuclear power
//D Relations between atoms and their arrangement in compounds

//#Q What happens to an electron that has absorbed a certain amount of energy which is though less than the energy necessary to remove it from the atom?
//^ Goes into excited state
//A Goes into excited state
//B Nothing
//C Decays
//D Explodes

//#Q How are the orbits in which the electrons of the atom reside called?
//^ Electron shells
//A Electron shells
//B Electron orbits
//C Electron paths
//D Electron circles

//#Q In chemistry and physics, what do we call free radicals?
//^ Atoms with at least one unpaired electron
//A Atoms free of electrons
//B Atoms not part of a molecule
//C Atoms with at least one unpaired electron
//D Atom freely floating in space

//#Q How is an atom having the valance of 1 called?
//^ Monad
//A Nucleuid
//B Mono particle
//C Monotom
//D Monad

//#Q Which of the following cannot affect the energy levels of the electrons of an atom?
//^ All of these can affect the energy levels
//A Absorption of energy from light (photons)
//B Magnetic field
//C All of these can affect the energy levels
//D Mechanical collision between particles

//#Q In atomic physics what does the term magnetic moment refer to?
//^ The magnetic field produced by an atom
//A The moment in which an atom enters a magnetic field
//B A miniature slice of time in an atoms magnetic interaction with other particles
//C The magnetic field produced by an atom
//D The moment in which an atom becomes magnetized

//#Q For the purposes of their experiments how do physicists slow down atoms in order to study them better?
//^ By laser cooling
//A With liquid nitrogen
//B By laser cooling
//C In special refrigerators
//D By bombarding them with micro particles

//#Q In atomic physics, which atoms are called exotic atoms?
//^ Atoms in which a sub-atomic particle has been replaced by another particle of the same charge
//A Atoms that occur on other planets of the Solar System but not on Earth
//B Atoms in which a sub-atomic particle has been replaced by another particle of the same charge
//C Magnetized atoms
//D Atoms that occur on Earth naturally very rarely

//#Q When a hydrogen atom loses its electron it might form which of the following?
//^ A proton
//A A proton
//B A neutron
//C A lepton
//D A quark

//#Q Which of the following components of the atom is not considered an elementary particle?
//^ Proton
//A Proton
//B Quark
//C Electron
//D Gluon

//#Q In nuclear physics what is a radionuclide?
//^ An atom with an unstable nucleus characterized by excess energy
//A A nucleus separated from the atom by radioactive processes
//B None of these
//C Two radioactive atoms in a molecule
//D An atom with an unstable nucleus characterized by excess energy

//#Q In physics and chemistry, which isotopes are considered stable?
//^ Isotopes that are not radioactive
//A Isotopes that are in a bond
//B Isotopes that are not radioactive
//C Isotopes in which the number of electrons, protons and neutrons is equal
//D Isotopes that do not form bonds

//#Q Super-heavy atoms, (or super heavy elements, often abbreviated SHE), are the elements with large atomic number (starting from 104), which occur only deep in the Earths mantle. They are very useful in the study of atoms structure and properties.
//^ False
//A True
//B False

//#Q Which is the force that binds together protons and neutrons together and thus forms the atoms nucleus?
//^ Strong interaction
//A Strong interaction
//B Electromagnetic force
//C Gravitation
//D Weak interaction

//#Q What does the word tornado literally mean?
//^ Thunderstorm
//A Devil
//B Death
//C Danger
//D Thunderstorm

//#Q What does the term tornado family denote?
//^ A series of tornadoes
//A A family that had suffered damages caused by a tornado
//B A series of tornadoes
//C A class of tornadoes
//D Quarrelsome family

//#Q What is the name of the tornado that occurred on March 18, 1925 and became the deadliest in U.S. history?
//^ Tri-State Tornado
//A Oklahoma City Tornado
//B Great Natchez Tornado
//C 1896 St.Louis – East St.Louis tornado
//D Tri-State Tornado

//#Q What is the name of the scale that is used to rate the intensity of tornadoes?
//^ Fujita scale
//A Dmitriev scale
//B Fujita scale
//C Richter scale
//D Saccitoni scale

//#Q What is the common shape of large single-vortex tornadoes?
//^ Wedge tornadoes
//A Funnel tornadoes
//B Stovepipe tornadoes
//C Rope tornadoes
//D Wedge tornadoes

//#Q The vast majority of tornadoes in the world occur in the Tornado Alley region which is located in this country.
//^ The United States
//A The United States
//B Indonesia
//C Mexico
//D Australia

//#Q Which of these is a common myth concerning the damages caused by a tornado to a house?
//^ Opening the windows will lessen the damages.
//A Having trees and shrubs around the house will lessen the damages.
//B Opening the windows will lessen the damages.
//C Tornadoes spare houses painted in orange.
//D All of these

//#Q What word is commonly used to refer to the central area of the tornado?
//^ Eye
//A All of these
//B Eye
//C Heart
//D Navel

//#Q The horse of what fictional hero is called Tornado?
//^ Zorro
//A Don Quixote
//B Zorro
//C Don Juan
//D dArtagnan

//#Q What actress starred in the 1996 disaster movie Twister?
//^ Helen Hunt
//A Meg Ryan
//B Helen Hunt
//C Jodie Foster
//D Michelle Pfeiffer

//#Q By what name was the closest planet to the Sun called by the Greeks?
//^ Hermes
//A Kokhav Hamah
//B Hermes
//C Hermaon
//D Mercury

//#Q Mercury is the densest major body in the solar system.
//^ False
//A False
//B True

//#Q Which probe became the first probe to visit Mercury in 1974?
//^ Mariner 10
//A Mariner 8
//B Mariner 9
//C Mariner 10
//D Venera 11

//#Q Mercurys maximum elongation is 32.2 degrees.
//^ False
//A True
//B False

//#Q When does a transit of Mercury occur?
//^ when the planet Mercury passes between the Earth and the Sun
//A when the planet Mercury passes between the Earth and the Sun
//B when the planet Mercury has an object pass between it and the Earth
//C None of these
//D when the planet Mercury reaches maximum apparent distance from the Sun

//#Q What is Calores Montes?
//^ a range of mountains on Mercury
//A a large crater on Mercury
//B a tall mountain on Mercury
//C a volcano on Mercury
//D a range of mountains on Mercury

//#Q Does Mercury have an atmosphere?
//^ No
//A Yes
//B No

//#Q Does Mercury have a magnetic field?
//^ Yes
//A Yes
//B No

//#Q What is Mercurys spin-orbit resonance?
//^ 3:2
//A 1:1
//B 8:5
//C 3:4
//D 3:2

//#Q What is the planet Uranus named after?
//^ The Greek god of the sky
//A The Egyptian god of the sky
//B The Roman god of the sky
//C The Greek god of the sky
//D The Babylonian god of the sky

//#Q How many years does it take for the planet Uranus to orbit the Sun once?
//^ 84
//A 104
//B 64
//C 84
//D 44

//#Q What element comprises the bulk of Uranus atmosphere?
//^ Hydrogen
//A Ozone
//B Carbon Dioxide
//C Hydrogen
//D Helium

//#Q Uranus has only 10 moons.
//^ False
//A False
//B True

//#Q What is the name of the first spacecraft to study the planet Uranus?
//^ Voyager 2
//A Pioneer 11
//B Pioneer 10
//C Voyager 2
//D Voyager 1

//#Q How many separate rings does the planet Uranus have according to observations made with the Hubble Space Telescope in 2005?
//^ 13 rings
//A 7 rings
//B Uranus does not have any rings.
//C 13 rings
//D 5 rings

//#Q Which is the largest of Uranus moons?
//^ Titania.
//A Titania.
//B Miranda.
//C Ariel.
//D Oberon.

//#Q Name the 1962 film about the planet Uranus?
//^ Journey to the Seventh Planet
//A Meet me on Uranus
//B Journey to the Seventh Planet
//C Escaping the Blue Planet
//D I Love Uranus

//#Q Uranus was renamed Urectum in what animated TV Series?
//^ Futurama
//A Futurama
//B The Simpsons
//C The Family Guy
//D American Dad

//#Q What is the name of the Japanese dried seaweed sheets used in the preparation of sushi?
//^ Nori
//A Onigiri
//B Sashimi
//C Yakisoba
//D Nori

//#Q Why will worms not live in seaweed fertilizer?
//^ Because of its high salt content
//A Because it contains antibiotics that repulse them
//B Because of its high salt content
//C All of these
//D Because it is acidic

//#Q Kelp ash is used in the production of which of the following?
//^ Glass
//A Plastic
//B Glass
//C Rubber
//D Teflon

//#Q What important advantage does algal fuel possess?
//^ All of these
//A It is relatively environmentally harmless.
//B It is biodegradable.
//C It produces much more energy than second-generation biofuel crops.
//D All of these

//#Q Marine algae may have this effect on the human body.
//^ Laxative effect
//A All of these
//B Laxative effect
//C May act as opiates
//D Increase the cholesterol levels

//#Q What process does the edible seaweed called Wakame accelerate according to studies?
//^ Burning of fat
//A Healing of wounds
//B Cell growth
//C Burning of fat
//D Delivery of the baby

//#Q The edible seaweed Irish moss contains this essential mineral used in the prevention and treatment of goiter.
//^ Iodine
//A Potassium
//B Calcium
//C Iodine
//D Sulfur

//#Q What name is commonly used to refer to the edible seaweed Caulerpa lentillifera, also known as sea grapes?
//^ Green caviar
//A Marine eggs
//B Green caviar
//C Sea corn
//D All of these

//#Q What medical condition is the chlorella algae beneficial for?
//^ All of these
//A All of these
//B High cholesterol levels
//C Radiation exposure
//D High blood pressure

//#Q What important mineral is sea lettuce especially rich in?
//^ Iron
//A Iron
//B Magnesium
//C Copper
//D Potassium

//#Q What did Charles Darwin major in at the University of Edinburgh where he joined his older brother in October 1825?
//^ Medicine
//A Geography
//B Natural history
//C Marine biology
//D Medicine

//#Q Charles Darwin had a passion for this popular hobby, which was introduced to him by his cousin William Darwin Fox.
//^ Collecting beetles
//A Collecting herbs
//B Collecting beetles
//C Painting
//D Fowling

//#Q Charles Darwin was neglecting his studies at the University of Edinburgh, so his father sent him to Cambridge to get a Bachelor of Art degree, as the first step towards what profession?
//^ Priest
//A Teacher
//B Medical doctor
//C Priest
//D Artist

//#Q What was Charles Darwin disgusted with while in Brazil during the second voyage of HMS Beagle?
//^ Slavery
//A Racism
//B Slavery
//C Animal sacrifices
//D Live animal skinning

//#Q In what country did Charles Darwin experience an earthquake, leading him to form a theory on the movements of the Earths crust?
//^ Chile
//A Australia
//B France
//C South Africa
//D Chile

//#Q What was the supposed reason for Charles Darwins health problems that started in 1837?
//^ Overwork
//A Allergy
//B Depression
//C A mysterious disease that he caught during his first voyage
//D Overwork

//#Q Which of these statements is true about Charles Darwins wife, Emma Wedgwood?
//^ She was known for her charity work
//A She was Charles second cousin
//B She was two years older than Charles
//C She was known for her charity work
//D She was quick-tempered and often argued with her husband

//#Q Charles Darwin and his wife Emma survived the death of this child of theirs.
//^ All of these
//A Charles Waring Darwin
//B Mary Eleanor Darwin
//C All of these
//D Anne Elizabeth Darwin

//#Q Who was Charles Darwins second son and fifth child, who became a prominent astronomer and mathematician?
//^ George Howard Darwin
//A Leonard Darwin
//B George Howard Darwin
//C Francis Darwin
//D William Erasmus Darwin

//#Q What impressive physical characteristic did Charles Darwin possess, which made the Bank of England use his image for the ten pound note in 2000?
//^ Large beard
//A Distinctive eyes
//B Very big ears
//C Unique nose
//D Large beard

//#Q What natural therapy works best for seasonal depression and low moods due to sleep deprivation?
//^ Bright light therapy
//A Water therapy
//B Bright light therapy
//C Aromatherapy
//D Massage

//#Q What type of fish contains the valuable Omega-3 fatty acids, proven to fight depression and improve overall health?
//^ Cold-water fish
//A Marine fish
//B Bony fish
//C Cartilaginous fish
//D Cold-water fish

//#Q What mineral present in some mineral waters is used as a cure for different types of depression?
//^ Lithium
//A Copper
//B Aluminium
//C Vanadium
//D Lithium

//#Q What spice possesses antidepressant properties?
//^ Saffron
//A Saffron
//B Black pepper
//C Chilli
//D Nutmeg

//#Q Listening to what type of music is recommended for people who suffer from mood disorders?
//^ Soft music
//A Loud music
//B Soft music
//C Jazz
//D Rock and roll

//#Q What type of food is rich in tryptophan, and therefore prevents and cures depression?
//^ All of these
//A Nuts
//B Dairy
//C Meat
//D All of these

//#Q What is the best location to exercise in order to fight depression according to studies?
//^ Outdoors
//A In a gym
//B In the bathroom
//C In your home
//D Outdoors

//#Q Which of these substances and minerals is not effective in the treatment of depression?
//^ Sodium
//A Sodium
//B Zinc
//C Magnesium
//D Dopamine

//#Q What animals are used in the treatment of mood disorders such as depression?
//^ All of these
//A Parrots
//B Dolphins
//C All of these
//D Dogs

//#Q Bathing in what type of water is proven to battle depression and enhance the mood?
//^ Cold water
//A Hot water
//B Mineral water
//C Cold water
//D Water with temperature close to that of the human body

//#Q What fields did the science of alchemy originally combine?
//^ All of these
//A Metallurgy and astrology
//B All of these
//C Chemistry and medicine
//D Art and physics

//#Q What element was usually the subject of transformation in alchemy?
//^ Lead
//A Copper
//B Lead
//C Lithium
//D Tin

//#Q Alchemists were in search of ‘panacea’. What is panacea?
//^ Remedy for all ailments
//A The meaning of life
//B Remedy for all ailments
//C The Holy Grail
//D A piece of Jesus Christ’s cross

//#Q What was the special magic power of the philosophers stone that alchemists were searching for?
//^ It would give them unprecedented knowledge.
//A It would bring them luck and happiness.
//B It would grant them eternal life.
//C All of these
//D It would give them unprecedented knowledge.

//#Q Until what century was alchemy considered a serious science in Europe?
//^ 16th century
//A 14th century
//B 13th century
//C 18th century
//D 16th century

//#Q What is the word ‘alchemy’ generally believed to mean literally?
//^ The art of transformation
//A The art of transformation
//B All in one
//C All is possible
//D The transfusion of matter

//#Q In what Asian country did one of the two main branches of alchemy originate?
//^ China
//A India
//B Saudi Arabia
//C China
//D Japan

//#Q What scientist is believed to have been the first true alchemist in Medieval Europe, as well as the most significant?
//^ Roger Bacon
//A Isaac Newton
//B Roger Bacon
//C Thomas Aquinas
//D Galileo Galilei

//#Q Who is the author of the 1988 book ‘The Alchemist’?
//^ Paulo Coehlo
//A J. K.Rowling
//B Umberto Eco
//C Terry Pratchett
//D Paulo Coehlo

//#Q What did alchemists associate the planets with?
//^ Metals
//A Women
//B Animals
//C Metals
//D Dreams

//#Q If I weighed 100 pounds(45.5 Kilograms) on Earth, about how much would I weigh on Mars?
//^ 37.7 Pounds(17.1 Kilograms)
//A 90.7 Pounds(41.2 Kilograms)
//B 48.6 Pounds(22.1 Kilograms)
//C 37.7 Pounds(17.1 Kilograms)
//D 88.9 Pounds(40.4 Kilograms)

//#Q Mars lower density and size gives it a mass about how much that of Earth?
//^ 1/10
//A 1/6
//B 1/8
//C 1/2
//D 1/10

//#Q Mars moon Deimos orbits the closest to its planet of any moon in the Solar System.
//^ False
//A True
//B False

//#Q Which of these orders the terrestrial planets from smallest to largest by diameter?
//^ Mercury, Mars, Venus, Earth
//A Mars, Mercury, Earth, Venus
//B Mercury, Mars, Venus, Earth
//C Venus, Mercury, Mars, Earth
//D Mars, Mercury, Venus, Earth

//#Q Jupiter is the fourth brightest object in the sky.
//^ False
//A False
//B True

//#Q The earliest evidence of animal life comes from this period.
//^ Vendian
//A Vendian
//B Cambrian
//C Ordovician
//D Carboniferous

//#Q Early amphibians such as Icthyostega evolved during what geological period?
//^ Devonian
//A Silurian
//B Carboniferous
//C Permian
//D Devonian

//#Q Arthropods were the largest animals on Earth during the Silurian period (443ma-417ma).
//^ True
//A True
//B False

//#Q What was the only mass extinction in which insects were affected?
//^ Permian/Triassic event
//A Cretaceous/Paleogene event
//B Ordovician/Silurian event
//C Triassic/Jurassic event
//D Permian/Triassic event

//#Q During what geological period did the earliest vascular plants evolve?
//^ Silurian
//A Devonian
//B Cretaceous
//C Silurian
//D Cambrian

//#Q When did the first grasses evolve?
//^ 55 million years ago
//A 55 million years ago
//B 35 million years ago
//C 65 million years ago
//D 200 million years ago

//#Q It has been proposed that before the evolution of leaves, plants had the photosynthetic apparatus on which parts?
//^ stems
//A stems
//B roots
//C buds
//D none of these

//#Q Most plant groups became extinct during the Permo-Triassic extinction event.
//^ False
//A True
//B False

//#Q What period marks the beginning of extensive land colonization by plants?
//^ Devonian
//A Cretaceous
//B Devonian
//C Cambrian
//D Permian

//#Q Endorphins are some of the so-called hormones of happiness. In what situations does our body choose to start producing endorphins?
//^ All of these
//A All of these
//B When we feel pain
//C When we are dying
//D In times of exhilaration

//#Q Adrenaline, or epinephrine, is one of the stress hormones our bodies produce. What is the effect of adrenaline on the human body?
//^ All of these
//A It dilates pupils.
//B It increases the blood sugar levels.
//C All of these
//D It suppresses the immune system.

//#Q More and more people are choosing replacement therapies with human growth hormones. What are the effects of such therapies on the body?
//^ All of these
//A All of these
//B Less body fat
//C Stronger immune system
//D Younger skin

//#Q Oxytocin is an important hormone for the human body especially for women. What is it responsible for?
//^ Contractions of the uterus
//A Contractions of the uterus
//B Development of the uterus
//C Development of the ovaries
//D Ovulation

//#Q Weve all heard about the importance of insulin, but where does its name come from?
//^ It comes from the Latin insula, which means island.
//A It means that it is produced inside the body.
//B Its name means reduces sugar in Greek.
//C It comes from the Latin insula, which means island.
//D Insulin means sugar in Latin.

//#Q The production of the hormone melatonin is inhibited by light and permitted by darkness. In which part of the body is it produced?
//^ All of these
//A Gastrointestinal tract
//B All of these
//C Retina
//D Pineal gland

//#Q Testosterone is a male hormone secreted in the testes in males and ovaries in females. Its deficiency is related to various disorders such as this one.
//^ Alzheimer’s Disease
//A All of these
//B Blindness
//C Alzheimer’s Disease
//D Melanoma

//#Q Which of these statements is true about the female hormone estrogen?
//^ All of these
//A It reduces muscle mass.
//B All of these
//C It decreases height growth.
//D It speeds up metabolism.

//#Q Progesterone, the hormone of pregnancy, is synthesized in this part of the body.
//^ All of these
//A In the ovaries
//B All of these
//C In the placenta
//D In the brain

//#Q Which of these statements is true about cortisol, a hormone produced by the cortex of the adrenal glands?
//^ All of these
//A Makeup decreases cortisol levels.
//B Lack of sleep increases cortisol levels.
//C Caffeine increases cortisol levels.
//D All of these

//#Q How fast have winds on Jupiter blown?
//^ 430 Kilometers per hour(267 Miles per hour)
//A 430 Kilometers per hour(267 Miles per hour)
//B 240 Kilometers per hour(150 Miles per hour)
//C 470 Kilometers per hour(292 Miles per hour)
//D 360 Kilometers per hour(223 Miles per hour)

//#Q How many natural satellites does Jupiter have?
//^ 63
//A 18
//B 56
//C 63
//D 60

//#Q Jupiter has been called the vacuum cleaner of the Solar System.
//^ True
//A False
//B True

//#Q The first moons of Jupiter discovered belong to this group.
//^ Galilean Moons
//A Galilean Moons
//B Ananke group
//C Himalia group
//D Carme Group

//#Q How large can Jupiter appear in the Earths sky?
//^ 50 arcseconds
//A 35 arcseconds
//B 50 arcseconds
//C 55 arcseconds
//D 40 arcseconds

//#Q Jupiters magnetic field is the strongest in the Solar System.
//^ False
//A False
//B True

//#Q Jupiter is growing.
//^ False
//A False
//B True

//#Q How oblate is Saturn?
//^ .1
//A .07
//B .11
//C .1
//D .08

//#Q Saturns magnetic field is stronger than Earths.
//^ False
//A False
//B True

//#Q Which of the following groups of animals does nematology study?
//^ Roundworms
//A All worms
//B Roundworms
//C Tapeworms
//D Intestinal parasites

//#Q Which insects does the science called Coleopterology study?
//^ Beetles
//A Beetles
//B Mosquitoes
//C Mantises
//D Parasitic insects

//#Q What animals does malacology study?
//^ Mollusks
//A Jellyfish
//B Monotremes
//C Mollusks
//D Arthropods

//#Q What does carcinology study?
//^ Crustaceans
//A Malignant tumors in animals and humans
//B The outer shells of invertebrates and reptiles
//C Crustaceans
//D Crabs, lobsters, and crayfish

//#Q Which of the following groups of animals does helminthology study?
//^ Parasitic worms
//A External parasites
//B Oviparous animals
//C Symbiotic animal species
//D Parasitic worms

//#Q The science known as theriology or therology studies which of the following?
//^ Mammals
//A Land animal species
//B Carnivorous animals
//C Mammals
//D Endemic animal species

//#Q The science called myrmecology deals with the study of which of the following?
//^ Ants
//A Wasps
//B Ants
//C Centipedes
//D Insects

//#Q Ichthyology is a branch of biology that deals with which of these?
//^ Fish
//A All of these
//B Amphibians
//C Fish
//D Water animals

//#Q What is the subject of study of the science called oology?
//^ Eggs
//A Animal reproductive organs
//B Bird feathers
//C Eggs
//D Eels

//#Q Which of these animals does dipterology study?
//^ Flies
//A Flies
//B Moles
//C Foxes
//D Lizards

//#Q In which part of the digestive system are the so-called Brunners glands located?
//^ Duodenum
//A Stomach
//B Colon
//C Small intestine
//D Duodenum

//#Q What type of duct is the Whartons duct found in the human body?
//^ Salivary duct
//A Tear duct
//B Salivary duct
//C Sweat duct
//D Bile duct

//#Q What type of cells are Betz cells that are found in the human body?
//^ Neurons
//A Epithelial cells
//B Neurons
//C Striated muscle cells
//D Melanocytes

//#Q The so-called space of Disse is located in this internal organ of the human body.
//^ Liver
//A Liver
//B Spleen
//C Pancreas
//D Kidney

//#Q In what part of the human body are Von Ebners glands located?
//^ Tongue
//A Skin
//B All of these
//C Nasal cavity
//D Tongue

//#Q In which gland of the human body can Hurthle cells be found?
//^ Thyroid gland
//A Thyroid gland
//B Thymus gland
//C Adrenal gland
//D Pituitary gland

//#Q The pores of Kohn are organs located in this part of the human body.
//^ Lungs
//A Skin
//B Tongue
//C Intestines
//D Lungs

//#Q The meibomian glands are special sebaceous glands located in this part of the human body.
//^ Eyelids
//A All of these
//B Ear canals
//C Eyelids
//D Lips

//#Q In which part of the human body are Sharpeys fibers found?
//^ All of these
//A Skull
//B Bones
//C All of these
//D Teeth

//#Q What human internal organ contains Luschkas crypts?
//^ Gallbladder
//A Uterus
//B Urinary bladder
//C Stomach
//D Gallbladder

//#Q According to scientific classifications, to which kingdom do fungi belong?
//^ None of these
//A To both the animal and the plant kingdom
//B The animal kingdom
//C The plant kingdom
//D None of these

//#Q Fungi take important part in which phase of the nutrient cycling and exchange?
//^ Organic matter decomposition
//A Organic matter formation
//B Organic matter recomposition
//C Organic matter decomposition
//D All of these

//#Q How is the discipline of biology dedicated to the study of fungi called?
//^ Mycology
//A Fungitics
//B Myology
//C Mycology
//D Fungology

//#Q Fungi are crucial for the production of which of these foods?
//^ Bread
//A Ketchup
//B Bread
//C Cheese
//D Creme

//#Q Fungi and their products are involved in the process of production of which of these goods?
//^ All of these
//A Detergents
//B All of these
//C Opiates
//D Antibiotics

//#Q What is the main difference between fungi and plants when cell structure is considered?
//^ Fungi do not have cellulose in their cell walls
//A Fungi do not have cellulose in their cell walls
//B Fungal cells contain membrane-bound nuclei
//C Fungi lack ribosomes
//D Fungi lack mitochodria

//#Q For which of these global tendencies in nature are fungi responsible?
//^ Decline of amphibian populations
//A Water poisoning
//B Decline of tree populations
//C Decline of amphibian populations
//D Global warming

//#Q In nature, fungi are known tp form symbiotic relationships with which of these organisms?
//^ All of these
//A Plants
//B Algae
//C Insects
//D All of these

//#Q How do fungi reproduce?
//^ All of these
//A Asexually
//B By spore dispersal
//C Sexually
//D All of these

//#Q A fungus of the Armillaria ostoyae genus, discovered in the Malheur National Forest in the Strawberry Mountains of eastern Oregon, U.S. is often cited as which of these?
//^ The largest living organism
//A The oldest living organism
//B The largest living organism
//C The fastest-growing living organism
//D The smallest living organism

//#Q What kind of therapy is the Tui na, used in traditional Chinese medicine?
//^ Massage
//A Sauna
//B Music therapy
//C Massage
//D Tea therapy

//#Q What part of the human being is the shen according to traditional Chinese medicine?
//^ Soul
//A Breath
//B Bodily fluids
//C Heart
//D Soul

//#Q What positive effect do shiitake mushrooms, largely used in traditional Chinese medicine, have on human health?
//^ All of these
//A They boost the immune system.
//B They prevent cancer.
//C They lower cholesterol.
//D All of these

//#Q Ginseng is widely used in traditional Chinese medicine. What is the meaning of the Chinese phrase renshen, from which the English word ginseng originated?
//^ Man root
//A Man root
//B Power root
//C Fast growing
//D Promoting life

//#Q Which of these methods is used in traditional Chinese medicine to diagnose conditions and diseases?
//^ All of these
//A Listening to the patients voice
//B All of these
//C Exploring the patients body odors
//D Checking the patients hair

//#Q What traditional Chinese food is believed to improve the skin and the function of the spleen, and to promote appetite?
//^ Bird nest
//A Sharkfin soup
//B Bird nest
//C Miso soup
//D Bamboo

//#Q What part of a ducks body is recommended for treating coughs in traditional Chinese medicine?
//^ Gizzard
//A Eyes
//B Bill
//C Liver
//D Gizzard

//#Q What type of herbs are used in traditional Chinese medicine to trigger sweating and invigorate blood?
//^ Pungent herbs
//A Sour herbs
//B Bitter herbs
//C Sweet herbs
//D Pungent herbs

//#Q Qigong, which is recommended in traditional Chinese medicine, is what type of exercise?
//^ Breathing
//A Wrestling
//B Weightlifting
//C Breathing
//D Swimming

//#Q What animal cures asthma, arteriosclerosis, impotence, thyroid problems, broken bones, and heart disease according to traditional Chinese medicine?
//^ Seahorse
//A Snake
//B Shark
//C Seahorse
//D Frog

//#Q In what country did reconstructive and plastic surgery originate?
//^ India
//A Roman Empire
//B India
//C Ancient Greece
//D Egypt

//#Q Archaeological findings suggest that true glass was first invented in this country.
//^ Egypt
//A Egypt
//B Japan
//C China
//D India

//#Q U.S. President George Washington was the most famous person to use an early form of dentures. What material were his dentures made from?
//^ Hippopotamus ivory
//A Platinum
//B Elephant ivory
//C Hippopotamus ivory
//D Porcelain

//#Q In what country was the modern safety pin created?
//^ United States
//A United States
//B Italy
//C France
//D China

//#Q In what country was silk first produced?
//^ China
//A Iran
//B China
//C Japan
//D India

//#Q In what century was the first form of the lighter created?
//^ 16th century
//A 2nd century
//B 6th century
//C 16th century
//D 10th century

//#Q In what century did the great Greek philosopher Socrates live?
//^ 5th century BC
//A 10th century BC
//B 5th century BC
//C 2nd century BC
//D 8th century BC

//#Q What was the most important occupation to Socrates according to Xenophons ‘Symposium’?
//^ Discussing philosophy
//A Discussing philosophy
//B Creating beauty
//C Studying sciences
//D Teaching children

//#Q According to Socrates, the ideal state had this type of governmental control.
//^ Military communism
//A None of these
//B Military communism
//C Absolute monarchy
//D Democracy

//#Q What is the nature of the so-called Socratic Method of inquiry?
//^ Answering a question with another question
//A Answering a question with another question
//B Asking the same question many times by rephrasing it
//C Answering a foolish question with a more foolish answer
//D Asking very personal questions to embarrass the other party

//#Q According to Socrates, people should worry most about which of the following?
//^ Their souls
//A Their future
//B Their souls
//C Nothing at all
//D Their health

//#Q Socrates believed that wrongdoing stems only from this phenomenon.
//^ Ignorance
//A Ignorance
//B Egoism
//C Frustration
//D Hopelessness

//#Q How did Socrates describe the so-called ‘demonic sign’ that he claimed to appear to him when he was about to make a mistake?
//^ Inner voice
//A Inner voice
//B Natural disaster
//C None of these
//D Divine vision

//#Q Socrates had a successful service in this state institution in Athens.
//^ Military
//A Government
//B Military
//C Court
//D All of these

//#Q In what century did the great Greek philosopher Aristotle live?
//^ 4th century BC
//A 4th century BC
//B 1st century BC
//C 7th century BC
//D 10th century BC

//#Q What did Aristotle request of his student Alexander the Great, according to some sources?
//^ That he would rebuild his hometown
//A That he would keep his teachings a secret
//B That he would marry his daughter
//C That he would rebuild his hometown
//D All of these

//#Q Finish the popular quote by the great Greek philosopher Aristotle: ‘There was never a genius without a tincture of…’.
//^ Madness
//A Sorrow
//B Scepticism
//C Foolishness
//D Madness

//#Q Aristotle believed in the existence of this anatomical difference between human males and females.
//^ Males had more teeth.
//A Females were born without a brain, and it was formed later.
//B All of these
//C Males had more kidneys.
//D Males had more teeth.

//#Q Aristotle believed these two scientific fields had nothing in common.
//^ Mathematics and physics
//A Mathematics and physics
//B Zoology and human anatomy
//C Geometry and arithmetic
//D Philosophy and psychology

//#Q In what type of written form did Aristotle prefer to express and defend his doctrines?
//^ Dialogue
//A Dialogue
//B Fable
//C Poetry
//D Monologue

//#Q What astronomical object was named in honor of Greek philosopher Aristotle?
//^ A crater on the Moon
//A A star
//B A constellation
//C One of the rings of Saturn
//D A crater on the Moon

//#Q What was the nature of sciences according to Aristotle?
//^ All of these
//A Practical
//B Theoretical
//C Poetical
//D All of these



//#Q This mental illness, classified by Emil Kraepelin in 1887, is characterized by persistent disorders in the perception or expression of reality.  A person who suffers from this disease may have delusions, hallucinations, disorganized or catatonic behavior.
//^ Schizophrenia
//A Autism
//B Huntingtons Disease
//C Schizophrenia
//D Dementia

//#Q This medical term refers to a condition, characterized by enlargement of the thyroid gland.
//^ Goiter
//A Goiter
//B Sore throat
//C Mumps
//D Boils

//#Q This disease is characterized by the presence of the following symptoms: recurrent, episodic vertigo, hearing loss, a sensation of aural fullness and tinnitus.  It is a balance disorder of the inner ear, first described by a French physician in 1861.
//^ Menieres Disease
//A Alzheimers Disease
//B Menieres Disease
//C Kawasaki Syndrome
//D Cushings Syndrome

//#Q A chalazion, also known as a Meibomian gland lipogranuloma, refers to which of these?
//^ A cyst on the eyelid
//A A fungal rash
//B A recurring headache
//C A cyst on the eyelid
//D A sore throat

//#Q Alopecia is the medical term which refers to baldness.
//^ False
//A False
//B True

//#Q This medical condition is characterized by subsequent decay of body tissues, caused by infection or thrombosis or lack of blood flow.
//^ Gangrene
//A Scleroderma
//B Gangrene
//C Tinea
//D Impetigo

//#Q Urticaria is a relatively common form of allergic reaction, that causes red skin welts. Which is the other term which refers to this skin ailment?
//^ Hives
//A Hives
//B Chicken pox
//C Shingles
//D Eczema

//#Q The term albino comes from the Latin word albus.  An albino person or animal is characterised by what?
//^ A lack of pigmentation in the skin, eyes and hair
//A Extremely dark pigmentation of the skin
//B A lack of pigmentation in the skin, eyes and hair
//C Redness of the skin
//D Oily skin

//#Q Which medical term refers to the crackling sound, produced when two rough surfaces in the human body come into contact?
//^ Crepitus
//A Bunion
//B Exostosis
//C Osteoporosis
//D Crepitus

//#Q Which word refers to a sound caused by abnormal or pathological heart valves?
//^ Murmur
//A Aneurysm
//B Murmur
//C Wheezing
//D Beat

//#Q USB connectors let you attach everything from printers to cameras to your computer quickly and easily. What does the abbreviation USB actually stand for?
//^ Universal Serial Bus
//A Universal Serial Bus
//B Universal Service Bus
//C Ultra Sensitive Bus
//D Utility Service Bus

//#Q In the world of computers, what does PC stand for?
//^ Personal Computer
//A Private Computer
//B Privileged Computing
//C Personal Computer
//D Programmable Computer

//#Q WWW, an abbreviation well known to Internet lovers, actually stands for what?
//^ World Wide Web
//A World Wide Web
//B World Wild Web
//C Windows World Wide
//D Wonderful World of Web-casting

//#Q Windows NT is a family of operating systems produced by Microsoft. What does NT stand for?
//^ New Technology
//A New Technology
//B Network Technology
//C Network Terminal
//D Networking and Troubleshooting

//#Q FAT, a file system developed by Microsoft, is the shortened form of what?
//^ File Allocation Table
//A File Accessible Table
//B File Array Table
//C File Allocation Table
//D File Acceptance Table

//#Q The division of a company or university that deals with software technology is often called the IT department. What does IT stand for?
//^ Information Technology
//A Inter-networking Technology
//B Informatics and Technology
//C Information Technology
//D Internet Technology

//#Q Human toes and  fingers go by what common name?
//^ Phalanges
//A Tarsals
//B Carpals
//C Phalanges
//D Vertabrae

//#Q The zygomatic processes form the cheek bones.
//^ True
//A True
//B False

//#Q The radius is a bone which is part of the human leg.
//^ False
//A True
//B False

//#Q According to the Bible, Eve was made out of which of Adams bones?
//^ Rib
//A Tibia
//B Rib
//C Rhombus
//D Clavicle

//#Q The clavicle is the bone that connects your upper arm to the rest of your body via your shoulder. What is the clavicle more commonly known as?
//^ the collar bone
//A the shoulder bone
//B the collar bone
//C the neck bone
//D the shin bone

//#Q What are baby teeth scientifically called?
//^ Deciduous teeth
//A Toddler teeth
//B Begginers teeth
//C Osseous Tissue
//D Deciduous teeth

//#Q The tail bone is scientifically known as the coccyx.
//^ True
//A False
//B True

//#Q The USB memory stick is a very useful device. But do you know what USB stands for?
//^ Universal Serial Bus
//A Unique Serial Bus
//B Universal Storage Bank
//C Universal Serial Bus
//D United Bus Scan

//#Q Use an IMAP server to get advanced mail features.  What does IMAP stand for?
//^ Internet Message Access Protocol
//A Internet Message Access Protocol
//B Intelligent Message Account Process
//C Internet Massive Access Peak
//D Intelligent Messaging Account Protocol

//#Q POP is used to retrieve e-mail from a mail server.
//^ Post Office Protocol
//A Performance Oriented Packaging
//B Primary Outgoing Protocol
//C Post Office Protocol
//D Post Office Procedures

//#Q You would use SMTP to send email messages.
//^ Simple Mail Transfer Protocol
//A Snail Mail Transfer Protocol
//B Simple Mail Transfer Protocol
//C Super Mail Transfer Procedure
//D Standard Mail Transfer Protocol

//#Q Do you know what TCP stands for?
//^ Transmission Control Protocol
//A Transfer Control Protocol
//B Time Control Protocol
//C Turbo Connection Protocol
//D Transmission Control Protocol

//#Q GPRS is a new service designed for digital cellular networks.
//^ General Packet Radio Service
//A General Packet Radio System
//B General Pocket Radio System
//C Global Packet Radio Service
//D General Packet Radio Service

//#Q Most of the pages on the Web are written in HTML.  It stands for this.
//^ Hyper Text Markup Language
//A Hyper Text Markup Language
//B Hillarious Text Message Language
//C Hardened Text Message Language
//D Hyper Text Make-up Language

//#Q You can use FTP to download a video file.  It stands for this.
//^ File Transfer Protocol
//A File To Person
//B File Transfer Protocol
//C Fast Transfer Protocol
//D Full Transfer Protocol

//#Q Do you like listening to MP3s? What does this mystical acronym mean?
//^ Moving Picture Experts Group Layer-3 Audio
//A Most Popular Layer-3 Audio
//B Moving Picture Experts Group Layer-3 Audio
//C Movable Protocol for Layer-3 Audio
//D Modern Protocol 3

//#Q IRC lets people all over the world chat in virtual rooms, called channels.
//^ Internet Relay Chat
//A Internet Rough Chat
//B Internet Reality Chat
//C Internet Real Chat
//D Internet Relay Chat

//#Q This property of the cell membrane allows allows some particles to cross more easily than others.
//^ Selective permeability
//A Discriminative passage
//B Semi-permeability
//C Semi-discriminative
//D Selective permeability

//#Q What is the name given to the current model of a cell membrane?
//^ Fluid Mosaic model
//A Bilayer Phospholipid model
//B Davson-Danielli model
//C Fluid Mosaic model
//D Protein-Lipid model

//#Q What does the Davson-Danielli cell model look like?
//^ Two layers of proteins sandwich a phospholipid bilayer
//A Two layers of proteins sandwich a phospholipid bilayer
//B There are no proteins, only a phospholipid bilayer
//C Proteins and phospholipids are structured in a checkerboard pattern
//D Proteins are embedded in a phospholipid bilayer

//#Q What animal cell helped prove that membrane proteins drift?
//^ Mouse
//A Dog
//B Mouse
//C Fish
//D Monkey

//#Q All cell proteins are embedded in the cell membrane.
//^ False
//A True
//B False

//#Q Glycolipids in cell membranes are involved in transport, enzymatic activity, intercellular joining, and cell-cell recognition.
//^ False
//A False
//B True

//#Q Does active transport require the energy of the molecule adenosine diphosphate or ADP?
//^ No
//A Yes
//B No

//#Q How permeable is the cell membrane?
//^ It is semi permeable
//A It is semi permeable
//B It varies in permeablity
//C It is fully permeable
//D It is not permeable

//#Q You are stranded on an island and start drinking water from the ocean because there is no other water source. What state will this put your cells in, and what will happen to you?
//^ hypertonic; dehydrate
//A hypotonic; rehydrate
//B isotonic; be in the same state
//C hypotonic; become sick
//D hypertonic; dehydrate

//#Q When you take a shower or bath for a long time, the skin on your fingertips shrivels.  This happens because your body does this.
//^ Absorbs water in the hypotonic solution
//A Loses water in the hypotonic solution
//B Loses water in the hypertonic solution
//C Absorbs water in the hypertonic solution
//D Absorbs water in the hypotonic solution

//#Q Which vehicle can also transport data?
//^ Bus
//A Ship
//B Car
//C Plane
//D Bus

//#Q Which astronomical phenomenon is also a popular programming environment?
//^ Eclipse
//A Polar lights
//B Eclipse
//C Equinox
//D Comet

//#Q Which vegetables come in the Enterprise Java flavour?
//^ Beans
//A Beans
//B Broccoli
//C Potatoes
//D Peas

//#Q The name of which beautiful flower also refers to an e-mail server/client?
//^ Lotus
//A Orchid
//B Rose
//C Lotus
//D Lily

//#Q Which girls name is also a the name of a computer programming language?
//^ Ada
//A Ada
//B Amelia
//C Anna
//D Agnes

//#Q Which sweets are stored by an Internet browser?
//^ Cookies
//A Biscuits
//B Candy bars
//C Cookies
//D Chocolates

//#Q What part of your body becomes a connection method when colored?
//^ Bluetooth
//A Green tongue
//B Blond hair
//C Bluetooth
//D Red-eye

//#Q Which art term is also used to refer to dependencies between computer applications or processes?
//^ Choreography
//A Choreography
//B Screenplay
//C Directing
//D Libretto

//#Q Which small software is actually a software giant from Redmond?
//^ Microsoft
//A Milisoft
//B Nanosoft
//C Minisoft
//D Microsoft

//#Q Which plant with tasty fruits is also a wireless handheld device?
//^ Blackberry
//A Strawberry
//B Blueberry
//C Gooseberry
//D Blackberry

//#Q The name of which capital city also refers to an open source project for the Java platform?
//^ Jakarta
//A Rome
//B Mexico
//C Jakarta
//D Cairo

//#Q Which letter of the alphabet is also the name of a popular computer programming language?
//^ C
//A E
//B C
//C B
//D A

//#Q Chemistry is defined as the natural science of matter, dealing with the composition of substances and their properties, reactions and interactions.  Which of the following would NOT be an example of a chemical reaction?
//^ converting liquid water to gaseous steam
//A mixing vinegar and baking soda together
//B the burning of a piece of wood
//C converting liquid water to gaseous steam
//D the rusting of a nail

//#Q What term describes the concentration of a solution in moles per liter?
//^ molarity
//A molarity
//B osmosis
//C diffusion
//D molality

//#Q pH, or the negative log of the H3O+ (hydronium ion) concentration, is the measure of acidity or basicity of an aqueous solution.  Which solution would have the lowest pH at room temperature?
//^ a strong acid such as sulfuric acid
//A a weak base such as ammonium hydroxide
//B a weak acid such as acetic acid
//C a strong acid such as sulfuric acid
//D a strong base such as sodium hydroxide solution

//#Q The equilibrium constant expression for a chemical equation is equal to the product concentrations divided by the reactant concentrations.  For example, A + B = C + D will give an equilibrium constant = [C][D]/[A][B].  According to LeChateliers principle, which of the following will affect the equilibrium of a given reaction?
//^ all of these will affect equilibrium
//A changing the volume or pressure
//B all of these will affect equilibrium
//C increasing the temperature
//D changing the concentration of a reactant or a product

//#Q In the Bronsted-Lowry acid-base classification, an acid is defined as a proton donor and a base is a proton acceptor.
//^ True
//A False
//B True

//#Q What does the  word geometry mean?
//^ earth measure
//A width and length
//B earth measure
//C shapes and sizes
//D size and measurement

//#Q What do we call a triangle that has three unequal sides?
//^ scalene
//A heronian
//B equilateral
//C scalene
//D isosceles

//#Q The Law of Pythagoras can always be used to find the length of the hypotenuse of an isosceles triangle.
//^ False
//A True
//B False

//#Q What is a curve?
//^ Anything that can be drawn in a plane without lifting the writing device.
//A A plane shape that never ends.
//B A plane shape that has no depth.
//C A plane shape that is not straight.
//D Anything that can be drawn in a plane without lifting the writing device.

//#Q Hexagon ABCDEF has six equal sides and six equal angles. How many degrees is each angle?
//^ 120 degrees
//A 144 degrees
//B 90 degrees
//C 180 degrees
//D 120 degrees

//#Q You have a string that is 120 inches. You must use this to enclose a shape of maximum area. What shape should  you form?
//^ A circle of circumference 120 inches
//A A square of 60 inches on each side
//B A square of 30 inches on each side
//C A circle of circumference 120 inches
//D A triangle of 30 inches on each side

//#Q If we add up all the interior angles of a quadrilateral, what sum do we get?
//^ 360 degrees
//A 90 degrees
//B 540 degrees
//C 180 degrees
//D 360 degrees

//#Q Two angles of a triangle are 4 degrees and 56 degrees, respectively. How large is the  third angle?
//^ 120 degrees
//A 60 degrees
//B 45 degrees
//C 120 degrees
//D 30 degrees

//#Q If we are using  regular square graph papers, what do we call the point where the x-axis meets the y-axis?
//^ the origin
//A the abscissa
//B the quadrant
//C the ordinate
//D the origin

//#Q The parallel sides of a trapezoid are 5 inches and 11 inches long. The height of the trapezoid is 4 inches. What is the area of the trapezoid?
//^ 32 square inches
//A 32 square inches
//B 256 inches
//C 64 square inches
//D 20 square inches

//#Q What do we call an angle of less than 90 degrees?
//^ acute
//A reflex
//B oblique
//C acute
//D obtuse

//#Q What was the name of the first geometry textbook which was written by the ancient Greek Euclid?
//^ The Elements
//A The Stoia
//B The Principia
//C The Elements
//D The Academy

//#Q Labeling of nutrition contents is required for most prepared foods. In the US, the Food and Drug Administration, the government agency responsible for regulating food, drugs, and cosmetic products, requires that a product labeled low fat contain what maximum amount of fats?
//^ No more than 3 grams per serving
//A No more than 3 grams per serving
//B Less than 1 gram per serving
//C Less than 5 grams per serving
//D No more than 15% of the servings calories from fat

//#Q Fats are a highly concentrated source of energy. It is estimated that one gram of fat provides how many calories?
//^ 9 kcal
//A 7 kcal
//B 20 kcal
//C 4 kcal
//D 9 kcal

//#Q Carbohydrates can be found in breads, cereals, fruits, and vegetables. Which of these compounds is not a carbohydrate?
//^ Glycerol
//A Fructose
//B Cellulose
//C Starch
//D Glycerol

//#Q Vitamin A plays an important role in vision, growth, healthy skin and hair, immune function, and reproduction. Which of these is not a significant source of Vitamin A?
//^ Nuts and grains
//A Egg yolks
//B Nuts and grains
//C Dark leafy greens
//D Sweet potatoes

//#Q The group of nutrients at the base of the Food Pyramid contains breads, grains, cereals, and pastas, so these foods should predominate in our diet. Which of these represents one serving from this group?
//^ 1/2 cup cooked cereal
//A 1 donut
//B 1/2 cup cooked cereal
//C 2 slices of bread
//D 4 cookies

//#Q Vegetarians can get all the proteins they need through non-meat food sources.
//^ True
//A True
//B False

//#Q Saturated fats have proven to be the main dietary cause of high blood LDL cholesterol levels.
//^ True
//A False
//B True

//#Q Vitamin C and Vitamins of the B group are crucial for the proper functioning of the body.  Are they considered to be complex, fat-soluble substances?
//^ No
//A No
//B Yes

//#Q Along with the minerals extracted from nutrients, the human body also produces minerals of its own, essential for maintaining it in good condition.
//^ No
//A Yes
//B No

//#Q Which cooking technique is considered to be best for preserving vitamins and minerals in meat and fish, during heat processing?
//^ Roasting
//A Deep frying
//B Braising
//C Sauteing
//D Roasting

//#Q This mineral, an important component of all living creatures cellular membranes, is one of the major minerals required in the structural composition of bones and teeth.
//^ Phosphorus
//A Phosphorus
//B Iron
//C Potassium
//D Fluoride

//#Q Which of these is a major problem concerning nutrition value of food, served at restaurants?
//^ Oversized meals
//A Foods lacking whole grains and fibers
//B Oversized meals
//C Excess protein contents
//D Excess sodium contents

//#Q What is the largest artery in the body?
//^ Aorta
//A Aorta
//B Carotid artery
//C Epicardium
//D Pulmonary artery

//#Q Which of the following is not a heart valve?
//^ Carotid Valve
//A Carotid Valve
//B Tricuspid valve
//C Mitral Valve
//D Pulmonary Valve

//#Q Which of the following is not a function of the pericardium?
//^ Receives blood returning to the heart from the superior and inferior vena cava
//A Keeps the heart contained in the chest cavity
//B Limits heart motion
//C Prevents the heart from over-expanding when blood volume increases
//D Receives blood returning to the heart from the superior and inferior vena cava

//#Q How many types of blood vessels are there?
//^ 4
//A 5
//B 6
//C 7
//D 4

//#Q The epicardium is also known as the visceral pericardium.
//^ True
//A True
//B False

//#Q Does the myocardium receive stimulation from the nervous system for its contractions?
//^ No
//A Yes
//B No

//#Q How many phases are there in a human cardiac cycle?
//^ 2
//A 3
//B 2
//C 1
//D 4

//#Q What are the two largest veins in the body?
//^ Vena cavae
//A Vena cavae
//B Pulmonary veins
//C Coronary veins
//D Atria

//#Q Where is the heart located?
//^ Between the lungs, behind and slightly to the left of your breastbone.
//A On top of the lungs, behind and slightly to the left of your breastbone.
//B Beneath the lungs, behind and slightly to the left of your breastbone.
//C To the right of the lungs, behind and slightly to the left of your breastbone.
//D Between the lungs, behind and slightly to the left of your breastbone.

//#Q What are cardiac arrhythmias?
//^ Abnormal rhythms of the heart
//A Abnormal rhythms of the heart
//B Whistling or swishing sounds
//C How fast your heart is beating
//D Normal rhythms of the heart

//#Q It may be stated that the process of thinking like an economist involves three basic issues. Which of the following is the odd one?
//^ Economists deal only with items with explicit prices
//A Economists explore the relationships between two variables, which hold other variables fixed.
//B Economists consider opportunity costs.
//C Economists think in marginal terms.
//D Economists deal only with items with explicit prices

//#Q Which statement about the problem of scarcity, a central issue in economics, is true?
//^ It is present when human wants exceed available resources.
//A It is present when human wants exceed available resources.
//B It exists only in market economies.
//C It could be eliminated if we could force prices to fall.
//D It is present when there is monopoly on the market.

//#Q In economics, the marginal concept refers to producing or consuming a good at the margin of the total produced or consumed amount. Which question does not involve a marginal decision?
//^ If I hire ten workers to produce tables, what will be the average cost per table?
//A Is it worth $2 to buy this extra slice of pizza?
//B If I drive slightly faster, what will be the change in my gasoline consumption?
//C If I hire ten workers to produce tables, what will be the average cost per table?
//D If I study for one more hour, by how much will it raise my grade?

//#Q In economics, opportunity cost is the difference between the yield that funds and resources earn in one use and the yield they could have earned had they been placed in an alternative investment.  Which of these factors has the most impact on opportunity cost?
//^ Scarcity
//A Poverty
//B Unemployment
//C Scarcity
//D Consumer spending

//#Q The spillover effect (or externality effect) is a concept in economics related to the impact of a certain decision and the respective action. Which situation would involve a spillover effect?
//^ A neighbour of yours repairs the sidewalk in front of his house, so the overall state of the neighbourhood pavement improves.
//A The hardware store gets an extra shipment of snow shovels, so they offer a buy one, get one free deal.
//B A neighbour of yours repairs the sidewalk in front of his house, so the overall state of the neighbourhood pavement improves.
//C The cost of magazines rises, so fewer and fewer people subscribe.
//D Termites cause excessive damage to your house, so you must pay to replace the adversely affected areas.

//#Q Which of these statements about the effect of specialization and trade on the market is most accurate?
//^ It causes the consumption of more and better goods.
//A It causes an increase in production.
//B It boosts purchasing ability of the consumers.
//C It causes the consumption of more and better goods.
//D It affects World economics as a whole.

//#Q In economics, the concept of opportunity cost is related to both the alternatives and decision-making. A friend offers you a Coke, a Pepsi, or a Diet Coke. You dont like Diet Coke, so after some thought, you take the Pepsi. In this case, what is the opportunity cost of your choice?
//^ The Coke
//A The Pepsi
//B The Diet Coke
//C The Coke plus the Diet Coke
//D The Coke

//#Q It is generally accepted, that economic market systems have proved to be so stable and efficient for which of these reasons?
//^ They facilitate exchange and specialization.
//A Everyone pays the same amount in taxes.
//B People cannot be self - sufficient.
//C They facilitate exchange and specialization.
//D Producers cannot specialize without markets.

//#Q What do we call the type of economy, where the government has an exclusive control over the production and distribution of goods and services?
//^ Centrally planned economy
//A Communal economy
//B Market economy
//C Transitional economy
//D Centrally planned economy

//#Q The oldest known aromatherapy text describes a medical practice which relied on aromatics. It is from the Sumerian period and approximately this old.
//^ 3500 BC
//A 2000 BC
//B 3500 BC
//C 2500 BC
//D 1000 BC

//#Q These compounds are emitted by plants and form gasses, which can be smelled.
//^ Aromatics
//A Vapors
//B Odors
//C Aromatics
//D Oils

//#Q These substances, present in some essential oils, slow down the development of bacteria.
//^ Bacteriostatic
//A Bacterising
//B Bacteriostopping
//C Bacteriostatic
//D Bactericidal

//#Q Add 20 to 30 drops of essential oil to a 100ml bottle of spring or deionized water and leave it in a dark space for a few days. Then filter it to make this.
//^ Flower water
//A Bath oil
//B Flower water
//C Skin oil
//D Cold compress

//#Q Antiseptic oils are used to treat these.
//^ Cuts and insect bites
//A Poor circulation and listlessness
//B Heartburn and indigestion
//C Colds and congestion
//D Cuts and insect bites

//#Q You should dilute this amount of essential oil into 100ml (3.25 fl oz.) of base oil.
//^ 20 - 60 drops
//A 100 - 150 drops
//B 50 - 70 drops
//C 30 - 80 drops
//D 20 - 60 drops

//#Q The physicians in this country can opt for education in aromatherapy, which would allow them to prescribe essential oils in their medical practice.
//^ France
//A Germany
//B Switzerland
//C France
//D Greece

//#Q Malaleuca alternifolia is the Latin name of this plant.
//^ Tea tree
//A Sandalwood
//B Tea tree
//C Peppermint
//D Lavender

//#Q Bergamot oil was discovered by this great explorer, born in Genoa, the son of a wool merchant and weaver.
//^ Christopher Columbus
//A Christopher Columbus
//B Amerigo Vespucci
//C Fernando Magelan
//D Marco Polo

//#Q More than 2000 years ago this famous philosopher and founder of medicine stated that The way to health is an aromatic bath and scented oils massage every day.
//^ Hippocrates
//A Homer
//B Hippocrates
//C Anaximander
//D Pythagoras

//#Q What color are the eggs in the popular Dr. Suess book with the character Sam-I-am that was published in 1960?
//^ Green
//A Green
//B Yellow
//C Blue
//D Red

//#Q This is a delicacy made from certain species of fish eggs, most notably the sturgeon.
//^ Caviar
//A Blintz
//B Coffee
//C Caviar
//D Baklava

//#Q If you are in South Central or South Western Pennsylvania and order dippy eggs, what popular way are you ordering your egg to be cooked?
//^ Over Easy
//A Omelette
//B Poached
//C Over Easy
//D Hard Boiled

//#Q Nutritionally, eggs are considered a good source of what?
//^ Protein
//A Vitamin C
//B Fiber
//C Niacin
//D Protein

//#Q When the white part of the egg is aerate or whipped to a light, fluffy consistency known as soft peaks and stiff peaks what sort of dessert or topping do you have?
//^ Meringue
//A Custard
//B Ice Cream
//C Mustard
//D Meringue

//#Q Vincent Price portrayed Egghead in what popular 1960s television series?
//^ Batman
//A Get Smart
//B Superman
//C Gilligans Island
//D Batman

//#Q Where is Egg Island located?
//^ Bahamas
//A Australia
//B Hawaii
//C Bahamas
//D Mexico

//#Q How long do you need to boil an egg for it to be considered hard boiled?
//^ 10 - 11 minutes
// A 10 - 11 minutes
//  B 5 - 6 minutes
//  C 30 minutes
//  D 1 hour

//# Q What is the name of an Easter egg made for the Russian Tsars between 1885 and 1917.
//^ Fabergé Egg
//A Peter Egg
//B Fabergé Egg
//C Russian Egg
//D Bunny Egg

//#Q Which of the following is not a fluid?
//^ All of these are fluids.
//A Air
//B All of these are fluids.
//C Oil
//D Helium

//#Q What is the definition of the term viscosity?
//^ The resistance of a fluid to deform under shear stress
//A The resistance of a fluid to deform under shear stress
//B The speed of a fluid moving in a tube
//C The time it takes for a fluid to freeze
//D None of these

//#Q What does volumetric flow rate mean?
//^ The volume of fluid which passes through a given volume per unit time
//A The volume of fluid which passes through a given volume per unit time
//B The way a fluid flows
//C None of these
//D The resistance of a fluid to deform under shear stress

//#Q What does laminar flow mean?
//^ The movement of a liquid in straight line(Water in a straw)
//A The movement of a liquid past a bumpy object. (Water past rapids)
//B The movement of a liquid in straight line(Water in a straw)
//C None of these
//D The movement of a liquid in space, outside the planet Earth

//#Q A piece of wood floating on the ocean has what kind of buoyancy?
//^ Positive buoyancy
//A None of these
//B Neutral buoyancy
//C Negative buoyancy
//D Positive buoyancy

//#Q Does gasoline float on distilled water?
//^ Yes
//A No
//B Yes

//#Q Does hydrogen float on helium?
//^ Yes
//A Yes
//B No

//#Q Does liquid mercury float on liquid gold?
//^ No
//A No
//B Yes

//#Q Does liquid iron float on liquid nickel?
//^ Yes
//A Yes
//B No

//#Q What is a hydrometer?
//^ An instrument used to measure a liquids density
//A None of these
//B An instrument used to measure a liquids temperature
//C An instrument used to measure a liquids weight
//D An instrument used to measure a liquids density

//#Q If the crow has any interruption in her note like hiccup, or a croak with a kind of swallowing, it signifies this event.
//^ Wind and rain
//A Wind and tornado
//B Wind and rain
//C Fog and thunder
//D Rain and haze

//#Q A reddish ring around the moon means this.
//^ Rain or snow
//A Rain or snow
//B Rainbow or bright sunshine
//C Fog or haze
//D Wind or rain

//#Q Such the weather will be if at dusk the sky is red.
//^ Dry
//A Dry
//B Rainy
//C Snowy
//D Hot

//#Q The first frost will come within this many days, after you hear the first cicada.
//^ 90
//A 45
//B 50
//C 90
//D 60

//#Q These are often used as weather indicators. Before the weather gets dry, they open up. If it will be wet, they return to their normal shape.
//^ Pine cones
//A Dandelions
//B Pine cones
//C Pea pods
//D Willow sprigs

//#Q This flower opens up in sunny weather. When rain is expected, it closes tightly.
//^ Scarlet Pimpernel
//A Primrose
//B Nasturtium
//C Daisy
//D Scarlet Pimpernel

//#Q If at noon on the 2nd of February you see this animals shadow, be sure the weather will be cold.
//^ A groundhog
//A A weasel
//B A groundhog
//C A hedgehog
//D A hog

//#Q If the tail of these animals appears thicker,  then you could expect a severe winter.
//^ Squirrels
//A Squirrels
//B Bears
//C Skunks
//D Marmots

//#Q If these birds do run for shelter during rain, the weather is going to get worse.
//^ Hens
//A Owls
//B Eagles
//C Pigeons
//D Hens

//#Q You should expect this, if fish jump out of the water while the weather is nice.
//^ Rain
//A Rainbows
//B Extreme heat
//C Lightning storm
//D Rain

//#Q A tropical cyclone is a storm with a closed circulation around a center of low pressure. Based on strength and location a tropical cyclone can be referred to by different names. Which of the following is not a possible name for a tropical cyclone?
//^ Mesocyclone
//A Tropical Storm
//B Typhoon
//C Hurricane
//D Mesocyclone

//#Q A tropical cyclone is classified to have reached landfall when the outer edges of the storm are over land.
//^ False
//A False
//B True

//#Q Once a tropical cyclone reaches wind speeds of at least 39 mph, it is classified as a tropical storm. At what minimum wind speed is a tropical storm classified as a hurricane or typhoon?
//^ 74 mph
//A 74 mph
//B 52 mph
//C 85 mph
//D 92 mph

//#Q In 1994, what major hurricane broke the record for longest-lasting hurricane ever observed both in the Pacific Ocean and worldwide?
//^ Hurricane John
//A Hurricane John
//B Hurricane Carrie
//C Hurricane Ginger
//D Hurricane Kyle

//#Q Despite a hurricane’s destructive nature and its toll on both lives and property, there are some beneficial effects of tropical cyclones.
//^ True
//A True
//B False

//#Q The word hurricane” comes from the name of a Caribbean god - Huracan. Huracan was god of what?
//^ The storms
//A The sea
//B The weather
//C The moon
//D The storms

//#Q What is the minimum ocean water temperature required for a tropical cyclone to form?
//^ 80 degrees Fahrenheit
//A 87 degrees Fahrenheit
//B 80 degrees Fahrenheit
//C 77 degrees Fahrenheit
//D 93 degrees Fahrenheit

//#Q Jupiter, the fifth planet from the Sun, has atmosphere composed of what gases?
//^ Hydrogen and helium
//A Oxygen and hydrogen
//B Hydrogen and nitrogen
//C Oxygen and nitrogen
//D Hydrogen and helium

//#Q According to the distance between the planets and the Sun, Jupiter is situated between which two planets in the Solar system?
//^ Mars and Saturn
//A Mercury and Venus
//B Venus and Earth
//C Neptune and Pluto
//D Mars and Saturn

//#Q The constant anticyclonic storm on Jupiter which can be seen through telescopes from Earth is called by what name?
//^ The Great Red Spot
//A The Green Belt
//B The Great Red Spot
//C The Red Eye
//D The Bright White Eye

//#Q How do the Korean, the Japanese and the Chinese call Jupiter?
//^ Wood star
//A Iron fist
//B Wood star
//C Ice cube
//D Fire ball

//#Q How many moons, revolving around Jupiter, did Galileo Galilei discover in the 17th century?
//^ 4
//A 4
//B 9
//C 1
//D 2

//#Q Which one is not a name of a Galilean moon revolving around Jupiter?
//^ Athena
//A Io
//B Athena
//C Europa
//D Callisto

//#Q The first directly-observed collision between two solar system bodies was between Jupiter and which comet?
//^ Shoemaker - Levy 9
//A Shoemaker - Levy 9
//B Hale - Bopp
//C Schwassmann - Wachmann
//D Tuttle - Giacobini - Kresak

//#Q The four Jovian planets in the Solar system are Jupiter, Saturn, Neptune and which other planet?
//^ Uranus
//A Mars
//B Venus
//C Uranus
//D Earth

//#Q Jupiter, the largest planet in the Solar system, is the ruling planet of which astrological sign?
//^ Sagittarius
//A Aries
//B Gemini
//C Sagittarius
//D Libra

//#Q Which of these names refers to a large group of asteroids in Jupiters orbit?
//^ The Trojan asteroids
//A The Hellenic asteroids
//B The Trojan asteroids
//C The Roman asteroids
//D The Martian asteroids

//#Q What are the abbreviations on prescriptions called?
//^ sig codes
//A sib abbreviations
//B sig codes
//C sif abbreviations
//D sic codes

//#Q Should I eat before taking my medication, if the prescription says the medication should be taken a.c.?
//^ No
//A No
//B Yes

//#Q In a pharmacy setting, what does ft. mean?
//^ let it be made
//A feet
//B for tincture
//C let it be made
//D place under tongue

//#Q Which of these is used to indicate the medication should be taken with food?
//^ c.c.
//A w.c.
//B l.c.
//C c.c.
//D a.c.

//#Q If a prescription has the terms NS and OS written on it, what does this probably mean?
//^ You have an eye problem.
//A You need an IV.
//B You cant get more of your ulcer medication.
//C You have really bad dandruff.
//D You have an eye problem.

//#Q Which of these would most likely appear on a prescription if the medication should be taken as a large single dose?
//^ bol.
//A prn
//B A.A.O.
//C bol.
//D q.i.d

//#Q Which of these is not one of the four main parts that make up a prescription?
//^ petition
//A petition
//B signature
//C inscription
//D subscription

//#Q If the prescription reads take 2 IBU 400mg Tab PO BID p.c. disp. q.s. 5 days DAW, how many ibuprofen tablets should be dispensed?
//^ 20
//A 10
//B 30
//C 40
//D 20

//#Q Pregnancy has a lot of myths surrounding it. Is this one of them? Do spicy foods and/or red wine help induce labor?
//^ No
//A Yes
//B No

//#Q This woman was the first female licensed physician in Great Britain. She died on December 17, 1917 at the age of 81.
//^ Elizabeth Garrett Anderson
//A Agnodice
//B Dr.Quinn
//C Florence Nightingale
//D Elizabeth Garrett Anderson

//#Q If youre double-jointed, it means you have two joints where normally there is one.
//^ False
//A True
//B False

//#Q If a dog is wagging its tail, then it is safe to approach.
//^ False
//A True
//B False

//#Q The nose is an amazing piece of the human body.  Every flower or food gives off odor molecules that your nose picks up and your brain translates. How many smells can your brain recognize?
//^ 10, 000
//A 5, 000
//B 15, 000
//C 10, 000
//D 20, 000

//#Q Which of these countries has the highest infant mortality rate according to a 2006 revision of the UN World Population Prospects report?
//^ United States
//A Singapore
//B Czech Republic
//C United States
//D Sweden

//#Q I think we have all heard this one. Does an apple a day keep the doctor away?
//^ No
//A Yes
//B No

//#Q What do you call a massive system of stars held together by gravity?
//^ A galaxy
//A A nebula
//B None of these
//C Space
//D A galaxy

//#Q Meteoroids are small celestial bodies consisting of ice, dust and rock that form gaseous tails as they move closer to the Sun.
//^ False
//A False
//B True

//#Q Which of the following asteroids is the only one visible to the naked eye?
//^ Vesta
//A Davida
//B Vesta
//C Ceres
//D Pallas

//#Q A solar eclipse is when Earth casts a shadow on the Moon.
//^ False
//A False
//B True

//#Q Which is the hottest planet of the Solar System?
//^ Venus
//A Mars
//B Venus
//C Mercury
//D Uranus

//#Q This Solar System body was once considered a planet, but was later reclassified as a dwarf planet and a member of the Kuiper Belt.
//^ Pluto
//A None of these
//B Venus
//C Jupiter
//D Pluto

//#Q Which planet of the Solar System has the most moons?
//^ Jupiter
//A Mars
//B Saturn
//C Jupiter
//D Pluto

//#Q Which of these equations can describe the Theorem of Pythagoras?
//^ a ^ 2 + b ^ 2 = c ^ 2
//A sqrt(pi) = t ^ 3
//B a ^ 2 + b ^ 2 = c ^ 2
//C e ^ (pi * i) = -1
//D a ^ 3 + b ^ 3 = c ^ 3

//#Q This can be viewed as a generalization of the Pythagorean Theorem.
//^ Law of Cosines
//A Law of  Willens
//B Law of Cosines
//C Law of Cotangents
//D Law of Verseed Sines

//#Q This is sometimes called Eulers Formula.
//^ e ^ (pi * i) + 1 = 0
//A a ^ 2 + b ^ 2 = c ^ 2
//B e = m * c ^ 2
//C a ^ 2 = b ^ 2 + c ^ 2 - 2 * a * b * cosine c
//D e ^ (pi * i) + 1 = 0

//#Q This is one of the major equations of relativity.
//^ E = M * C ^ 2
//A V = (4 / 3) * pi * r ^ 2
//B V = arcsine(pi + i ^ 2)
//C L = sqrt(L / g)
//D E = M * C ^ 2

//#Q What is the name of this famous theorem?  If x, y, and z are non-zero positive integers, then x^n+y^n=z^n has no solution if n is an integer greater than two.
//^ Fermats Theorem
//A Fermats Theorem
//B Gauss Theorem
//C Eulers Theorem
//D Riemanns Hypothesis

//#Q x^2+y^2=r^2 is which equation?
//^ the equation of a circle
//A the equation of a parabola
//B the equation of a circle
//C the equation of a right triangle
//D the equation of a hyperbola

//#Q What is this equation?  F=G*m1*m2/d^2
//^ the force of gravity between two bodies of masses m1 and m2 at distance d
//A the atomic number of an isotope of uranium at distance d from the nucleus
//B the force of gravity between two bodies of masses m1 and m2 at distance d
//C the  thermal force between two masses, m1 and m2 at a distance d from the isothermal center
//D the focal length of a lens of diopter length m1 and m2 at distance d

//#Q Given the equation C=pi*D. What does the C and the D stand for?
//^ The circumference and diameter of a circle
//A The circumference and diameter of a circle
//B The electrical capacitance and the electrical dipole
//C The circular radius and the diopter distance
//D The cranial area and the circumspectum

//#Q What does this equation describe?  y=A(sin) wt, where A is the amplitude and t is the time.
//^ Simple harmonic motion
//A The tangent of the angle x
//B The cosine of the angle w
//C Linear motion
//D Simple harmonic motion

//#Q This equation, Y=mX+B, represents what?
//^ A line in the plane
//A A prism
//B A circle in the plane
//C A line in the plane
//D An ellipse in the plane

//#Q Which drug consists of a sediment, extracted form the fruit of the squirting cucumber, that is native of the the Mediterranean region?
//^ Elaterium
//A Piperazine
//B Thionin
//C Elaterium
//D Mycoherbicide

//#Q Rafflesia, a parasitic plant found in southeastern Asia, has flowers, which smell like what?
//^ Rotting meat
//A Sweet perfume
//B Mushrooms
//C Rotting meat
//D Garlic

//#Q This tree, which grows mainly in Australia, is the tallest of all flowering evergreen plants.
//^ Eucalyptus
//A Acacia cultriformis
//B IIIawarra
//C Sugar brother
//D Eucalyptus

//#Q Drosera, an insectivorous plant that grows in South Africa, South America and Australia, attracts the insects to its tips in what way?
//^ By its dew - drop appearance
//A By its colours
//B By its smell of rotting meat
//C By its sweet smell
//D By its dew - drop appearance

//#Q This type of orchid, discovered by Charles Darwin, is pollinated by the hawkmoth, an insect with a long tongue.
//^ The Comet Orchid
//A Stargaser
//B Clivia miniata
//C Sundew
//D The Comet Orchid

//#Q Which tree, that grows on the Canary Islands, Cape Verde and Madeira, secretes a reddish juice, called Dragons blood?
//^ Dracaena draco
//A Dracaena draco
//B Para rubber tree
//C The Canary Island Pine
//D Castanopsis

//#Q This plant, native to the shallow waters of the Amazon River basin, is the largest representative of waterlilies.
//^ Victoria waterlily
//A American Lotus
//B Sacred Lotus
//C Red lily
//D Victoria waterlily

//#Q Which plant, that grows in the equatorial rainforests of Sumatra, Indonesia, has the largest unbranched inflorescence in the world?
//^ Titan arum
//A Titan arum
//B Rafflesia amoldii
//C Talipot palm
//D Tillandsia

//#Q The German word edelweiss, referring to one of the most famous European mountain flowers, means what in English?
//^ Noble and white
//A Frost and noble
//B Beautiful and white
//C Noble and white
//D Frost and white

//#Q Three dogs and two puppies weigh 128 lbs. Four dogs and three puppies weigh 176 lbs. All dogs weigh the same and all puppies weigh the same. What is the weight of two dogs and one puppy?
//^ 80 lbs
//A 32 lbs
//B 16 lbs
//C 80 lbs
//D 48 lbs

//#Q Isabella took a test that had 20 questions.  The total grade was computed by awarding 10 points for each correct answer and deducting 5 points for each incorrect answer. Isabella answered all 20 questions and received a score of 125. How many answers did Isabella get incorrect?
//^ 5
//A 10
//B 5
//C 3
//D 8

//#Q Which two planets of the Solar System, characterized by a low magnetic field, have no moons at all?
//^ Mercury and Venus
//A Mercury and Mars
//B Mercury and Venus
//C Venus and Jupiter
//D Venus and Mars

//#Q Which natural satellite is Jupiters largest moon as well as the largest moon in the whole Solar System?
//^ Ganymede
//A Titan
//B Io
//C Europa
//D Ganymede

//#Q This moon, bearing the name of the ferryman of the dead in Greek mythology, is the largest satellite of Pluto.
//^ Charon
//A Charon
//B Nereid
//C Proteus
//D Larissa

//#Q What is the fifth largest moon of Jupiter, named after the nymph of Greek Mythology, who nursed young Zeus (Jupiter) with goat milk.
//^ Amalthea
//A Galatea
//B Mimas
//C Amalthea
//D Himalia

//#Q Cupid, named after a character in a Shakespearean play and discovered in 2003 with the help of the Hubble telescope, is a small natural satellite of which planet?
//^ Uranus
//A Mars
//B Saturn
//C Uranus
//D Neptune

//#Q This space object, named after the mythological son of Ares (Mars), is the larger and innermost of Mars two moons, orbiting closer to its major planet than any other satellite in the Solar System.
//^ Phobos
//A Phobos
//B Thebe
//C Elara
//D Deimos

//#Q What is the name of the largest moon of Saturn and the second largest moon in the Solar System, which was the first satellite to be discovered after the discovery of the four Galilean moons?
//^ Titan
//A Io
//B Titan
//C Rhea
//D Triton

//#Q This asteroid, orbiting around the sun, is sometimes called the second moon of the Earth but it is not a real satellite.
//^ Cruithne
//A Vesta
//B Cruithne
//C Pallas
//D Davida

//#Q Which natural satellite of Saturn is characterized by its irregular shape, unexplained sponge-like appearance and chaotic rotation?
//^ Hyperion
//A Janus
//B Miranda
//C Oberon
//D Hyperion

//#Q This natural satellite, named after Neptunes son from the Greek Mythology, is the largest moon of the planet Neptune.
//^ Triton
//A Nereid
//B Phoebe
//C Triton
//D Proteus

//#Q Which company demonstrated the first GPRS mobile phone with video-on-demand in March of 2002?
//^ Samsung
//A Sony Ericsson
//B Motorola
//C Nokia
//D Samsung

//#Q In 2002 Ericsson signed a joint agreement with a vendor, whose advanced silicon technology would be used in the core components for Ericssons GPRS and 3G reference design platforms.  Who was that vendor?
//^ Texas Instruments
//A IBM
//B Motorola
//C Intel
//D Texas Instruments

//#Q In 2002, which battery manufacturer announced the development of a battery, which would fully recharge in 15 minutes or less?
//^ Rayovac
//A Duracell
//B Rayovac
//C Energizer
//D Sony

//#Q In 2002, which phone manufacturer announced the first handset with camera for cdma2000 1x EV-DO service?
//^ LG
//A Motorola
//B Nokia
//C LG
//D Sony Ericsson

//#Q In 2002, which manufacturer launched the first windows-powered cell phone, originally known as codename canary?
//^ HTC
//A LG
//B HTC
//C Nokia
//D Samsung

//#Q Announced in 2002, model 6370 was what manufacturers first CDMA2000 1X handset?
//^ Nokia
//A Nokia
//B Siemens
//C Sony Ericsson
//D Motorola

//#Q In August 2002, this wireless company announced the availability of roaming in 35 countries.  It was later bought out by Cingular Wireless.
//^ ATT Wireless
//A T - mobile
//B VoiceStream
//C ATT Wireless
//D Verizon Wireless

//#Q In November of 2002 Sprint PCS announced the launch of the first US camera phone.  Who was the manufacturer?
//^ Sanyo
//A Nokia
//B LG
//C Sanyo
//D Siemens

//#Q In 2002, which manufacturer announced the first 3GPP compliant EDGE (Enhanced Data-Rates for GSM Evolution) handset?
//^ Nokia
//A Nokia
//B Sony Ericsson
//C Samsung
//D Motorola

//#Q When first announced, the RS MultiMediaCard (RS-MMC) was available in what maximum density?
//^ 64mb
//A 32mb
//B 128mb
//C 256mb
//D 64mb

//#Q From which language does the word  algebra derive?
//^ Arabic
//A Greek
//B Arabic
//C Latin
//D Sanskrit

//#Q How many of the basic mathematical operations are needed to have an algebra?
//^ 3
//A 3
//B 2
//C 0
//D 4

//#Q In the group of whole numbers under addition, what is the additive identity of 7?
//^ 0
//A 1 / 7
//B 1
//C - 7
//D 0

//#Q Which famous mathematician proved that there is no formula to find the roots of any equation of degree more than four?
//^ Abel
//A Abel
//B Euler
//C Gauss
//D Galois

//#Q In algebra, what is an Abelian group?
//^ A group that is commutative
//A A group that is distributive
//B A group that is reflexive
//C A group that is commutative
//D A group that is transitive

//#Q This mathematician was the first to develop an algebraic method of solving any cubic equation.
//^ Nicolai Fontana Tartaglia
//A Nicolai Fontana Tartaglia
//B Evariste Galois
//C Girolamo Cardano
//D Carl Friedrich Gauss

//#Q Who was the first mathematician to use the term group?
//^ Evariste Galois
//A Georg Cantor
//B Evariste Galois
//C Augustin Cauchy
//D Leonhard Euler

//#Q The subject that studies the solution of a system of linear inequalities is called Linear Programming. Which of these men was most instrumental in its development?
//^ George B.Dantzig
//A Sir Isaac Barrow
//B Sir Isaac Newton
//C Alfred Whitehead
//D George B.Dantzig

//#Q In the set of real numbers under the operation of multiplication, every number has an inverse.
//^ False
//A False
//B True

//#Q Different colors derive form the different wavelengths of the spectrum of light. What part of it do we call visible light, i.e. we can perceive with our eyes?
//^ 380 - 740 nm
//A 0 - 500 nm
//B 1000 + nm
//C 700 - 900 nm
//D 380 - 740 nm

//#Q What is the science of colors called?
//^ Chromatics
//A Chromatics
//B Chromatology
//C Colorology
//D Coloritics

//#Q When a wave of light with a wavelength of approximately 700 nm hits your eyes, it causes sensation of what color?
//^ Red
//A Green
//B Black
//C It will cause no sensation
//D Red

//#Q Which is the color from the visible spectrum produced by waves of the smallest wavelength?
//^ Violet
//A Violet
//B Yellow
//C Red
//D Green

//#Q If an object scatters light in all wavelengths, what color does it appear to be?
//^ White
//A White
//B Transparent
//C Black
//D Invisible

//#Q What objects do we call translucent?
//^ Objects that transmit light and scatter it
//A Objects that transmit light and scatter it
//B Objects that reflect all light specularly(i.e. in the manner of a mirror)
//C Objects that absorb all wavelengths
//D Objects that transmit light but do not scatter it

//#Q Chemiluminescence is a phenomenon involving which of the following processes?
//^ Emitting light
//A Emitting light
//B Reflecting light
//C Refracting light
//D Transmitting light

//#Q What component of the human eye is responsible for the perception of light of different wavelengths, which results into color vision?
//^ Cones
//A Cones
//B Rods
//C None of these
//D Pupils

//#Q It has been calculated that human beings can distinguish this many different colors.
//^ 10 millions
//A 10 000
//B 10 millions
//C 256
//D 260 000

//#Q Compared to men, women are much more likely to fall into this group in regards to their color vision.
//^ Tetrachromats
//A Color-deficient
//B Dichromats
//C Tetrachromats
//D Color-blind

//#Q Synesthesia is a special condition of the brain which is characterized by which of the following unusual events?
//^ Seeing colors when listening to music or reading letters/ numbers
//A Seeing colors when in stress
//B Seeing colors generated by the brain not based on reality
//C Seeing colors when listening to music or reading letters/ numbers
//D Seeing colors when sleeping

//#Q For a few seconds after exposure to strong light we continue to see the shape of the light source even after we dont look at it any more. What are these fleeting images in our brain called?
//^ Afterimages
//A Echoimages
//B Preimages
//C Afterimages
//D Printouts

//#Q According to the color theory what should red paint look viewed under blue light?
//^ Black
//A Transparent
//B Black
//C White
//D Purple

//#Q Which of the following colors cannot be a pure spectral color?
//^ Purple
//A Cyan
//B Purple
//C Yellow
//D Orange

//#Q Which of the following colors is an example of a Tyndall effect color?
//^ The blue of the human iris
//A The red of the red apple
//B All of these
//C The color of the human skin
//D The blue of the human iris

//#Q In most computer monitors which of these colors is not accomplished by simply emitting in the respective wavelength?
//^ Orange
//A Green
//B Red
//C Orange
//D Cyan

//#Q What important work connected to color theory did the international group of experts known as the Commission Internationale de leclairage (CIE) create in 1931?
//^ Developed a mathematical model of color
//A Mapped the frequency of basic colors in the spectrum
//B Developed a mathematical model of color
//C Developed the color model of the universe
//D Defined the primary, secondary, and tertiary colors

//#Q What two main characteristics measure the properties of light in the human visible range?
//^ Frequency and intensity
//A Frequency and intensity
//B Wavelength and speed
//C Speed and intensity
//D Wavelength and frequency

//#Q Which of the statements about the spectral colors and light sensation in humans is true?
//^ There are more possible spectral combinations than color sensations in the human brain.
//A Spectral light causes equivalent color sensations in most mammal species.
//B In order to cause a sensation of a certain color the light should be emitted only in this color.
//C There are more possible spectral combinations than color sensations in the human brain.
//D There are more possible color sensations in the human brain than spectral combinations.

//#Q Which species has the most complex color vision system in the animal kingdom?
//^ Mantis shrimp
//A Mantis shrimp
//B Honey-and bumblebees
//C Fat - tailed dunnart
// D Pigeons

//# Q The mean distance between the Sun and the Earth is about 93 million miles, which is also called what by astronomers?
//^ Astronomical Unit(AU)
//A Light Year(LY)
//B Astronomical Unit(AU)
//C Solar Constant(SC)
//D Astronomical Mile(AM)

//#Q How long does it take light to travel from the Sun to the Earth?
//^ About 8 minutes
//A Less than 1 minute
//B Just over 34 minutes
//C It arrives instantaneously
//D About 8 minutes

//#Q The Sun creates its radiation (heat) by the nuclear fusion between which two elements?
//^ Hydrogen and Helium
//A Helium and Oxygen
//B Carbon and Helium
//C Hydrogen and Helium
//D Hydrogen and Carbon

//#Q The Sun contains about what percentage of the entire solar systems mass?
//^ 98 %
//A 28 %
//B 98 %
//C 78 %
//D 58 %

//#Q How long does it take the Sun to rotate once upon its axis?
//^ About 24 to 28 days
//A About 24 to 28 days
//B The Sun does not rotate at all
//C About 24 to 30 hours
//D About once a year

//#Q The period of time between maximum and minimum sunspot activity, known as the Solar Cycle is about how many years in length?
//^ 11 years
//A 51 years
//B 101 years
//C 1 year
//D 11 years

//#Q The Suns surface temperature is roughly 10,000 degrees F. The temperature at the Suns core, however can be as high as what?
//^ 2,000,000 degrees F.
//A 25,000 degrees F.
//B 100,000 degrees F.
//C 2,000,000 degrees F.
//D 500,000 degrees F.

//#Q The Suns magnetic field, driven by the Solar Wind, can reach distances how far out into space?
//^ Into Interstellar space
//A Just past the orbit of Mercury
//B Into Interstellar space
//C Just inside the orbit of Jupiter
//D Between Pluto and the Oort Cloud

//#Q A Solar Eclipse occurs when the Earth is between the Sun and the Moon.
//^ False
//A False
//B True

//#Q What Greek mythological figure flew too close to the sun with his wings made of wax?
//^ Icarus
//A Pasiphae
//B Ariadne
//C Daedalus
//D Icarus

//#Q On average, how much of a persons body weight is muscle?
//^ 40 %
//A 15 %
//B 65 %
//C 90 %
//D 40 %

//#Q How many muscles are in the human body?
//^ 640
//A 640
//B 1000
//C 150
//D 320

//#Q How many muscles are in your face?
//^ 30
//A 44
//B 12
//C 8
//D 30

//#Q There are 3 types of muscle in the human body. What are they?
//^ Cardiac, Skeletal, Smooth
//A Voluntary, Involuntary, Nervous
//B Voluntary, Involuntary, Skeletal
//C Cardiac, Skeletal, Smooth
//D Aerobic, Anaerobic, Nervous

//#Q While muscle stimulation occurs during weight lifting and resistance exercises, muscle growth occurs later when the muscles are at rest.
//^ True
//A False
//B True

//#Q Which of these would not cause a muscle cramp?
//^ being overweight
//A dehydration
//B low blood sugar
//C extreme cold
//D being overweight

//#Q Doctors dont believe that growing causes pain, so growing pains do not exist.
//^ True
//A True
//B False

//#Q Muscles push and pull-- thats how you can wriggle your fingers back and forth.
//^ False
//A True
//B False

//#Q You should always warm up your muscles before lifting weights.
//^ True
//A False
//B True

//#Q What connects muscles to bones?
//^ Tendons
//A Nothing
//B Tendons
//C Cartilage
//D Ligaments

//#Q Which are the four tastes considered as basic in Western culture?
//^ Bitter, sweet, sour and salty
//A Sweet, salty, tasteless, and sour
//B Bitter, salty, sweet, and savory
//C Sweet, salty, chilly, and sour
//D Bitter, sweet, sour and salty

//#Q Each basic taste corresponds to a specific area of the tongue, which perceives it. This spacial division of taste receptors is called taste map.
//^ False
//A True
//B False

//#Q Taste is related to what other basic sense?
//^ Smell
//A Balance
//B Vision
//C Hearing
//D Smell

//#Q Which is the most bitter substance known to taste researchers?
//^ Denatonium
//A Quinine
//B Brucine
//C Denatonium
//D Coffee

//#Q The ability to perceive the unpleasant taste of bitter is assumed by researchers to have evolved with this function.
//^ To protect people from poisoning
//A To help people choose tasty foods to bad tasting ones
//B To help people choose foods with more vitamins
//C To protect people from poisoning
//D To protect people from overeating

//#Q Saltiness is a taste sensation produced most strongly by which of the following chemical compounds?
//^ Sodium chloride
//A Cesium
//B Sodium chloride
//C Potassium chloride
//D Rubidium

//#Q Sourness is a taste that is a proof of which of the following properties of substances?
//^ Acidity
//A Temperature
//B Toxicity
//C Ionization
//D Acidity

//#Q The carbonyl chemical group in substances evokes the sensation of what taste?
//^ Sweet
//A Sour
//B Sweet
//C Chilly
//D Bitter

//#Q The taste called umami, which is considered by the Japanese and Chinese taste researchers for one of the basic tastes, is mainly associated with which of the following groups of substances?
//^ Proteins
//A Carbohydrates
//B Aldehydes
//C Proteins
//D Fats

//#Q In taste science, what is the meaning of the term supertaster?
//^ A person with sharper sense of taste than average
//A A food with sharper taste than average
//B A person with sharper sense of taste than average
//C A person who tastes foods and beverages professionally
//D A supercomputer with sensors able to detect extremely tastes accurately

//#Q Which of these continents represent the natural habit of the cactus?
//^ South and North America
//A North America and Africa
//B North America, South America and Africa
//C South and North America
//D South America and Africa

//#Q In order to adapt to the dry environment, cacti completely lost their leaves in the process of evolution.
//^ False
//A False
//B True

//#Q Which of these is NOT one of cactis mechanisms for preserving water?
//^ Reduced stem volume
//A A waxy coating on the surface of the plant
//B Reduced surface area
//C Thick, hard-walled stem
//D Reduced stem volume

//#Q Which part of the cactus performs the process of photosynthesis?
//^ Stem
//A Stem
//B Blooms
//C Roots
//D Spines

//#Q Because of the strict water preserving mechanisms, the cactus dies within hours after a part of it is broken or damaged.
//^ False
//A True
//B False

//#Q Which of these processes does the cactus perform only at night?
//^ Transpiration
//A Circulation
//B Transpiration
//C Photosynthesis
//D Reproduction

//#Q Cacti can only be pollinated by a certain type of tropical bees.
//^ False
//A False
//B True

//#Q The coat of arms of which country includes a depiction of a cactus?
//^ Mexico
//A Brasil
//B Peru
//C Mexico
//D Guatemala

//#Q In which of the following areas are cacti used?
//^ All of these
//A Building / construction
//B All of these
//C Cooking
//D Medicine

//#Q What is the origin of the word cactus?
//^ Greek
//A Portuguese
//B German
//C Mexican(Spanish)
//D Greek

//#Q In aromatherapy, essential oils are often used to enhance the mood.
//^ True
//A False
//B True

//#Q This health care discipline uses mostly the technique of spinal adjustment.
//^ Chiropractic
//A Rolfing
//B Acupuncture
//C Chiropractic
//D Alexander Technique

//#Q This type of alternative medicine is based on the assumption that if large amounts of a certain substance cause symptoms of illness, then small amounts of this same substance can alleviate symptoms by activating the body’s self-healing abilities.
//^ Homeopathy
//A Reiki
//B Ozone Therapy
//C Homeopathy
//D Hellerwork Bodywork

//#Q Ayurveda, chiropractic, traditional Chinese medicine and homeopathy are all forms of alternative medicine that adopt which of the following principles?
//^ Holism
//A Holism
//B Survival of the fittest
//C Reductionism
//D Trial and error

//#Q This form of alternative medicine focuses on stimulating different areas of the feet.
//^ Reflexology
//A Therapeutic touch
//B Reflexology
//C Iridology
//D Osteopathy

//#Q One of the fundamental beliefs of ayurveda is that five elements form the Universe and everything in it including the human body. These elements are earth, fire, water, air and which of the following?
//^ Space
//A Rock
//B Space
//C Wood
//D Phlegm

//#Q Color therapy assumes that each color influences differently our moods, levels of energy and even mental state and abilities. What is the color red usually associated with?
//^ Passion and strength
//A Higher mental capability
//B Passion and strength
//C Calmness and purity
//D Optimism and joy

//#Q Tinctures in herbal medicine are made by mixing dried herbs with oils, such as sesame oil or almond oil.
//^ False
//A False
//B True

//#Q Which of the following is NOT a type of yoga?
//^ Asana yoga
//A Hatha yoga
//B Ashtanga yoga
//C Kundalini yoga
//D Asana yoga

//#Q Acupressure uses which of the following techniques?
//^ Finger or hand pressure on certain points of the body
//A Inserting needles into certain points of the body
//B Myofascial release
//C Deep muscle massage
//D Finger or hand pressure on certain points of the body

//#Q Which of these statements is true about the human blood plasma?
//^ It comprises 55 % of the blood content.
//A It is colorless.
//B All of these
//C It comprises 55 % of the blood content.
//D It contains 60 % water.

//#Q What does the term blood serum refer to?
//^ Blood plasma without the clotting proteins
//A None of these
//B Blood plasma without the clotting proteins
//C Blood without the cell elements
//D It is a synonym for blood plasma.

//#Q Which of these names refers to or is a synonym for red blood cells?
//^ All of these
//A Haematids
//B RBCs
//C All of these
//D Erythrocytes

//#Q Which of these statements is true about the white blood cells, also called leukocytes?
//^ All of these
//A They are cells of the immune system.
//B There are five different types of white blood cells.
//C There are leukocytes in the lymph.
//D All of these

//#Q What are the blood cells called thrombocytes responsible for?
//^ Blood clotting
//A Blood clotting
//B Defence against bacteria and viruses
//C Transporting carbon dioxide
//D All of these

//#Q Which of these terms refers to the formation of blood cells?
//^ Haematopoiesis
//A Haematopoiesis
//B Haematogenesis
//C All of these
//D Haematophagus

//#Q Which of these factors defines the medical condition known as anemia?
//^ All of these
//A Decreased number of red blood cells
//B Decreased oxygen - binding ability of the hemoglobin molecules in the blood
//C All of these
//D Decreased quantity of hemoglobin in the blood

//#Q For the removal of which of these waste products is blood responsible?
//^ All of these
//A Lactic acid
//B Carbon dioxide
//C All of these
//D Urea

//#Q Which of these organs is responsible for the production of blood proteins, including clotting proteins?
//^ Liver
//A Bone marrow
//B Liver
//C All of these
//D Spleen

//#Q Which of these organs is responsible for the degradation of red blood cells?
//^ Spleen
//A Spleen
//B Kidneys
//C Liver
//D Lungs

//#Q Saturns rings consist mostly of water ice.
//^ True
//A True
//B False

//#Q Saturn is the Roman name of which Greek deity?
//^ Kronos
//A Styx
//B Ourobouros
//C Kronos
//D Pan

//#Q In astrology Saturn is believed to be the planetary ruler of which sign?
//^ Capricorn
//A Pisces
//B Cancer
//C Sagittarius
//D Capricorn

//#Q Saturn is the furthermost planet that can be seen with the naked eye.
//^ True
//A False
//B True

//#Q This moon of Saturn looks somewhat like a bulls eye if viewed from a certain angle because of the huge Herschel crater on its surface.
//^ Mimas
//A Rhea
//B Tethys
//C Ymir
//D Mimas

//#Q Saturns atmosphere consists mostly of these two gases.
//^ hydrogen and helium
//A hydrogen and methane
//B methane and ammonia
//C helium and nitrogen
//D hydrogen and helium

//#Q Saturns moon Titan is the largest natural satellite in our Solar system.
//^ False
//A True
//B False

//#Q A joint NASA/ESA/ASI robotic spacecraft mission to Saturn and its moons was launched in 1997. What is the spacecraft known as?
//^ Cassini–Huygens
//A Cassini–Huygens
//B Voyager 15
//C Titan IV
//D Ulysses

//#Q Saturn is the only ringed planet in the Solar system.
//^ False
//A False
//B True

//#Q In about how many years does the planet Saturn finish one revolution around the Sun?
//^ 29 1 / 2 years
//A 30 years
//B 29 years
//C 29 1 / 2 years
//D 28 1 / 2 years

//#Q What is the Latin word for skin?
//^ Cutis
//A Derma
//B Papilla
//C Cutis
//D Epicanthus

//#Q What is the name of the pigment that determines the color of human skin?
//^ Melanin
//A Melamine
//B Melanin
//C Antocian
//D Melatonin

//#Q What is the approximate surface of the skin of an average adult human?
//^ From 1.5 to 2.0 square meters
//A Between 0.5 and 1.0 square meters
//B From 2.0 to 2.5 square meters
//C Between 3.0 and 3.5 square meters
//D From 1.5 to 2.0 square meters

//#Q What is the average number of sweat glands in the skin per square inch (6.5cm²)?
//^ 650
//A 1100
//B 650
//C 3000
//D 125

//#Q The skin has its own ecosystems of microorganisms, including yeasts and bacteria, which cannot be removed by washing.
//^ True
//A True
//B False

//#Q What is the natural oil produced by human skin called?
//^ Sebum
//A All of these
//B Sebum
//C Sebatiol
//D Cutaneous oil

//#Q How many types of skin are there depending on skins reaction to UV-radiation?
//^ 6 types
//A 4 types
//B 3 types
//C 5 types
//D 6 types

//#Q Skin consists of how many basic layers?
//^ 3
//A 2
//B 5
//C 3
//D 4

//#Q The epidermis is very rich in blood vessels.
//^ False
//A False
//B True

//#Q Mammary glands are considered to be modified sweat glands.
//^ True
//A False
//B True

//#Q What is the name of the chemical compound that stands behind vitamin C?
//^ L - ascorbic acid
//A L - carnitine
//B Citric acid
//C L - ascorbic acid
//D Acetylsalicylic acid

//#Q Most animals and plants are not able to synthesize vitamin C by themselves.
//^ False
//A False
//B True

//#Q Which of these animals has lost the ability to synthesize vitamin C?
//^ All of these
//A Guinea pigs
//B Most bat species
//C All of these
//D All simians

//#Q What is the quantity of vitamin C that a healthy adult goat produces daily?
//^ 13 grams or more
//A 0, 5 grams at least
//B 13 grams or more
//C 3 grams at least
//D About 9, 5 grams

//#Q The deficiency of vitamin C leads to this disease, which can be lethal.
//^ Scurvy
//A Influenza
//B Meningitis
//C Scurvy
//D Cancer

//#Q Vitamin C is necessary for the production of this protein in the human body.
//^ Collagen
//A Cytokine
//B Collagen
//C Fibrin
//D Opsin

//#Q Vitamin C is a powerful antioxidant and pro-oxidant.
//^ True
//A False
//B True

//#Q Vitamin C is said to be beneficial for the treatment of various diseases and medical conditions. Which of the following is one of them?
//^ All of these
//A All of these
//B Cancer
//C AIDS
//D Autism

//#Q What fruit is believed to be the highest in vitamin C content?
//^ Kakadu plum
//A Kakadu plum
//B Lemon
//C Kiwi
//D Rose hip

//#Q The highest concentration of vitamin C in animals bodies is in their liver. Which of these animals has the largest quantity of vitamin C in its liver?
//^ Calf
//A Pig
//B Chicken
//C None of these
//D Calf

//#Q Which of the B vitamins is known as thiamine?
//^ Vitamin B1
//A Vitamin B1
//B Vitamin B3
//C Vitamin B2
//D Vitamin B12

//#Q In what substance is vitamin K soluble?
//^ Fat
//A Water
//B All of these
//C Protein
//D Fat

//#Q What chemical compound is commonly known as vitamin C?
//^ Ascorbic acid
//A Acetylsalicylic acid
//B Ascorbic acid
//C Aminobenzoic acid
//D Hyaluronic acid

//#Q The deficiency of what vitamin causes Rickets and Osteomalacia in humans?
//^ Vitamin D
//A Vitamin B5
//B Vitamin D
//C Vitamin A
//D Vitamin E

//#Q Which of these diseases is associated with vitamin A deficiency?
//^ Night - blindness
//A Night - blindness
//B Pellagra
//C Scurvy
//D All of these

//#Q Which of the B vitamins is also known as folic acid?
//^ Vitamin B9
//A Vitamin B1
//B Vitamin B12
//C Vitamin B5
//D Vitamin B9

//#Q Vitamin E is naturally soluble in this substance.
//^ Fat
//A All of these
//B Lactase
//C Fat
//D Water

//#Q What food is a rich source of vitamin B6?
//^ All of these
//A All of these
//B Meat
//C Vegetables
//D Nuts

//#Q An overdose of what vitamin can cause diarrhea, nausea and heartburn?
//^ Vitamin B5
//A Vitamin A
//B Vitamin B5
//C Vitamin K
//D Vitamin C

//#Q Niacin is the name of this B vitamin.
//^ Vitamin B3
//A Vitamin B12
//B Vitamin B5
//C Vitamin B9
//D Vitamin B3

//#Q In the US, to qualify for Medicare benefits, you must meet be which of the following?
//^ Be over 65 OR be disabled OR getting dialysis OR have ALS(Lou Gehrigs Disease)
//A Be over 65 OR be disabled OR getting dialysis OR have ALS(Lou Gehrigs Disease)
//B Be over 70 OR have MS(multiple sclerosis) OR be blind OR have ALS(Lou Gehrigs Disease)
//C Be over 60 OR be disabled OR getting dialysis OR have ALS(Lou Gehrigs Disease)
//D Be over 60 OR have MS(multiple sclerosis) OR be blind OR have ALS(Lou Gehrigs Disease)

//#Q In the US, Medicare Part B is primarily coverage for which of the following?
//^ Non - hospital services
//A Hospital admissions
//B Medications
//C Non - hospital services
//D Dialysis

//#Q Who administers the US health program Medicaid, and who funds Medicaid?
//^ Medicaid is administered by each state government, and is jointly funded by the federal government and the state governments.
//A Medicaid is administered by the Centers for Medicare and Medicaid Services(CMS), and funded by the state governments.
//B Medicaid is administered by each state government, and is funded by the federal government.
//C Medicaid is administered by the Centers for Medicare and Medicaid Services(CMS), and jointly funded by the Federal Government and the state governments.
//D Medicaid is administered by each state government, and is jointly funded by the federal government and the state governments.

//#Q Which of the following 4 people is most likely to be eligible for the US health program Medicaid?
//^ A 25 - year - old single woman who is pregnant and unemployed
//A A 25 - year - old single man who is unemployed
//B A 25 - year - old self - employed woman with 5 children
//C A 25 - year - old self - employed married man with 5 children
//D A 25 - year - old single woman who is pregnant and unemployed

//#Q The State Childrens Health Insurance Program (SCHIP) was primarily designed to do what?
//^ Provide health insurance to children who do not qualify for Medicaid
//A Provide additional health insurance to children who are receiving Medicaid
//B Provide health insurance to disabled children
//C Provide health insurance to older children
//D Provide health insurance to children who do not qualify for Medicaid

//#Q The Centers for Medicare and Medicaid Services (CMS) used to be known as what?
//^ The Health Care Financing Administration(HCFA)
//A Medicare
//B The Centers for Disease Control (CDC)
//C The Health Care Financing Administration(HCFA)
//D The Department of Health and Human Services(DHHS)

//#Q With regard to Medicare Part D, what is the donut hole?
//^ The donut hole is the coverage gap during which the patient is responsible for all drug costs.
//A The donut hole is the coverage gap for patients who eat donuts.
//B The donut hole is the coverage gap for patients between Medicaid age and Medicare age.
//C The donut hole is the coverage gap during which the patient is responsible for all drug costs.
//D The donut hole is the loss of health insurance to patients whose diets are unhealthy.

//#Q In the US, all Medicare Part A participants pay a premium for the service.
//^ False
//A False
//B True

//#Q In the US, all Medicare Part B participants pay a monthly premium for the service.
//^ True
//A False
//B True

//#Q A US citizen can qualify for both Medicare and Medicaid at the same time.
//^ True
//A False
//B True

//#Q If the planet Mars, with a diameter of 6772 kilometers, is at a distance of 80,000,000 kilometers, what is its angular diameter in arc seconds?
//^ 17.46
//A 16.27
//B 14.64
//C 18.92
//D 17.46

//#Q If an orbiting body is revolving around its parent body in a perfectly circular path at a distance of 1,000,000,000 kilometers with an orbital velocity of 15 km/s, how long is its year in Earth years?
//^ 13.28
//A 11.39
//B 27.42
//C 13.28
//D 7.23

//#Q A body is orbiting another body in an elliptical orbit with a closest approach of 1000 kilometers and a farthest approach of 2000 kilometers. At its farthest approach, a triangle formed by connecting its orbital positions one day apart to its parent body covers an area of 100,000 square kilometers. How large of an area does this body sweep out in the period of one day at its closest approach?
//^ 100, 000 square kilometers
//A 79, 884 square kilometers
//B 100, 000 square kilometers
//C 50, 000 square kilometers
//D 200, 000 square kilometers

//#Q If a mass of 1 kilogram has a gravitational force of approximately 6.8x10^-12 at 1 meter (Earth = 1), what would the surface gravitational force be on a body with a mass of 5x10^18 kilograms and a diameter of 100 kilometers?
//^ 0.0136
//A 0.00863
//B 0.0034
//C 0.129
//D 0.0136

//#Q What type of structure do tulips grow out from?
//^ Bulb
//A Rhizome
//B Root
//C Bulb
//D Tuber

//#Q What does the name of the iris flower literally mean in Greek?
//^ Rainbow
//A Flower
//B Rainbow
//C Sky
//D Eye

//#Q Narcissus plants, commonly called daffodils, contain the toxin lycorine in which structure?
//^ Bulb and leaves
//A Blossom
//B Stamen
//C Bulb and leaves
//D All of these

//#Q What does the poppy flower symbolize in many cultures as well as in art?
//^ Death
//A Death
//B Sleep
//C Oblivion
//D All of these

//#Q Viola plants, commonly referred to as violets, pansies or heartsease, are used as food and in medicine because they are rich in these nutrients.
//^ Vitamins A and C
//A All of these
//B Vitamins A and C
//C Iron and magnesium
//D Lycopene and tannin

//#Q The carnation is the national flower of this European country.
//^ Spain
//A France
//B Scotland
//C Spain
//D Germany

//#Q To which continent are common daisies native?
//^ Europe
//A All of these
//B North America
//C Asia
//D Europe

//#Q According to Greek mythology, Zeus saved one of Asclepius students from his wrath by turning him into this flower.
//^ Peony
//A Rose
//B Peony
//C Forget - me - not
//D Dahlia

//#Q The Lilium plants, commonly known as lilies, are extremely toxic to this animal.
//^ Cat
//A Dog
//B All of these
//C Sheep
//D Cat
