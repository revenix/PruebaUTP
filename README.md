# PruebaUTP

Crear la base de datos con el Script adjunto al correo.

Modificar la cadena de conexion de la fuente del proyecto en el archivo:
WSPruebaUTP > Models > BDNotasContext > "Server=INGRESAR_SERVIDOR_LOCAL;Database=BDNotas;Trusted_Connection=True;"

Endpoints: 

1 - Login 
https://localhost:44391/api/usuario/login

en el body ingresar:

{"Email":"i202102@edu.pe",
 "Password":"contra2021"
}

NOTA:password almacenado en SHA256 en Base de datos

obtener el token para realizar las consultas. 

2 - Crear Notas

https://localhost:44391/api/nota/crear

Body: ingresar(ejemplo):

{"idUsuario":2,
 "nota1":12,
 "nota2":15,
 "nota3":20,
 "nota4":20
}

Authorization: tipo "Bearer token" > el token generado en el login.

3 - Listar Notas

https://localhost:44391/api/nota/2

Authorization: tipo "Bearer token" > el token generado en el login.

