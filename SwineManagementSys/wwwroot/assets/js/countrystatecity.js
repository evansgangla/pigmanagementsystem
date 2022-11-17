var countryStateInfo = {
    "Nigeria": {
        "Abuja": {
            "Federal Capital Territory": ["Abaji",
                "Abuja Municipal",
                "Bwari",
                "Gwagwalada",
                "Kuje",
                "Kwali"]
        },
        "Abia": {
            "Abia Central": ["Ikwuano", "Isiala - Ngwa North", "Isiala - Ngwa South", "Umuahia North", "Umuahia South"],
            "Abia North": ["Arochukwu", "Bende", "Isiukwuato", "Ohafia", "Umu-Nneochi"],
            "Abia South": ["Aba North", "Aba South", "Obi Ngwa", "Osisioma Ngwa", "Ugwunagbo", "Ukwa East", "Ukwa West"]
        },
        "Adamawa": {
            "Adamawa Central": ["Fufore",
                "Girei",
                "Gombi",
                "Hong",
                "Song",
                "Yola North",
                "Yola South"],
            "Adamawa North": ["Madagali",
                "Maiha",
                "Michika",
                "Mubi North",
                "Mubi South"],
            "Adamawa South": ["Demsa",
                "Ganye",
                "Guyuk",
                "Jada",
                "Lamurde",
                "Mayo-Belwa",
                "Numan",
                "Shelleng",
                "Toungo"]
        },
        "Akwa Ibom": {
            "Akwa Ibom North East	": ["Etinan",
                "Ibesikpo Asutan",
                "Ibiono Ibom",
                "Itu",
                "Nsit Atai",
                "Nsit Ibom",
                "Nsit Ubium",
                "Uruan",
                "Uyo"],
            "Akwa Ibom North West	": ["Abak",
                "Essien Udim",
                "Etim Ekpo",
                "Ika",
                "Ikono",
                "Ikot Ekpene",
                "Ini",
                "Obot Akara",
                "Oruk Anam",
                "Ukanafun"],
            "Akwa Ibom South	": ["Eastern Obolo",
                "Eket",
                "Esit - Eket",
                "Ibeno",
                "Ikot Abasi",
                "Mbo",
                "Mkpat Enin",
                "Okobo",
                "Onna",
                "Oron",
                "Udung Uko",
                "Urue-Offong/Oruko"]
        },
        "Anambra": {
            "Anambra Central": ["Anaocha",
                "Awka North",
                "Awka South",
                "Dunukofia",
                "Idemili North",
                "Idemili South",
                "Njikoka"],
            "Anambra North": ["Anambra East",
                "Anambra West",
                "Ayamelum",
                "Ogbaru",
                "Onitsha North",
                "Onitsha South",
                "Oyi"],
            "Anambra South": ["Aguata",
                "Ekwusigo",
                "Ihiala",
                "Nnewi North",
                "Nnewi South",
                "Orumba North",
                "Orumba South"]

        },
        "Bauchi": {
            "Bauchi Central	": ["Damban",
                "Darazo",
                "Ganjuwa",
                "Misau",
                "Ningi",
                "Warji"],
            "Bauchi North": ["Gamawa",
                "Giade",
                "Itas/Gadau",
                "Jamaare",
                "Katagum",
                "Shira",
                "Zaki"],
            "Bauchi South": ["Alkaleri",
                "Bauchi",
                "Bogoro",
                "Dass",
                "Kirfi",
                "Tafawa-Balewa",
                "Toro"]
        },
        "Bayelsa": {
            "Bayelsa Central	": ["Kolokuma/Opokuma",
                "Southern Ijaw",
                "Yenegoa"],
            "Bayelsa East": ["Brass",
                "Nembe",
                "Ogbia"],
            "Bayelsa West": ["Ekeremor",
                "Sagbama"]
        },
        "Benue": {
            "Benue North East": ["Katsina-Ala",
                "Konshisha",
                "Kwande",
                "Logo",
                "Ukum",
                "Ushongo",
                "Vandeikya"],
            "Benue North West": ["Buruku",
                "Gboko",
                "Guma",
                "Gwer East",
                "Gwer West",
                "Makurdi",
                "Tarka"],
            "Benue South": ["Ado",
                "Agatu",
                "Apa",
                "Obi",
                "Ogbadibo",
                "Ohimini",
                "Oju",
                "Okpokwu",
                "Oturkpo"]
        },
        "Borno": {
            "	Borno Central	": ["Bama",
                "Dikwa",
                "Jere",
                "Kaga",
                "Kala/Balge",
                "Konduga",
                "Mafa",
                "Maiduguri",
                "Ngala"],
            "	Borno North	": ["Abadam",
                "Gubio",
                "Guzamala",
                "Kukawa",
                "Magumeri",
                "Marte",
                "Mobbar",
                "Monguno",
                "Nganzai"],
            "	Borno South	": ["Askira/Uba",
                "Bayo",
                "Biu",
                "Chibok",
                "Damboa",
                "Gwoza",
                "Hawul",
                "Kwaya Kusar",
                "Shani"]
        },
        "Cross River": {
            "	Cross River Central	": ["Abi",
                "Boki",
                "Etung",
                "Ikom",
                "Obubra",
                "Yakurr"],
            "	Cross River North	": ["Bekwara",
                "Biase",
                "Obanliku",
                "Obudu",
                "Ogoja",
                "Yala"],
            "	Cross River South	": ["Akamkpa",
                "Akpabuyo",
                "Bakassi",
                "Calabar-Municipal",
                "Calabar South",
                "Odukpani"]
        },
        "Delta": {
            "Delta Central": ["Ethiope East",
                "Ethiope West",
                "Okpe",
                "Sapele",
                "Udu",
                "Ughelli North",
                "Ughelli South",
                "Uvwie"],
            "Sapele": ["Aniocha North",
                "Delta North",
                "Ika North East",
                "Ika South",
                "Ndokwa East",
                "Ndokwa West",
                "Oshimili North",
                "Oshimili South",
                "Ukwuani"],
            "Delta South": ["Bomadi",
                "Burutu",
                "Isoko North",
                "Isoko South",
                "Patani",
                "Warri North",
                "Warri South",
                "Warri South West"]
        },
        "Ebonyi": {
            "	Ebonyi North	": ["Abakaliki",
                "Ebonyi",
                "Izzi",
                "Ohaukwu"],
            "	Ebonyi South	": ["Afikpo North",
                "Afikpo South",
                "Ivo",
                "Ohaozara",
                "Onicha"],
            "	Ebonyi Central	": ["Ezza North",
                "Ezza South",
                "Ikwo",
                "Ishielu"]
        },
        "Edo": {
            "	Edo Central	": ["Esan Central",
                "Esan North East",
                "Esan South East",
                "Esan West",
                "Igueben"],
            "	Edo North	": ["Akoko-Edo",
                "Etsako Central",
                "Etsako East",
                "Etsako West",
                "Owan East",
                "Owan West"],
            "	Edo South	": ["Egor",
                "Ikpoba-Okha",
                "Oredo",
                "Orhionmwon",
                "Ovia North East",
                "Ovia South West",
                "Uhunmwonde"]

        },
        "Ekiti": {
            "	Ekiti Central": ["Ado Ekiti",
                "Efon",
                "Ekiti West",
                "Ijero",
                "Irepodun/Ifelodun"],
            "	Ekiti North	": ["Ido-Osi",
                "Ikole",
                "Ilejemeji",
                "Moba",
                "Oye"],
            "	Ekiti South": ["Aiyekire (Gbonyin)",
                "Ekiti East",
                "Ekiti South West",
                "Emure",
                "Ikere",
                "Ise/Orun"]
        },
        "Enugu": {
            "	Enugu East	": ["Enugu East",
                "Enugu North",
                "Enugu South",
                "Isi-Uzo",
                "Nkanu East",
                "Nkanu West"],
            "	Enugu North	": ["Igbo-Etiti",
                "Igbo-Eze North",
                "Igbo-Eze South",
                "Nsukka",
                "Udenu"],
            "	Enugu West	": ["Uzo-Uwani",
                "Aninri",
                "Awgu",
                "Ezeagu",
                "Oji-River",
                "Udi"]
        },
        "Gombe": {
            "Gombe Central": ["Akko",
                "Yamaltu/Deba"],
            "Gombe North": ["Dukku",
                "Funakaye",
                "Gombe",
                "Kwami",
                "Nafada"],
            "Gombe South": ["Balanga",
                "Billiri",
                "Kaltungo",
                "Shomgom"]
        },
        "Imo": {
            "	Imo East	": ["Aboh-Mbaise",
                "Ahiazu-Mbaise",
                "Ezinihitte",
                "Ikeduru",
                "Mbaitoli",
                "Ngor-Okpala",
                "Owerri-Municipal",
                "Owerri North",
                "Owerri West"],
            "	Imo North	": ["Ehime-Mbano",
                "Ihitte/Uboma",
                "Isiala Mbano",
                "Obowo",
                "Okigwe",
                "Unuimo"],
            "	Imo West	": ["Ideato North",
                "Ideato South",
                "Isu",
                "Njaba",
                "Nkwerre",
                "Nwangele",
                "Oguta",
                "Ohaji/Egbema",
                "Orlu",
                "Orsu",
                "Oru East",
                "Oru West"]
        },
        "Jigawa": {
            "	Jigawa North-East	": ["Auyo",
                "Biriniwa",
                "Guri",
                "Hadejia",
                "Kafin Hausa",
                "Kaugama",
                "Kiri Kasamma",
                "Malam Madori"],
            "	Jigawa North-West	": ["Babura",
                "Gagarawa",
                "Garki",
                "Gumel",
                "Gwiwa",
                "Kazaure",
                "Maigatari",
                "Ringim",
                "Roni",
                "Sule-Tankarkar",
                "Taura",
                "Yankwashi"],
            "	Jigawa South-West	": ["Birni Kudu",
                "Buji",
                "Dutse",
                "Gwaram",
                "Jahun",
                "Kiyawa",
                "Miga"]
        },
        "Kaduna": {
            "	Kaduna Central	": ["Birnin-Gwari",
                "Chikun",
                "Giwa",
                "Igabi",
                "Kaduna North",
                "Kaduna South",
                "Kajuru"],
            "	Kaduna North	": ["Ikara",
                "Kubau",
                "Kudan",
                "Lere",
                "Markafi",
                "Sabon-Gari",
                "Soba",
                "Zaria"],
            "	Kaduna South	": ["Jaba",
                "Jemaa",
                "Kachia",
                "Kagarko",
                "Kaura",
                "Kauru",
                "Sanga",
                "Zango-Kataf"]
        },
        "Kano": {
            "	Kano Central	": ["Dala",
                "Dawakin Kudu",
                "Fagge",
                "Garum Mallam",
                "Gezawa",
                "Gwale",
                "Kano Municipal",
                "Kumbotso",
                "Kura",
                "Madobi",
                "Minjibir",
                "Nasarawa",
                "Tarauni",
                "Ungogo",
                "Warawa"],
            "	Kano North	": ["Bagwai",
                "Bichi",
                "Dambatta",
                "Dawakin Tofa",
                "Gabasawa",
                "Gwarzo",
                "Kabo",
                "Karaye",
                "Kunchi",
                "Makoda",
                "Rimin Gado",
                "Shanono",
                "Tofa",
                "Tsanyawa"],
            "	Kano South	": ["Ajingi",
                "Albasu",
                "Bebeji",
                "Bunkure",
                "Doguwa",
                "Garko",
                "Gaya",
                "Kibiya",
                "Kiru",
                "Rano",
                "Rogo",
                "Sumaila",
                "Takai",
                "Tudun Wada",
                "Wudil"]
        },
        "Katsina": {
            "	Katsina Central	": ["Batagarawa", "Batsari", "Charanchi", "Dan Musa", "Dutsin-Ma", "Jibia", "Kaita", "Katsina", "Kurfi", "Rimi", "Safana"],
            "   Katsina North   ": ["Baure", "Bindawa", "Daura", "Dutsi", "Ingawa", "Kankia", "Kusada", "Maiadua", "Mani", "Mashi", "Sandamu", "Zango"],
            "   Katsina South   ": ["Bakori", "Dandume", "Danja", "Faskari", "Funtua", "Kafur", "Kankara", "Malumfashi", "Matazu", "Musawa", "Sabuwa"]
        },
        "Kebbi": {
            "	Kebbi Central	": ["Aleiro", "Birnin Kebbi", "Bunza", "Gwandu", "Kalgo", "Koko/Besse", "Maiyama"],
            "   Kebbi North     ": ["Arewa-Dandi", "Argungu", "Augie", "Bagudo", "Dandi", "Jega", "Suru"],
            "   Kebbi South     ": ["Fakai", "Ngaski", "Sakaba", "Shanga", "Wasagu/Danko", "Yauri", "Zuru"]
        },
        "Kogi": {
            "   Kogi Central  ": ["Adavi", "Ajaokuta", "Ogori/Magongo", "Okehi", "Okene"],
            "   Kogi East  ": ["Ankpa", "Bassa", "Dekina", "Ibaji", "Idah", "Igalamela-Odolu", "Ofu", "Olamabolo", "Omala"],
            "   Kogi West  ": ["Ijumu", "Kabba/Bunu", "Kogi", "Lokoja", "Mopa-Muro", "Yagba East", "Yagba West"]
        },
        "Kwara": {
            "   Kwara Central  ": ["Asa", "Ilorin East", "Ilorin South", "Ilorin West", "Offa"],
            "   Kwara North   ": ["Baruten", "Edu", "Kaiama", "Moro", "Pategi"],
            "   Kwara South   ": ["Ekiti", "Ifelodun", "Irepodun", "Isin", "Oke-Ero", "Oyun"]
        },
        "Lagos": {
            "	Lagos Central	": ["Apapa", "Eti-Osa", "Lagos Island", "Lagos Mainland", "Surulere"],
            "   Lagos East   ": ["Epe", "Ibeju/Lekki", "Ikorodu", "Kosofe", "Shomolu"],
            "   Lagos West   ": ["Agege", "Ajeromi-Ifelodun", "Alimosho", "Amuwo-Odofin", "Badagry", "Ifako-Ijaye", "Ikeja", "Mushin", "Ojo", "Oshodi-Isolo"]
        },
        "Nassarawa": {
            "   Nassarawa North  ": ["Akwanga", "Nasarawa-Eggon", "Wamba"],
            "   Nassarawa South  ": ["Awe", "Doma", "Keana", "Lafia", "Obi"],
            "   Nassarawa West   ": ["Karu", "Keffi", "Kokona", "Nasarawa", "Toto"]
        },
        "Niger": {
            "   Niger East  ": ["Bosso", "Chanchaga", "Gurara", "Muya", "Paikoro", "Rafi", "Shiroro", "Suleja", "Tafa"],
            "   Niger North  ": ["Agwara", "Borgu", "Kontagora", "Magama", "Mariga", "Mashegu", "Rijau", "Wushishi"],
            "   Niger South  ": ["Agaie", "Bida", "Edati", "Gbako", "Katcha", "Lapai", "Lavun", "Mokwa"]
        },
        "Ogun": {
            "   Ogun Central  ": ["Abeokuta North", "Abeokuta South", "Ewekoro", "Ifo", "Obafemi-Owode", "Odeda"],
            "   Ogun East  ": ["Ijebu East", "Ijebu North", "Ijebu North East", "Ijebu Ode", "Ikenne", "Odogbolu", "Ogun waterside", "Remo North", "Shagamu"],
            "   Ogun West  ": ["Ado-Odo/Ota", "Egbado North", "Egbado South", "Imeko-Afon", "Ipokia"]
        },
        "Ondo": {
            "   Ondo Central  ": ["Akure North", "Akure South", "Idanre", "Ifedore", "Ondo East", "Ondo West"],
            "   Ondo North   ": ["Akoko North East", "Akoko North West", "Akoko South East", "Akoko South West", "Ose", "Owo"],
            "   Ondo South  ": ["Ese-Odo", "Ilaje", "Ile-Oluji-Okeigbo", "Irele", "Odigbo", "Okitipupa"]
        },
        "Osun": {
            "   Osun Central  ": ["Boluwaduro", "Boripe", "Ifedayo", "Ifelodun", "Ila", "Irepodun", "Odo-Otin", "Olorunda", "Orolu", "Osogbo"],
            "   Osun East   ": ["Atakumosa East", "Atakumosa West", "Ife Central", "Ife East", "Ife North", "Ife South", "Ilesha East", "Ilesha West", "Obokun", "Oriade"],
            "   Osun West  ": ["Aiyedade", "Aiyedire", "Ede North", "Ede South", "Egbedore", "Ejigbo", "Irewole", "Isokan", "Iwo", "Ola-oluwa"]
        },
        "Oyo": {
            "   Oyo Central  ": ["Afijio", "Akinyele", "Atiba", "Egbeda", "Lagelu", "Ogo Oluwa", "Oluyole", "Ona-Ara", "Oyo East", "Oyo West", "Surulere"],
            "   Oyo North  ": ["Atigbo", "Irepo", "Iseyin", "Itesiwaju", "Iwajowa", "Kajola", "Ogbomosho North", "Ogbomosho South", "Olorunsogo", "Orelope", "Ori Ire", "Saki East", "Saki West"],
            "   Oyo South  ": ["Ibadan North", "Ibadan North East", "Ibadan North West", "Ibadan South East", "Ibadan South West", "Ibarapa Central", "Ibarapa East", "Ibarapa North", "Ido"]
        },
        "Rivers": {
            "   Rivers East  ": ["Emohua", "Etche", "Ikwerre", "Obia/Akpor", "Ogu/Bolo", "Okrika", "Omumma", "Port-Harcourt"],
            "   Rivers South East  ": ["Andoni", "Eleme", "Gokana", "Khana", "Opobo/Nkoro", "Oyigbo", "Tai"],
            "   Rivers West  ": ["Abua/Odual", "Ahoada East", "Ahoada West", "Akuku Toru", "Asari-Toru", "Bonny", "Degema", "Ogba/Egbema/Ndoni"]
        },
        "Sokoto": {
            "	Sokoto East	": ["Gada", "Goronyo", "Gwadabawa", "Illela", "Isa", "Rabah", "Sabon Birni", "Wurno"],
            "   Sokoto North ": ["Binji", "Gudu", "Kware", "Silame", "Sokoto North", "Sokoto South", "Tangaza", "Wamako"],
            "   Sokoto South  ": ["Bodinga", "Dange-Shuni", "Kebbe", "Shagari", "Tambuwal", "Tureta", "Yabo"]
        },
        "Taraba": {
            "   Taraba Central  ": ["Bali", "Gashaka", "Gassol", "Kurmi", "Sardauna"],
            "   Taraba North   ": ["Ardo-Kola", "Jalingo", "Karim-Lamido", "Lau", "Yorro", "Zing"],
            "   Taraba South  ": ["Donga", "Ibi", "Takum", "Ussa", "Wukari"]
        },
        "Yobe": {
            "   Yobe East  ": ["Bursari", "Geidam", "Gujba", "Gulani", "Tarmua", "Yunusari"],
            "   Yobe North  ": ["Bade", "Jakusko", "Karasuwa", "Machina", "Nguru", "Yusufari"],
            "   Yobe South  ": ["Damaturu", "Fika", "Fune", "Nangere", "Potiskum"]
        },
        "Zamfara": {
            "   Zamfara Central  ": ["Bungudu", "Gusau", "Maru", "Tsafe"],
            "   Zamfara North   ": ["Birnin Magaji", "Kaura Namoda", "Shinkafi", "Talata Mafara", "Zurmi"],
            "   Zamfara West  ": ["Anka", "Bakura", "Bukkuyum", "Gummi", "Maradun"]
        },
    },
    "Kenya": {
        "Baringo": {
            "Tiaty": ["Tirioko",
                "Kolowa",
                "Ribkwo",
                "Silale",
                "Loiyamorok",
                "Tangulbei/Korossi",
                "Churo/Amaya"
            ],
            "Mogotio": ["Mogotio", "Emining", "Kisanana"],
            "Koibatek": ["Lembus", "Lembus Kwen", "Ravine", "Mumberes/Maji Mazuri", "Lembus/Perkerra", "Koibatek"],
            "Baringo Central": ["Sacho", "Kabarnet", "Tenges", "Ewalel/Chapchap", "Kapropita"],
            "Marigat": ["Mukutani", "Marigat", "Iichamus", "Mochongoi"],
            "Baringo North": ["Barwessa", "Kabartonjo", "Saimoi/Kipsaraman", "Saimo/Soi", "Bartabwa"]
        },
        "Bomet": {
            "Konoin": ["Kimulot", "Mogogosiek", "Boito", "Embomos", "Chepchabas"],
            "Sotik": ["Ndanai/Abosi", "Chemagel", "Kipsonoi", "Kapletundo", "Rongena/Manaret"],
            "Chepalungu": ["Kong'Asis", "Nyangores", "Sigor", "Chebunyo", "Siongiroi"],
            "Bomet East": ["Merigi", "Kembu", "Longisa", "Kipreres", "Chemaner"],
            "Bomet Central": ["Silibwet Township", "Ndaraweta", "Singorwet", "Chesoen", "Mutarakwa"]
        },
        "Bungoma": {
            "Cheptais": ["Cheptais",
                "Kakateny", "Chesikaki", "Chepyuk"],
            "Mt Elgon": ["Kaptama", "Elgon"],
            "Sirisia": ["Malakisi/South Kulisiru ", "Lwandanyi", "Namwela"],
            "Kabuchai": ["West Nalondo", "Mukuyuni", "Kabuchai/Chwele", "Bwake/Luuya"],
            "Bumula": ["Kabula", "Kimaeti", "Siboti", "South Bukusu", "Bumula", "Khasoko", "West Bukusu"],
            "Kanduyi": ["Bukembe West", "Bukembe East", "Township", "Khalaba", "Musikoma", "East Sang'Alo", "Marakaru/Tuuti", "West Sang'Alo"],
            "Webuye West": ["Bokoli", "Misikhu", "Sitikho", "Matulo"],
            "Kimilili": ["Kibingei", "Kimilili", "Maeni", "Kamukuywa"],
            "Tongaren": ["Mbakalo", "Naitiri/Kabuyefwe", "Milima", "Ndalu/ Tabani", "Tongaren", "Soysambu/ Mitua"],
            "Webuye  East": ["Mihuu", "Ndivisi", "Maraka"]
        },
        "Busia": {
            "Nambale": ["Nambale Township",
                "Bukhayo North Walatsi",
                "Bukhayo East",
                "Bukhayo Central"],
            "Matayos": ["Bukhayo West",
                "Matayos South",
                "Busibwabo",
                "Burumba", "Mayenje"],
            "Teso North": ["Malaba Central",
                "Malaba North",
                "Ang'Urai South",
                "Ang'Urai North",
                "Ang'Urai East",
                "Malaba South"],
            "Teso South": ["Ang'Orom", "Chakol South", "Chakol North", "Amukura West", "Amukura East", "Amukura Central"],
            "Butula": ["Marachi West", "Marachi East", "Marachi North", "Elugulu", "Kingandole", "Marachi Central"],
            "Samia": ["Namboboto Nambuku", "Nangina", "Ageng'A Nanguba", "Bwiri"],
            "Bunyala": ["Bunyala Central", "Bunyala North", "Bunyala West", "Bunyala South"]
        },
        "Elgeyo-Marakwet": {
            "Marakwet East sub-county": ["Kapyego",
                "Sambirir"],
            "Keiyo South": ["Soy North",
                "Soy South",
                "Kabiemit"],
            "Marakwet East sub-county": ["Endo",
                "Embobut/Embulot"],
            "Marakwet West": ["Lelan", "Sengwer", "Cherangany", "Moiben Kuserwo", "Kapsowar", "Arror"],
            "Keiyo North": ["Kamariny", "Emsoo", "Tambach", "Kapchemutwa"],
            "Keiyo South": ["Kaptarakwa", "Chepkorio", "Metkei"]
        },
        "Embu": {
            "Mbeere North": ["Muminji",
                "Evurore"],
            "Manyatta": ["Ruguru-Ngandori",
                "Kithimu",
                "Nginda",
                "Mbeti North",
                "Kirimari",
                "Gaturi South",
                "Gaturi North"],
            "Runyenjes": ["Kaagari South",
                "Central",
                "Kaagari North",
                "Kyeni North",
                "Kyeni South"],
            "Mbeere South": ["Mwea", "Makima", "Mbeti South", "Mavuria", "Kiambere"],
            "Mbeere North": ["Nthawa"]
        },
        "Garissa": {
            "Hulugho": ["Sangailu"],
            "Ijara": ["Masalani"]
        },
        "Homa Bay": {
            "Kasipul": ["West Kasipul",
                "South Kasipul",
                "Central Kasipul",
                "East Kamagak",
                "West Kamagak"],
            "Kabondo Kasipul": ["Kabondo East",
                "Kabondo West",
                "Kokwanyo/Kakelo",
                "Kojwach"],
            "Karachuonyo": ["West Karachuonyo",
                "North Karachuonyo",
                "Central",
                "Kanyaluo"],
            "Rangwe": ["Kagan", "Kochia"],
            "Homa Bay Town": ["Homa Bay Central", "Homa Bay Arujo", "Homa Bay East", "Homa Bay West"],
            "Ndhiwa": ["Kwabwai", "Kanyadoto", "Kanyikela", "Kabouch North", "Kabuoch South/Pala", "Kanyamwa Kosewe", "Kanyamwa Kologi"],
            "Mbita": ["Mfangano Island", "Rusinga Island", "Kasgunga", "Gembe", "Lambwe"],
            "Karachuonyo": ["Kibiri", "Wang'Chieng", "Kendu Bay Town"],
            "Rangwe": ["West Gem", "East Gem",],
            "Suba": ["Gwassi South", "Gwassi North", "Kaksingiri West", "Ruma-Kaksingiri East"]
        },
        "Isiolo": {
            "Isiolo": ["Wabera", "Bula Pesa", "Ngare Mara", "Burat", "Oldonyiro"],
            "Merti": ["Chari"],
            "Garbatulla": ["Kinna"]
        },
        "Kajiado": {
            "Kajiado North": ["Olkeri",
                "Ongata Rongai",
                "Nkaimurunya",
                "Oloolua",
                "Ngong"],
            "Kajiado Central": ["Purko",
                "Ildamat",
                "Dalalekutuk",
                "Matapato North",
                "Matapato South"],
            "Kajiado East": ["Kaputiei North",
                "Kitengela",
                "Oloosirkon/Sholinke",
                "Kenyawa-Poka",
                "Imaroro"],
            "Kajiado West": ["Keekonyokie"],
            "Loitokitok": ["Kimana", "Entonet/Lenkism", "Imbrikani/Eselelnkei", "Kuku", "Rombo"],
            "Kajiado West": ["Iloodokilani", "Magadi", "Ewuaso Oonkidong'I", "Mosiro"]
        },
        "Kakamega": {
            "Lugari": ["Mautuma",
                "Lugari",
                "Lumakanda",
                "Chekalini",
                "Chevaywa",
                "Lwandeti"],
            "Likuyani": ["Likuyani",
                "Sango",
                "Kongoni",
                "Nzoia",
                "Sinoko"],
            "Malava": ["West Kabras",
                "Chemuche",
                "East Kabras",
                "Butali Chegulo",
                "Manda-Shivanga",
                "South Kabras"],
            "Lurambi": ["Butsotso East", "Butsotso South", "Butsotso Central", "Sheywe", "Mahiakalo", "Shirere"],
            "Navakholo": ["Ingoste-Matiha", "Shinoyi-Shikomari-Esumeiya", "Bunyala West", "Bunyala East", "Bunyala Central"],
            "Mumias West": ["Mumias Central", "Mumias North", "Etenje", "Musanda"],
            "Mumias East": ["Lusheya Lubinu", "Malaha Isongo Makunga", "East Wanga"],
            "Matungu": ["Koyonzo", "Kholera", "Khalaba", "Mayoni", "Namamali"],
            "Khwisero": ["Kisa North"],
            "Butere": ["Marama West", "Marama Central", "Marenyo-Shianda", "Marama North", "Marama South"],
            "Khwisero": ["Kisa East", "Kisa West", "Kisa Central"],
            "Shinyalu": ["Isukha North", "Murhanda", "Isukha Central", "Isukha South", "Isukha East", "Isukha West"],
            "Ikolomani": ["Idakho South", "Idakho East", "Idakho North", "Idakho Central"]
        },
        "Kericho": {
            "Ainamoi": ["Belgut", "Kapsoit", "Ainamoi", "Kapkugerwet", "Kipchebor", "Kipchimchim", "Kapsaos"],
            "Belgut": ["Chaik", "Cheptororiet/Seretut"],
            "Kipkelion West": ["Chilchila"],
            "Bureti": ["Kisiara", "Tebesonik", "Cheboin", "Chemosot", "Litein", "Cheplanget", "Kapkatet"],
            "Belgut": ["Waldai", "Kabianga"],
            "Sigowet/Soin": ["Sigowet", "Kaplelartet", "Soliat", "Soin"],
            "Kipkelion East": ["Kedowa/Kimugul", "Chepseon", "Tendeno/Sorget"],
            "Kipkelion West": ["Kunyak", "Kamasian", "Kipkelion"],
            "Kipkelion East": ["Londiani"]
        },
        "Kiambu": {
            "Githunguri": ["Githiga",
                "Ikinu",
                "Ngewa",
                "Komothai",
                "Githunguri"],
            "Kiambu Town": ["Ting'Ang'A",
                "Ndumberi",
                "Riabai",
                "Kiambu Township"],
            "Kiambaa": ["Cianda",
                "Karuri",
                "Ndenderu",
                "Muchatha",
                "Kihara"],
            "Kabete": ["Gitaru", "Muguga", "Nyadhuna", "Kabete", "Uthiru"],
            "Lari": ["Kinale", "Nyanduma", "Kamburu", "Lari/Kirenga", "Kijabe"],
            "Gatundu South": ["Kiamwangi", "Kiganjo", "Ndarugu", "Ngenda"],
            "Gatundu North": ["Gituamba", "Githobokoni", "Chania", "Mang'U"],
            "Juja": ["Murera", "Theta", "Juja", "Witeithie", "Kalimoni"],
            "Thika Town": ["Thika Township", "Kamenu", "Hospital", "Gatuanyaga", "Ngoliba"],
            "Ruiru": ["Gitothua", "Gatongora", "Kahawa Wendani", "Biashara", "Kahawa/Sukari", "Kiuu", "Mwiki", "Mwihoko"],
            "Kikuyu": ["Karai", "Nachu", "Sigona", "Kikuyu", "Kinoo"],
            "Limuru": ["Bibirioni", "Limuru Central", "Ndeiya", "Limuru East", "Ngecha Tigoni"]
        },
        "Kilifi": {
            "Kilifi North": ["Mnarani", "Sokoni", "Dabaso", "Watamu", "Kibarani", "Matsangoni", "Tezo"],
            "Kilifi South": ["Junju", "Mwarakaya", "Chasimba", "Mtepeni", "Shimo La Tewa"],
            "Rabai": ["Mwawesa",
                "Ruruma", "Kambe/Ribe", "Rabai/Kisurutini"],
            "Kaloleni": ["Mariakani", "Kayafungo", "Kaloleni", "Mwanamwinga"],
            "Ganze": ["Bamba", "Jaribuni", "Ganze", "Sokoke"],
            "Malindi": ["Jilore", "Kakuyuni", "Shella", "Ganda", "Malindi Town"],
            "Magarini": ["Marafa", "Magarini", "Gongoni", "Adu", "Garashi", "Sabaki"]
        },
        "Kirinyaga": {
            "Kirinyaga North/Mwea West": ["Mutithi",
                "Kangai",
                "Thiba",
                "Wamumu"],
            "Kirinyaga South": ["Nyangati",
                "Murinduko",
                "Gathigiriri",
                "Tebere"],
            "Kirinyaga East": ["Kabare",
                "Baragwi",
                "Njukiine",
                "Ngariama",
                "Karumandi"],
            "Kirinyaga West": ["Mukure", "Kiine", "Kariti"],
            "Kirinyaga Central": ["Mutira", "Kanyekini", "Kerugoya", "Inoi"]
        },
        "Kisii": {
            "Bomachoge Borabu": ["Bombaba Borabu", "Bokimonge", "Magenche", "Boochi Borabu"],
            "Kitutu Chache South": ["Nyakoe",
                "Kisii Central"],
            "Bonchari": ["Bomariba",
                "Bogiakumu",
                "Bomorenda",
                "Riana"],
            "South Mugirango": ["Tabaka", "Boikanga", "Bogetenga", "Borabu Chitago", "Moticho", "Getenga"],
            "Bobasi": ["Masige West", "Masige East", "Basi Central", "Nyacheki", "Bassi Bogetaorio", "Bobasi Chache", "Sameta Mokwerero", "Bobasi Boitangare",],
            "Bomachoge Chache": ["Majoge Basi", "Boochi Tendere", "Bosoti Sengera"],
            "Nyaribari Masaba": ["Ichuni", "Nyamasibi", "Masimba", "Gesusu", "Kiamokama"],
            "Nyaribari Chache": ["Bobaracho", "Kisii Central", "Keumbu", "Kiogoro", "Ibeno"],
            "Kitutu Chache North": ["Sensi", "Monyerero", "Marani", "Kegogi"],
            "Kitutu Chache South": ["Bogusero", "Bogeka", "Nyatieko"]
        },
        "Kisumu": {
            "Kisumu East": ["Manyatta B",
                "Nyalenda A", "Kajulu", "Kolwa East", "Kolwa Central"],
            "Kisumu Central": ["Shauri Moyo Kaloleni"],
            "Kisumu West": ["South West Kisumu"],
            "Kisumu Central": ["Market Milimani", "Kondele", "Nyalenda B", "Railways", "Migosi"],
            "Seme": ["West Seme", "Central Seme", "East Seme", "North Seme"],
            "Nyando": ["East Kano/Wawidhi", "Kabonyo Kanyagwal", "Kobura", "Awasi/Onjiko", "Ahero"],
            "Muhoroni": ["Miwani", "Ombeyi", "Masogo/Nyang'Oma", "Chemelil", "Muhoroni Koru"],
            "Nyakach": ["South West Nyakach", "North Nyakach", "Central Nyakach", "West Nyakach", "South East Nyakach"],
            "Kisumu West": ["Central Kisumu", "North Kisumu", "West Kisumu", "North West Kisumu"]
        },
        "Kitui": {
            "Mwingi North": ["Mumoni",
                "Tseikuru",
                "Tharaka", "Ngomeni", "Kyuso"],
            "Mwingi West": ["Kyome/Thaana",
                "Nguutani",
                "Migwani",
                "Kiomo/Kyethani"],
            "Mwingi Central Sub- County": ["Central",
                "Kivou",
                "Nguni",
                "Nuu",
                "Mui", "Waita"],
            "Kitui Rural": ["Kwavonza/Yatta", "Kanyangi", "Mbitini", "Kisasi"],
            "Kitui Central": ["Miambani", "Township", "Kyangwithya West", "Mulango", "Kyangwithya East"],
            "Kitui East": ["Nzambani", "Zombe/Mwitika", "Chuluni"],
            "Kitui South": ["Ikutha", "Athi", "Ikanga/Kyatune", "Mutomo", "Mutha", "Kanziko"],
            "Kitui West": ["Mutongoni", "Kauwi", "Matinyani", "Kwamutonga/Kithumula", "Voo/Kyamatu", "Endau/Malalani"]
        },
        "Kwale": {
            "Msambweni": ["Ukunda",
                "Kinondo",
                "Ramisi", "Gombato Bongwe"],
            "Lunga Lunga": ["Pongwe Kikoneni",
                "Dzombo",
                "Mwereni",
                "Vanga"],
            "Matuga": ["Tsimba Golini",
                "Waa Ngombeni",
                "Tiwi",
                "Kubo South"],
            "Kinango": ["Ndavaya", "Puma", "Kinango", "Mackinon Road", "Chengoni/Samburu", "Mwavumbo", "Kasemeni"]
        },
        "Laikipia": {
            "Laikipia West": ["Marmanet",
                "Igwamiti",
                "Salama"],
            "Laikipia East": ["Ngobit",
                "Tigithi",
                "Thingithu",
                "Nanyuki"],
            "Laikipia West": ["Ol-Moran",
                "Rumuruti Township", "Githiga"],
            "Laikipia East": ["Umande"],
            "Laikipia North": ["Sosian", "Segera", "Mugogodo West", "Mugogodo East"]
        },
        "Lamu": {
            "Lamu East": ["Faza", "Kiunga", "Basuba"],
            "Lamu West": ["Shella", "Mkomami", "Hindi", "Mkunumbi", "Bahari", "Witu"],
        },
        "Machakos": {
            "Athi River": ["Mathatani", "Syokimau-Mulolongo"],
            "Machakos": ["Kalama", "Mua", "Mutituni", "Township", "Mumbuni North", "Muvuti-Kiima-Kimwe", "Kola"],
            "Mwala": ["Mbiuni", "Makutano-Mwala", "Masii", "Muthetheni", "Wamunyu", "Kibauni"],
            "Masinga": ["Kivaa", "Masinga Central", "Ekalakala", "Muthesya", "Mananja"],
            "Yatta": ["Ndalani", "Matuu", "Kithimani", "Ikombe", "Katangi"],
            "Kangundo": ["Kangundo North", "Kangundo Central", "Kangundo East", "Kangundo West"],
            "Matungulu": ["Tala", "Matungulu North", "Matungulu East", "Matungulu West", "Kyeleni"],
            "Kathiani": ["Mitamboni", "Kathiani Central", "Upper Kaewa-Iveti", "Lower Kaewa-Kaani"],
            "Athi River": ["Athi River", "Kinanie"]
        },
        "Makueni": {
            "Mbooni": ["Tulimani", "Mbooni", "Kithungo/Kitundu", "Kiteta-Kisau", "Waia/Kako", "Kalawa/ Kathulumbi"],
            "Kilome": ["Kasikeu", "Mukaa", "Kiima Kiu/Kalanzoni"],
            "Kaiti": ["Ukia", "Kee", "Kilungu", "Ilima"],
            "Makueni": ["Wote", "Muvau/Kikumini", "Mavindini", "Kitise/Kithuki", "Kathonzweni", "Nzaui/Kilili/Kalamba", "Mbitini"],
            "Kibwezi West": ["Makindu", "Nguumo", "Kikumbulyu North", "Nguu/Masumba", "Emali/Mulala", "Ivingoni/Nzambani"],
            "Kibwezi East": ["Masongaleni", "Mtito Andei", "Thange"]
        },
        "Marsabit": {
            "Laisamis": ["Laisamis"]
        },
        "Meru": {
            "Igembe South": ["Maua", "Kiegoi/Antubochiu", "Athiru Gaiti", "Akachiu", "Kanuni"],
            "Igembe Central": ["Akirang'Ondu", "Athiru Ruujine", "Kiengu/Igembe East", "Njia", "Kangeta"],
            "Igembe North": ["Antuambui", "Ntunene", "Antubetwe Kiongo", "Naathu", "Amwathi"],
            "Tigania West": ["Athwana", "Akithii", "Kianjai", "Nkomo", "Mbeu"],
            "Tigania East": ["Thangatha", "Mikinduri", "Kiguchwa", "Muthara", "Karama"],
            "Imenti North": ["Municipality", "Ntima East", "Ntima West", "Nyaki West"],
            "Buuri": ["Timau", "Kisima", "Kiirua Naari", "Ruiru Rwawera"],
            "Imenti Central": ["Mwangathia", "Abothuguchi Central", "Abothuguchi West", "Kiagu"],
            "Buuri": ["Kibirichia"],
            "Imenti South": ["Mitunguu", "Igoji East", "Igoji West", "Abogeta East", "Abogeta West", "Nkuene"]
        },
        "Migori": {
            "Rongo": ["North Kamagambo", "Central Kamagambo", "South Kamagambo", "East Kamagambo"],
            "Awendo": ["North Sakwa", "South Sakwa", "West Sakwa", "Central Sakwa"],
            "Suna East": ["God Jope", "Suna Central", "Kakrao", "Kwa"],
            "Suna West": ["Wiga", "Waseweta Ii", "Ragana-Oruba", "Wasimbete"],
            "Uriri": ["West Kanyamkago", "North  Kanyamkago", "Central Kanyamkago", "South Kanyamkago", "East Kanyamkago"],
            "Nyatike": ["Kachieng'", "Kanyasa", "North Kadem", "Macalder/Kanyarwanda", "Kaler", "Got Kachola", "Muhuru"],
            "Kuria West": ["Masaba", "Bukira East", "Bukira Central/Ikerege", "Isibania", "Mokerero", "Tagare", "Nyamosense/Komosoko"],
            "Kuria East": ["Ntimaru West", "Gokeharaka/Getambwega", "Ntimaru East", "Nyabasi East", "Nyabasi West"],
        },
        "Mombasa": {
            "Changamwe": ["Kipevu", "Airport", "Changamwe"],
            "Jomvu": ["Jomvu Kuu", "Miritini", "Mikindani"],
            "Kisauni": ["Mjambere", "Magogoni", "Junda", "Bamburi", "Mwakirunge", "Mtopanga", "Shanzu"],
            "Nyali": ["Frere Town", "Kongowea", "Ziwa La Ng'Ombe", "Mkomani", "Kadzandani"],
            "Mvita": ["Tudor", "Makadara -Mji Wa Kale", "Tononoka", "Ganjoni -Shimanzi", "Majengo"],
            "Changamwe": ["Chaani", "Port Reitz"],
            "Likoni": ["Shika Adabu", "Mtongwe", "Bofu"]
        },
        "Muranga": {
            "Mathioya": ["Kiru", "Kamacharia", "Gitugi"],
            "Kiharu": ["Wangu", "Mugoiri", "Mbiri", "Township", "Murarandia", "Gaturi"],
            "Kigumo": ["Kahumbu", "Muthithi", "Kigumo", "Kangari", "Kinyona"],
            "Muranga South": ["Kimorori/Wempa", "Makuyu", "Kambiti", "Kamahuhu", "Ichagaki", "Nginda"],
            "Kandara": ["Ng'Araria", "Muruka", "Kagundu-Ini", "Gaichanjiru", "Ithiru", "Ruchu"],
            "Gatanga": ["Ithanga", "Kakuzi/Mitubiri", "Mugumo-Ini", "Kihumbu-Ini", "Gatanga", "Kariara"],
            "Kangema": ["Kanyenya-Ini", "Muguru", "Rwathia"],
        },
        "Nairobi": {
            "Ruaraka": ["Mathare North", "Lucky Summer", "Korogocho", "Babandogo", "Utalii"],
            "Embakasi South": ["Imara Daima", "Pipeline", "Kwa Njenga", "Kwa Reuben", "Kware"],
            "Westlands": ["Parklands/Highridge", "Karura", "Kangemi", "Mountain View", "Kitisuru"],
            "Dagoretti North": ["Kilimani", "Kileleshwa", "Kawangware", "Kabiro", "Gatina"],
            "Kibra": ["Woodley/Kenyatta Golf Course", "Laini Saba", "Lindi", "Makina", "Sarang'Ombe"],
            "Roysambu": ["Zimmerman", "Roysambu", "Githurai", "Kahawa West", "Kahawa"],
            "Kasarani": ["Mwiki", "Kasarani", "Clay City", "Njiru", "Ruai"],
            "Embakasi East": ["Lower Savanna", "Embakasi", "Utawala", "Mihango", "Upper Savanna"],
            "Makadara": ["Viwandani", "Harambee", "Makongeni", "Maringo/Hamza"],
            "Kamukunji": ["Eastleigh South", "Eastleigh North", "California", "Pumwani", "Airbase"],
            "Starehe": ["Landimawe", "Nairobi South", "Nairobi Central", "Ngara", "Pangani", "Ziwani/Kariokor"],
            "Mathare": ["Huruma", "Hospital", "Ngei", "Mlango Kubwa", "Kiamaiko"],
            "Dagoretti South": ["Mutu-Ini", "Ngando", "Riruta", "Uthiru/Ruthimitu", "Waithaka"],
            "Langata": ["Karen", "Nairobi West", "Mugumo-Ini", "South C", "Nyayo Highrise", "Kariobangi North", "Dandora Area I", "Dandora Area Ii"],
            "Embakasi North": ["Dandora Area Iv"],
            "Embakasi West": ["Umoja I", "Umoja Ii", "Mowlem", "Kariobangi South"],
            "Embakasi Central": ["Kayole North", "Kayole Central", "Kayole South", "Komarock", "Matopeni/Spring Valley"]
        },
        "Nakuru": {
            "Molo": ["Elburgon", "Mariashoni", "Mariashoni", "Turi", "Molo"],
            "Njoro": ["Njoro", "Mau Narok", "Mauche", "Kihingo", "Nessuit", "Lare"],
            "Naivasha": ["Biashara", "Hells Gate", "Lake View", "Mai Mahiu", "Maeilla", "Olkaria", "Naivasha East", "Viwandani"],
            "Kuresoi South": ["Amalo", "Keringet", "Kiptagich", "Tinet"],
            "Gilgil": ["Gilgil", "Elementaita", "Mbaruk/Eburu", "Malewa West", "Murindat"],
            "Kuresoi North": ["Kiptororo", "Nyota", "Sirikwa", "Kamara"],
            "Subukia": ["Subukia", "Waseges", "Kabazi"],
            "Rongai": ["Menengai West", "Visoi", "Soin", "Mosop", "Solai"],
            "Nakuru North": ["Dundori", "Kabatini", "Kiamaina", "Lanet/Umoja", "Bahati"],
            "Nakuru West": ["Kaptembwo", "Kapkures", "Rhoda", "Shaabab", "Barut", "London"],
            "Nakuru East": ["Biashara", "Kivumbini", "Flamingo", "Menengai", "Nakuru East"]
        },
        "Nandi": {
            "Aldai": ["Kemeloi-Maraba", "Kobujoi", "Kaptumo/Kaboi", "Koyo/Ndurio", "Kabwareng", "Terik"],
            "Nandi East": ["Nandi Hills", "Chepkunyuk", "Kapsimotwo", "Ol'Lessos", "Kapchorua"],
            "Chesumei": ["Lelmoko/Ngechek", "Chemundu/Kapng'Etunyi", "Kosirai", "Kaptel/Kamoiywo", "Kiptuiya"],
            "Emgwen": ["Chepkumia", "Kapsabet", "Kilibwoni", "Kapkangani"],
            "Mosop": ["Ndalat", "Sangalo/Kebulonik", "Chepterwai", "Kipkaren", "Kurgung/Surungai", "Kabisaga"],
            "Tinderet": ["Songhor/Soba", "Tinderet", "Chemelil/Chemase"]
        },
        "Narok": {
            "Transmara West": ["Kilgoris Central"],
            "Narok North": ["Olorropil", "Melili", "Suswa", "Olposimoru", "Olokurto", "Narok Town", "Nkareta"],
            "Narok South": ["Maji Moto/Naroosura", "Ololulung'A", "Melelo", "Loita", "Sogoo", "Sagamian", "Degema", "Ogba/Egbema/Ndoni"],
            "Narok West": ["Ilmotiook", "Mara", "Siana", "Naikarra"],
            "Transmara West": ["Keyian", "Angata Barikoi", "Shankoe", "Kimintet", "Lolgorian"],
            "Transmara East": ["Iikerin", "Ololmasani", "Mogondo", "Kapsasian"]
        },
        "Nyamira": {
            "Masaba North": ["Rigoma", "Gachuba", "Gesima"],
            "Manga": ["Kamera", "Magombo", "Manga"],
            "Nyamira": ["Nyamaiya", "Bogichora", "Bosamaro", "Bonyamatuta", "Township"],
            "Nyamira North": ["Itibo", "Bomwagamo", "Bokeira", "Magwagwa", "Ekerenyo"],
            "Borabu": ["Mekenene", "Kiabonyoru", "Nyansiongo", "Esise"]
        },
        "Nyandarua": {
            "Oljoroorok": ["Charagita", "Gathanji", "Gatimu", "Weru", "Kiritta"],
            "Kipipiri": ["Githioro", "Wanjohi", "Kipipiri", "Kipipiri"],
            "Olkalou": ["Kanjuiri Range", "Rurii", "Karau", "Mirangine", "Kaimbaga"],
            "Ndaragwa": ["Leshau/Pondo", "Central", "Shamata"],
            "Kinangop": ["Engineer", "Gathara", "North Kinangop", "Murungaru", "Njabani/Kiburu", "Nyakio", "Githabai"]
        },
        "Nyeri": {
            "Nyeri South": ["Iria-Ini", "Chinga", "Karima"],
            "Mukurweini": ["Gikondi", "Rugi", "Mukurwe-Ini West", "Mukurwe-Ini Central"],
            "Nyeri Central": ["Kiganjo/Mathari", "Rware", "Gatitu/Muruguru", "Ruring'U / Karia", "Kamakwa/Mukaro"],
            "Mathira East": ["Karatina Town", "Mahiga", "Iriaini", "Konyu", "Magutu"],
            "Mathira West": ["Kirimukuyu", "Ruguru"],
            "Tetu": ["Dedan Kimathi", "Wamagana", "Aguthi-Gaaki"],
            "Kieni West": ["Mweiga", "Mwiyogo/Endarasha", "Mugunda", "Gatarakwa"],
            "Kieni East": ["Naromoru/Kiamathaga", "Thegu River", "Kabaru", "Gakawa"]
        },
        "Samburu": {
            "Samburu Central": ["Maralal", "Loosuk", "Porro"],
            "Samburu North": ["El-Barta", "Nachola", "Ndoto"],
            "Samburu Central": ["Angata Nayokie", "Baawa", "Suguta Marmar", "Lodokejek"],
            "Samburu East": ["Waso", "Wamba West", "Wamba North"]
        },
        "Siaya": {
            "Rarieda": ["North Uyoma", "South Uyoma", "West Uyoma", "East Asembo", "West Asembo"],
            "Ugenya": ["West Ugenya", "Ukwala", "North Ugenya", "East Ugenya"],
            "Ugunja": ["Sidindi", "Sigomere", "Ugunja"],
            "Alego Usonga": ["Usonga", "West Alego", "Central Alego", "Siaya Township", "North Alego", "South East Alego"],
            "Gem": ["North Gem", "West Gem", "Central Gem", "Yala Township", "East Gem", "South Gem"],
            "Bondo": ["West Yimbo", "Central Sakwa", "South Sakwa", "Yimbo East", "West Sakwa", "North Sakwa"]
        },
        "Taita Taveta": {
            "Taveta": ["Chala", "Mata"],
            "Wundanyi": ["Wundanyi/Mbale", "Wumingu/Kishushe", "Mwanda/Mgange", "Werugha"],
            "Mwatate": ["Bura", "Ronge", "Mwatate", "Wusi/Kishamba", "Chawia"],
            "Taveta": ["Bomani", "Mboghoni", "Mahoo"],
            "Voi": ["Kasigau", "Mbololo", "Sagala", "Marungu", "Ngolia", "Kaloleni"]
        },
        "Tana River": {
            "Galole": ["Wayu"],
            "Garsen": ["Kipini East", "Garsen South", "Kipini West", "Garsen Central", "Garsen West", "Garsen North"]
        },
        "Tharaka-Nithi": {
            "Muthambi": ["Mitheru", "Muthambi"],
            "Mwimbi": ["Mwimbi", "Ganga", "Chogoria"],
            "Igambang'ombe": ["Igambang`Ombe", "Mariani"],
            "Tharaka North": ["Gatunga", "Mukothima"],
            "Tharaka South": ["Nkondi", "Chiakagira", "Marimanti"],
            "Chuka": ["Karingani", "Magumoni", "Mugwe"]
        },
        "Trans Nzoia": {
            "Kwanza": ["Kapomboi", "Kwanza", "Keiyo", "Bidii"],
            "Endebess": ["Chepchoina", "Endebess", "Matumbei"],
            "Saboti": ["Kinyoro", "Matisi", "Tuwani", "Saboti", "Machewa"],
            "Kiminini": ["Kiminini", "Waitaluk", "Sirende", "Nabiswa", "Hospital", "Sikhendu"],
            "Cherangany": ["Makutano", "Kaplamai", "Motosiet", "Cherangany/Suwerwa", "Chepsiro/Kiptoror", "Sinyerere", "Sitatunga"]
        },
        "Turkana": {
            "Turkana East": ["Kapedo/Napeitom"]
        },
        "Uasin Gishu": {
            "Soy": ["Moi'S Bridge", "Kapkures", "Ziwa", "Soy", "Kuinet/Kapsuswa", "Segeroi/Barsombe", "Kipsomba"],
            "Turbo": ["Ngenyilel", "Tapsagoi", "Kamagut", "Kiplombe", "Kapsaos", "Huruma"],
            "Moiben": ["Tembelio", "Sergoit", "Karuna/Meibeki", "Moiben", "Kimumu"],
            "Ainabkoi": ["Kapsoya", "Kaptagat", "Ainabkoi/Olare"],
            "Kapseret": ["Simat/ Kapseret", "Kipkenyo", "Megun", "Ngeria", "Langas"],
            "Kesses": ["Racecourse", "Cheptiret/Kipchamo", "Tulwet/Chiyat", "Tarakwa"]
        },
        "Vihiga": {
            "Sabatia": ["Chavakali", "Busali", "Lyaduywa/Izava", "West Sabatia", "North Maragoli", "Wodanga"],
            "Hamisi": ["Shiru", "Gisambai", "Muhudu", "Tambua", "Jepkoyai", "Banja", "Shamakhokho"],
            "Luanda": ["Luanda South"],
            "Emuhaya": ["North East Bunyore", "Central Bunyore", "West Bunyore"],
            "Vihiga": ["South Maragoli", "Lugaga-Wamuluma", "Central Maragoli", "Mungoma"],
            "Luanda": ["Luanda Township", "Wemilabi", "Mwibona", "Emabungo"],
        },
        "West Pokot": {
            "West Pokot": ["Riwo", "Kapenguria", "Mnagei", "Siyoi"],
            "Pokot North": ["Suam"],
            "Pokot Central": ["Masool", "Lomut", "Wei Wei"],
            "Pokot South": ["Chepareria", "Batei", "Lelan", "Tapach"]
        }


    },
    "Rwanda": {
        "Amajyaruguru": {
            "Burera": ["Bungwe", "Butaro", "Cyanika", "Cyeru", "Gahunga", "Gatebe", "Gitovu", "Kagogo", "Kinoni", "Kinyababa", "Kivuye", "Nemba", "Rugarama", "Rugengabari", "Ruhunde", "Rusarabuye", "Rwerere"],
            "Gakenke": ["Busengo", "Coko", "Cyabingo", "Gakenke", "Gashenyi", "Janja", "Kamubuga", "Karambo", "Kivuruga", "Mataba", "Minazi", "Mugunga", "Muhondo", "Muyongwe", "Muzo", "Nemba", "Ruli", "Rusasa", "Rushashi"],
            "Gicumbi": ["Bukure", "Bwisige", "Byumba", "Cyumba", "Giti", "Kageyo", "Kaniga", "Manyagiro", "Miyove", "Mukarange", "Muko", "Mutete", "Nyamiyaga", "Nyankenke", "Rubaya", "Rukomo", "Rushaki", "Rutare", "Ruvune", "Rwamiko", "Shangasha"],
            "Musanze": ["Busogo", "Cyuve", "Gacaca", "Gashaki", "Gataraga", "Kimonyi", "Kinigi", "Muhoza", "Muko", "Musanze", "Nkotsi", "Nyange", "Remera", "Rwaza", "Shingiro"],
            "Rulindo": ["Base", "Burega", "Bushoki", "Buyoga", "Cyinzuzi", "Cyungo", "Kinihira", "Kisaro", "Masoro", "Mbogo", "Murambi", "Ngoma", "Ntarabana", "Rukozo", "Rusiga", "Shyorongi", "Tumba"]
        },
        "Amajyepfo": {
            "Gisagara": ["Gikonko", "Gishubi", "Kansi", "Kibirizi", "Kigembe", "Mamba", "Muganza", "Mugombwa", "Mukindo", "Musha", "Ndora", "Nyanza", "Save"],
            "Huye": ["Gishamvu", "Huye", "Karama", "Kigoma", "Kinazi", "Maraba", "Mbazi", "Mukura", "Ngoma", "Ruhashya", "Rusatira", "Rwaniro", "Simbi", "Tumba"],
            "Kamonyi": ["Gacurabwenge", "Karama", "Kayenzi", "Kayumbu", "Mugina", "Musambira", "Ngamba", "Nyamiyaga", "Nyarubaka", "Rugarika", "Rukoma", "Runda"],
            "Muhanga": ["Cyeza", "Kabacuzi", "Kibangu", "Kiyumba", "Muhanga", "Mushishiro", "Nyabinoni", "Nyamabuye", "Nyarusange", "Rongi", "Rugendabari", "Shyogwe"],
            "Nyamagabe": ["Buruhukiro", "Cyanika", "Gasaka", "Gatare", "Kaduha", "Kamegeri", "Kibirizi", "Kibumbwe", "Kitabi", "Mbazi", "Mugano", "Musange", "Musebeya", "Mushubi", "Nkomane", "Tare", "Uwinkingi"],
            "Nyanza": ["Busasamana", "Busoro", "Cyabakamyi", "Kibilizi", "Kigoma", "Mukingo", "Muyira", "Ntyazo", "Nyagisozi", "Rwabicuma"],
            "Nyaruguru": ["Busanze", "Cyahinda", "Kibeho", "Kivu", "Mata", "Muganza", "Munini", "Ngera", "Ngoma", "Nyabimata", "Nyagisozi", "Ruheru", "Ruramba", "Rusenge"],
            "Ruhango": ["Bweramana", "Byimana", "Kabagali", "Kinazi", "Kinihira", "Mbuye", "Mwendo", "Ntongwe", "Ruhango"]
        },
        "Iburasirazuba": {
            "Bugesera": ["Gashora",
                "Juru", "Kamabuye", "Mareba", "Mayange", "Musenyi", "Mwogo", "Ngeruka", "Ntarama", "Nyamata", "Nyarugenge", "Rilima", "Ruhuha", "Rweru", "Shyara"],
            "Gatsibo": ["Gasange", "Gatsibo", "Gitoki", "Kabarore", "Kageyo", "Kiramuruzi", "Kiziguro", "Muhura", "Murambi", "Ngarama", "Nyagihanga", "Remera", "Rugarama", "Rwimbogo"],
            "Kayonza": ["Gahini", "Kabare", "Kabarondo", "Mukarange", "Murama", "Murundi", "Mwiri", "Ndego", "Nyamirama", "Rukara", "Ruramira", "Rwinkwavu"],
            "Kirehe": ["Gahara", "Gatore", "Kigarama", "Kigina", "Kirehe", "Mahama", "Mpanga", "Musaza", "Mushikiri", "Nasho", "Nyamugari", "Nyarubuye"],
            "Ngoma": ["Gashanda", "Jarama", "Karembo", "Kazo", "Kibungo", "Mugesera", "Murama", "Mutenderi", "Remera", "Rukira", "Rukumberi", "Rurenge", "Sake", "Zaza"],
            "Nyagatare": ["Gatunda", "Karama", "Karangazi", "Katabagemu", "Kiyombe", "Matimba", "Mimuri", "Mukama", "Musheri", "Nyagatare", "Rukomo", "Rwempasha", "Rwimiyaga", "Tabagwe"],
            "Rwamagana": ["Fumbwe", "Gahengeri", "Gishali", "Karenge", "Kigabiro", "Muhazi", "Munyaga", "Munyiginya", "Musha", "Muyumbu", "Mwulire", "Nyakaliro", "Nzige", "Rubona"]
        },
        "Iburengerazuba": {
            "Karongi": ["Bwishyura", "Gashari", "Gishyita", "Gitesi", "Lac Kivu", "Mubuga", "Murambi", "Murundi", "Mutuntu", "Rubengera", "Rugabano", "Ruganda", "Rwankuba", "Twumba"],
            "Ngororero": ["Bwira", "Gatumba", "Hindiro", "Kabaya", "Kageyo", "Kavumu", "Matyazo", "Muhanda", "Muhororo", "Ndaro", "Ngororero", "Nyange", "Sovu"],
            "Nyabihu": ["Bigogwe", "Jenda", "Jomba", "Kabatwa", "Karago", "Kintobo", "Mukamira", "Muringa", "Rambura", "Rugera", "Rurembo", "Shyira"],
            "Nyamasheke": ["Bushekeri", "Bushenge", "Cyato", "Gihombo", "Kagano", "Kanjongo", "Karambi", "Karengera", "Kirimbi", "Lac Kivu", "Macuba", "Mahembe", "Nyabitekeri", "Rangiro", "Ruharambuga", "Shangi"],
            "Rubavu": ["Bugeshi", "Busasamana", "Cyanzarwe", "Gisenyi", "Kanama", "Kanzenze", "Lac Kivu", "Mudende", "Nyakiriba", "Nyamyumba", "Nyundo", "Rubavu", "Rugerero"],
            "Rusizi": ["Bugarama", "Butare", "Bweyeye", "Gashonga", "Giheke", "Gihundwe", "Gikundamvura", "Gitambi", "Kamembe", "Muganza", "Mururu", "Nkanka", "Nkombo", "Nkungu", "Nyakabuye", "Nyakarenzo", "Nzahaha", "Rwimbogo"],
            "Rutsiro": ["Boneza", "Gihango", "Kigeyo", "Kivumu", "Lac Kivu", "Manihira", "Mukura", "Murunda", "Musasa", "Mushonyi", "Mushubati", "Nyabirasi", "Ruhango", "Rusebeya"]
        },
        "Umujyi wa Kigali": {
            "Gasabo": ["Bumbogo",
                "Gatsata",
                "Gikomero",
                "Gisozi", "Jabana", "Jali", "Kacyiru", "Kimihurura", "Kimironko", "Kinyinya", "Ndera", "Nduba", "Remera", "Rusororo", "Rutunga"],
            "Kicukiro": ["Gahanga",
                "Gatenga",
                "Gikondo",
                "Kagarama", "Kanombe", "Kicukiro", "Kigarama", "Masaka", "Niboye", "Nyarugunga"],
            "Nyarugenge": ["Gitega",
                "Kanyinya",
                "Kigali",
                "Kimisagara",
                "Mageregere",
                "Muhima", "Nyakabanda", "Nyamirambo", "Nyarugenge", "Rwezamenyo"]
        }
    }
}


