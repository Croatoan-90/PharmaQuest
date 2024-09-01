# PharmaQuest

Enlace que redirige al drive donde se encuentra la parte gráfica y las tomas de pantalla
de las integraciones con Avalanche.

https://drive.google.com/drive/folders/120dHRgvgPxJ7X4H69dG1l6iX6yRzv-f7?usp=sharing

<h2> ¿Qué es Pharmaquest? </h2>

Es un juego educativo elaborado principalmente para los estudiantes de medicina, el cual permite profundizar en
el uso de los diferentes medicamentos para el tratamiento de diversos síntomas.

Las ventajas de este juego no recaen únicamente en la enseñanza de la manipulación de dichos medicamentos, sino
que puede resultar siendo una plataforma efectiva para las diferentes farmacéiticas a la hora de querer promoverm
visualizar y enseñar sobre sus productos.

PharmaQuest fue exportado para ser usado en la web, en formato WEBGL, lo que permite la escalabilidad, el fácil acceso y la no 
necesidad de requerimientos de hardware.

<h2>modos de juego</h2>

PharmaQuest plantea tres modos de juegos:

* Modo historia: en este modo se plantea incluir historias que tienen lugar en diferentes entornos, cada uno que podría ser foco de diferentes infecciones y enfermedades.
El jugador completará las historias y ganará diferentes NFTs al hacerlo.

*Modo Arcade: aquí podrán jugar de manera ilimitada, curando paciuentes y obteniendo los primeros lugares con la mayor cantidad de pacientes salvados. Aquí será posible
personalizar la interfaz haciendo uso de las skins adquiridas con las monedas del juego.

*Modo Multijugador: dos prospectos de médicos lucharán para ver cuál de ellos es el que logra curar a la mayor cantidad de pacientes.

 <h2>¿En qué está elaborado?</h2>

El videojuego está elaborado en el motor Unity, y programadas sus mecániocas en lenguaje C#. La párte artística usó elementos
de IA y fue manipulada usando programas de diseño como Adobe Illustrator. El backend de implementación de Web3 fue desarrollado haciendo uso de IDE 
Visual Studio y fue programado en lenguajes como Solidity.

<h2>¿Cómo se implementa o se planea seguir implementando la Web3 en el juego?</h2>

Píldoras: moneda común del juego. Se gana completando tareas diarias,
semanales, y mensuales.
Botiquines: Moneda premium, que se puede usar para comprar píldoras, medicinas
especiales, y NFTs.
NFTs:
Medallas: NFT con habilidades especiales (e.g., bonificación de tiempo, aumento de
píldoras ganadas). Se pueden seleccionar hasta 3 por partida.
Personalización del Consultorio: NFTs que personalizan la estética del consultorio.
Medallas Especiales: NFTs ganadas al completar el modo historia, con habilidades
adicionales.

<h4>Integración con la Blockchain de Avalanche:</h4>

* Conexión con Blockchain: Decidir si la integración con Avalanche se hará
principalmente desde el lado del servidor (backend) o directamente desde Unity (el
motor del juego).
Uso de Bibliotecas:
* Para Unity: Explorar bibliotecas como Nethereum para manejar contratos
inteligentes y transacciones directamente desde C#.
* Para la Página Web: Posiblemente utilizar Web3.js o Ethers.js para interactuar
con la blockchain desde el front-end (HTML, CSS, JS).
* Smart Contracts: Necesitaremos desarrollar contratos inteligentes en Solidity para
manejar las monedas, NFTs, y cualquier otra funcionalidad blockchain.

  <h3>Política Monetaria</h3>

<h4>Objetivos:</h4>
   
Estabilidad Económica: Asegurar que la economía del juego no se infle o desinfle
demasiado rápido, manteniendo un balance en la cantidad de monedas en circulación.
Incentivos para Jugadores: Motivar a los jugadores a seguir participando en las tareas y
desafíos diarios, semanales, y mensuales para ganar Píldoras.

Control de la Oferta de Botiquines: Regular la cantidad de Botiquines que se pueden
obtener para evitar que se devalúen.

Valorización de NFTs: Mantener un valor estable y atractivo para los NFTs, asegurando
que las habilidades y personalizaciones que otorgan sean valiosas.

<h4>Distribución de Monedas:</h4>
    
* Píldoras:

Tareas Diarias: Cada día, el jugador puede ganar una cantidad fija de Píldoras
completando ciertas tareas (e.g., tratar un número específico de pacientes).
Tareas Semanales: Completar un conjunto de tareas diarias durante la semana
otorga una bonificación en Píldoras.

Tareas Mensuales: Cumplir con todas las tareas semanales en un mes otorga
una bonificación aún mayor.

Límite Diario: Establecer un límite en la cantidad de Píldoras que un jugador puede
ganar en un día para evitar la inflación.

Gastos de Píldoras: Las Píldoras se pueden gastar en medicamentos regulares y
en mejoras básicas dentro del juego.

* Botiquines:
  
Obtención Limitada: Los Botiquines son más escasos y se pueden obtener solo a
través de logros especiales, compras dentro del juego, o eventos únicos.

Intercambio con Píldoras: Permitir que los jugadores intercambien Botiquines por
Píldoras, pero con una tasa que desincentive la acumulación excesiva de Botiquines.

Usos Especiales: Los Botiquines se pueden usar para comprar medicamentos
especiales, NFTs, y otras mejoras premium que no se pueden adquirir con Píldoras.

<h4>Inflación y Deflación:</h4>

* Mecanismos Anti-Inflación: Control de la Emisión: Limitar la cantidad de Píldoras y Botiquines en circulación.
Tasa de Intercambio Dinámica: Ajustar la tasa de intercambio entre Botiquines y
Píldoras según la demanda.

* Mecanismos Anti-Deflación: Incentivos de Gasto: Crear incentivos para que los jugadores gasten sus monedas
en lugar de acumularlas (e.g., descuentos temporales, objetos exclusivos).
Eventos Especiales: Introducir eventos en el juego donde se recompense a los
jugadores por gastar sus monedas.

<h4>Valoración y Escasez de NFTs:</h4>

* Ediciones Limitadas: Crear NFTs con ediciones limitadas para asegurar que se
mantengan valiosos.

* Ciclo de Lanzamiento de NFTs: Introducir nuevos NFTs periódicamente para mantener
el interés de los jugadores.

* NFTs con Usos Únicos: Algunos NFTs podrían tener usos limitados o caducidad para
asegurar que se mantenga la demanda de nuevos NFTs.

<h4>Monitoreo y Ajustes:</h4>

* Métricas Clave: Monitorear constantemente métricas como la tasa de inflación de
monedas, la cantidad de transacciones de NFTs, y la cantidad de monedas acumuladas
por jugadores.

* Ajustes Periódicos: Establecer revisiones periódicas de la política monetaria y ajustar
según sea necesario para mantener el equilibrio económico

<h4>Comunicación con los Jugadores:</h4>

* Transparencia: Mantén a los jugadores informados sobre las políticas monetarias y
cualquier cambio que se realice.

* Participación de la Comunidad: Considera permitir que los jugadores voten sobre
ciertos aspectos de la política monetaria, para aumentar su compromiso.

<h2>Meidcamentos usados en el juego</h2>

Este es un prototipo del juego que no tuvo mentor[ia por parte de alg[un experto en farmac[eutica ni medicina. Si
el juego avanza en su producci[on se pretende contar con personas experta en el [area para que puedan actuar de consultoras a la hora
de implementar los diferentes medicamentos y los s[intomas que tratan.
