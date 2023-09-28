# CheckTelefono

  esercizio in cui vengono dati in ingresso alcuni numeri ed il programma ritorna quello più simile ad un numero reale. 
  Se nessuno dei tre numeri è abbastanza smilie ad un numero reale, il programma non ritorna niente.

  Dato che ci sono tre conformazioni possibili simili ai numeri reali ho utilizzato alcuni "if" per far riconoscore
  al programma le tre possibilità.  Pezzo del codice:

  if (numero[0] == 0)
            {
                if(numero.Length == 14)
                {
                    n = 0;
                    return numero;
                }
            }
