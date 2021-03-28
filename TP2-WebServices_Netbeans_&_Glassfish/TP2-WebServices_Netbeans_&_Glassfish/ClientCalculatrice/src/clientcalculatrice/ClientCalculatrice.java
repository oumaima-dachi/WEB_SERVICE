/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clientcalculatrice;

import java.util.Scanner;

/**
 *
 * @author ahmed
 */
public class ClientCalculatrice {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i = sc.nextInt(), 
                j = sc.nextInt();
        System.out.println(add(i, j));
    }

    private static int add(int i, int j) {
        webservice.CalculatriceWS_Service service = new webservice.CalculatriceWS_Service();
        webservice.CalculatriceWS port = service.getCalculatriceWSPort();
        return port.add(i, j);
    }
    
}
