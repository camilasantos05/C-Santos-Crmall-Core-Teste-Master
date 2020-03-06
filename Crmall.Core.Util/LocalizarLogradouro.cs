using Crmall.Core.Domain.Entities;
using Crmall.Core.Util.Entities;
using RestSharp;
using System;

namespace Crmall.Core.Util
{
    public class LocalizarLogradouro
    {
        private readonly IRestClient _client;
        private readonly IRestRequest _request;

        public LocalizarLogradouro(IRestRequest request, IRestClient client)
        {
            _request = request;
            _client = client;
        }

        public Endereco BuscarCep(string cep)
        {
            _client.BaseUrl = new Uri("https://viacep.com.br/ws/");
            _request.Resource = $"{cep}/json/";

            IRestResponse<ResultadoBuscaLogradouro> response = _client.Get<ResultadoBuscaLogradouro>(_request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var result = response.Data;
            var endereco = new Endereco(result.cep,
                                        result.logradouro,
                                        string.Empty,
                                        result.complemento,
                                        result.bairro,
                                        result.localidade,
                                        result.uf);
            return endereco;
        }
    }
}
