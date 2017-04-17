﻿using System;
using System.Collections.Generic;
using System.IO;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.client.parameters
{
	public class Policy
	{
		public String productCode;
		public String productVersion;

		public DateTime proposalDate;
		public DateTime effectiveDate;
		public DateTime expireDate;
		public Insured insured;
		public IndividualPolicyholder indiPolicyholder;
		public OrganizationPolicyholder orgPolicyhodler;
		public List<Document> documents;
		public Payer payer;
		public Boolean isPayerSameAsPolicyholder;
	}

	public class Payer
	{
		public String name;
		public InThaiAddress inThaiAddress;
		public OutThaiAddress outThaiAddress;
	}

	public class Document
	{
		public DocumentCategory category;
		public String name;
		public FileInfo file;
	}


	public enum DocumentCategory
	{
		CAR_REGISTRATION = 1,
		DRIVING_LICENSE = 3
	}


	public class Insured
	{
		public String vehicleType;
		public String vehicleSubType;

		public String vehicleMakeName;
		public int vehicleModelYear;
		public String vehicleModelDescription;

		public int vehicleRegistrationYear;
		public String vehicleRegistrationNo;
		public String vehicleCountry;
		public String vehicleProvince;
		public VehicleUsage vehicleUsage;
		public String vehicleChassisNo;

		public String vehicleColor;
		public String vehicleEngineNo;
	}

	//TODO
	public enum VehicleType {
		Sedan = 587
	}

	public enum VehicleSubType {
		Car_Seat_up_to_7_people = 618,
		Sedan_Powered_by_electricity = 588

	}

	public class InThaiAddress
	{
		public String street;
		public String province;
		public String district;
		public String subDistrict;
		public String postalCode;
	}

	public class OutThaiAddress
	{
		public String address;
		public String city;
		public String country;
	}


	public class IndividualPolicyholder
	{
		public String taxNo;
		public IndividualPrefix title;
		public String firstName;
		public String lastName;
		public String idType;
		public String idNo;
		//String email;
		public String mobile;
		//String officeTel;
		//String homeTel;
		// public String occupation;
		//public String nationality;
		// PolicyholderProfile profile;
		public InThaiAddress inThaiAddress;
		public OutThaiAddress outThaiAddress;
	}

	public class OrganizationPolicyholder
	{
		public OrganizationPrefix title;
		public String companyName;
		public String registrationNo;
		public String taxNo;
		public String branch;
		public DateTime registrationDate;
		public String industryCategory;
		public String contactPerson;
		public String contactPhoneNo;
		public InThaiAddress inThaiAddress;
		public OutThaiAddress outThaiAddress;
	}

	public enum IndividualPrefix
	{
		Khun = 5,
		Mr = 6,
		Mrs = 7,
		Miss = 8
	}

	public enum OrganizationPrefix
	{
		Bank = 21,
		Group = 14,
		Warehouse = 16,
		Company = 1,
		University = 9
	}
}
