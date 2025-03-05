using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public record ProjectDTO(
           int ProjectId,
           int? ProjectStatus,
           int? ContractingCompanyId,
           string? ProjectName,
           string? City,
           string? Neighborhood,
           bool IsPurchaseInTender,
           DateOnly? DateWinningTender,
           bool IsContractDevelopment,
           string? ContractDevelopmentFile,
           string? NumberHakiraContract,
           DateOnly? DevelopmentPeriodEndDate,
           bool IsDiscounted,
           bool? IsHachiraContract,
           bool? IsDiscountedHachira,
           string? HachiraContractFile,
           string? NumberLease,
           DateOnly? HachiraContractEndDate,
           bool IsPurchaseTaxPaymentConfirmation,
           string? PurchaseTaxPaymentConfirmationFile,
           bool IsAppreciationTaxPaymentConfirmation,
           string? AppreciationTaxPaymentConfirmationFile,
           bool? IsSalesTaxPaymentConfirmation,
           string? SalesTaxPaymentConfirmationFile,
           string? PowerOfAttorneyToLawyerFile,
           int? LendingBank,
           bool? IsPerselasia,
           string? FullAssetIdentificationBeforePerselasia,
           string? AnotherIdentification,
           string? PerselasiaFile,
           string? FullAssetIdentificationAfterPerselasia,
           int? Bloc,
           int? Smooth,
           int? SmothArea,
           bool? IsRishumBaitMeshutaf,
           bool? IsPrepareWarningComment,
           bool IsTookJointListingExpenses,
           double? PrincipalAmount,
           DateOnly? CollectionExpensesFrom1,
           double? CollectionAmount1,
           DateOnly? CollectionExpensesFrom2,
           double? CollectionAmount2,
           DateOnly? CollectionExpensesFrom3,
           double? CollectionAmount3,
           DateOnly InsertDate,
           DateOnly? UpdateDate,
           bool? IsRishumBaitMeshutafStarted,
           int? LandOwnershipId,
           string? MechozReshutMass,
           string? MechozReshutMassAddress,
           string? MechozMenaelMekarkaey,
           string? MechozMenaelMekarkaeyAddress,
           string? MechozTabu,
           string? MechozTabuAddress,
           string? ProjectDrawingFile,
           string? Note);

    //public record ProjectDTO(int ProjectId,int? ProjectStatus, int? ContractingCompanyId, string? ProjectName, string? City, string? Neighborhood
    //   ,bool IsPurchaseInTender, DateOnly? DateWinningTender,
    //    bool IsContractDevelopment, string? ContractDevelopmentFile,
    //     string? NumberHakiraContract, DateOnly? DevelopmentPeriodEndDate, bool IsDiscounted,
    //    bool? IsHachiraContract, bool? IsDiscountedHachira,string? HachiraContractFile, string? NumberLease,
    //    DateOnly? HachiraContractEndDate,bool IsPurchaseTaxPaymentConfirmation, 
    //    string? PurchaseTaxPaymentConfirmationFile,bool IsAppreciationTaxPaymentConfirmation ,
    //    string? AppreciationTaxPaymentConfirmationFile,
    //    bool? IsSalesTaxPaymentConfirmation, string? SalesTaxPaymentConfirmationFile,
    //    string? PowerOfAttorneyToLawyerFile, int? LendingBank, bool? IsPerselasia,
    //    string? FullAssetIdentificationBeforePerselasia, string? AnotherIdentification,
    //    string? PerselasiaFile, string? FullAssetIdentificationAfterPerselasia, int? Bloc,
    //    int? Smooth, int? SmothArea , bool? IsRishumBaitMeshutaf , bool? IsPrepareWarningComment, bool IsTookJointListingExpenses,
    //    double? PrincipalAmount, DateOnly? CollectionExpensesFrom1,
    //    double? CollectionAmount1, DateOnly? CollectionExpensesFrom2, double? CollectionAmount2,
    //    DateOnly? CollectionExpensesFrom3, double? CollectionAmount3, DateOnly InsertDate,
    //    DateOnly? UpdateDate, bool? IsRishumBaitMeshutafStarted, int? LandOwnershipId
    //    ,string? MechozReshutMass, string? MechozReshutMassAddress, string? MechozMenaelMekarkaey,
    //    string? MechozMenaelMekarkaeyAddress, string? MechozTabu, string? MechozTabuAddress,
    //    string? ProjectDrawingFile,string? Note);


    //שדות שנמלא לבד
    // int ProjectId 
    // int? ProjectStatus סטטוס הפרויקט מאותחל בפעיל בעת הוספת פרויקט
    //נציג בטופס פעיל ונמלא בDB 1 או 0 פעחיל או לא פעיל
    // ContractingCompanyId שם החברה מתמלא אוטומתית לפי ID של הניתוב ממנו נכנס
    // בטופס נציג את השם ובDB נמלא לפי ID מפתח זר לטבלת חברה מסתבר   

    //IsPurchaseInTender : בדיפולטיבי מציג FALSE 
    //אם בחר כן נציג לו שדה נוסף למלא שהןא תאריך זכיה

    // bool IsContractDevelopment : בדיפוטיבי מציג FALSE
    //אם בחר כן מציג לו אופציה להעלת קובץ
    // חוזה פיתוח string? ContractDevelopmentFile 
    //חכירה וכן מס חוזה string? NumberLease 
    //ובחירת תאריך סיום תקופת הפיתוח DateOnly? DevelopmentPeriodEndDate 

    //bool IsDiscounted : דיפולטיבי זה לא
    //אם כן יציג עוד 2 שדות למלא העלת קובץ של: 
    //שדה של קובץ חוזה חכירה
    //עוד שדה שלleaseContractFile 
    //עוד בחירת תאריך סיום חוזה חכירה

    //IsPurchaseTaxPaymentConfirmation 
    // דיפולטיבי זה לא אם כן נותן אופציה להעלת קובץ
    //PurchaseTaxPaymentConfirmationFile

    //IsAppreciationTaxPaymentConfirmation
    //דיפולטיבי זה לא אם כן נותן אופציה להעלות קובץ
    //string? AppreciationTaxPaymentConfirmationFile 

    //bool? IsSalesTaxPaymentConfirmation 
    //אישור תשלום מס מכירה בחירה של כן לא או אין צורך

    //בפונקציה של הסרבר נמלא את השדות האלו באחת מ2 אופציות 
    //1ץ עי המשתמש שמליא אותם בCLIENT 
    // 2. נשאיר אותם NULL מאחורי הקלעים

    //string? SalesTaxPaymentConfirmationFile  בחירת קובץ

    //int? LendingBank
    // לשלוף את רשימת בהנקים ולהציג לבחירת המשתמש

    //bool? IsPerselasia 
    //אם עונה על השאלה: האם בוצעה פרפליזציה בכן
    //פותח לו מילוי של עוד שדות
    //string? PerselasiaFile 
    //string? FullAssetIdentificationAfterPerselasia 
    //int? Bloc 
    //int? Smooth

    //bool IsTookJointListingExpenses 
    //בדיפולטיבי זה לא אם בוחר כן נפתחים לו שדות נוספים למלא:
    //double? PrincipalAmount DateOnly? CollectionExpensesFrom1 double? CollectionAmount1 
    //וככה 3 פעמים שתי השדות האלו

    //bool? IsRishumBaitMeshutafStarted 
    // לשלוף את רשימת הבעלויות ממסד הנתונים ולהציג למשתמש לבחירה
    //לבדוק האם בחר בעלות שרשומה? בAPI

    //int? LandOwnershipId 
    //מציג את רשימת הבעלויות 
    //תגית SELECT

    //כללי
    //לבדוק איך שם פרויקט מאפשר NULL
    // וכן שם עיר מאפשר NULL
    // וגם שם שכונה


}
