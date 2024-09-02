# PharmaQuest

![Oficina3](https://github.com/user-attachments/assets/6d387aa3-69a7-46c4-81bf-8ef8aca5a700)

Enlace que redirige al drive donde se encuentra la parte gráfica y las tomas de pantalla
de las integraciones con Avalanche.

https://drive.google.com/drive/folders/120dHRgvgPxJ7X4H69dG1l6iX6yRzv-f7?usp=sharing

<h2> ¿Qué es PharmaQuest? </h2>

Es un juego educativo elaborado principalmente para los estudiantes de medicina, el cual permite profundizar en
el uso de los diferentes medicamentos para el tratamiento de diversos síntomas.

Las ventajas de este juego no recaen únicamente en la enseñanza de la manipulación de dichos medicamentos, sino
que puede resultar siendo una plataforma efectiva para las diferentes farmacéiticas a la hora de querer promoverm
visualizar y enseñar sobre sus productos.

PharmaQuest fue exportado para ser usado en la web, en formato WEBGL, lo que permite la escalabilidad, el fácil acceso y la no 
necesidad de requerimientos de hardware.

<h2>¿Cómo se juega?</h2>

El jugador debe poner atención a los síntomas que aparecen en la pantalla y debe elegir el medicamento que pueda curarlos. Se selecciona uno de los medicamentos, 
luego se hace clic debajo de la imagen del paciente y finalmente se interactúa con la flecha verde. Si es correcto el medicamento, el síntoma aparece con un signo verde,
mientras que si es equivocado, la imagen del paciente cambia y el tiempo se reduce.

Luego de que todos los síntomas tengan el signo verde visible, se hace clic en el botón de Next y se continúa jugando. Así mismo existen ayudas, las cuales cuestan píldoras; enre ellas se encuentran
el reloj, que suma tiempo y el desfibrilador, que permite tener una oportunidad más antes que se acabe el tiempo.

<h2>Modos de juego</h2>

PharmaQuest plantea tres modos de juegos:

* Modo historia: en este modo se plantea incluir historias que tienen lugar en diferentes entornos, cada uno que podría ser foco de diferentes infecciones y enfermedades.
El jugador completará las historias y ganará diferentes NFTs al hacerlo.

* Modo Arcade: aquí podrán jugar de manera ilimitada, curando paciuentes y obteniendo los primeros lugares con la mayor cantidad de pacientes salvados. Aquí será posible
personalizar la interfaz haciendo uso de las skins adquiridas con las monedas del juego.

* Modo Multijugador: dos prospectos de médicos lucharán para ver cuál de ellos es el que logra curar a la mayor cantidad de pacientes.

 <h2>¿En qué está elaborado?</h2>

El videojuego está elaborado en el motor Unity, y programadas sus mecániocas en lenguaje C#. La párte artística usó elementos
de IA y fue manipulada usando programas de diseño como Adobe Illustrator. El backend de implementación de Web3 fue desarrollado haciendo uso de IDE 
Visual Studio y fue programado en lenguajes como Solidity.

<h2>¿Cómo se implementa o se planea seguir implementando la Web3 en el juego?</h2>

Píldoras: moneda común del juego. Se gana completando tareas diarias,
semanales, y mensuales.

Botiquines: moneda premium, que se puede usar para comprar píldoras, medicinas
especiales, y NFTs.

<h1>NFTs:</h1>

* Medallas: NFT con habilidades especiales (e.g., bonificación de tiempo, aumento de
píldoras ganadas). Se pueden seleccionar hasta 3 por partida.

* Personalización del Consultorio: NFTs que personalizan la estética del consultorio.

* Medallas Especiales: NFTs ganadas al completar el modo historia, con habilidades
adicionales.

<h4>Integración con la Blockchain de Avalanche:</h4>

* Conexión con Blockchain: decidir si la integración con Avalanche se hará
principalmente desde el lado del servidor (backend) o directamente desde Unity (el
motor del juego).

Uso de Bibliotecas:

* Para Unity: explorar bibliotecas como Nethereum para manejar contratos
inteligentes y transacciones directamente desde C#.

* Para la Página Web: posiblemente utilizar Web3.js o Ethers.js para interactuar
con la blockchain desde el front-end (HTML, CSS, JS).

* Smart Contracts: necesitaremos desarrollar contratos inteligentes en Solidity para
manejar las monedas, NFTs, y cualquier otra funcionalidad blockchain.

  <h3>Política Monetaria</h3>

<h4>Objetivos:</h4>
   
Estabilidad Económica: asegurar que la economía del juego no se infle o desinfle
demasiado rápido, manteniendo un balance en la cantidad de monedas en circulación.
Incentivos para Jugadores: Motivar a los jugadores a seguir participando en las tareas y
desafíos diarios, semanales, y mensuales para ganar Píldoras.

Control de la Oferta de Botiquines: regular la cantidad de Botiquines que se pueden
obtener para evitar que se devalúen.

Valorización de NFTs: mantener un valor estable y atractivo para los NFTs, asegurando
que las habilidades y personalizaciones que otorgan sean valiosas.

<h4>Distribución de Monedas:</h4>
    
* Píldoras:

Tareas Diarias: cada día, el jugador puede ganar una cantidad fija de Píldoras
completando ciertas tareas (e.g., tratar un número específico de pacientes).
Tareas Semanales: Completar un conjunto de tareas diarias durante la semana
otorga una bonificación en Píldoras.

Tareas Mensuales: cumplir con todas las tareas semanales en un mes otorga
una bonificación aún mayor.

Límite Diario: establecer un límite en la cantidad de Píldoras que un jugador puede
ganar en un día para evitar la inflación.

Gastos de Píldoras: las Píldoras se pueden gastar en medicamentos regulares y
en mejoras básicas dentro del juego.

* Botiquines:
  
Obtención Limitada: los Botiquines son más escasos y se pueden obtener solo a
través de logros especiales, compras dentro del juego, o eventos únicos.

Intercambio con Píldoras: permitir que los jugadores intercambien Botiquines por
Píldoras, pero con una tasa que desincentive la acumulación excesiva de Botiquines.

Usos Especiales: los Botiquines se pueden usar para comprar medicamentos
especiales, NFTs, y otras mejoras premium que no se pueden adquirir con Píldoras.

<h4>Inflación y Deflación:</h4>

* Mecanismos Anti-Inflación: control de la Emisión: Limitar la cantidad de Píldoras y Botiquines en circulación.
Tasa de Intercambio Dinámica: Ajustar la tasa de intercambio entre Botiquines y
Píldoras según la demanda.

* Mecanismos Anti-Deflación: incentivos de Gasto: Crear incentivos para que los jugadores gasten sus monedas
en lugar de acumularlas (e.g., descuentos temporales, objetos exclusivos).
Eventos Especiales: Introducir eventos en el juego donde se recompense a los
jugadores por gastar sus monedas.

<h4>Valoración y Escasez de NFTs:</h4>

* Ediciones Limitadas: crear NFTs con ediciones limitadas para asegurar que se
mantengan valiosos.

* Ciclo de Lanzamiento de NFTs: introducir nuevos NFTs periódicamente para mantener
el interés de los jugadores.

* NFTs con Usos Únicos: algunos NFTs podrían tener usos limitados o caducidad para
asegurar que se mantenga la demanda de nuevos NFTs.

<h4>Monitoreo y Ajustes:</h4>

* Métricas Clave: monitorear constantemente métricas como la tasa de inflación de
monedas, la cantidad de transacciones de NFTs, y la cantidad de monedas acumuladas
por jugadores.

* Ajustes Periódicos: establecer revisiones periódicas de la política monetaria y ajustar
según sea necesario para mantener el equilibrio económico

<h4>Comunicación con los Jugadores:</h4>

* Transparencia: mantén a los jugadores informados sobre las políticas monetarias y
cualquier cambio que se realice.

* Participación de la Comunidad: considera permitir que los jugadores voten sobre
ciertos aspectos de la política monetaria, para aumentar su compromiso.

<h2>Medicamentos usados en el juego:</h2>

Este es un prototipo que no tuvo mentoría por parte de expertos en farmacéutica o medicina. Si
el juego avanza en su producción, se pretende contar con personas expertas en estas áreas para que puedan actuar de consultoras a la hora
de implementar los diferentes medicamentos y los síntomas que tratan.

<h3>Amoxicilina:</h3> la amoxicilina es un antibiótico de la familia de las penicilinas, utilizado para tratar infecciones bacterianas como infecciones del oído, respiratorias, y urinarias. Actúa inhibiendo la síntesis de la pared celular bacteriana.

<h3>Cetirizina:</h3> la cetirizina es un antihistamínico de segunda generación, utilizado para aliviar los síntomas de alergias como la rinitis alérgica y la urticaria. 

<h3>Protopic:</h3> Protopic es un medicamento inmunomodulador tópico que contiene tacrolimus, utilizado para tratar el eczema atópico (dermatitis) en casos moderados a graves. 

<h3>Ibuprofeno:</h3> el ibuprofeno es un medicamento antiinflamatorio no esteroideo (AINE) que se usa para aliviar el dolor, la inflamación y la fiebre. 

<h3>Calmidol:</h3> Calmidol es un medicamento que combina ibuprofeno con un antiespasmódico (clorhidrato de lisina) y cafeína, utilizado principalmente para aliviar el dolor menstrual y los síntomas asociados, como calambres y malestar general. 

<h3>Bentyl:</h3> Bentyl es un medicamento que contiene diciclomina, un antiespasmódico que se utiliza para tratar el síndrome del intestino irritable (SII). 

<h3>Chloraseptic:</h3> Chloraseptic es un anestésico tópico utilizado para aliviar el dolor de garganta y la irritación bucal.

<h3>Tylenol:</h3> Tylenol es un medicamento que contiene acetaminofén (paracetamol), utilizado para aliviar el dolor leve a moderado y reducir la fiebre.

<h3>Electrolit:</h3> Electrolit es una bebida de rehidratación oral que contiene electrolitos y glucosa, diseñada para reponer líquidos y minerales perdidos por deshidratación debido a diarrea, vómitos, ejercicio intenso, o calor extremo.

<h3>Apronax:</h3> Apronax es un medicamento que contiene naproxeno, un antiinflamatorio no esteroideo (AINE) utilizado para aliviar el dolor, la inflamación y la fiebre.

<h3>Fosfomicina:</h3> la fosfomicina es un antibiótico utilizado para tratar infecciones del tracto urinario, como la cistitis.

<h3>Dramamine:</h3> Dramamine es un medicamento que contiene dimenhidrinato, un antihistamínico utilizado para prevenir y tratar el mareo por movimiento y las náuseas.

<h3>Terbinafina:</h3> la terbinafina es un antimicótico utilizado para tratar infecciones fúngicas de la piel, uñas y cabello, como el pie de atleta y la onicomicosis.

<h3>Kaopectate:</h3> Kaopectate es un medicamento utilizado para tratar la diarrea y las molestias estomacales. Contiene kaolin y pectina, que ayudan a absorber líquidos y reducir la inflamación en el tracto gastrointestinal.

<h3>Restasis:</h3> Restasis es un medicamento oftálmico que contiene ciclosporina A, utilizado para tratar la sequedad ocular crónica al aumentar la producción de lágrimas en los ojos.

<h3>Bisolvón:</h3> Bisolvón es un medicamento utilizado para aliviar la tos productiva y facilitar la eliminación del moco en las vías respiratorias.

<h3>Capsaicina:</h3> la capsaicina es un compuesto activo en los chiles que se utiliza en cremas tópicas para aliviar el dolor, especialmente en condiciones como la artritis y el dolor neuropático.

<h3>Prometazina:</h3> la prometazina es un antihistamínico que se utiliza para tratar alergias, náuseas, y síntomas del resfriado, además de ser un sedante en algunos casos.

<h3>NyQuil:</h3> NyQuil es un medicamento combinado utilizado para aliviar los síntomas del resfriado y la gripe, como la tos, el dolor de garganta y la congestión.

<h3>Esmolol:</h3> el esmolol es un betabloqueador utilizado para controlar la frecuencia cardíaca y tratar la hipertensión y la taquicardia en situaciones agudas.

<h3>Metamucil:</h3> Metamucil es un suplemento de fibra que contiene psyllium, utilizado para mejorar la regularidad intestinal y aliviar el estreñimiento. 

<h3>Carafate:</h3> Carafate es un medicamento que contiene sucralfato, utilizado para tratar úlceras gástricas y duodenales.

<h3>Bepanthol:</h3> Bepanthol UQ es una crema que contiene dexpanthenol, utilizada para hidratar y proteger la piel seca y dañada.

<h3>Isodine:</h3> Isodine es una solución antiséptica que contiene povidona yodada, utilizada para desinfectar heridas y prevenir infecciones.
