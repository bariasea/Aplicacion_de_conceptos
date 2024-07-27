BASE DE DATOS IMPLEMENTADA:
![image](https://github.com/user-attachments/assets/1a6d98da-8dea-47fb-a78a-5bf17694903e)



Para el siguiente ejercicio se solicita la aplicación de conceptos establecidos en clase, en la cual define una aplicación web de notas programada en c# para lo cual tenemos estas imágenes de resultado la aplicación inicial muestra lo solicitado, sobre la misma pestaña encontramos “Aplicación Notas que es la resolución del problema” además tenemos los datos de estudiante.
![image](https://github.com/user-attachments/assets/ee8e76ea-1842-470e-9675-68ac32e59644)
 


“Aplicación Notas” (Listar)
 ![image](https://github.com/user-attachments/assets/157f365b-aa76-4007-9871-9903a428c2f6)


#Detalles:
![image](https://github.com/user-attachments/assets/7259c41c-e47a-47be-b423-602cecdebefe)

 
#Editar
![image](https://github.com/user-attachments/assets/7ee5fee3-1ef1-443d-808e-3a59c569d340)

#Crear
![image](https://github.com/user-attachments/assets/91a69c4d-78ce-4590-9e0b-105db5ed5250)
 

Siendo estas las funciones principales de la aplicación notas, creada para la resolución del problema planteado, mientras que dentro del mismo código se encuentran los conceptos planteados:
	Distribución de componentes: ya que modulamos los datos en distintas capas:
![image](https://github.com/user-attachments/assets/3d9ed20a-47c0-4edc-a585-9fb663e0bd24)

 

Desde el model para la estructura de datos:
![image](https://github.com/user-attachments/assets/948e827e-49ee-47f9-a0fa-2bb45c4eca19)

 
Repository da el acceso a las operaciones CRUD sobre la base de datos:
![image](https://github.com/user-attachments/assets/295732a1-c1f1-4eca-a613-c2ecae937de1)

![image](https://github.com/user-attachments/assets/b8e0b0f9-0ade-4ae8-b9fa-322f18fe4a09)


 

Service al tener la lógica de negocio de la aplicación además de interactuar con el repository:
![image](https://github.com/user-attachments/assets/19aaf8c6-88ed-4eb3-92e6-87e4d999ee8b)

 

Por último, en la distribución de componentes tenemos el controller el cual se encarga de manejar las solicitudes HTTP y regresar la acción establecida:

![image](https://github.com/user-attachments/assets/b887122d-5e33-4d14-96b1-9238eb95fc81)

	SEPARACIÓN INTERFAZ E IMPLEMENTACIÓN:
Esto se encuentra nuevamente en el repository -- Irepository que significa class interfaz:
![image](https://github.com/user-attachments/assets/f43cc86a-9e14-4d97-8db0-56fe41ef08d4)

 
Repository implementación:
![image](https://github.com/user-attachments/assets/22420ff2-82e2-4abd-b5f1-183d5d53086f)

 
	Concurrencia: 
Este apartado se realiza para evitar la saturación del programa es por ello que utilizamos theards o hilos sobre este caso es en la opción crear y listar:
![image](https://github.com/user-attachments/assets/a58e9444-4ee8-428b-b5fd-70ff064ee64a)
![image](https://github.com/user-attachments/assets/7b68a019-64d7-416e-89b4-f9b7bf5bb244)


Para listar: 
![image](https://github.com/user-attachments/assets/c1cf77f7-04c4-4d1c-a234-8f63db5204bd)

 


Al crear una nueva nota:  
![image](https://github.com/user-attachments/assets/47335013-0f28-4b57-b9d9-4ab9aac34a4f)

