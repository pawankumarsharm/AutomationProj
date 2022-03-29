using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemQA.Utility
{
    class ObjectIdentifiers
    {
        public static readonly string _landingpage = "//h1[contains(text(),'3M Software Download Portal')]";
        public static readonly string _showsoftwarebtn = "//a[@class='col-md-12 MMM--btn MMM--btn_secondary mix-MMM--btn_allCaps mix-MMM--btn_fullWidthMobileOnly unicornButtonActive' and text()='Show Software']";
        public static readonly string _platformIdentifier = "//select[@id='selectedPlatform']";
        public static readonly string _MonitorQASDIdentifier = "//body/div[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/a[1]";
        public static readonly string _requestBtn = "//button[@id='downloadBtn']";
        public static readonly string _mailId = "//input[@id='mailId']";
        public static readonly string _veriftBtnIdentifier = "//button[@id='verifyBtn']";
        public static readonly string _firstnameId = "//input[@id='firstName']";
        public static readonly string _lastnameId = "//input[@id='lastName']";
        public static readonly string _orgNameId = "//input[@id='orgName']";
        public static readonly string _countryId = "//select[@id='selectedCountry']";
        public static readonly string _stateId = "//select[@id='State']";
        public static readonly string _cityId = "//input[@id='city']";
        public static readonly string _registerBtnIdentifier = "//button[@id='btnRegister']";
        public static readonly string _stateHeader = "//label[contains(text(),'State/Province')]";
        public static readonly string _verifySuccessMsg = "/html/body/[@class='modal-open']/div[@id='toast-container']/div[@class='toast toast-success']";
        public static readonly string _signout = "/html/body/div[1]/div[1]/div[2]/div[2]/ul/div[3]/li[2]/a/u";

        //approve request
        public static readonly string _signinbtn = "//a[contains(text(),'Sign in')]";
        public static readonly string _email = "//*[@id='logonIdentifier']";
        public static readonly string _password = "//*[@id='password']";
        public static readonly string _loginbtn = "//*[@id='next']";
        public static readonly string _organisationBtnIdentifier = "//*[@id='orgDropdown']";
        public static readonly string _continueBtn = "//*[@id='btnConfirmOrgModal']";
        public static readonly string _unapprovedReq = "//body/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/a[1]/i[1]";
        public static readonly string _searchBox = "/html/body/div[1]/div[3]/div/div[2]/div/div[4]/label/input";
        public static readonly string _unapproveBtn = "/html/body/div[1]/div[3]/div/div[2]/div/table/tbody/tr[1]/td[5]/a";
        public static readonly string _approveBtn = "//*[@id='approvebtn']";
        public static readonly string _createBtn = "/html/body/div[1]/div[3]/div/div[1]/div[2]/div[2]/div[3]/div/a[1]";
        public static readonly string _createBtnLast = "/html/body/div[1]/div[3]/div/div/form/div[2]/div/button[1]";
        public static readonly string _softwareBtnIdentifier = "/html/body/div[1]/div[2]/div/div/ul/li[5]/a";
        public static readonly string _notification = "/html/body/div[3]/div/div[2]";
        public static readonly string _mergeBtn = "//*[@id='RedirectToMerge']";
        public static readonly string _mergeNotification = "/html/body/div[@id='toast-container']/div[@class='toast toast-error']/div[@class='toast-message']";
        public static readonly string _mergeSearchBox = "//*[@id='searchOrgInput']";
        public static readonly string _mergeSearchBtn = "//*[@id='searchOrgId']";
        public static readonly string _mergeSearchIdentifier = "/html/body/div[1]/div[3]/div/div[2]/div[2]/div/table/thead/tr/th[3]/center";
        public static readonly string _selectOrgToMerge = "/html/body/div[@class='MMM--themeWrapper']/div[@class='wrapper']/div[@id='content']/div[@class='card']/div[@class='row mb-3']/div[@id='orgTable_wrapper']/table[@id='orgTable']/tbody/tr[@class='odd']/td[@class='sorting_1']/input[@class='orgRedirect']";
        public static readonly string _saveBtn = "/html/body/div[1]/div[3]/div/div/form/div[2]/div/button[1]";
        public static readonly string _roleBtnIdentifier = "//*[@id='roleAssigned']";
        public static readonly string _rejectBtn = "//*[@id='id_reject']";
        public static readonly string _rejectMailYesBtn = "//*[@id='yesButton']";
        public static readonly string _noRecord = "/html/body/div[1]/div[3]/div/div[2]/div/table/tbody/tr/td";
        public static readonly string _toastMsg = "/html/body/div[3]/div/div[2]";
        public static readonly string _stateUnapproved = "//*[@id='State']";
        public static readonly string _rejectToastMsg = "/html/body/div[3]/div/div[2]";
        public static readonly string _mergeSuccessMsg = "/html/body/div[3]/div[2]/div[2]";



        //post organisation creation
        public static readonly string _organisationBtn = "/html/body/div[1]/div[2]/div/div/ul/li[4]/a/i";
        public static readonly string _orgSearchBox = "/html/body/div[1]/div[3]/div/div[3]/div/div[2]/label/input";
        public static readonly string _orgNameIdentifier = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr/td[1]/a";
        public static readonly string _addUserBtn = "/html/body/div[1]/div[3]/div/div[2]/div[1]/div/button";
        public static readonly string _userRole = "//*[@id='SelectedUserRoleCode']";
        public static readonly string _userFirstName = "//*[@id='FirstName']";
        public static readonly string _userLastName = "//*[@id='LastName']";
        public static readonly string _userEmail = "//*[@id='Email']";
        public static readonly string _userContactNum = "//*[@id='Contact']";
        public static readonly string _noRecordPostOrg = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr/td";
        public static readonly string _noUserPostOrg = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr/td";

        public static readonly string _userCreateBtn = "/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div/div[6]/div/button[1]";
        public static readonly string _roleString = "//*[@id='roleAssigned']";

        public static readonly string _userCreationSucessMsg = "/html/body/div[3]/div";
        public static readonly string _userEditSucessMsg = "/html/body/div[3]/div/div[2]";
        public static readonly string _deleteOrgSucessMsg = "/html/body/div[3]/div/div[2]";
        public static readonly string _userMailSucessMsg = "/html/body/div[3]/div/div[2]";
        public static readonly string _addRoleSucessMsg = "/html/body[@class='modal-open']/div[@class='MMM--themeWrapper']/div[@class='wrapper']/div[@id='content']/div[@id='addRoleModal']";

        public static readonly string _deleteRoleConfirmSecond = "/html/body/div[1]/div[3]/div/div[6]/div/div/div[2]/form/div/h1";
        public static readonly string _confirmDeleteRoleButton = "//*[@id='btnConRemoveRoleHideModal']";
        public static readonly string _table = "/html/body/div[1]/div[3]/div/div[3]/div[2]/div/table/tbody/tr";

        ///Delete Organisation
        public static readonly string _deleteOrgIdentifier = "/html/body/div[@class='MMM--themeWrapper']/div[@class='wrapper']/div[@id='content']/div[3]/div[@id='dataTable_wrapper']/table[@id='dataTable']/tbody/tr[@class='odd']/td[1]/a";
        public static readonly string _deleteOrgBtn = "/html/body/div[1]/div[3]/div/div[1]/div[2]/div/a[2]/i";
        public static readonly string _deleteOrgConfirmBtn = "/html/body/div[3]/div/div/div[2]/button[2]";

        /// send mail
        public static readonly string _showAll = "/html/body/div[1]/div[3]/div/div[2]/div[2]/div/div[1]/div[1]/label/select";
        public static readonly string _mailOrg = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr/td[1]/a";
        public static readonly string _mailSend = "/html/body/div[1]/div[3]/div/div[2]/div[2]/div/div[1]/table/tbody/tr[1]/td[5]/button[1]/i";
        public static readonly string _mailSendConfirmBtn = "/html/body/div[3]/div/div/div[2]/button[2]";

        //Add user Role
        public static readonly string _userBtn = "/html/body/div[1]/div[2]/div/div/ul/li[3]/a/i";
        public static readonly string _userSearchBox = "/html/body/div[1]/div[3]/div/div[3]/div/div[3]/label/input";
        public static readonly string _userNameBtn = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr[1]/td[1]/a";
        public static readonly string _addRoleBtn = "//*[@id='btnAddRole']";
        public static readonly string _choseRoleDropDown = "//*[@id='role']";
        public static readonly string _chooseBusinessUnit = "//*[@id='bu']";
        public static readonly string _chooseOrganisation = "//*[@id='org']";
        public static readonly string _addUserRoleBtn = "//*[@id='btnAddUserRoles']";

        //Remove role
        public static readonly string _removeRoleBtn = "/html/body/div[1]/div[3]/div/div[3]/div[2]/div/table/tbody/tr/td[5]/center/button";
        public static readonly string _removeRoleConfirmBtn = "//*[@id='btnRemoveRoleRemoveModal']";

        public static readonly string _removeRoleConfirmMsg = "/html/body/div[@id='toast-container']/div[@class='toast toast-success']/div[@class='toast-message']";
        public static readonly string _removeRoleMsgId = "//*[@id='toast-container']";
        public static readonly string _removeRoleButton2 = "/html/body/div[1]/div[3]/div/div[3]/div[2]/div/table/tbody/tr[2]/td[5]/center/button";
        public static readonly string _roleRemoveConfirmMsg = "/html/body/div[3]/div";
        //Edit User
        public static readonly string _editUserBtn = "/html/body/div[1]/div[3]/div/div[2]/div[1]/div/a[1]/i";
        public static readonly string _editNum = "//*[@id='Contact']";
        public static readonly string _editSaveBtn = "/html/body/div[1]/div[3]/div/div/div/div[1]/div/form/div/div[5]/div/button[1]";

        //Release Software
        public static readonly string _releaseSoftwareBtn = "/html/body/div[1]/div[3]/div/div[3]/div[1]/div/button";
        public static readonly string _product = "//*[@id='id_software']";
        public static readonly string _version = "//*[@id='VersionList']";

        public static readonly string _LicenseExpiryDate = "/html/body/div[1]/div[3]/div/div/form/div/div[1]/div[4]/div/div/span/i";
        public static readonly string _maxActivation = "//*[@id='id_activations']";
        public static readonly string _relaseBtn = "//*[@id='submit-id-signup']";
        public static readonly string _orgRelease = "/html/body/div[1]/div[3]/div/div[3]/div/table/tbody/tr/td[1]/a";
        public static readonly string _searchboxDate = "//*[@id='id_validTillDate']";
        public static readonly string _releaseSoftwareSucessMsg = "/html/body/div[3]/div/div[2]";


        //approve request
        public static readonly string _btnSignIn = "//button[@id='next' and text()='Sign in']";
        public static readonly string _loginContinueBtn = "//button[@id='btnConfirmOrgModal']";
        public static readonly string _loginErrAlert = "/html/body/div[@id='panel']/table[@class='panel_layout']/tbody/tr[@class='panel_layout_row']/td[@id='panel_center']/div[@class='inner_container']/div[@class='api_container normaltext']/div[@id='api']/div[@class='localAccount']/div[@class='error pageLevel']/p";
        public static readonly string _orgDropdown = "//select[@id='orgDropdown']";
        public static readonly string _continuebtn = "//button[@id='btnConfirmOrgModal']";
        public static readonly string _unapprovedLink = "div.MMM--themeWrapper:nth-child(1) div.mmm--site-bd:nth-child(8) div.mmm--grids div.MMM--siteNav ul.MMM--secondaryNav li.js-secondaryNavLink.UnApprovedReq:nth-child(2) > a:nth-child(1)";
        public static readonly string _unapprovelinkproceed = "//tbody/tr[1]/td[5]/a[1]";
        public static readonly string _btnapprove = "//button[@id='approvebtn']";
        public static readonly string _createbtn = "div.MMM--themeWrapper:nth-child(1) div.wrapper:nth-child(10) div.card.mb-5:nth-child(10) div.card-body div.mt-2 div.float-right:nth-child(3) div:nth-child(2) > a.MMM--btn.MMM--btn_primary.mix-MMM--btn_fullWidthMobileOnly.mix-MMM--btn_allCaps.unicornButtonActive.btnwidthcss:nth-child(1)";
        public static readonly string _mergebtn = "//a[@id='RedirectToMerge']";
        public static readonly string _requesterdetailsele = "//text[contains(text(),'Requester Details')]";
        public static readonly string _createbtnfinal = "div.MMM--themeWrapper:nth-child(1) div.wrapper:nth-child(10) div.row:nth-child(2) form.form-horizontal.mainbox.col-md-12:nth-child(1) div.form-group:nth-child(2) div.col-md-offset-2.col-md-10 > button.MMM--btn.MMM--btn_primary.mix-MMM--btn_fullWidthMobileOnly.mix-MMM--btn_allCaps.unicornButtonActive:nth-child(2)";
        public static readonly string _dashboardLinkId = "//a[text()='DASHBOARD ']";
        public static readonly string _softwareLinkId = "/html/body/div[1]/div[2]/div/div/ul/li[5]/a";
        public static readonly string _softwareSearchId = "//*[@id='dataTable_filter']/label/input";
        public static readonly string _softwareavlMQA = "//a[contains(text(),'Monitor QA')]";
        public static readonly string _softwareeditCust = "//a[contains(text(),'Identifier')]";
        public static readonly string _editSoftwareId = "//*[@id='dataTable']/tbody/tr[1]/td[5]/a[1]/i";

        //CreateOrg
        public static readonly string _orgDetailsTxtId = "//h1[contains(text(),'Organization Details')]";
        public static readonly string _orgLinkId = "//a[text()='ORGANIZATIONS']";
        public static readonly string _createOrgBtn = "//button[text()='Create New Organization']";
        public static readonly string _orgnewNameId = "//input[@id='OrganizationName']";
        public static readonly string _createOrgFnameId = "//input[@id='FirstName']";
        public static readonly string _createOrgLnameId = "//input[@id='LastName']";
        public static readonly string _createOrgCountryId = "//select[@id='SelectedCountryId']";
        public static readonly string _createOrgStateId = "//select[@id='State']";
        public static readonly string _createOrgEmailId = "//input[@id='Email']";
        public static readonly string _createOrgCityId = "//input[@id='City']";
        public static readonly string _createOrgContactId = "//input[@id='Contact']";
        public static readonly string _createOrgBUId = "//select[@id='SelectedBusinessUnitListId']";
        public static readonly string _createOrgATId = "//select[@id='SelectedOrganizationAccountTypeId']";
        public static readonly string _createOrgFieldId = "//select[@id='SelectedOrganizationFieldId']";
        public static readonly string _createOrgStatusId = "//select[@id='SelectedOrganizationStatusId']";
        public static readonly string _createOrgCreateBtnId = "//button[text()='Create']";
        public static readonly string _createOrgCanclBtnId = "//button[text()='Cancel']";
        public static readonly string _toastOrgCreatedId = "//div[@class='toast-message'and text()='Organization created.']";
        public static readonly string _toastOrgDeletedId = "//div[@class='toast-message'and text()='Organisation removed.']";
        public static readonly string _toastOrgAlreadyExist = "//div[contains(text(),'This Organizations name already exists.')]";

        public static readonly string _toastOrgCancelBtn = "//button[text()='Cancel']";
        public static readonly string _toastOrgCreateErr = "//span[@id='OrganizationName-error']";
        public static readonly string _editBussUnit = "//select[@id='BusinessUnitCode']";
        public static readonly string _activationKey = "//select[@id='id_activations']";
        public static readonly string _triaPerod = "//input[@id='TrailPeriod']";
        public static readonly string _btnUpdate = "//button[contains(text(),'Update')]";
        public static readonly string _toastEditSftwreSuccess = "//div[contains(text(),'The Software updated successfully')]";
        public static readonly string _deleteSoftwareId = "//i[contains(text(),'')]";
        public static readonly string _deleteOKConfirm = "//button[contains(text(),'OK')]";
        public static readonly string _deleteCancel = "//button[contains(text(),'Cancel')]";
        public static readonly string _addNewSoftWare = "//button[contains(text(),'Add New Software')]";
        public static readonly string _toastMsg123 = "//div[@class='toast toast-warning')]";

        //Create Software
        public static readonly string _newSoftwareName = "//input[@id='Name']";
        public static readonly string _newSoftwareType = "//select[@id='type']";
        public static readonly string _newBussinessUnit = "//select[@id='BusinessUnitCode']";
        public static readonly string _newStwShortDesc = "//textarea[@id='Notes']";
        public static readonly string _newStwBeta = "//input[@id='ChkBeta']";
        public static readonly string _selfrequest = "//input[@id='MyChk']";
        public static readonly string _btnCreateStwre = "//button[contains(text(),'Create')]";
        public static readonly string _toastnewSftWreSuccess = "//div[contains(text(),'The Software added successfully.')]";
        public static readonly string _toastAlreadyExists = "//div[contains(text(),'Software already exists')]";
        public static readonly string _toastemailLinkNotification = "//div[contains(text(),'Email has been sent with download instructions.')]";
    }
}