window.onload = function () {

    //Get html elements
    var countySel = document.getElementById("countySel");
    var stateSel = document.getElementById("stateSel");
    var citySel = document.getElementById("citySel");
    var zipSel = document.getElementById("zipSel");

    //Load countries
    for (var country in countryStateInfo) {
        countySel.options[countySel.options.length] = new Option(country, country);
    }

    //County Changed
    countySel.onchange = function () {

        stateSel.length = 1; // remove all options bar first
        citySel.length = 1; // remove all options bar first
        zipSel.length = 1; // remove all options bar first

        if (this.selectedIndex < 1)
            return; // done

        for (var state in countryStateInfo[this.value]) {
            stateSel.options[stateSel.options.length] = new Option(state, state);
        }
    }

    //State Changed
    stateSel.onchange = function () {

        citySel.length = 1; // remove all options bar first
        zipSel.length = 1; // remove all options bar first

        if (this.selectedIndex < 1)
            return; // done

        for (var city in countryStateInfo[countySel.value][this.value]) {
            citySel.options[citySel.options.length] = new Option(city, city);
        }
    }

    //City Changed
    citySel.onchange = function () {
        zipSel.length = 1; // remove all options bar first

        if (this.selectedIndex < 1)
            return; // done

        var zips = countryStateInfo[countySel.value][stateSel.value][this.value];
        for (var i = 0; i < zips.length; i++) {
            zipSel.options[zipSel.options.length] = new Option(zips[i], zips[i]);
        }
    }
}