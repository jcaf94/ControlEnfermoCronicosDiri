
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CEN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.Enumerated.Chroni;
/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                //cmd = new SqlCommand (createUser, cnn);
                //cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                //cmd = new SqlCommand (associatedUser, cnn);
                //cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes


                PatientCAD patientCAD = new PatientCAD ();
                PatientCEN patientCEN = new PatientCEN ();

                LocationCAD locationCAD = new LocationCAD ();
                LocationCEN locationCEN = new LocationCEN ();

                DiaryCAD diaryCAD = new DiaryCAD ();
                DiaryCEN diaryCEN = new DiaryCEN ();

                PractitionerCAD practitionerCAD = new PractitionerCAD ();
                PractitionerCEN practitionerCEN = new PractitionerCEN ();

                EncounterCAD encounterCAD = new EncounterCAD ();
                EncounterCEN encounterCEN = new EncounterCEN ();

                RelatedPersonCAD relatedPersonCAD = new RelatedPersonCAD ();
                RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN ();

                ScheduleCAD scheduleCAD = new ScheduleCAD ();
                ScheduleCEN scheduleCEN = new ScheduleCEN ();

                SlotCAD slotCAD = new SlotCAD ();
                SlotCEN slotCEN = new SlotCEN ();

                ConditionCAD conditionCAD = new ConditionCAD ();
                ConditionCEN conditionCEN = new ConditionCEN ();

                ConversationCAD conversationCAD = new ConversationCAD ();
                ConversationCEN conversationCEN = new ConversationCEN ();

                MessageCAD messageCAD = new MessageCAD ();
                MessageCEN messageCEN = new MessageCEN ();

                ReclamationCAD reclamationCAD = new ReclamationCAD ();
                ReclamationCEN reclamationCEN = new ReclamationCEN ();

                ReclamationResponseCAD reclamationResponseCAD = new ReclamationResponseCAD ();
                ReclamationResponseCEN reclamationResponseCEN = new ReclamationResponseCEN ();

                ObservationCAD observationCAD = new ObservationCAD ();
                ObservationCEN observationCEN = new ObservationCEN ();

                PositionCAD positionCAD = new PositionCAD ();
                PositionCEN positionCEN = new PositionCEN ();

                CarePlanCAD carePlanCAD = new CarePlanCAD ();
                CarePlanCEN carePlanCEN = new CarePlanCEN ();

                ActivityCAD activityCAD = new ActivityCAD ();
                ActivityCEN activityCEN = new ActivityCEN ();

                GoalCAD goalCAD = new GoalCAD ();
                GoalCEN goalCEN = new GoalCEN ();

                MedicationCAD medicationCAD = new MedicationCAD ();
                MedicationCEN medicationCEN = new MedicationCEN ();

                IngredientCAD ingredientCAD = new IngredientCAD ();
                IngredientCEN ingredientCEN = new IngredientCEN ();

                ConditionCodeCAD conditionCodeCAD = new ConditionCodeCAD ();
                ConditionCodeCEN conditionCodeCEN = new ConditionCodeCEN ();

                SubstanceCodeCAD substanceCodeCAD = new SubstanceCodeCAD ();
                SubstanceCodeCEN substanceCodeCEN = new SubstanceCodeCEN ();

                CarePlanCategoryCAD carePlanCategoryCAD = new CarePlanCategoryCAD ();
                CarePlanCategoryCEN carePlanCategoryCEN = new CarePlanCategoryCEN ();

                SpecialtyCAD specialtyCAD = new SpecialtyCAD ();
                SpecialtyCEN specialtyCEN = new SpecialtyCEN ();

                RelationshipCAD relationshipCAD = new RelationshipCAD ();
                RelationshipCEN relationshipCEN = new RelationshipCEN ();

                AdministratorCAD administratorCAD = new AdministratorCAD ();
                AdministratorCEN administratorCEN = new AdministratorCEN (administratorCAD);

                AssessmentCAD assessmentCAD = new AssessmentCAD ();
                AssessmentCEN assessmentCEN = new AssessmentCEN (assessmentCAD);
                //CAD CAD = new CAD();
                //CEN CEN = new CEN();


                //Creamos ConditionCode
                int conditionCode1 = conditionCodeCEN.New_ ("412775002", "Apraxia of dressing");
                ConditionCodeEN conditionCode1EN = conditionCodeCEN.ReadOID (conditionCode1);

                //Creamos CarePlanCategory
                int carePlanCategory1 = carePlanCategoryCEN.New_ ("000002", "Asthma clinical management plan");
                CarePlanCategoryEN carePlanCategory1EN = carePlanCategoryCEN.ReadOID (carePlanCategory1);


                // Creamos Locations
                int location1 = locationCEN.New_ (LocationStatusEnum.active, "LocationName1", "LocationDescription1",
                        LocationModeEnum.public_location, LocationTypeEnum.hospital, "address", LocationPhysicalTypeEnum.building,
                        "ManagingOrg", "223322223", "location1@email.ll", "03183");
                // Asignamos Position a Location
                locationCEN.ReadOID (location1).Position = positionCEN.ReadOID (positionCEN.New_ (1.11111, 1.22222, 1.33333, location1));

                int location2 = locationCEN.New_ (LocationStatusEnum.active, "LocationName2", "LocationDescription2",
                        LocationModeEnum.private_location, LocationTypeEnum.pharmacy, "address", LocationPhysicalTypeEnum.building,
                        "ManagingOrg", "telf", "location2@email.ll", "CP");

                // Asignamos Position a Location
                locationCEN.AssignPosition (location1, positionCEN.New_ (2.11111, 2.22222, 2.33333, location2));


                // Creamos Patients
                IList<int> locationsPatient1 = new List<int>();
                locationsPatient1.Add (location1);

                int patient1 = patientCEN.New_ ("nif", true, "name", "surname1 surname2", GenderEnum.unknown, new DateTime (2014, 12, 12),
                        false, "address", "email@email.es", "telf", MaritalStatusEnum.married, "photo", locationsPatient1, null, "password");

                int patient2 = patientCEN.New_ ("nif2", true, "name2", "surname21 surname22", GenderEnum.male, new DateTime (2000, 02, 12),
                        false, "address2", "email2@email.es", "telf2", MaritalStatusEnum.single, "photo2", locationsPatient1, null, "password2");

                // Asignamos Diary al Patient
                patientCEN.AssignDiary (patient1, diaryCEN.New_ (patient1));
                patientCEN.AssignDiary (patient2, diaryCEN.New_ (patient2));

                //Asignamos Location al Patient
                patientCEN.AssignLocation (patient1, locationsPatient1);


                //Creamos Pratitioner
                IList<int> locationsPractitioner1 = new List<int>();
                locationsPractitioner1.Add (location1);

                IList<int> locationsPractitioner2 = new List<int>();
                locationsPractitioner1.Add (location2);

                int practitioner1 = practitionerCEN.New_ ("nif", true, PractitionerRoleEnum.physician, "name", "surname1 surname2",
                        GenderEnum.other, new DateTime (2014, 12, 12), "address", "email@email.es", "telf", "photo",
                        new DateTime (2014, 12, 12), new DateTime (2014, 12, 12), locationsPractitioner1, "password");

                int practitioner2 = practitionerCEN.New_ ("nif2", true, PractitionerRoleEnum.nurse, "name2", "surname12 surname22",
                        GenderEnum.female, new DateTime (1914, 12, 11), "address2", "email2@email.es", "telf2", "photo2",
                        new DateTime (2014, 10, 12), new DateTime (2014, 12, 12), locationsPractitioner2, "password2");

                IList<int> practitionersPatient1 = new List<int>();
                practitionersPatient1.Add (practitioner1);

                //Asignamos Practitioners a Patient
                patientCEN.AssignPractitioner (patient1, practitionersPatient1);


                // Asignamos Practitioner al Diary
                diaryCEN.AssignPractitioner (patientCEN.ReadOID (patient1).Diary.Identifier, practitionersPatient1);


                //Creamos Specialty
                int specialty1 = specialtyCEN.New_ ("409967009", "Toxicology");
                int specialty2 = specialtyCEN.New_ ("408467006", "Adult mental illness");

                IList<int> specialtiesPractitioner1 = new List<int>();
                specialtiesPractitioner1.Add (specialty1);
                specialtiesPractitioner1.Add (specialty2);

                //Asignamos Specialty a Practitioner
                practitionerCEN.AssignSpecialty (practitioner1, specialtiesPractitioner1 [0]);


                //Creamos RelatedPerson
                IList<int> patientsRelatedPerson1 = new List<int>();
                patientsRelatedPerson1.Add (patient1);

                int relatedPerson1 = relatedPersonCEN.New_ ("nif", "name", "surname1, surname2",
                        GenderEnum.male, new DateTime (2014, 12, 12), "address", "email", "tlf", "photo",
                        new DateTime (2014, 12, 12), new DateTime (2014, 12, 12), "password", true);

                int relatedPerson2 = relatedPersonCEN.New_ ("nif2", "name2", "surname21, surname22",
                        GenderEnum.male, new DateTime (2014, 12, 12), "address", "email", "tlf", "photo",
                        new DateTime (2014, 12, 12), new DateTime (2014, 12, 12), "password", true);

                IList<int> relatedPersonsPatient1 = new List<int>();
                relatedPersonsPatient1.Add (relatedPerson1);

                IList<int> patientsRelatedPerson2 = new List<int>();
                patientsRelatedPerson2.Add (patient2);

                //Creamos Relationship
                int relationship_relatedPerson1_patient1 = relationshipCEN.New_ (RelationshipEnum.friend, patient1, relatedPerson1);

                //Asignamos RelatedPerson al Patient
                patientCEN.AssignRelatedPerson (patient1, relatedPersonsPatient1);

                //Asignamos Patient a RelatedPerson
                relatedPersonCEN.AssignPatient (relatedPerson2, patientsRelatedPerson2);


                //Creamos Observations with Symptom, Measure, Factor
                int observation1 = observationCEN.New_ (MeasureTypeEnum.Blood_preassure_systolic_y_diastolic, "name",
                        new DateTime (2014, 12, 12), "note", new DateTime (2014, 12, 12), patientCEN.ReadOID (patient1).Diary.Identifier,
                        new DateTime (2014, 12, 12), ObservationCategoryEnum.factor, SymptomGradeEnum.four, 120, 80, patient1);


                //Creamos Schedules
                int schedule1_practitioner1 = scheduleCEN.New_ (practitioner1, location1, false, new DateTime (2017, 08, 02, 09, 30, 00),
                        new DateTime (2017, 08, 02, 13, 00, 00), new DateTime (2017, 08, 02, 17, 30, 00),
                        new DateTime (2017, 08, 02, 20, 00, 00), new DateTime (2017, 08, 02), new DateTime (2017, 09, 01));
                int schedule2_practitioner1 = scheduleCEN.New_ (practitioner1, location1, false, new DateTime (2017, 08, 02, 09, 30, 00),
                        new DateTime (2017, 08, 02, 18, 00, 00), new DateTime (2017, 08, 02, 18, 00, 00),
                        new DateTime (2017, 08, 02, 18, 00, 00), new DateTime (2017, 08, 02), new DateTime (2017, 09, 01));
                int schedule1_practitioner2 = scheduleCEN.New_ (practitioner2, location2, true, new DateTime (2017, 08, 02),
                        new DateTime (2017, 08, 02), new DateTime (2017, 08, 02), new DateTime (2017, 08, 02),
                        new DateTime (2017, 08, 02), new DateTime (2017, 09, 01));
                int schedule2_practitioner2 = scheduleCEN.New_ (practitioner2, location2, false, new DateTime (2017, 08, 02),
                        new DateTime (2017, 08, 02), new DateTime (2017, 08, 02), new DateTime (2017, 08, 02),
                        new DateTime (2017, 08, 02), new DateTime (2017, 09, 01));

                //Creamos Slots
                int slot1_schedule1_practitioner1 = slotCEN.New_ (SlotStatusEnum.busy, new DateTime (2017, 04, 02, 8, 0, 0),
                        new DateTime (2017, 04, 02, 8, 15, 0), "note", schedule1_practitioner1);
                int slot2_schedule1_practitioner1 = slotCEN.New_ (SlotStatusEnum.free, new DateTime (2017, 04, 02, 8, 15, 0),
                        new DateTime (2017, 04, 02, 8, 30, 0), "note", schedule1_practitioner2);

                //Creamos Encounters
                IList<int> practitionersEncounter1 = new List<int>();
                practitionersEncounter1.Add (practitioner1);

                int encounter1 = encounterCEN.New_ (EncounterStatusEnum.planned, EncounterTypeEnum.consultation,
                        EncounterPriorityEnum.as_needed, new DateTime (2017, 04, 02, 8, 0, 0), new DateTime (2017, 04, 02, 8, 15, 0),
                        "Para variar", "Seguridad social", patient1, practitionersEncounter1, null, slot1_schedule1_practitioner1, "note");


                //Creamos Condition
                int condition1 = conditionCEN.New_ (encounter1, ConditionCategoryEnum.encounter_diagnosis, ConditionClinicalStatusEnum.recurrence, ConditionSeverityEnum.severe, "onset", "abatement", "note");
                conditionCEN.AssignConditionCode (condition1, conditionCode1);

                //ConditionEN condition1EN = conditionCEN.ReadOID (condition1);
                //condition1EN.ConditionCode = conditionCode1EN;

                //Creamos CarePlan
                int carePlan1 = carePlanCEN.New_ ("subject", CarePlanStatusEnum.active, "context", new DateTime (2017, 04, 03),
                        new DateTime (2017, 04, 03), "description", "note", encounter1, new DateTime (2017, 06, 30));

                IList<int> categoriesCarePlan1 = new List<int>();
                categoriesCarePlan1.Add (carePlanCategory1);
                carePlanCEN.AssignCategory (carePlan1, categoriesCarePlan1);

                //Creamos Goal
                int goal1 = goalCEN.New_ ("subject", new DateTime (2017, 04, 03), "target", GoalCategoryEnum.behavioral,
                        "description", GoalStatusEnum.process, GoalPriorityEnum.medium, "note", carePlan1);

                //Creamos Activity
                int activity1 = activityCEN.New_ ("progress", "description", carePlan1, new DateTime (2017, 04, 10),
                        new DateTime (2017, 04, 11));

                //Creamos Medication
                int medication1 = medicationCEN.New_ ("name", "manufacturer", "description", FormEnum.capsule, 2.2, "dosage",
                        MedicationStatusEnum.active, true);
                int medication2 = medicationCEN.New_ ("name2", "manufacturer2", "description2", FormEnum.powder, 0.004, "dosage2",
                        MedicationStatusEnum.active, false);

                IList<int> medicationsActivity1 = new List<int>();
                medicationsActivity1.Add (medication1);

                //Asignamos Medication a Activity
                activityCEN.AssignMedication (activity1, medicationsActivity1);

                //Creamos SubstanceCode
                int substanceCode1 = substanceCodeCEN.New_ ("12006", "Ornithine racemase");
                SubstanceCodeEN substanceCode1EN = substanceCodeCEN.ReadOID (substanceCode1);
                int substanceCode2 = substanceCodeCEN.New_ ("102002", "Hemoglobin Okaloosa");

                //Creamos Ingredients
                int ingredient1 = ingredientCEN.New_ ("2.2 mg", true, substanceCode1);
                int ingredient2 = ingredientCEN.New_ ("3.0 ml", true, substanceCode2);
                int ingredient3 = ingredientCEN.New_ ("3.88 kg", true, substanceCode2);

                IList<int> ingredientsMedication1 = new List<int>();
                ingredientsMedication1.Add (ingredient1);
                ingredientsMedication1.Add (ingredient2);

                IList<int> ingredientsMedication2 = new List<int>();
                ingredientsMedication2.Add (ingredient2);
                ingredientsMedication2.Add (ingredient3);

                //Asignamos ingredient a Medication
                medicationCEN.AssignIngredient (medication1, ingredientsMedication1);
                medicationCEN.AssignIngredient (medication2, ingredientsMedication2);

                //Creamos Conversation2
                IList<MessageEN> messagesConversation2 = new List<MessageEN>();
                int conversation2 = conversationCEN.New_ (new DateTime (2017, 04, 01), messagesConversation2, practitioner1);
                ConversationEN conversation2EN = new ConversationEN ();
                conversation2EN = conversationCEN.ReadOID (conversation2);

                conversationCEN.AssignPatient (conversation2, patient1);

                //Creamos Messages2
                int message12 = messageCEN.New_ (new DateTime (2017, 03, 01), "content", true, conversation2, "attachment");
                MessageEN message12EN = messageCEN.ReadOID (message12);
                messagesConversation2.Add (message12EN);
                int message22 = messageCEN.New_ (new DateTime (2017, 03, 01), "content", false, conversation2, "attachment");
                MessageEN message22EN = messageCEN.ReadOID (message22);
                messagesConversation2.Add (message22EN);

                //Creamos Conversation3
                IList<MessageEN> messagesConversation3 = new List<MessageEN>();
                int conversation3 = conversationCEN.New_ (new DateTime (2017, 04, 01), messagesConversation3, practitioner2);
                ConversationEN conversation3EN = new ConversationEN ();
                conversation3EN = conversationCEN.ReadOID (conversation3);

                conversationCEN.AssignRelatedPerson (conversation3, relatedPerson1);

                //Creamos Messages2
                int message13 = messageCEN.New_ (new DateTime (2017, 03, 01), "content", true, conversation3, "attachment");
                MessageEN message13EN = messageCEN.ReadOID (message13);
                messagesConversation3.Add (message12EN);
                int message23 = messageCEN.New_ (new DateTime (2017, 03, 01), "content", false, conversation3, "attachment");
                MessageEN message23EN = messageCEN.ReadOID (message23);
                messagesConversation3.Add (message22EN);


                //Creamos Reclamation
                int reclamation1 = reclamationCEN.New_ (ReclamationActionEnum.changePractitioner, "subject", "content",
                        new DateTime (2017, 04, 01), practitioner1, "note", false, ReclamationTypeEnum.administrative);

                //Creamos ReclamationResponse
                int reclamation1Response1 = reclamationResponseCEN.New_ ("response", ReclamationResponseActionStateEnum.taken,
                        new DateTime (2017, 04, 01), reclamation1);

                //Creamos Administrador
                int administrator1 = administratorCEN.New_ ("Juan", GenderEnum.male, DateTime.Now, "sinFoto", "unEmail", "1234", "Velasco", "555A", "UnaDireccion", "966459877");

                //Creamos assessment
                int assessment1 = assessmentCEN.New_ (4, practitioner1, patient2, -1);
                int assessment2 = assessmentCEN.New_ (3, practitioner2, -1, relatedPerson2);
                int assessment3 = assessmentCEN.New_ (1, practitioner2, patient1, -1);

                //Creamos customs Administrador
                administratorCEN.SetBirthDate (administrator1, new DateTime (1984, 5, 25));
                administratorCEN.SetEmail (administrator1, "juan@funciona.com");
                administratorCEN.SetGender (administrator1, GenderEnum.unknown);
                administratorCEN.SetPassword (administrator1, "1235", "PassNoValida");
                administratorCEN.SetPassword (administrator1, "1234", "PassValida");
                administratorCEN.SetPhoto (administrator1, "FotoPreciosa.jpg");
                administratorCEN.Login ("555A", "PassValida");
                administratorCEN.Logout (administrator1);

                //Creamos customs Assessment
                assessmentCEN.SetRating (assessment2, 5);

                //Creamos customs CarePlan
                carePlanCEN.SetEndDate (carePlan1, new DateTime (2017, 11, 27));
                carePlanCEN.SetModified (carePlan1, new DateTime (2017, 5, 13));

                //Creamos customs Condition
                conditionCEN.SetNote (condition1, "La nota de pruebas de Mayo");

                //Creamos customs Encounter
                encounterCEN.SetNote (encounter1, "La nota para los encounters");
                encounterCEN.SetPriority (encounter1, EncounterPriorityEnum.timing_critical);
                encounterCEN.SetStatus (encounter1, EncounterStatusEnum.planned);

                //Creamos customs Goal
                goalCEN.SetStatus (goal1, GoalStatusEnum.failure);
                goalCEN.SetStatusDate (goal1, new DateTime (2017, 05, 13));

                //Creamos customs Location
                locationCEN.SetEmail (location1, "prueba@ua.alu.ua.es");
                locationCEN.SetManagingOrganization (location1, "Una organización chula");
                locationCEN.SetMode (location1, LocationModeEnum.private_location);
                locationCEN.SetPhone (location1, "555999666");
                locationCEN.SetPhysicalType (location1, LocationPhysicalTypeEnum.vehicle);
                locationCEN.SetStatus (location1, LocationStatusEnum.suspended);
                locationCEN.SetType (location1, LocationTypeEnum.pharmacy);

                //Creamos customs Medication
                medicationCEN.SetDosage (medication1, "Dosis de prueba");
                medicationCEN.SetRate (medication1, 4.75);
                medicationCEN.SetStatus (medication1, MedicationStatusEnum.inactive);

                //Creamos customs Message
                messageCEN.SetIsRead (message13, true);

                //Creamos customs Observations
                observationCEN.SetDateObservation (observation1, new DateTime (2017, 05, 13));
                observationCEN.SetMeasureType (observation1, MeasureTypeEnum.Heart_rate);
                observationCEN.SetNote (observation1, "Nota prueba set correcta");
                observationCEN.SetSymptomGrade (observation1, SymptomGradeEnum.three);
                observationCEN.SetValue1 (observation1, 451.78);
                observationCEN.SetValue2 (observation1, 43.1);

                //Creamos customs Patients
                patientCEN.SetActive (patient1, false);
                patientCEN.SetAddress (patient1, "Direccion de prueba set funciona");
                patientCEN.SetBirthDate (patient1, new DateTime (1978, 12, 12));
                patientCEN.SetDeceased (patient1, true);
                patientCEN.SetEmail (patient1, "Email de prueba set funciona");
                patientCEN.SetMaritalStatus (patient1, MaritalStatusEnum.widowed);
                patientCEN.SetName (patient1, "Nombre de prueba set funciona");
                patientCEN.SetPassword (patient1, "passwordIncorecta", "1234");
                patientCEN.SetPassword (patient1, "password", "123456789");
                patientCEN.SetPhone (patient1, "Teléfono de prueba set funciona");
                patientCEN.SetSurnames (patient1, "Apellidos de prueba set funciona");
                patientCEN.Login ("inventado", "inventado");
                patientCEN.Login ("nif", "123456789");
                patientCEN.Logout (-458787454);
                patientCEN.Logout (458787454);
                patientCEN.Logout (patient1);


                //Creamos customs Practitioners
                practitionerCEN.SetActive (practitioner1, false);
                practitionerCEN.SetAddress (practitioner1, "Direccion de prueba set funciona");
                practitionerCEN.SetEmail (practitioner1, "Email de prueba set funciona");
                practitionerCEN.SetEndDate (practitioner1, new DateTime (2017, 09, 15));
                practitionerCEN.SetPassword (practitioner1, "passwordIncorecta", "1234");
                practitionerCEN.SetPassword (practitioner1, "password", "123456789");
                practitionerCEN.SetPhone (practitioner1, "Teléfono de prueba set funciona");
                practitionerCEN.SetPhoto (practitioner1, "Foto de prueba set funciona");
                practitionerCEN.SetRole (practitioner1, PractitionerRoleEnum.receptionist);
                practitionerCEN.Login ("inventado", "inventado");
                practitionerCEN.Login ("nif", "123456789");
                practitionerCEN.Logout (-458787454);
                practitionerCEN.Logout (458787454);
                practitionerCEN.Logout (practitioner1);

                //Creamos customs Reclamation
                reclamationCEN.SetNote (reclamation1, "Nota de prueba set funciona");
                reclamationCEN.SetResolved (reclamation1, false);

                //Creamos customs RelatedPerson
                relatedPersonCEN.SetAddress (relatedPerson1, "Dirección de prueba set funciona");
                relatedPersonCEN.SetEmail (relatedPerson1, "Email de prueba set funciona");
                relatedPersonCEN.SetEndDate (relatedPerson1, new DateTime (2017, 6, 20));
                relatedPersonCEN.SetPassword (relatedPerson1, "password1", "1234");
                relatedPersonCEN.SetPassword (relatedPerson1, "password", "abc123");
                relatedPersonCEN.SetPhone (relatedPerson1, "Telefono de prueba set funciona");
                relatedPersonCEN.SetPhoto (relatedPerson1, "Photo de prueba set funciona");
                relatedPersonCEN.Login ("inventado", "inventado");
                relatedPersonCEN.Login ("nif", "abc123");
                relatedPersonCEN.Logout (-555);
                relatedPersonCEN.Logout (789545896);
                relatedPersonCEN.Logout (relatedPerson1);

                //Creamos customs RelationShip
                relationshipCEN.SetRelationshipType (relationship_relatedPerson1_patient1, RelationshipEnum.caregiver);
                relationshipCEN.SetRelationship (relationship_relatedPerson1_patient1, patient1, relatedPerson2);

                //Creamos customs Schedule
                scheduleCEN.SetActive (schedule1_practitioner1, false);
                scheduleCEN.SetMorningStart (schedule1_practitioner1, new DateTime (2017, 5, 1, 9, 00, 00));
                scheduleCEN.SetMorningEnd (schedule1_practitioner1, new DateTime (2017, 5, 1, 13, 00, 00));
                scheduleCEN.SetAfternoonStart (schedule1_practitioner1, new DateTime (2017, 5, 1, 15, 00, 00));
                scheduleCEN.SetAfternoonEnd (schedule1_practitioner1, new DateTime (2017, 5, 1, 19, 00, 00));
                scheduleCEN.SetDateStart (schedule1_practitioner1, new DateTime (2017, 5, 1));
                scheduleCEN.SetDateEnd (schedule1_practitioner1, new DateTime (2018, 1, 1));

                slotCEN.SetNote (slot1_schedule1_practitioner1, "Prueba nota set funciona");
                slotCEN.SetStartDate (slot1_schedule1_practitioner1, new DateTime (2017, 05, 18, 10, 00, 00));
                slotCEN.SetEndDate (slot1_schedule1_practitioner1, new DateTime (2017, 05, 18, 10, 15, 00));
                slotCEN.SetStatus (slot1_schedule1_practitioner1, SlotStatusEnum.busy);

                IList<LocationEN> listaLocations = locationCEN.ReadAll (0, -1);

                List<int> numPacientesCentro = new List<int>();

                foreach (LocationEN loc in listaLocations) {
                        IList<PatientEN> listaPacientes = patientCEN.GetPatientsByLocation (loc.Identifier);
                        numPacientesCentro.Add (listaPacientes.Count);
                }
                


                List<int> numPractitionerCentro = new List<int>();

                foreach (LocationEN loc in listaLocations)
                {
                    IList<PractitionerEN> listaPacientes = practitionerCEN.GetPractitionersByLocation(loc.Identifier);
                    numPractitionerCentro.Add(listaPacientes.Count);
                }

                /*PROTECTED REGION END*/
            }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
