using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wba.PE1.Webshop.Web.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    Storage = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SortNumber = table.Column<int>(nullable: true),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "Phones" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2L, "Laptops" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3L, "Tablets" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Info", "Price", "ProductName", "Size", "SortNumber", "Storage" },
                values: new object[,]
                {
                    { 1L, 1L, "iphone11.png", "Apple A11 Fusion-chip met Neural Engine Levert uitstekende algehele prestaties voor het openen en uitvoeren van applicaties, bladeren door menu's, startschermen en meer. Apple iOS 11 Met iOS 11 is iPhone X een krachtig, persoonlijk en intelligent apparaat. Het biedt geweldige mogelijkheden voor augmented reality in zowel games als apps. Universeel ontgrendeld Compatibel met alle grote Amerikaanse providers, zoals Verizon, AT&T, Sprint en T-Mobile. Werkt ook met prepaid providers, waaronder Cricket Wireless, Boost Mobile, MetroPCS, Simple Mobile, Total Wireless, Tracfone, Net10, Mint en H2O. 4G LTE-snelheid Deze smartphone biedt een snelle internetverbinding om apps te downloaden, inhoud te streamen en verbonden te blijven op sociale media. 5,8-inch Super Retina HD-scherm met HDR en True Tone Het extra grote scherm met een resolutie van 2436 x 1125 en een slanke behuizing passen perfect in uw hand. 12.0MP camera met optische beeldstabilisatie en live foto's Snel genoeg om zo ongeveer alles te vangen en slim genoeg om te begrijpen wat het ziet. Bevat ook een 7,0 MP aan de voorzijde gerichte TrueDepth-camera voor zelfportretten en video's. 64GB intern geheugen Biedt voldoende opslagruimte voor uw contacten, muziek, apps en meer. Face ID-technologie Biedt veilige authenticatie en Apple Pay.", "€1000", "Iphone X", "5 inch", 1, "64GB" },
                    { 17L, 3L, "iPad.png", "Breng je creatieve ideeën tot leven met Apple iPad Air (2020) 10.9 inch 64 GB Wifi Space Gray + Apple Pencil 2. De meegeleverde Apple Pencil (2e generatie) is een intuitive stylus waarmee je comfortabel tekeningen en notities maakt. Alle apps openen razendsnel dankzij de krachtige A14 Bionic Chip. Je gaat zo bijvoorbeeld snel aan de slag met de apps van Adobe CC. Dit doe je op het scherpe 10.9 inch Retina scherm. Apple Pencil 2 is aanraakgevoelig, daardoor wissel je eenvoudig van tool door 2 keer op de stylus te tikken. Deze functie is beschikbaar in verschillende apps en stel je zelf in. Je bergt en laadt Apple Pencil 2 op door hem te bevestigen aan de magnetische zijkant van iPad Air (2020).", "€389", "iPad", null, 1, "126GB" },
                    { 16L, 2L, "Microsoft.png", "Microsoft Surface Laptop 2. Producttype: Notebook, Vormfactor: Clamshell. Processorfamilie: Intel® 8ste generatie Core™ i7, Processormodel: i7-8650U, Frequentie van processor: 1,90 GHz. Beeldschermdiagonaal: 34,3 cm (13.5inch), Resolutie: 2256 x 1504 Pixels, Touchscreen. Intern geheugen: 16 GB. Totale opslagcapaciteit: 512 GB, Opslagmedia: SSD. Ingebouwde grafische adapter. Inclusief besturingssysteem: Windows 10 Pro. Kleur van het product: Platina. Gewicht: 1,28 kg", "€1.885", "Microsoft Surface", "13,5 inch", 8, "512GB" },
                    { 15L, 2L, "Lenovo.png", "Nog meer gebruiksgemak Of je nu moet deelnemen aan een telefonische vergadering of wilt dansen op swingende deuntjes, met de ThinkPad E15 Gen 2-laptop kan het allebei dankzij de optionele ingebouwde Versa Tray. Je hoeft nooit meer naar je headset te zoeken of snoeren te ontwarren: open eenvoudig het laatje, waarna de Bluetooth®-oordopjes automatisch verbinding maken met je pc. Je kunt meer dan twee uur ononderbroken telefoongesprekken voeren. De dubbele microfoon zorgt ervoor dat omgevingsgeluid wordt onderdrukt, waardoor vergaderingen nog productiever worden.Verbeter je prestaties De ThinkPad E15 Gen 2-laptop combineert de kracht van een Intel® Core™-processor van de 11e generatie met DDR4-geheugen en een optionele afzonderlijke NVIDIA® grafische kaart, zodat je de hele werkdag door topprestaties kunt leveren. De laptop voert vol vertrouwen alle taken uit die er op je pad komen en handhaaft zelfs op intelligente wijze de optimale temperatuur wanneer je meerdere apps tegelijk gebruikt.", "€754", "Lenovo ThinkPad", "15,6 inch", 7, "256GB" },
                    { 14L, 2L, "Dell.png", "DELL Latitude 3510. Producttype: Notebook, Vormfactor: Clamshell. Processorfamilie: Intel® 10de generatie Core™ i5, Processormodel: i5-10210U, Frequentie van processor: 1,6 GHz. Beeldschermdiagonaal: 39,6 cm (15.6inch), HD type: Full HD, Resolutie: 1920 x 1080 Pixels. Intern geheugen: 8 GB, Intern geheugentype: DDR4-SDRAM. Totale opslagcapaciteit: 256 GB, Opslagmedia: SSD. Inclusief besturingssysteem: Windows 10 Pro. Kleur van het product: Grijs. Ingebouwde grafische adapter", "€680", "DELL Latitude ", "15,6 inch", 6, "256GB" },
                    { 13L, 2L, "Acer.png", "De Aspire 5 met een Intel® of AMD processor en een NVIDIA® of AMD grafische kaart1 is een en al kracht. Met tot wel 24 GB aan geheugen heb je ruim voldoende voor al je multitaskingbehoeften.Je beschikt over voldoende kracht en opslagruimte voor al je taken dankzij een snel ladende M.2 PCIe SSD van maximaal 1 TB 1 en een HDD van maximaal 2 TB1.Dankzij de dunne rand en een screen-to-body ratio van 81,61%1 geniet je nog meer van je kleurrijke Full HD IPS-scherm. Voor nog beter beeld en om je ogen te beschermen, is het scherm voorzien van Acer Color Intelligence™1.", "€849", "Acer Aspire 5", "17,3 inch", 5, "512GB" },
                    { 12L, 2L, "macbookAir.png", "De nieuwste MacBook Air is verkrijgbaar in zilver, spacegrijs en goud en heeft een schitterend Retinadisplay met True Tone-technologie, Touch ID, een Magic Keyboard met achtergrondverlichting en een Force Touch-trackpad. Allemaal in die dunne en lichte iconische wigvorm, gemaakt van 100% gerecycleerd aluminium. En met een batterijduur van 11 uur is dit een alleskunner waar je de hele dag mee aan de slag kunt.", "€999", "Macbook Air", "13 inch", 4, "256GB" },
                    { 11L, 2L, "hpGamingLaptop.png", "Wanneer je gaat starten met een nieuwe studie kan een goede studentenlaptop niet ontbreken. Heb je een laptop nodig met meer grafische werkkracht dan de gemiddelde laptop? Dan is de HP Pavilion Gaming wellicht iets voor jou. De nieuwste generatie i7 processor in combinatie met de NVIDIA® GTX 1660Ti grafische kaart van 6 GB en het werkgeheugen van 16 GB zorgt ervoor dat de laptop programma’s aankan die veel grafische rekenkracht vereisen. Denk bijvoorbeeld aan video’s editen in Adobe Premiere Pro en foto’s bewerken in Photoshop. Ook een ingewikkelde draaitabel maken in Excel is geen enkel probleem. De NVIDIA® GeForce GTX 1650 grafische kaart zorgt ervoor dat de laptop en het beeldscherm nog sneller met elkaar communiceren. Hierdoor werk je niet alleen met zware programma’s als Adobe Lightroom of 3ds Max, maar speel je na je huiswerk ook jouw favoriete games in de hoogste frame rate. De laptop is geschikt voor VR, dus beleef een game in een geweldige virtual reality-ervaring.Ook ideaal: met twee ventilatoren blijft de temperatuur koel voor topprestaties, zodat je langer met je studentenlaptop aan de slag kunt.", "€1.499,00", "HP Laptop Pavilion Gaming", "15,6 inch", 3, "1024GB" },
                    { 18L, 3L, "TabletSamsung.png", "De nieuwe A7 heeft een slank ontwerp, een levendig entertainmentsysteem en uitstekende prestaties, en is een stijlvolle metgezel in je leven. Geniet met volle teugen van alles waar je van houdt en deel gemakkelijk je favoriete momenten. Leer, ontdek, maak contact en laat je inspireren.", "€206,10", "Samsung Galaxy", null, 2, "64GB" },
                    { 10L, 2L, "hpLaptop.png", "Een superdunne, lichte laptop boordevol prestaties en stijl.Wees creatiever dan ooit met deze stijlvolle krachtpatser die speciaal voor jou is gemaakt. Hij is dun genoeg om overall mee naartoe te nemen en biedt voldoende power voor een lange werkdag.Doe meer Multitasking gaat soepel en snel dankzij een krachtige Intel®-processor. Bekijk video's, bewerk foto's en blijf verbonden met je familie en vrienden met alle kracht die hiervoor nodig is.Dun. Slank. Verfijnd. Een fraaie metalen finish geeft deze laptop een aantrekkelijke, elegante uitstraling. Elk detail, van het verhoogde toetsenbord tot de nieuwe smalle rand, is gericht op comfort en stijl. Een superkrachtig geluid Dankzij twee HP speakers, HP Audio Boost en speciale afstemming door de experts van B&O geniet je van een rijk, authentiek geluid. Geluid dat je raakt.", "€699", "HP Laptop Pavilion 15", "15.6 inch", 2, "512GB" },
                    { 8L, 1L, "Doro.png", "De veelzijdige Doro 8035 is geschikt voor zowel nieuwe als ervaren smartphonegebruikers. U kunt kiezen uit een traditionele Android-interface of een intuïtieve en gemakkelijk navigeerbare interface van Doro zelf. De Doro 8035 houdt bij welke functies u het meest gebruikt en is voorzien van Google Assistant*, een effectieve persoonlijke assistent die reageert op uw stem. De ingebouwde assistentieknop neemt rechtstreeks contact op met veiligheidsdiensten en hulpdiensten bij u in de buurt.", "€199,99", "Doro 8035", null, 7, "16GB" },
                    { 7L, 1L, "Huawei.png", "Het 6,3-inch dewdrop-display met een scherm/behuizing-verhouding van 88,4% biedt een brede en meeslepende visuele ervaring. Met een diameter van 2,65 mm bereikt de kleine en discrete camera aan de voorkant meer ruimte om opwindende game-graphics en fantastische beelden met minder onderbrekingen weer te geven.Met de speciale coating en verfijnd vakmanschap schittert de achterkant met verbluffende rondingen onder elk licht en elke schaduw. Elegantie en uitstraling worden vanuit elk perspectief getoond.De grote 5 000 mAh-batterij ondersteunt al uw dagelijkse taken gedurende meerdere dagen zonder regelmatig op te laden.6 De HUAWEI Y6p kan ook worden gebruikt als oplader om andere telefoons moeiteloos bij te tanken. Bovendien maakt de back-upmodus op dit apparaat het mogelijk om tweerichtingsback-up voor gegevens en foto's op Android-telefoons te ondersteunen.", "€139,10", "XIAOMI Redmi Note 9T", null, 6, "64GB" },
                    { 6L, 1L, "Xiaomi.png", "Met 5G+5G dual SIM kunt u genieten van een uitgebreide 5G-ervaring, zowel voor werk als voor entertainment.De octa-core processor MediaTek Dimensity 800U ondersteunt continu uw dagelijkse behoeften, of u nu aan het chatten bent met vrienden, video's streamt of online vergaderingen bijwoont.Tot 100% sneller dan de vorige generatie met hogere schrijfsnelheid. Open apps en maak foto's in een oogwenk.     Een opnieuw ontworpen vingerafdruksensor aan de zijkant voor ergonomisch comfort en snelle ontgrendeling.e batterij van 5000mAh(typ) laat u niet in de steek met 15 uur navigatie, 18 uur video afspelen of 11 uur gamen.Zodra de batterij bijna leeg is, kunt u met de 18W snelle oplader 33% opladen in slechts 30 minuten, zodat u altijd klaar bent voor vertrek. De batterij met een hoog oplaadcycli heeft een langere totale levensduur en gaat tot bijna 3 jaar mee zonder noemenswaardige degradatie.", "€224,10", "XIAOMI Redmi Note 9T", null, 5, "128GB" },
                    { 5L, 1L, "Nokia.png", "Geef jouw wereld kleur met de aangepaste vormen en wazige achtergronden van de portretmodus. Bovendien zorgt de nieuwe portret editor ervoor dat je foto's kan bewerken en de focus kan verleggen, ook nadat je ze genomen hebt. Nokia 2.4 houdt het tot 2 dagen vol op één enkele lading. De 4500 mAh AI-geässisteerde Adaptive Battery geeft prioriteit aan de apps die je het vaakst gebruikt zodat jij kunt blijven doen waar je zo van houdt.Kijk, leer en creëer op het 6,5inch HD+ display - compleet met selfie notch voor een maximale schermervaring. Ontgrendel je apparaat snel en gemakkelijk met de handige vingerafdruksensor of gebruik de AI gezichtsontgrendeling - zo blijft jouw telefoon ook echt van jou.", "€109,99", "Nokia 2.4", "5 inch", 5, "32GB" },
                    { 4L, 1L, "samsungGAL.png", "De zwarte Samsung Galaxy S21 Ultra 5G zet het leven in de schijnwerpers, zodat je nooit een moment hoeft te missen. Je voelt je als een regisseur en neemt video's op in verbluffende 8K-resolutie. Maar dat is nog niet alles, want met de functie Video Snap kan je jouw favoriete momenten uit video's omzetten in foto's met een hoge resolutie - met slechts één klik. Met de quadro-camera kan je portretten met een hoge resolutie maken die bijna professionele kwaliteit hebben en je zowel overdag als 's nachts van je beste kant laten zien.Je kan ook rekenen op de gebruikelijke Galaxy-kracht: een contrastrijk scherm, een lange batterijlevensduur en een snelle Exynos 2100-processor. De Exynos 2100 met geïntegreerde kunstmatige intelligentie in de Galaxy S21-serie is de snelste tot nu toe in een Galaxy-smartphone. Dus je kan er gewoon doorheen knallen in plaats van lang te wachten. Maar dat is niet alles. Dankzij de slimme batterij kan de Galaxy S21-serie elke gebruiker en levensstijl bijhouden - zelfs op lange dagen. Met snelle 5G kan je high-definition games spelen met lage latency, een heel seizoen van een favoriete show downloaden of je nieuwste vlog uploaden - in een mum van tijd. Het tot 120 Hz 6,8inch Dynamic AMOLED-scherm maakt video's, foto's en meer tot een ware belevenis en laat je diep in alle content duiken - in indrukwekkende beeldkwaliteit en vrijwel zonder vertraging. En met 256 GB ingebouwd geheugen kan je duizenden momenten veilig opslaan.", "€1.299,99", "Samsung GAL S21", "5 inch", 4, "256GB" },
                    { 3L, 1L, "iphoneSE.png", "Apple iPhone SE 64 GB Roze is een echte krachtpatser in een herkenbaar jasje. Dankzij de razendsnelle A13 Bionic chip laden al je apps in enkele seconden. Met 64 GB aan opslag heb je beperkt ruimte voor je favoriete apps en foto's. Heb je meer opslagruimte nodig? Kies dan de 128 of 256 GB variant. De smartphone heeft qua uiterlijk veel weg van iPhone 8. Zo heeft het toestel een glazen achterkant, waardoor je het toestel nu ook draadloos oplaadt. Het kleinere formaat zorgt ervoor dat 'ie makkelijk in je broekzak past. Op het 4,7 inch scherm kijk je gemakkelijk jouw favoriete films en series en verstuur jij jouw berichtjes. Ontgrendelen doe je nog steeds met Touch ID via de fysieke home button. Ook op iPhone SE 2020 Zwart maak je de mooiste foto's en 4K video's met de 12 megapixel camera met portretmodus.", "€650", "Iphone SE", "5 inch", 3, "128" },
                    { 2L, 1L, "samsungs20.png", "De Samsung Galaxy S20 Fan Edition brengt design en performance bij elkaar. Het toestel beschikt over een 6.5-inch-Infinity-O-Display met Super-AMOLED-beeldtechnologie en een verversingsfrequentie tot 120 Hz, wat zorgt voor scherpe en vloeiende beelden. Bovenin het scherm bevindt zich de 32 megapixel-selfiecamera en op de achterzijde heeft het toestel zelfs drie camera’s om iedere situatie goed vast te leggen. Zo beschikt de camera over verschillende functies als Night Mode en Super Steady, waar je met Single Take 14 foto’s achter elkaar maakt. Zo heb je altijd kans dat je een of meerdere mooie foto’s hebt vastgelegd. Daarnaast heeft de camera 30x digitale zoom, 3x optische zoom en maak je ook nog eens schitterende panoramashots met de Ultra-Wide-lens.De Galaxy S20 FE beschikt over een krachtige processor, 6 GB werkgeheugen en 128 GB opslaggeheugen. Deze opslag kan zelfs worden uitgebreid met een microSD-kaart van maximaal 1 TB. Zo heb je altijd genoeg ruimte voor al je foto’s, video’s en apps. De S20 FE biedt je alle gemakken die je je kunt wensen waar je met de krachtige batterij van 4.500 mAh de hele dag gebruik van maakt. Is je batterij toch leeg? Dan is deze dankzij de Super-Fast-Charging-technologie zo weer opgeladen. Uiteraard kun je ook energie lenen van een andere Samsung-smartphone door middel van Wireless PowerShare.", "€739,99", "Samsung S20", "5 inch", 2, "128GB" },
                    { 9L, 2L, "macbook13.png", "De nieuwe MacBook Pro is ongelooflijk dun en licht, en sneller en krachtiger dan voorheen. Nooit eerder was het display zo helder en kleurrijk. Bovendien is hij uitgerust met Touch Bar, een in het toetsenbord ingebouwde glazen strook die je kunt bedienen met Multi‑Touch-gebaren. Zo heb je altijd direct toegang tot alle tools die je wilt gebruiken. De MacBook Pro is het resultaat van grensverleggende ideeën. En helemaal klaar voor die van jou.", "€1570", "Macbook pro", "13 inch", 1, "1TB" },
                    { 19L, 3L, "iPadPro.png", "Met Apple iPad Pro (2020) 12.9 inch 128 GB Wifi Space Gray ga je met jouw creatieve projecten aan de slag. Met de 2 camera's op de achterkant van het toestel maak je al jouw beeldmateriaal gewoon zelf. Dankzij de ultragroothoeklens vang je meer beeld in één video of foto. Daarna heb je direct alles beschikbaar om je project vorm te geven, want iPad Pro beschikt over een A12Z processor. Daarmee multitask je probleemloos door verschillende apps naast elkaar te zetten. Jouw projecten werk je tot in de details uit op het grote 12.9 inch retina scherm. iPad Pro is geoptimaliseerd voor Augmented Reality, dankzij de LiDAR Scanner. Deze sensor meet de afstanden nauwkeurig, zodat je het meeste uit jouw AR games en apps haalt.", "€1.079,10", "Apple iPad Pro", null, 3, "128GB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
