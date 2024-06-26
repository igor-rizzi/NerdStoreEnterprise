﻿using NSE.WebApp.MVC.Interfaces.Services.Autenticacao;
using NSE.WebApp.MVC.Models;
using System.Text;
using System.Text.Json;

namespace NSE.WebApp.MVC.Services.Autenticacao
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly HttpClient _httpClient;

        public AutenticacaoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public object JsonConvert { get; private set; }

        public async Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin)
        {
            var loginContent = new StringContent(
                                    JsonSerializer.Serialize(usuarioLogin),
                                    Encoding.UTF8,
                                    "application/json");

            var response = await _httpClient.PostAsync("http://127.0.0.1:5022/api/identidade/autenticar", loginContent);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync(), options);
        }

        public async Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro)
        {
            var registroContent = new StringContent(
                                        JsonSerializer.Serialize(usuarioRegistro),
                                        Encoding.UTF8,
                                        "application/json");

            var response = await _httpClient.PostAsync("http://127.0.0.1:5022/api/identidade/nova-conta", registroContent);

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync());
        }
    }
}
