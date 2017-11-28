/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package farmacialeon;
  import java.sql.*;
import java.util.Properties;
import javax.swing.JOptionPane;
/**
 *
 * @author Mario Ruiz
 */
public class Conexion {
            
    public Connection Conectar(){
         String host = "farmacialeon.database.windows.net";
        String database = "LeoDb";
        String user = "administrador";
        String password = "Aplicaciones1.";
        Connection conect = null;
    try{

           Class.forName("com.mysql.jdbc.Driver");
           String url = String.format("jdbc:mysql://%s/%s", host, database);
           Properties properties = new Properties();
            properties.setProperty("user",user);
            properties.setProperty("password",password);
            properties.setProperty("useSSL", "true");
            properties.setProperty("verifyServerCertificate", "true");
            properties.setProperty("requireSSL", "false");
             conect = DriverManager.getConnection(url,properties);
       }
      catch(Exception ex){

           JOptionPane.showMessageDialog(null, ex);

       }
        return conect;
    }
}
