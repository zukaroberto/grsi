package controller;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.DatePicker;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import model.Cliente;

import java.util.Date;

public class ClientesController {

    @FXML private TextField tfNumCliente;

    @FXML private TextField tfNome;

    @FXML private TextField tfNIF;

    @FXML private TextField tfMorada;

    @FXML private TextField tfCPlocalidade;

    @FXML private TextField tfCPrua;

    @FXML private TextField tfCPdescr;

    @FXML private DatePicker dpDataNasc;

    @FXML private TextArea taObs;

    @FXML private Button btnCriar;

    @FXML
    void criar(ActionEvent event) {
        int numCliente = Integer.parseInt(this.tfNumCliente.getText());
        String nome = this.tfNome.getText();
        int nif = Integer.parseInt(this.tfNIF.getText());
        String morada = this.tfMorada.getText();
        int cpLoc = Integer.parseInt(this.tfCPlocalidade.getText());
        int cpRua = Integer.parseInt(this.tfCPrua.getText());
        String cpDescr = this.tfCPdescr.getText();
        Date dataNasc = (Date) this.dpDataNasc.getUserData();
        String obs = this.taObs.getText();

        Cliente cliente =
                new Cliente(numCliente,nome,nif,morada,cpLoc,cpRua,cpDescr,dataNasc,obs);
    }

}
