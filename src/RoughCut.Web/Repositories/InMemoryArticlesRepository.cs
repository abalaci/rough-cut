using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class InMemoryArticlesRepository : IArticlesRepository
    {
        private static readonly IReadOnlyDictionary<string, Article> _articlesByAlias =
            new Dictionary<string, Article>(StringComparer.OrdinalIgnoreCase)
            {
                ["interviu-luchian-ciobanu"] = new Article
                {
                    Alias = "interviu-luchian-ciobanu",
                    Author = new Author
                    {
                        Alias = "mara-crisan",
                        Title = "Mara Crișan"
                    },
                    Body = @"<p><strong>Pregătind acest interviu, am găsit foarte puţine informaţii despre dumneavoastră. Aş vrea să știu de ce?</strong></p>
                    <p>Nu cred că m-a întrebat nimeni mai mult decât exista deja pe internet, dar e adevărat că încerc să pun o barieră între viața personală și cea profesională. Cred că sunt construit de așa natură încât nu pot subscrie la acest curent de a mă pune în primul plan, cu toate că știu că acesta e curentul: ""Dacă nu ești pe social-media nu exiști"", doar că nu mă interesează, pentru că e o falsă senzație că lucrurile funcționează așa. Adică, nu îmi fac selfies, nu postez fotografii cu mine nicăieri. Mi se pare că nu e important ca eu să fiu văzut, mai degrabă este mai important ceea ce fac.</p>
                    <p><strong>Aţi debutat în lungmetraj acum câţiva ani şi de atunci aţi semnat imaginea unor filme importante. Ca parte activă a breslei cinematografice, cum vi se pare generaţia care vine acum?</strong></p>
                    <p>Cred că aveți greaua misiune de a continua ceea ce a fost început la ceva timp după revoluție și ceea ce se numește noul val românesc. Este destul de greu, o miză destul de mare să continuați munca regizorilor care au consacrat această schimbare.</p>
                    <p><strong>Aţi studiat la UNATC. Cum v-a influențat instituția? Aţi păstrat legătura?</strong></p>
                    <p>Sigur că m-a influențat. M-a influențat mai degrabă pentru că am avut acces la peliculă, la un aparat de filmat.</p>
                    <p>În primul rând, atunci când eram student, era destul de greu accesibilă o cameră. Erau alte rigori. Digitalul nu ajunsese încă la noi. Îmi amintesc că primul aparat de fotografiat digital l-am avut după ce am intrat la facultate, nu a fost ușor de obținut.</p>
                    <p>În al doilea rând, cel mai important a fost faptul că făceam parte dintr-o echipă. Vrei, nu vrei, te trezești în mijlocul unei echipe care face asta. Începutul a fost cu stângăcii, dar ulterior s-a produs un film.</p>
                    <p>Referitor la colegi, da! Am păstrat legătura cu o parte din ei, am lucrat și lucrez în continuare și cred că asta e cea mai mare moștenire pe care o am din facultate. Un colectiv cu care te dezvolți. Ai o agendă de oameni pe care poți să îi suni, iar când apare un proiect mai mare alegi de acolo.</p>
                    <p><strong>La începutul carierei dumneavoastră, ce proiect v-a marcat în mod pozitiv şi, poate, v-a deschis cel mai mult ochii faţă de meseria de director de imagine?</strong></p>
                    <p>Țin minte și acum, primul proiect care m-a marcat pozitiv a fost chiar primul scurtmetraj din anul 1, semestrul 2. Aveam un exercițiu care trebuia realizat pe o peliculă de 16 mm. Aveam câteva role, 3 sau 4, era și o presiune din cauza asta. L-am făcut cu o echipă foarte restrânsă. A fost prima oară când am avut senzația că așa trebuie făcut un film. A fost poetic, un proiect emoționant.</p>
                    <p><strong>Cum a fost colaborarea cu Cristi Puiu? În industrie, este cunoscut ca un regizor exigent.</strong></p>
                    <p>Înainte să termin facultatea, am avut norocul să ajung direct pe platou la Aurora și practic, am luat-o de la zero. Mi-am dat seama că toată teoria pe care am învățat-o în facultate este un capitol care funcționează la nivel scolastic. Colaborarea cu Cristi Puiu a fost a doua școală de film și cea cu care am rezonat perfect. Îmi plăcea documentarul, simțeam ceea ce francezii numesc „cinema direct” și am avut bucuria și norocul să ajung în ograda lui și să primesc certitudinea că direcția pe care o simțeam era una justă. Nu doar că am primit această confirmare, dar lucrurile au căpătat o dimensiune aproape de neegalat în privința cunoștințelor pe care le-am primit.</p>
                    <p>Puiu este foarte generos. E unul dintre foarte puținii regizori cu care am lucrat, care explică în totalitate ceea ce face și care este scopul, adică de ce trebuie să faci lucrurile într-un anumit fel. Făcea asta pentru toată echipa, nu numai pentru mine că eram la început, pentru toată lumea era un șir nesfârșit de explicații. Ca să poți lua decizii, trebuie să cunoști conceptul, iar el are acest dar de a-l împărți cu echipa.</p>
                    <p>Așa cum e exigent cu el și cu proiectele lui, Cristi vrea ca și echipa cu care lucrează să fie la fel de exigentă și de implicată. Nu e ușor, dar are dreptate: un film în care nu te implici 100% nu are cum să atingă perfecțiunea.</p>
                    <p>Mă consider norocos și cred că viața îți oferă foarte puține ocazii în care ți se deschid niște porți. Dacă ești pe fază ți se întâmplă și lucruri bune.</p>
                    <p><strong>Pentru acest domeniu, vi se pare importantă prezenţa activă a unui mentor? Există vreo persoană căreia să îi mulţumiţi pentru că v-a ghidat primii paşi în carieră?</strong></p>
                    <p>Da, cred că e Cristi. A fost mult mai mult decât o colaborare într-o echipă de filmare. Au fost niște ani pe care i-am petrecut în jurul lui, începând cu <em>Aurora</em> până la <em>Sieranevada</em>, cred că au fost cel puțin 4-5 ani. Dacă ar fi să socotesc în felul ăsta, el a avut cea mai mare influență asupra mea.</p>
                    <p><strong>Cum a reacţionat familia dumneavoastră când le-aţi spus că doriţi să daţi admitere la facultatea de film? Aveţi printre rude persoane care au tangenţe cu meseria dumneavoastră?</strong></p>
                    <p>Eu am plecat de acasă când aveam 18 ani și nu prea am mai dat socoteală pentru nimic. Pot spune că atunci mi-am luat zborul și deciziile care au urmat au fost exclusiv ale mele. Nu am pe nimeni în familie în domeniul ăsta și aș zice că a fost un accident că am ajuns să fac film.</p>
                    <p>La momentul la care am intrat la facultate, eram căsătorit, iar decizia am luat-o la sugestia soției. Îmi plăcea foarte mult fotografia, voiam să aprofundez acest domeniu, iar într-o discuție, Oana m-a încurajat să urmez o facultate. Inițial am vrut să dau admiterea la Arte, dar m-am întâlnit cu niște colegi care erau mai mari și studiau deja la UNATC, cumpăram hârtie foto de la ei, le rămăsese de la examene. Ei mi-au zis că în primii doi ani, la UNATC se face un curs de fotografie foarte bun. Așa am ajuns să dau admiterea cu gândul că peste 2 ani mă voi ocupa doar de fotografie, dar ce să vezi, în timpul ăsta am trecut și prin echipa de filmare. A început să îmi placă și filmul, așa că am rămas.</p>
                    <p><strong>Ce filme vă amintiţi din copilărie? Cred că pe fiecare ne marchează unele filme văzute în perioada asta a vieţii.</strong></p>
                    <p>Primul film care m-a marcat e <em>Mihai Viteazul</em>, sună foarte brutal și poate nedemn de o listă întreagă de capodopere cinematografice, dar trebuie să pun în context faptul că în copilărie, televizorul aproape că nu exista, în comunism nu vedeai la televizor decât nişte seriale cehești, ungurești, poloneze. Erau 2 ore de emisiune în fiecare zi, din care jumătate era laudatio pentru Nicolae Ceaușescu. Apoi mai trebuie spus că generația mea a crescut fără prea multă supraveghere de foarte devreme.</p>
                    <p>Pe mine și pe soră-mea, părinții ne-au lăsat singuri acasă de la 7 ani. Vacanțele de vară le petreceam afară toată ziua. Intram și la cinema. Până și acolo era un singur film pe săptămână. Eram mai mulți copii și primul rând era preferatul nostru. Primul film pe care mi-l amintesc în sala de cinema a fost <em>Mihai Viteazul</em>: era un ecran imens, din cea mai mare sală de cinema a orașului. Când a apărut Mihai Viteazul pe cal, Amza Pellea, m-a impresionat atât de tare, mai era și color - noi aveam televizoare alb-negru acasă. Era ceva ce nu puteam să îmi imaginez. Era un univers în care nu aveai acces, nu puteai să intri. Cumpăram un bilet și vedeam filmele de 2-3 ori. Ne rugam de doamnele de la cinematograf să ne mai lase să-l vedem și a doua zi. Și ne lăsau. Ne puneau ca, în momentul în care urmează să se sfârșească filmul, să ne ridicăm primii și tragem draperiile. Erau draperiile de la cele două uși de ieșire care opreau lumina să intre în sală. Întotdeauna mă lua prin surprindere că dincolo de draperiile astea era zi și cu totul altă lume. Le făceam lor serviciul ăsta și ne lăsau să revedem filmul. Asta era convenția.</p>
                    <p>Atunci nu mi-am dat seama ce influență a avut cinema-ul pentru mine.</p>
                    <p><strong>Aveţi un model în cinematografie?</strong></p>
                    <p>Nu am avut niciodată un model, am fost persoana care nu a fost niciodată fanul unei trupe. Eram invidios că în jurul meu aveam oameni care ziceau că sunt fani Depeche Mode și Pet Shop Boys. Le-am ascultat și eu, mi-au plăcut, doar că niciodată nu am reușit să fiu fan al unui singur artist.</p>
                    <p>Am o listă mai mare de oameni de la care mi-a plăcut câte ceva. În cazul întrebării tale sunt câțiva regizori: începând de la noi de acasă, mi se pare că Puiu este preferatul meu din cinematografia românească, sigur că mai există și alții cu care am și colaborat care au anumite titluri care îmi plac foarte mult. Din cinema-ul european- Bruno Dumont este unul dintre preferații mei, alături de Lars von Trier care îmi place foarte tare. Noul val francez și perioada aia cu multe abateri de la reguli, pot spune că Éric Rohmer e acela care îmi place cel mai mult, dar cu toții fac parte dintr-o mișcare destul de omogenă.</p>
                    <p>Îmi plac documentariștii foarte tare, Raymond Depardon, care după mine este unul dintre exponenții acestui Cinema Direct. De la școala suedeză, Ingmar Bergman e un capitol aparte. Din Asia îmi place Apichatpong Weerasethakul. Dacă intrăm în zona de cinema mainstream pot spune că îmi plac Martin Scorsese, John Cassavetes, care deși la origine este actor a fost un regizor fantastic și, la fel, David Fincher e incredibil, la fel Paul Thomas Anderson.</p>
                    <p>Nu sunt influențat doar de regizori, ci în general de oameni, fie că sunt arhitecți, filosofi, gânditori, operatori. Trebuie să menționez și operatori: aș alege pe Robby Muller și Roger Deakins.</p>
                    <p><strong>Din perspectiva directorului de imagine, ce aţi considera că reprezintă cea mai mare dificultate pentru producerea unui film?</strong></p>
                    <p>Cea mai mare dificultate este realizarea conceptului imaginii filmului. Dau un exemplu: e foarte ușor să spui: ""văd acest film în alb - negru"". Conceptul imaginii unui film e mult mai mult de atât. Unde e așezat aparatul, înălțimea lui, cum miști aparatul, de ce îl miști așa, când il miști și când nu? Apoi paleta de culori, tipul de lumină, raportul de contraste de iluminare, și multe alte detalii. Toate astea ajung să fie puse, înainte de a începe filmarea, într-un concept. Conceptul ăsta este o înlănțuire de ingrediente pe care, dacă le alegi înțelept, reușești să te apropii de viziunea regizorului, de a amplifica anumite relații, de a crea niște emoții care să avantajeze povestea și personajele. Toate par înfricoșătoare, mai ales la început, dar, dacă pui multe întrebări și în special întrebările corecte, ai șansa să găsești deja niște răspunsuri care vor elimina o bună parte din problemă.</p>
                    <p>Să le faci pe toate bine, să slujească filmului, să fie unic și să te reprezinte. Mi se pare foarte complicat și mi-a luat ceva să înțeleg toate astea. Până la urmă, dacă nu ar fi atât de complicat nici nu ar fi motivant să faci un film.</p>",
                    Categories = new[] { new Category { Alias = "interviu", Name = "Interviu" } },
                    Created = new DateTime(year: 2022, month: 5, day: 12),
                    ImageUrl = new Uri("/assets/img/interviu-luchian-ciobanu.png", UriKind.Relative),
                    Title = "Interviu cu Luchian Ciobanu",
                },
                ["dolores-no-illum magna-sanctus-et-lorem-enim-te-quod-accusam-duo"] = new Article
                {
                    Author = new Author
                    {
                        Alias = "john-doe",
                        Title = "John Doe"
                    },
                    Title = "Dolores no illum magna sanctus et lorem enim te quod accusam duo",
                    Description = "Elitr enim consetetur erat eos vel sea sed nonumy elitr lobortis lorem invidunt nisl. Facilisi erat rebum rebum sed est augue et possim nonummy invidunt elitr consequat sed sea accusam nonumy.",
                    ImageUrl = new Uri("/assets/img/home-bg.jpg", UriKind.Relative),
                    Created = new DateTime(year: 2022, month: 5, day: 3),
                },
                ["et-delenit-dignissim-facilisis-tempor-voluptua"] = new Article
                {
                    Author = new Author
                    {
                        Alias = "john-doe",
                        Title = "John Doe"
                    },
                    Title = "Et delenit dignissim facilisis tempor voluptua",
                    Description = "Ea sea sadipscing amet facilisis justo aliquam labore. Invidunt justo elitr nonumy at sed. Vulputate ut voluptua diam id magna sed lobortis sed ut molestie justo amet est. Diam dolore sanctus stet vel et.",
                    ImageUrl = new Uri("/assets/img/about-bg.jpg", UriKind.Relative),
                    Created = new DateTime(year: 2022, month: 5, day: 2),
                },
                ["diam-nihil-sanctus-ipsum-gubergren-sit-eos-ut-exerci"] = new Article
                {
                    Author = new Author
                    {
                        Alias = "john-doe",
                        Title = "John Doe"
                    },
                    Title = "Diam nihil sanctus ipsum gubergren sit eos ut exerci",
                    Description = "Justo nam amet dolore takimata lorem minim sit sea eirmod ipsum tempor diam no ipsum. Duis velit dolore diam voluptua at esse nulla facilisis exerci gubergren laoreet dolor dolore ea diam. Dolor ut nonumy eu eos.",
                    ImageUrl = new Uri("/assets/img/contact-bg.jpg", UriKind.Relative),
                    Created = new DateTime(year: 2022, month: 5, day: 1),
                },
                ["est-erat-enim-diam-labore-ipsum-aliquyam-dignissim"] = new Article
                {
                    Author = new Author
                    {
                        Alias = "john-doe",
                        Title = "John Doe"
                    },
                    Title = "Est erat enim diam labore ipsum aliquyam dignissim",
                    Description = "Diam lorem rebum dolor consetetur eos sea tempor amet dolor erat dolore iusto sanctus liber duis et laoreet. Rebum accumsan in dolor vero suscipit vel justo dolor. Et sit duo in duo justo vero.",
                    ImageUrl = new Uri("/assets/img/post-bg.jpg", UriKind.Relative),
                    Created = new DateTime(year: 2022, month: 5, day: 1),
                },
                ["accusam-sanctus-iriure-duis-kasd"] = new Article
                {
                    Author = new Author
                    {
                        Alias = "john-doe",
                        Title = "John Doe"
                    },
                    Title = "Accusam sanctus iriure duis kasd",
                    Description = "Dolore lorem volutpat et kasd ipsum rebum cum sea et ut magna. No duo sed elitr. Eos et te rebum. Labore lobortis diam sit autem diam tempor eirmod in sed elitr sit gubergren sea ut. Kasd takimata consequat sit clita eu facilisis lorem no et aliquyam clita iriure eirmod amet nulla labore lorem accusam.",
                    ImageUrl = new Uri("/assets/img/astronaut.jpg", UriKind.Relative),
                    Created = new DateTime(year: 2022, month: 4, day: 29),
                },
            };

        public Task<Article[]> GetAllAsync() =>
            Task.FromResult(_articlesByAlias.Values.OrderByDescending(a => a.Created).ToArray());

        public Task<Article?> GetByAliasAsync(string alias) => Task.FromResult(GetByAlias(alias));

        public Task<Article[]> GetByAuthorAsync(string authorId) =>
            Task.FromResult(_articlesByAlias.Values.Where(a => a.Author.Alias == authorId).ToArray());

        private static Article? GetByAlias(string alias)
        {
            if (_articlesByAlias.ContainsKey(alias))
            {
                return _articlesByAlias[alias];
            }

            return default;
        }
    }
}
