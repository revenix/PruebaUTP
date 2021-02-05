# PruebaUTP

Crear la base de datos con el Script adjunto al correo y sus inserts de Usuarios.
NOTA:password almacenado en SHA256 en la tabla [Usuario] de la Base de datos [BDNotas]

Modificar la cadena de conexion de la fuente del proyecto en el archivo:
WSPruebaUTP > Models > BDNotasContext > "Server=INGRESAR_SERVIDOR_LOCAL;Database=BDNotas;Trusted_Connection=True;"

Endpoints: 

1 - Login 
https://localhost:44391/api/usuario/login

BODY: ingresar

{"Email":"i202101@edu.pe",
 "Password":"contra2021"
}

NOTA:password almacenado en SHA256 en Base de datos

obtener el token para realizar las consultas en los endpoints. 

img Ejemplo: http://prntscr.com/ydo1ya

2 - Crear Notas

https://localhost:44391/api/nota/crear

BODY: ingresar(ejemplo):

{"idUsuario":2,
 "nota1":12,
 "nota2":15,
 "nota3":13,
 "nota4":18
}

Authorization: tipo "Bearer token" > ingresar el token generado en el login.

IMG Ejemplo Endpoint : http://prntscr.com/ydo77c
IMG Ejemplo Ingresar Token : http://prntscr.com/ydodpv

3 - Listar Notas por Usuario por ID (Ejm: 1 , 2)

https://localhost:44391/api/nota/1
https://localhost:44391/api/nota/2 

Authorization: tipo "Bearer token" > ingresar el token generado en el login.
IMG Ejemplo Ingresar Token : http://prntscr.com/ydodpv

