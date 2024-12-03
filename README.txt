GUIA ENDPOINTS ContactsAdmin

1- GET Contacts
Trae todos los contactos de la base. No requiere ingresar ningun dato.

2- POST Contacts
Inserta nuevo contacto en la base. Hay que ingresar Nombre, Empresa, Email, Telefono

3- GET Contacts(id)
Trae contacto por Id. Se debe proporcionar el Id del contacto y se busca en la base.

4-PUT Contacts(id)
Actualiza contacto existente

5-DELETE Contacts(id)
Borra contacto de la base.

6-GET Contacts(email)
Trae contacto por email.

7-GET Contacts (telefono)
Trae contacto por telefono

--------------------------------------------------------------------------------------

Crear una REST API desde 0 fue desafiante para mi, ya que en el pasado me habia tocado testear endpoints con Postman o modificar APIs pero no desde 0.
Lo que mas me costo fue entender el funcionamiento de los Token, lo cual pude resolver con Identity.
Lo que no pude realizar fue agregar los atributos que debia tener "Usuario", en mi caso solo tiene Email y Contraseña.
Se que tengo muchas cosas por mejorar y aprender, esto fue lo que logre en estos dias.
Gracias por la oportunidad!



