using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeService.Enums
{
    public enum Messages
    {
        NUMERO_NAO_INFORMADO,
        LISTA_SALVA,
        ERRO_AO_SALVAR_LISTA,
        ERRO_AO_SALVAR_JSON,
        ERRO_AO_CRIAR_GRID,
        ERRO_AO_CHAMAR_API,
        API_CHAMADA,
        JSON_SALVO,
        GRID_CRIADO
    }

    public static class MessagesExtension
    {
        public static string GetMessage(this Messages message)
        {
            switch (message)
            {
                case Messages.NUMERO_NAO_INFORMADO:
                    return "Informe um número válido";
                case Messages.LISTA_SALVA:
                    return "Lista de números salva em numeros_ordenar.txt";
                case Messages.ERRO_AO_SALVAR_LISTA:
                    return "Ocorreu um erro ao salvar a lista: ";
                case Messages.ERRO_AO_SALVAR_JSON:
                    return "Ocorreu um erro ao salvar o arquivo JSON: ";
                case Messages.JSON_SALVO:
                    return "Arquivo data.json salvo com sucesso";
                case Messages.GRID_CRIADO:
                    return "Grid criado com sucesso";
                case Messages.ERRO_AO_CRIAR_GRID:
                    return "Ocorreu um erro ao ler o arquivo data.json e criar o Grid";
                case Messages.ERRO_AO_CHAMAR_API:
                    return "Ocorreu um erro ao chamar a API";
                case Messages.API_CHAMADA:
                    return "API chamada com sucesso";
            }

            return "";
        }
    }
}
