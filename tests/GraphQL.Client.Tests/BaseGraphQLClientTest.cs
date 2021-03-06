using System;

namespace GraphQL.Client.Tests {

	public abstract class BaseGraphQLClientTest : IDisposable{

		public GraphQLClient GraphQLClient { get; set; } = new GraphQLClient("https://swapi.apis.guru/");

		public void Dispose() =>
			this.GraphQLClient.Dispose();

	}

}
