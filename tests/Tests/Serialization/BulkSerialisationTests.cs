// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Threading.Tasks;
using Tests.Domain;

namespace Tests.Serialization
{
	public class BulkSerialisationTests : SerializerTestBase
	{
		[U]
		public async Task BulkRequest_SerialisationTest()
		{
			var expectedJson = @"{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
";

			expectedJson = expectedJson.Replace("\r\n", "\n", System.StringComparison.Ordinal);

			var operations = new BulkOperationsCollection
			{
				new BulkIndexOperation<Project>(FixedProject) { Index = "project" },
				new BulkIndexOperation<Project>(FixedProject)
			};

			var request = new BulkRequest
			{
				Operations = operations
			};

			var serialisedJson = await SerializeAndGetJsonStringAsync(request);
			serialisedJson.Should().Be(expectedJson);
		}

		[U]
		public async Task BulkRequest_DescriptorSerialisationTest()
		{
			var expectedJson = @"{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
";

			expectedJson = expectedJson.Replace("\r\n", "\n", System.StringComparison.Ordinal);

			var request = new BulkRequestDescriptor();
			request.Index(FixedProject, b => b.Index("project"));
			request.Index(FixedProject);

			var serialisedJson = await SerializeAndGetJsonStringAsync(request);
			serialisedJson.Should().Be(expectedJson);
		}

		[U]
		public async Task BulkRequest_IndexMany_DescriptorSerialisationTest()
		{
			var expectedJson = @"{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
{""index"":{""_index"":""project""}}
{""lastActivity"":""0001-01-01T00:00:00"",""leadDeveloper"":{""gender"":0,""firstName"":""Steve"",""id"":0,""lastName"":""Gordon""},""numberOfContributors"":0,""startedOn"":""0001-01-01T00:00:00"",""state"":""BellyUp"",""type"":""project"",""visibility"":0}
";

			expectedJson = expectedJson.Replace("\r\n", "\n", System.StringComparison.Ordinal);

			var request = new BulkRequestDescriptor();
			request.IndexMany(new [] { FixedProject, FixedProject });

			var serialisedJson = await SerializeAndGetJsonStringAsync(request);
			serialisedJson.Should().Be(expectedJson);
		}

		private static readonly Project FixedProject = new()
		{
			LeadDeveloper = new Developer
			{
				FirstName = "Steve",
				LastName = "Gordon",
				Gender = Gender.Male
			}
		};
	}
}