using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using VkNet.Enums;
using VkNet.Model.Attachments;
using VkNet.Tests.Infrastructure;

namespace VkNet.Tests.Categories.Docs
{
	[TestFixture]
	public class DocsSaveTests : CategoryBaseTest
	{
		protected override string Folder => "Docs";

		[Test]
		public void Save()
		{
			Url = "https://api.vk.com/method/docs.save";
			ReadCategoryJsonPath("Save");

			var docUploadResult = ReadJson("Categories", Folder, "DocUploadResult");

			var result = Api.Docs.Save(docUploadResult, "IMG_907", null);

			Assert.IsNotEmpty(result);
		}

		[Test]
		public void Save2()
		{
			Url = "https://api.vk.com/method/docs.save";
			ReadCategoryJsonPath("Save2");

			var docUploadResult = ReadJson("Categories", Folder, "DocUploadResult");

			var result = Api.Docs.Save(docUploadResult, "IMG_907", null);

			Assert.IsNotEmpty(result);
		}

		[Test]
		public void Save3()
		{
			Url = "https://api.vk.com/method/docs.save";
			ReadCategoryJsonPath("Save3");

			var docUploadResult = ReadJson("Categories", Folder, "DocUploadResult");

			var result = Api.Docs.Save(docUploadResult, "IMG_907", null);

			Assert.IsNotEmpty(result);
		}

		[Test]
		public void Save_Type()
		{
			Url = "https://api.vk.com/method/docs.save";
			ReadCategoryJsonPath("Save3");

			var docUploadResult = ReadJson("Categories", Folder, "DocUploadResult");

			var result = Api.Docs.Save(docUploadResult, "IMG_907", null);

			Assert.IsNotEmpty(result);
			var item = result.FirstOrDefault();
			item.Should().NotBeNull();
			var doc = item.Instance as Document;
			doc.Should().NotBeNull();
			Assert.AreEqual(DocumentTypeEnum.Text, doc.Type);
		}
	}
}