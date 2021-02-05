<p># PruebaUTP</p>
<p><br></p>
<p>Crear la base de datos con el Script adjunto al correo y sus inserts de Usuarios.</p>
<p>NOTA:password almacenado en SHA256 en la tabla [Usuario] de la Base de datos [BDNotas]</p>
<p><br></p>
<p>Modificar la cadena de conexion de la fuente del proyecto en el archivo:</p>
<p>WSPruebaUTP &gt; Models &gt; BDNotasContext &gt; &quot;Server=INGRESAR_SERVIDOR_LOCAL;Database=BDNotas;Trusted_Connection=True;&quot;</p>
<p>Endpoints: &nbsp;</p>
<p>1 - Login &nbsp;</p>
<p>https://localhost:44391/api/usuario/login&nbsp;</p>
<p>BODY: ingresar</p>
<p>{&quot;Email&quot;:&quot;i202101@edu.pe&quot;,</p>
<p>&nbsp;&quot;Password&quot;:&quot;contra2021&quot;</p>
<p>}</p>
<p>&nbsp;</p>
<p>NOTA:password almacenado en SHA256 en Base de datos&nbsp;</p>
<p>obtener el token para realizar las consultas en los endpoints.</p>
<p>img Ejemplo: http://prntscr.com/ydo1ya&nbsp;</p>
<p>2 - Crear Notas</p>
<p>https://localhost:44391/api/nota/crear&nbsp;</p>
<p><br></p>
<p>BODY: ingresar(ejemplo):</p>
<p><br></p>
<p>{&quot;idUsuario&quot;:2,</p>
<p>&nbsp;&quot;nota1&quot;:12,</p>
<p>&nbsp;&quot;nota2&quot;:15,</p>
<p>&nbsp;&quot;nota3&quot;:13,</p>
<p>&nbsp;&quot;nota4&quot;:18</p>
<p>}</p>
<p><br></p>
<p>Authorization: tipo &quot;Bearer token&quot; &gt; ingresar el token generado en el login.&nbsp;</p>
<p><br></p>
<p>IMG Ejemplo Endpoint : http://prntscr.com/ydo77c</p>
<p>IMG Ejemplo Ingresar Token : http://prntscr.com/ydodpv</p>
<p><br></p>
<p>3 - Listar Notas por Usuario por ID (Ejm: 1 , 2)</p>
<p><br></p>
<p>https://localhost:44391/api/nota/1</p>
<p>https://localhost:44391/api/nota/2</p>
<p><br></p>
<p>Authorization: tipo &quot;Bearer token&quot; &gt; ingresar el token generado en el login.&nbsp;</p>
<p>IMG Ejemplo Ingresar Token : http://prntscr.com/ydodpv</p>
