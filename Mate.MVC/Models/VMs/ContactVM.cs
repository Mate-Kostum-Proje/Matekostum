﻿using System.ComponentModel.DataAnnotations;

namespace Mate.MVC.Models.VMs
{
	public class ContactVM
	{
		[DataType(DataType.EmailAddress)]
		[MaxLength(50)]
		[Required(ErrorMessage = "Email girmek zorunludur")]
		public string Email { get; set; }

		[MaxLength(500)]
		[DataType(DataType.Text)]
		[Required(ErrorMessage = "Konu girmek zorunludur")]
		public string Subject { get; set; }

		[MaxLength(50)]
		[MinLength(2)]
		[DataType(DataType.Text)]
		[Required(ErrorMessage = "İsim girmek zorunludur")]
		public string Name { get; set; }

		[MaxLength(50)]
		[DataType(DataType.Text)]
		[Required(ErrorMessage = "Mesaj girilmesi zorunludur")]
		public string Message { get; set; }
	}
}