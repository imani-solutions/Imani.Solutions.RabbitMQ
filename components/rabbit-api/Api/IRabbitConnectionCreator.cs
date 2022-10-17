using System;
using RabbitMQ.Client;

namespace Imani.Solutions.RabbitMQ.API
{
    public interface IRabbitConnectionCreator : IDisposable
    {
        IConnection GetConnection();
        IModel GetChannel();
    }
}