using AutoMoqCore;

namespace BuzzTicket.Tests.TestConfiguration.Mocks
{

    /// <summary>
    ///     Classe base para extensão de um serviço à ser mockado
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CustomMock<T> where T : class
    {
        public AutoMoqer _mocker;

        protected CustomMock()
        {
            _mocker = new AutoMoqer();
        }

        /// <summary>
        ///     Obriga o usuário a realizar a criação dos mocks à serem utilizados em cada serviço testado com retorno padrão
        /// </summary>
        /// <returns></returns>
        public abstract CustomMock<T> UseDefaultMock();

        /// <summary>
        ///     Concretiza a instância do serviço à ser testado
        /// </summary>
        /// <returns></returns>
        public T Resolve()
        {
            return _mocker.Resolve<T>();
        }
    }

}
