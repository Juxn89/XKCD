## Instaladores
Instalador de [.NET Core x64](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-3.0.100-windows-x64-installer), [Carpeta de imágenes](https://drive.google.com/drive/folders/1pOPwaH_Bt9GZD3hIRZaB52pUIE46mS-O?usp=sharing)

## ¿Cómo ejecutar la aplicación?
1. Abrir la ventana de comandos de windows.
![Paso_01](https://i.ibb.co/HhLnxxv/0.png)

2. Es necesario tener instalado el **.Net Core 3** para poder ejecutar la aplicación, para ellos vamos a revisar si se encuetra instalado, ejecutamos el camando **dotnet --version**.
![Paso_02](https://i.ibb.co/682jvwq/1.png)

3. En ese caso, no se encuentra instalado, por ellos procederemos a realizar la instalación y esperamos a que finalice. **Nota:** Sería recomendable re-iniciar el equipo para que se actualicen las variables de entorno.
![Paso_03](https://i.ibb.co/fxRWyCF/3.png)
![Paso_04](https://i.ibb.co/6HdyKpy/4.png)

4. Ejecutamos nuevamente el comando **dotnet --version** para comprobar que la instalación fue un éxito, nos deberia de mostrar la versión del **.Net Core**.
![Paso_05](https://i.ibb.co/2n6QRY9/5.png)

5. Descargarmos el repositorio, y en la cosola de Windows navegamos dentro de la caprte llamada **XKCD-Comic**, en dicha capeta se encuentra el código fuente de la aplicación. A como se muestran en las imagenes a continuación.
![Paso_06](https://i.ibb.co/Ldrwbdn/6.png)
![Paso_07](https://i.ibb.co/pJpKHjT/7.png)

6. Una vez dentro de la capeta **XKCD-Comic** (en la consola de Windows), ejecutamos el siguiente comando **dotnet run XKCD-Comic.csproj**, esto realizará la compilación del proyecto, re-estructurará las dependencias del mismo y nos permitirá levantar un servidor para ejecutar la aplicación. Esto puede tomar un par de minutos.
![Paso_08](https://i.ibb.co/hsxCXcK/8.png)

7. Una vez finalizados el proceso anterior, nos mostrará la información sobre la url en dónde se ejecutará la aplicación; a como se muestra en la imagen de abajo la URL sería: (HTTPS) **https://localhost/5001**, (HTTP)**http://localhost/5000**. Por lo cual tendríamos que abrir el navegador y escribir la URL para poder acceder al aplicativo.
![Paso_09](https://i.ibb.co/QK8QDnd/9.png)

8. En un dado caso que nos muestre una pantalla, cómo la de abajo, bastaría con hacer click en en el botón que dice **Mostrar configuración avanzada** y luego hacer click en el enlace que dice **Acceder a localhost(sitio no seguro)**
![Paso_10](https://i.ibb.co/3zv3pc9/10.png)
![Paso_11](https://i.ibb.co/JttZq8q/11.png)
