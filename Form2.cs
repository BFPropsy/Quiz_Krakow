using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CNET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void historiaTekstEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int btnTag = Convert.ToInt32(senderObject.Tag);
            wyswietlHist(btnTag);
        }

        private void wyswietlHist(int nrHist)
        {
            switch(nrHist)
                {
                case 21:
                    pictureBox1.Image = Properties.Resources.Barbakan;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Najbardziej wysunięta na północ część fortyfikacji miejskich Krakowa. Znajduje się na Plantach, przed Bramą Floriańską, po południowej stronie ul. Basztowej." +
                        "Został wzniesiony w latach 1498–1499 za panowania króla Jana Olbrachta w obawie przed najazdem wołosko-tureckim zagrażającym Krakowowi po klęsce bukowińskiej. Inspiracją do tej decyzji były dwa barbakany w Toruniu (Starotoruński z 1429 r. i Chełmiński z 1449 r.), których możliwości obronne skłoniły króla do budowy „takowej fortalicji” w Krakowie. Jan Olbracht osobiście położył tam kamień węgielny pod budowę i przekazał na ten cel 100 grzywien." + Environment.NewLine +
                        "W 1816 senator Feliks Radwański w swoim „Votum oddzielnym” w obronie Barbakanu i Bramy Floriańskiej przed wyburzeniem użył m.in. argumentacji, iż do pozbawionego tych fortyfikacji centrum miasta wtargną silne wiatry północne i północno-zachodnie, narażając mieszkańców na częste fluksje, reumatyzmy, a może i paraliże. Tymczasem dekret cesarski wydany w Wiedniu jeszcze w roku 1806 zalecał zburzenie warowni właśnie ze względów sanitarnych i zdrowotnych. Ostatecznie zwyciężyły argumenty Radwańskiego." + 
                        "W roku 1910, w związku z obchodami 500-lecia zwycięstwa pod Grunwaldem, powstał projekt umieszczenia w Barbakanie Panoramy Grunwaldzkiej, której autorami mieli być Jan Styka i Tadeusz Styka. Artyści przyjechali z Paryża do Krakowa specjalnie w tej sprawie jeszcze w 1909 roku, aby przedstawić szkice panoramy Komitetowi Grunwaldzkiemu. Wydali też broszurę pt. „Grunwald w Rondlu Bramy Floriańskiej”. Pomysł wywołał ożywioną dyskusję, której echa można znaleźć m.in. w utworach Boya pisanych do Zielonego Balonika. + " +
                        " Sprawę panoramy w Barbakanie ostatecznie rozstrzygnęła urzędująca w Wiedniu Centralna Komisja do spraw opieki nad zabytkami, odmawiając zgody na to przedsięwzięcie. Negatywną decyzję motywowano obawą przed narażeniem historycznej budowli na uszkodzenie. Tzw. Diorama Grunwaldzka, Tadeusza Popiela i Zygmunta Rozwadowskiego, była eksponowana w specjalnie zbudowanym drewnianym budynku na placu św. Ducha. Na Barbakanie znajduje się płyta poświęcona Marcinowi Oracewiczowi. Jak głosi legenda, podczas konfederacji barskiej, gdy zabrakło mu amunicji przy obronie Krakowa, nabił karabin guzikiem od czamary i zabił rosyjskiego dowódcę Panina.";
                    break;
                case 22:
                    pictureBox1.Image = Properties.Resources.Bernatka;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Kładka pieszo-rowerowa na Wiśle w Krakowie łącząca Kazimierz z Podgórzem, zbudowana w miejscu dawnego mostu Podgórskiego. Decyzją rady miasta została nazwana imieniem o. Laetusa Bernatka, zakonnika, który na przełomie XIX i XX w. doprowadził do wybudowania budynków szpitala Bonifratrów w Krakowie. " + Environment.NewLine +
                        "Kładka, zbudowana według projektu Autorskiej Pracowni Projektowo-Plastycznej prof. Andrzeja Gettera, ma formę stalowego łuku rozpiętego pomiędzy istniejącymi przyczółkami mostu Podgórskiego, do którego podwieszone są dwa pomosty (jeden dla pieszych, drugi dla rowerzystów). Stalowy łuk ma długość 145 metrów, natomiast pomosty ok. 130 m. Całość konstrukcji waży ponad 700 ton, a koszt jej budowy to ponad 38 mln zł. " +
                        "Powstanie kładki przyczyniło się do ożywienia kulturalnego, towarzyskiego i turystycznego prowadzących do niej ulic po obu stronach rzeki, a także przyległej części bulwarów wiślanych[potrzebny przypis]. Przywrócone zostało znaczenie dawnego traktu między placem Wolnica a Rynkiem Podgórskim wiodącego ulicami Mostową i K. Brodzińskiego." + Environment.NewLine +
                        "Kładka staje się miejscem zakochanych. Na barierze mostu zapięto już setki kłódek z wypisanymi, a nawet wygrawerowanymi na nich imionami, inicjałami, wyrazami miłości, datami. Zakochane pary wieszają kłódkę na moście, zatrzaskują ją, po czym wrzucają kluczyk do Wisły na znak, że ich uczucie pozostanie nierozerwalne do końca życia. " +
                        "Kładka stała się więc tzw. mostem Miłości, przykładów którego istnieje wiele w Europie: florencki Ponte Vecchio nad rzeką Arno, rzymski Most Mulwijski, paryski Pont des Arts, a w Polsce: wrocławski Most Tumski, bydgoska kładka przy Operze Nova, warszawski Most Poniatowskiego.";
                    break;
                case 23:
                    pictureBox1.Image = Properties.Resources.KrakusKopiec;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Kopiec znajdujący się w Krakowie, na prawym brzegu Wisły w dzielnicy Podgórze, usypany na najwyższym wzniesieniu wapiennego zrębu Krzemionek – Wzgórzu Lasoty (271 m). Wysokość od podstawy – 16 m, średnica u podstawy 57 m, górna 8 m (wierzchołek płaski), objętość 19 100 m³. Z kopcem Krakusa związane są obchody Rękawki." +
                        "W historycznej Małopolsce poza Krakowem wielkie kopce kurhanowe znajdują się jeszcze w Krakuszowicach, Leszczkowie, Sandomierzu, Sólcy, Święcicy i Złotej." + Environment.NewLine +
                        "Jan Długosz łączył jego usypanie z osobą Kraka, legendarnego założyciela miasta Krakowa. Opisuje, że pogrzebano go zgodnie ze zwyczajem na szczycie wzgórza, zaś dwaj jego synowie, wykonując jego wolę, wznieśli kopiec na wieczną pamiątkę." + Environment.NewLine +
                        "Niektórzy uczeni wskazywali na podobieństwo kopca do tych z terenów Skandynawii i sugerowali nordyckie pochodzenie Kraka(tym bardziej że obecność Wandalów na terenie Małopolski do IV w. jest udowodniona). Jednak zwyczaj sypania kopców na grobach był częsty już w czasach epoki kamiennej.W znacznej części Europy zachowały się kurhany grobowe przypominające kształtem i lokalizacją kopiec Kraka." +
                        "Według innych hipotez, wysuwanych już w okresie dwudziestolecia międzywojennego m.in. przez Rudolfa Jamkę, kopiec może mieć pochodzenie scytyjskie, huńskie, a nawet wikińskie.";
                    break;
                case 24:
                    pictureBox1.Image = Properties.Resources.Mariacki;
                    lblHistoria.Font = new Font(Font.FontFamily, 8);
                    lblHistoria.Text = "Jeden z największych i najważniejszych, po archikatedrze wawelskiej, kościołów Krakowa, od 1962 roku posiadający tytuł bazyliki mniejszej. Należy do najbardziej znanych zabytków Krakowa i Polski. Jest kościołem gotyckim, budowanym w XIV i XV wieku. Położony jest przy północno-wschodnim narożniku Rynku Głównego, na Placu Mariackim. Kościół znajduje się na trasie Małopolskiej Drogi św. Jakuba z Sandomierza do Tyńca. Według Jana Długosza pierwszy murowany kościół w stylu romańskim został ufundowany przez biskupa krakowskiego Iwona Odrowąża w latach 1221–1222 na miejscu pierwotnej drewnianej świątyni. Wkrótce jednak budowlę zniszczono podczas najazdów tatarskich." + Environment.NewLine +
                    "W latach 1290–1300 wzniesiono, częściowo na poprzednich fundamentach, wczesnogotycki kościół halowy, który konsekrowano około roku 1320–1321.Prace jednak kontynuowane były jeszcze w trzeciej dekadzie czternastego stulecia.W latach 1355–1365, dzięki fundacji Mikołaja Wierzynka, wzniesiono obecne prezbiterium." +
                    "Z kolei w latach 1392–1397 polecono mistrzowi Mikołajowi Wernerowi lepsze doświetlenie kościoła. Budowniczy obniżył mury naw bocznych, a w murach magistralnych wprowadził duże otwory okienne. W ten sposób halowy układ świątyni zmienił się na bazylikowy. W 1443 roku miało miejsce silne trzęsienie ziemi, które spowodowało runięcie sklepienia świątyni." +
                    "W pierwszej połowie XV wieku dobudowano kaplice boczne. Większość z nich była dziełem mistrza Franciszka Wiechonia z Kleparza. W tym też czasie podwyższona została wieża północna, przystosowana do pełnienia funkcji strażnicy miejskiej. W 1478 cieśla Matias Heringkan pokrył wieżę hełmem. Na nim, w 1666, umieszczono złoconą koronę. " +
                    "W końcu XV wieku świątynia Mariacka wzbogaciła się o arcydzieło rzeźbiarskie późnego gotyku – Ołtarz Wielki – dzieło Wita Stwosza. W XVIII wieku, na polecenie archiprezbitera Jacka Augusta Łopackiego, wnętrze gruntownie przerobiono w stylu późnego baroku. Autorem tych prac był Francesco Placidi. Wymieniono wtedy 26 ołtarzy, sprzęt, wyposażenie, ławy, obrazy, a ściany ozdobiono polichromią pędzla Andrzeja Radwańskiego.Z tego okresu pochodzi również późnobarokowa kruchta.Na początku XIX wieku, wskutek wprowadzenia austriackich przepisów sanitarnych i w ramach porządkowania miasta, zlikwidowano przykościelny cmentarz. W ten sposób powstał plac Mariacki. W latach 1887–1891, pod kierunkiem Tadeusza Stryjeńskiego, wprowadzono do wnętrza wystrój neogotycki.Świątynia zyskała nową polichromię projektu i pędzla Jana Matejki, z którym współpracowali: Stanisław Wyspiański i Józef Mehoffer – autorzy witraży w prezbiterium i nad organami głównymi.";
                    break;
                case 25:
                    pictureBox1.Image = Properties.Resources.Centralny;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Centralne miejsce Nowej Huty, w administracyjnej dzielnicy XVIII. Przeznaczony dla spacerowiczów, ale jednocześnie pełniący rolę węzła komunikacyjnego i punktu przesiadkowego." +
                    "Realizacja budowy rozpoczęła się w 1949 roku.Autorami koncepcji architektonicznej byli Tadeusz Ptaszycki oraz Marta i Janusz Ingardenowie.Miał tam powstać teatr, a za nim, na Łąkach Nowohuckich – jezioro.Pośrodku Placu miał stanąć obelisk.Pomysł został jednak zaniechany w połowie lat pięćdziesiątych XX wieku. W latach osiemdziesiątych rozpoczęto budowę Nowohuckiego Centrum Kultury(NCK) w miejscu wcześniej wspomnianego teatru, który wybudowano w innym miejscu Nowej Huty.NCK miało być jednym z największych domów kultury w Polsce. W 2004 roku Rada Miasta Krakowa przeznaczyła milion złotych na modernizację Placu Centralnego.Miał zostać przywrócony wygląd Placu sprzed 55 lat.Wykonano w środku deptak z ławkami, zmodernizowano zieleń, pojawiły się ławki, kosze na śmieci, stylowe ogrodzenia zieleni.Na Aleję Róż, jak i na Plac powróciły lampy kandelabrowe." +
                    "8 września 2004 roku radni z Rady Miasta Krakowa zmienili nazwę placu, dodając do jego nazwy patrona – Ronalda Reagana. Początkowo planowano usunięcie z nazwy słowa" +
                    "Centralny" + ", ale wskutek działań Komitetu Obrony Nazwy Placu Centralnego, założonego przez mieszkańców oraz niektórych radnych miasta i radnych nowohuckich dzielnic, zmiana ograniczyła się do dodania patrona.";
                    break;
                case 26:
                    pictureBox1.Image = Properties.Resources.Mechaniczny;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Świadomość potrzeby rozwijania nauk technicznych i inżynieryjnych pojawiła się w krakowskim środowisku naukowym już na przełomie XVI i XVII w. Wiązała się ona z nazwiskami Stanisława Grzepskiego, autora pierwszego polskiego podręcznika miernictwa, Stanisława Pudłowskiego, badacza uniwersalnej miary długości oraz Jana Brożka - matematyka, lekarza i historyka nauki. Brożek podkreślał w swoich pracach konieczność powiązania rozwoju myśli naukowej z ekonomicznymi potrzebami kraju. Swój pierwszy wykład z zakresu inżynierii wojskowej wygłosił 20 stycznia 1627 r." +
                    "Na bardziej konkretne koncepcje przyszedł czas 150 lat później, kiedy to w ramach reform krajowej nauki zainicjowanych przez Hugona Kołłątaja, do programu studiów włączono takie przedmioty jak: mechanika, statyka z hydrostatyką, cerometria, hydraulika, hydrografia oraz architektura cywilna i wojskowa. Plany działacza Komisji Edukacji Narodowej były znacznie bardziej ambitne(kadry inżynieryjne Szkoły Głównej Koronnej kształcić miał Tadeusz Kościuszko), jednak wobec zacofania ekonomicznego upadającej Rzeczypospolitej, nie doczekały się rozwinięcia." +
                    "Przełom nastąpił w 1834 r., wraz z powstaniem Instytutu Technicznego w Krakowie.Szkoła ta prowadziła kształcenie ogólne i zawodowe o zróżnicowanych kierunkach -inżynieryjnym, poligraficznym czy artystycznym.W trakcie ponad 100 lat funkcjonowania, Instytut przechodził zmienne koleje losu, ostatecznie zostając zdegradowanym do stopnia szkoły średniej pod nazwą Państwowej Szkoły Przemysłowej.Nie przeszkodziło to jednak w wykształceniu kilku pokoleń techników o dobrym przygotowaniu zawodowym." + Environment.NewLine +
                    "Lata niepodległości otworzyły w Krakowie całkowicie nowe możliwości kształcenia inżynieryjnego. w 1921 r.na Akademii Górniczej powstała Katedra Budownictwa i Inżynierii. Jej kierownikiem został prof. Izydor Stella-Sawicki.Z jego nazwiskiem nierozłącznie wiąże się inicjatywa założenia Politechniki Krakowskiej.Droga do jej powstania była jednak długa i usiana licznymi trudnościami.";
                    break;
                case 27:
                    pictureBox1.Image = Properties.Resources.UJ;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Uniwersytet Krakowski jest najstarszą uczelnią w Polsce i jedną z najstarszych w tym regionie Europy. Ufundowany został 12 maja 1364 roku przez króla polskiego Kazimierza Wielkiego. Studium generale – tak wówczas nazywano Uniwersytet — składało się z trzech wydziałów: sztuk wyzwolonych, medycyny i prawa. Za życia fundatora funkcjonowały tylko dwa pierwsze. Po śmierci króla uczelnia przestała istnieć." + Environment.NewLine +
                    "Po nieudanych próbach jej odnowienia w latach dziewięćdziesiątych XIV wieku, została ponownie ufundowana przez króla Władysława Jagiełłę 26 lipca 1400 roku.Do odnowienia przyczynił się zapis testamentowy zmarłej w 1399 roku królowej Jadwigi.Struktura uniwersytetu została dopełniona przez wydział teologiczny powołany formalnie już w roku 1397 Najstarsze i główne kolegium uniwersyteckie nosiło nazwę Królewskiego, a potem Większego(Collegium Maius)." +
                    "W XV wieku powstały jeszcze dwa – Prawnicze(Collegium Iuridicum) i Filozoficzne(Collegium Minus), a także kilka burs dla studentów i młodszych wykładowców.Uniwersytet ulokowany w ówczesnej stolicy Królestwa Polskiego nie zaprzestał już swej działalności. Stanowi on nie tylko symbol ciągłości państwa polskiego, ale czyni z Krakowa jeden z najważniejszych ośrodków edukacyjnych w kraju. W XV wieku uniwersytet przeżył jedną z najlepszych faz swego rozwoju." + 
                    "Przyciągał wówczas studentów z całej Europy. Co roku zapisywało się około 200 nowych.Oprócz Polaków studiowali: Rusini, Litwini, Węgrzy, Niemcy, Czesi, Szwajcarzy, Anglicy, Niderlandczycy, Francuzi, Włosi, Hiszpanie, nawet Tatarzy. Słynął zwłaszcza z nauki prawa, matematyki i astronomii.Wśród profesorów tego wieku wymienić należy przede wszystkim znakomitych prawników: Stanisława ze Skarbimierza i Pawła Włodkowica – współtwórców koncepcji prawa międzynarodowego, a także matematyków, astronomów i geografów: Marcina Króla z Żurawicy, Jana z Głogowa, Wojciecha z Brudzewa, Macieja Miechowitę." + 
                    "Wśród ówczesnych studentów znalazł się Mikołaj Kopernik, który wpisał się na studia w roku 1491.";
                    break;
                case 28:
                    pictureBox1.Image = Properties.Resources.Krakow;
                    lblHistoria.Font = new Font(Font.FontFamily, 9);
                    lblHistoria.Text = "Pierwszą udokumentowaną wzmianką o Krakowie jest relacja kordobańskiego kupca Ibrahima ibn Jakuba z 965 r., w której wspomina o otoczonym lasami bogatym grodzie, leżącym na skrzyżowaniu szlaków handlowych." + Environment.NewLine +
                    "Najstarszy ośrodek osadniczy znajdował się m.in. na obronnym Wawelu i był jednym z grodów w plemiennym państwie Wiślan. Około 990 r.gród znalazł się w granicach państwa piastowskiego, stając się z czasem jedną z głównych siedzib królestwa." + 
                    " Pierwsza wiarygodna pisemna wzmianka o Krakowie pochodzi z dokumentu Dagome iudex z ok. 992 r.Nad Wisłą obok Wawelu, niewielkim wzgórzu z jurajskiego wapienia, według legendy stała niegdyś świątynia pogańska, na miejscu której zbudowano następnie kościół romański pw. św.Michała Archanioła. Co najmniej od 1000 w Krakowie znajdowała się siedziba biskupstwa, a za panowania Kazimierza Odnowiciela Kraków stał się główną siedzibą książęcą." +
                    " W okresie rozbicia dzielnicowego Kraków był siedzibą księcia seniora, z czasem jednak książęta krakowscy stracili faktyczne zwierzchnictwo nad innymi władcami piastowskimi. W 1241 r.miasto zostało zniszczone podczas najazdu mongolskiego. Mogło to zadecydować o niepowodzeniu pierwszej lokacji Krakowa, którą najprawdopodobniej planowano na początku XIII wieku." + 
                    " W dniu 5 czerwca 1257 r., wzorując się na Wrocławiu, książę Bolesław V Wstydliwy, jego matka Grzymisława i żona św. Kinga nadali miastu przywilej lokacyjny na prawie magdeburskim. Nowo wytyczone miasto zostało zasiedlone głównie przez przybyszów ze Śląska i Niemiec, co tłumaczy fakt posługiwania się językiem niemieckim przez mieszczaństwo krakowskie do XVI w. Wtedy też powstał charakterystyczny szachownicowy układ miasta, w który wpasowano zachowane elementy wcześniejsze(ul.Grodzka, kościół Mariacki)." + 
                    " Pomiędzy Krakowem a Wawelem istniała osada Okół, dawne podgrodzie, która została wcielona do Krakowa przez króla Władysława Łokietka po buncie wójta Alberta. W 1320 r.w katedrze wawelskiej koronowano Władysława Łokietka, kończąc symbolicznie okres rozbicia dzielnicowego. Odtąd, aż do 1734 r., Kraków był miejscem koronacji królów Polski. W XIV wieku na przedmieściach Krakowa powstały dwa kolejne miasta: na południu Kazimierz(1335) i na północy Kleparz(1366).";
                    break;
            }
        }
    }
}
