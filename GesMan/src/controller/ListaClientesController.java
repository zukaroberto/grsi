package controller;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;

public class ListaClientesController {

    @FXML
    private TableView<?> tblClientes;

    @FXML
    private TableColumn<?, ?> colNum;

    @FXML
    private TableColumn<?, ?> colNome;

    @FXML
    private TableColumn<?, ?> colMorada;

    @FXML
    private TableColumn<?, ?> colNIF;

    @FXML
    private Button btnInserirCliente;

    @FXML
    private Button btnAbrirTicket;

    @FXML
    private Button btnCancelar;

}
