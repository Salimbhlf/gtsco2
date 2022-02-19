
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/07/2022 22:54:07
-- Generated from EDMX file: C:\Users\Thinkpad T450\Desktop\monapp\gtsco2\gtsco2\gtsco2\basededonne\gtsco.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gtsco1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Absence_annee_scolaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Absence] DROP CONSTRAINT [FK_Absence_annee_scolaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Absence_Semestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Absence] DROP CONSTRAINT [FK_Absence_Semestre];
GO
IF OBJECT_ID(N'[dbo].[FK_Absence_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Absence] DROP CONSTRAINT [FK_Absence_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Contract_avenant_changement_Employeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contract_avenant_changement] DROP CONSTRAINT [FK_Contract_avenant_changement_Employeur];
GO
IF OBJECT_ID(N'[dbo].[FK_Contract_avenant_changement_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contract_avenant_changement] DROP CONSTRAINT [FK_Contract_avenant_changement_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Contrat_changement_employeur_Employeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contrat_changement_employeur] DROP CONSTRAINT [FK_Contrat_changement_employeur_Employeur];
GO
IF OBJECT_ID(N'[dbo].[FK_Contrat_changement_employeur_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contrat_changement_employeur] DROP CONSTRAINT [FK_Contrat_changement_employeur_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Decision_Proce_verbal_delibation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Decision] DROP CONSTRAINT [FK_Decision_Proce_verbal_delibation];
GO
IF OBJECT_ID(N'[dbo].[FK_Decision_Promo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Decision] DROP CONSTRAINT [FK_Decision_Promo];
GO
IF OBJECT_ID(N'[dbo].[FK_Decision_Semestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Decision] DROP CONSTRAINT [FK_Decision_Semestre];
GO
IF OBJECT_ID(N'[dbo].[FK_Decision_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Decision] DROP CONSTRAINT [FK_Decision_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Evaluation_annee_scolaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_Evaluation_annee_scolaire];
GO
IF OBJECT_ID(N'[dbo].[FK_Evaluation_Module]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_Evaluation_Module];
GO
IF OBJECT_ID(N'[dbo].[FK_Evaluation_Semestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_Evaluation_Semestre];
GO
IF OBJECT_ID(N'[dbo].[FK_Evaluation_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_Evaluation_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Maitre_Apprentissage_Employeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Maitre_Apprentissage] DROP CONSTRAINT [FK_Maitre_Apprentissage_Employeur];
GO
IF OBJECT_ID(N'[dbo].[FK_Module_Opation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Module] DROP CONSTRAINT [FK_Module_Opation];
GO
IF OBJECT_ID(N'[dbo].[FK_Opation_Specialite]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Opation] DROP CONSTRAINT [FK_Opation_Specialite];
GO
IF OBJECT_ID(N'[dbo].[FK_Promo_Mode_formation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Promo] DROP CONSTRAINT [FK_Promo_Mode_formation];
GO
IF OBJECT_ID(N'[dbo].[FK_Promo_Opation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Promo] DROP CONSTRAINT [FK_Promo_Opation];
GO
IF OBJECT_ID(N'[dbo].[FK_Section_Mode_formation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Section] DROP CONSTRAINT [FK_Section_Mode_formation];
GO
IF OBJECT_ID(N'[dbo].[FK_Section_Opation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Section] DROP CONSTRAINT [FK_Section_Opation];
GO
IF OBJECT_ID(N'[dbo].[FK_Section_Promo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Section] DROP CONSTRAINT [FK_Section_Promo];
GO
IF OBJECT_ID(N'[dbo].[FK_semestre_annee_annee_scolaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[semestre_annee] DROP CONSTRAINT [FK_semestre_annee_annee_scolaire];
GO
IF OBJECT_ID(N'[dbo].[FK_semestre_annee_Semestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[semestre_annee] DROP CONSTRAINT [FK_semestre_annee_Semestre];
GO
IF OBJECT_ID(N'[dbo].[FK_soiver_stg_prof]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[soiver_stg] DROP CONSTRAINT [FK_soiver_stg_prof];
GO
IF OBJECT_ID(N'[dbo].[FK_soiver_stg_Semestre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[soiver_stg] DROP CONSTRAINT [FK_soiver_stg_Semestre];
GO
IF OBJECT_ID(N'[dbo].[FK_soiver_stg_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[soiver_stg] DROP CONSTRAINT [FK_soiver_stg_Stagiair];
GO
IF OBJECT_ID(N'[dbo].[FK_Specialite_Branch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Specialite] DROP CONSTRAINT [FK_Specialite_Branch];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_Employeur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_Employeur];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_Etablissement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_Etablissement];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_Maitre_Apprentissage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_Maitre_Apprentissage];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_Promo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_Promo];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_Section]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_Section];
GO
IF OBJECT_ID(N'[dbo].[FK_Stagiair_tuteur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stagiair] DROP CONSTRAINT [FK_Stagiair_tuteur];
GO
IF OBJECT_ID(N'[dbo].[FK_Transferer_Etablissement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transferer] DROP CONSTRAINT [FK_Transferer_Etablissement];
GO
IF OBJECT_ID(N'[dbo].[FK_Transferer_Stagiair]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transferer] DROP CONSTRAINT [FK_Transferer_Stagiair];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Absence]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Absence];
GO
IF OBJECT_ID(N'[dbo].[annee_scolaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[annee_scolaire];
GO
IF OBJECT_ID(N'[dbo].[Branch]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Branch];
GO
IF OBJECT_ID(N'[dbo].[Contract_avenant_changement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contract_avenant_changement];
GO
IF OBJECT_ID(N'[dbo].[Contrat_changement_employeur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contrat_changement_employeur];
GO
IF OBJECT_ID(N'[dbo].[Decision]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Decision];
GO
IF OBJECT_ID(N'[dbo].[Employeur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employeur];
GO
IF OBJECT_ID(N'[dbo].[Etablissement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Etablissement];
GO
IF OBJECT_ID(N'[dbo].[Evaluation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evaluation];
GO
IF OBJECT_ID(N'[dbo].[Maitre_Apprentissage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Maitre_Apprentissage];
GO
IF OBJECT_ID(N'[dbo].[Mode_formation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mode_formation];
GO
IF OBJECT_ID(N'[dbo].[Module]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Module];
GO
IF OBJECT_ID(N'[dbo].[Opation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Opation];
GO
IF OBJECT_ID(N'[dbo].[Proce_verbal_delibation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proce_verbal_delibation];
GO
IF OBJECT_ID(N'[dbo].[prof]', 'U') IS NOT NULL
    DROP TABLE [dbo].[prof];
GO
IF OBJECT_ID(N'[dbo].[Promo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Promo];
GO
IF OBJECT_ID(N'[dbo].[Section]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Section];
GO
IF OBJECT_ID(N'[dbo].[Semestre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Semestre];
GO
IF OBJECT_ID(N'[dbo].[semestre_annee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[semestre_annee];
GO
IF OBJECT_ID(N'[dbo].[soiver_stg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[soiver_stg];
GO
IF OBJECT_ID(N'[dbo].[Specialite]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Specialite];
GO
IF OBJECT_ID(N'[dbo].[Stagiair]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stagiair];
GO
IF OBJECT_ID(N'[dbo].[Transferer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transferer];
GO
IF OBJECT_ID(N'[dbo].[tuteur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tuteur];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Absences'
CREATE TABLE [dbo].[Absences] (
    [ID_Absence] int IDENTITY(1,1) NOT NULL,
    [Seance_1_ABS] bit  NULL,
    [Seance_2_ABS] bit  NULL,
    [Seance_3_ABS] bit  NULL,
    [Seance_4_ABS] bit  NULL,
    [Date_ABS] datetime  NULL,
    [Justif_ABS] varchar(50)  NULL,
    [Num_STG] varchar(12)  NULL,
    [ID_Semestre] int  NULL,
    [ID_Année_SCO] int  NULL,
    [Absence_Justifer] bit  NULL
);
GO

-- Creating table 'annee_scolaire'
CREATE TABLE [dbo].[annee_scolaire] (
    [ID_Année_SCO] int  NOT NULL,
    [disination] varchar(50)  NULL,
    [DATE_D_Année_SCO] datetime  NULL,
    [Date_F_Année_SCO] datetime  NULL,
    [Session_Année_SCO] varchar(15)  NULL
);
GO

-- Creating table 'Branches'
CREATE TABLE [dbo].[Branches] (
    [Code_Branche] varchar(15)  NOT NULL,
    [Designation_Branche] varchar(30)  NULL
);
GO

-- Creating table 'Contract_avenant_changement'
CREATE TABLE [dbo].[Contract_avenant_changement] (
    [id_emp] int  NOT NULL,
    [num_stg] varchar(12)  NOT NULL,
    [NUM_AV_CHANG] int  NULL,
    [NUM_AV_VALID_CHANG] int  NULL,
    [DATE_AV_VALID_CHANG] datetime  NULL,
    [DATE_DBT_FORMA_CHANG] datetime  NULL,
    [DATE_FIN_FORMA_CHANG] datetime  NULL,
    [DATE_FIN_FORMA_ANCIEN_EMP] datetime  NULL
);
GO

-- Creating table 'Contrat_changement_employeur'
CREATE TABLE [dbo].[Contrat_changement_employeur] (
    [Num_stg] varchar(12)  NOT NULL,
    [ID_emp] int  NOT NULL,
    [Num_validation_cont_proro] int  NULL,
    [date_validation_cont_proro] datetime  NULL,
    [date_dbt_proro] datetime  NULL,
    [date_fin_proro] datetime  NULL
);
GO

-- Creating table 'Decisions'
CREATE TABLE [dbo].[Decisions] (
    [ID_Decision] int IDENTITY(1,1) NOT NULL,
    [Type_Decision] varchar(30)  NULL,
    [Date_Decision] datetime  NULL,
    [ID_PV_Délibiration] int  NULL,
    [ID_Promo] int  NULL,
    [ID_Semestre] int  NULL,
    [Num_STG] varchar(12)  NULL
);
GO

-- Creating table 'Employeurs'
CREATE TABLE [dbo].[Employeurs] (
    [ID_Emp] int IDENTITY(1,1) NOT NULL,
    [Type_Emp] varchar(10)  NULL,
    [Nature_Emp] varchar(6)  NULL,
    [Nom_Emp] varchar(25)  NULL,
    [Statut_Emp] varchar(25)  NULL,
    [Adresse_Emp] varchar(80)  NULL,
    [Code_Postal_Emp] int  NULL,
    [Commune_Emp] varchar(50)  NULL,
    [Tel_Emp] int  NULL,
    [Fax_Emp] int  NULL,
    [Mail_Emp] varchar(30)  NULL,
    [Fonction_Emp] varchar(30)  NULL,
    [Secteur_Activité_Emp] varchar(50)  NULL
);
GO

-- Creating table 'Etablissements'
CREATE TABLE [dbo].[Etablissements] (
    [ID_ETAB] int  NOT NULL,
    [Nom_ETAB] varchar(25)  NULL,
    [Tél_ETAB] int  NULL,
    [Fax_ETAB] int  NULL,
    [Mail_ETAB] varchar(30)  NULL,
    [Code_Postal_EATB] int  NULL,
    [Commune_ETAB] varchar(40)  NULL,
    [Adresse_ETAB] varchar(80)  NULL
);
GO

-- Creating table 'Evaluations'
CREATE TABLE [dbo].[Evaluations] (
    [Num_STG] varchar(12)  NOT NULL,
    [ID_Semestre] int  NOT NULL,
    [ID_Année_SCO] int  NOT NULL,
    [ID_Module] int  NOT NULL,
    [Control_1] float  NULL,
    [Control_2] float  NULL,
    [Exam] float  NULL,
    [Rattrapage] float  NULL
);
GO

-- Creating table 'Maitre_Apprentissage'
CREATE TABLE [dbo].[Maitre_Apprentissage] (
    [ID_Maitre_Apprentissage] int IDENTITY(1,1) NOT NULL,
    [ID_Emp] int  NULL,
    [Nom_Maitre_Apprentissage] varchar(25)  NULL,
    [Prenom_Maitre_Apprentissage] varchar(25)  NULL,
    [Qualification_Maitre_Apprentissage] varchar(50)  NULL,
    [Profil_Maitre_Apprentissage] varchar(30)  NULL,
    [Poste_Maitre_Apprentissage] varchar(30)  NULL,
    [Ancienté_Métier_Maitre_Apprentissage] int  NULL,
    [Ancienté_Entriprise_Maitre_Apprentissage] int  NULL,
    [Ayant_Suivie_Stage] varchar(3)  NULL,
    [Nbr_Stgiaire_Former] int  NULL,
    [Adresse_Maitre_Apprentissage] varchar(80)  NULL,
    [Commune_Maitre_Apprentissage] varchar(40)  NULL,
    [Daira_Maitre_Apprentissage] varchar(40)  NULL,
    [Wilaya_Maitre_Apprentissage] varchar(30)  NULL,
    [Mail_Maitre_Apprentissage] varchar(30)  NULL,
    [Tel_Maitre_Apprentissage] int  NULL
);
GO

-- Creating table 'Mode_formation'
CREATE TABLE [dbo].[Mode_formation] (
    [ID_Mode_Formation] int IDENTITY(1,1) NOT NULL,
    [Code_Mode_Formation] varchar(10)  NULL,
    [Désignation_Mode_Formation] varchar(30)  NULL
);
GO

-- Creating table 'Modules'
CREATE TABLE [dbo].[Modules] (
    [ID_Module] int IDENTITY(1,1) NOT NULL,
    [Designation_Module] varchar(30)  NULL,
    [Note_Elim_Module] float  NULL,
    [coefficient_Module] int  NULL,
    [ID_Option] int  NULL
);
GO

-- Creating table 'Opations'
CREATE TABLE [dbo].[Opations] (
    [ID_Option] int IDENTITY(1,1) NOT NULL,
    [Code_Option] varchar(10)  NULL,
    [Designation_Option] varchar(50)  NULL,
    [Specialite] int  NULL
);
GO

-- Creating table 'Proce_verbal_delibation'
CREATE TABLE [dbo].[Proce_verbal_delibation] (
    [ID_PV_Délibiration] int IDENTITY(1,1) NOT NULL,
    [Num_PV_Délibiraiton] int  NULL,
    [Date_PV_Délibiration] datetime  NULL
);
GO

-- Creating table 'profs'
CREATE TABLE [dbo].[profs] (
    [id_prof] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(50)  NULL,
    [prenom] varchar(50)  NULL,
    [spesalite] varchar(50)  NULL
);
GO

-- Creating table 'Promoes'
CREATE TABLE [dbo].[Promoes] (
    [ID_Promo] int IDENTITY(1,1) NOT NULL,
    [Code_Promo] varchar(10)  NULL,
    [Diplome] varchar(30)  NULL,
    [DATE_D_Formation] datetime  NULL,
    [Date_F_Formation] datetime  NULL,
    [ID_Option] int  NULL,
    [Mode_de_formation] int  NULL
);
GO

-- Creating table 'Sections'
CREATE TABLE [dbo].[Sections] (
    [SectionID] int IDENTITY(1,1) NOT NULL,
    [Code_Section] varchar(10)  NULL,
    [ID_Promo] int  NULL,
    [ID_Mode_Formation] int  NULL,
    [ID_Option] int  NULL
);
GO

-- Creating table 'Semestres'
CREATE TABLE [dbo].[Semestres] (
    [ID_Semestre] int IDENTITY(1,1) NOT NULL,
    [Designation_Semestre] varchar(25)  NULL
);
GO

-- Creating table 'semestre_annee'
CREATE TABLE [dbo].[semestre_annee] (
    [ID_Semestre] int  NOT NULL,
    [id_annee_sco] int  NOT NULL,
    [date_dube_semester] datetime  NULL,
    [date_fin_semester] datetime  NULL
);
GO

-- Creating table 'soiver_stg'
CREATE TABLE [dbo].[soiver_stg] (
    [num_stg] varchar(12)  NOT NULL,
    [prof] int  NOT NULL,
    [semestre] int  NOT NULL,
    [NBR__VISITE_FORMATEUR] int  NULL,
    [OBSERV_FORMAT] varchar(50)  NULL
);
GO

-- Creating table 'Specialites'
CREATE TABLE [dbo].[Specialites] (
    [ID_Specialité] int IDENTITY(1,1) NOT NULL,
    [Code_SP] varchar(10)  NULL,
    [Designation_SP] varchar(50)  NULL,
    [ID_Branche] varchar(15)  NULL
);
GO

-- Creating table 'Stagiairs'
CREATE TABLE [dbo].[Stagiairs] (
    [Num_STG] varchar(12)  NOT NULL,
    [Nom] varchar(25)  NULL,
    [Prenom] varchar(25)  NULL,
    [Date_de_Naissance] datetime  NULL,
    [Lieu_Naissance] varchar(40)  NULL,
    [Adresse] varchar(80)  NULL,
    [Code_postal] int  NULL,
    [Commune] varchar(50)  NULL,
    [Sexe] varchar(5)  NULL,
    [Telephone] int  NULL,
    [E_Maile] varchar(30)  NULL,
    [Nivo_SCO] varchar(25)  NULL,
    [Prenom_Père_STG] varchar(25)  NULL,
    [Nom_Mère_STG] varchar(25)  NULL,
    [Prenom_Mère_STG] varchar(25)  NULL,
    [Nbr_Frère_STG] int  NULL,
    [Situation_Familiale_STG] varchar(20)  NULL,
    [Situation_Familiale_Parents_STG] varchar(20)  NULL,
    [Profession_Père_STG] varchar(25)  NULL,
    [Profession_Mère_STG] varchar(25)  NULL,
    [Nationalité_STG] varchar(25)  NULL,
    [Num_Diplom_STG] varchar(20)  NULL,
    [ID_Emp] int  NULL,
    [Num_Validation_Contrat_STG] int  NULL,
    [Date_Validation_Contrat_STG] datetime  NULL,
    [Date_Resiliation_Contrat_STG] datetime  NULL,
    [ID_Maitre_Apprentissage] int  NULL,
    [ID_ETAB] int  NULL,
    [Num_Avenant_Cont_Prorogation] int  NULL,
    [Num_Validation_Cont_Prorogation] int  NULL,
    [Date_D_Prorgation] datetime  NULL,
    [Date_F_Prorogation] datetime  NULL,
    [Section] int  NULL,
    [id_tuteur] int  NULL,
    [ID_Promo] int  NULL,
    [photo] varbinary(max)  NULL
);
GO

-- Creating table 'Transferers'
CREATE TABLE [dbo].[Transferers] (
    [ID_etb] int  NOT NULL,
    [num_stg] varchar(12)  NOT NULL,
    [nom_directeur] varchar(50)  NULL,
    [prinom_directeur] varchar(50)  NULL,
    [date_transfert] datetime  NULL
);
GO

-- Creating table 'tuteurs'
CREATE TABLE [dbo].[tuteurs] (
    [id_tuteur] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(50)  NULL,
    [prenom] varchar(50)  NULL,
    [aderisse] varchar(50)  NULL,
    [code_postal] int  NULL,
    [comunne] varchar(50)  NULL,
    [telephone] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Absence] in table 'Absences'
ALTER TABLE [dbo].[Absences]
ADD CONSTRAINT [PK_Absences]
    PRIMARY KEY CLUSTERED ([ID_Absence] ASC);
GO

-- Creating primary key on [ID_Année_SCO] in table 'annee_scolaire'
ALTER TABLE [dbo].[annee_scolaire]
ADD CONSTRAINT [PK_annee_scolaire]
    PRIMARY KEY CLUSTERED ([ID_Année_SCO] ASC);
GO

-- Creating primary key on [Code_Branche] in table 'Branches'
ALTER TABLE [dbo].[Branches]
ADD CONSTRAINT [PK_Branches]
    PRIMARY KEY CLUSTERED ([Code_Branche] ASC);
GO

-- Creating primary key on [id_emp], [num_stg] in table 'Contract_avenant_changement'
ALTER TABLE [dbo].[Contract_avenant_changement]
ADD CONSTRAINT [PK_Contract_avenant_changement]
    PRIMARY KEY CLUSTERED ([id_emp], [num_stg] ASC);
GO

-- Creating primary key on [Num_stg], [ID_emp] in table 'Contrat_changement_employeur'
ALTER TABLE [dbo].[Contrat_changement_employeur]
ADD CONSTRAINT [PK_Contrat_changement_employeur]
    PRIMARY KEY CLUSTERED ([Num_stg], [ID_emp] ASC);
GO

-- Creating primary key on [ID_Decision] in table 'Decisions'
ALTER TABLE [dbo].[Decisions]
ADD CONSTRAINT [PK_Decisions]
    PRIMARY KEY CLUSTERED ([ID_Decision] ASC);
GO

-- Creating primary key on [ID_Emp] in table 'Employeurs'
ALTER TABLE [dbo].[Employeurs]
ADD CONSTRAINT [PK_Employeurs]
    PRIMARY KEY CLUSTERED ([ID_Emp] ASC);
GO

-- Creating primary key on [ID_ETAB] in table 'Etablissements'
ALTER TABLE [dbo].[Etablissements]
ADD CONSTRAINT [PK_Etablissements]
    PRIMARY KEY CLUSTERED ([ID_ETAB] ASC);
GO

-- Creating primary key on [Num_STG], [ID_Semestre], [ID_Année_SCO], [ID_Module] in table 'Evaluations'
ALTER TABLE [dbo].[Evaluations]
ADD CONSTRAINT [PK_Evaluations]
    PRIMARY KEY CLUSTERED ([Num_STG], [ID_Semestre], [ID_Année_SCO], [ID_Module] ASC);
GO

-- Creating primary key on [ID_Maitre_Apprentissage] in table 'Maitre_Apprentissage'
ALTER TABLE [dbo].[Maitre_Apprentissage]
ADD CONSTRAINT [PK_Maitre_Apprentissage]
    PRIMARY KEY CLUSTERED ([ID_Maitre_Apprentissage] ASC);
GO

-- Creating primary key on [ID_Mode_Formation] in table 'Mode_formation'
ALTER TABLE [dbo].[Mode_formation]
ADD CONSTRAINT [PK_Mode_formation]
    PRIMARY KEY CLUSTERED ([ID_Mode_Formation] ASC);
GO

-- Creating primary key on [ID_Module] in table 'Modules'
ALTER TABLE [dbo].[Modules]
ADD CONSTRAINT [PK_Modules]
    PRIMARY KEY CLUSTERED ([ID_Module] ASC);
GO

-- Creating primary key on [ID_Option] in table 'Opations'
ALTER TABLE [dbo].[Opations]
ADD CONSTRAINT [PK_Opations]
    PRIMARY KEY CLUSTERED ([ID_Option] ASC);
GO

-- Creating primary key on [ID_PV_Délibiration] in table 'Proce_verbal_delibation'
ALTER TABLE [dbo].[Proce_verbal_delibation]
ADD CONSTRAINT [PK_Proce_verbal_delibation]
    PRIMARY KEY CLUSTERED ([ID_PV_Délibiration] ASC);
GO

-- Creating primary key on [id_prof] in table 'profs'
ALTER TABLE [dbo].[profs]
ADD CONSTRAINT [PK_profs]
    PRIMARY KEY CLUSTERED ([id_prof] ASC);
GO

-- Creating primary key on [ID_Promo] in table 'Promoes'
ALTER TABLE [dbo].[Promoes]
ADD CONSTRAINT [PK_Promoes]
    PRIMARY KEY CLUSTERED ([ID_Promo] ASC);
GO

-- Creating primary key on [SectionID] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [PK_Sections]
    PRIMARY KEY CLUSTERED ([SectionID] ASC);
GO

-- Creating primary key on [ID_Semestre] in table 'Semestres'
ALTER TABLE [dbo].[Semestres]
ADD CONSTRAINT [PK_Semestres]
    PRIMARY KEY CLUSTERED ([ID_Semestre] ASC);
GO

-- Creating primary key on [ID_Semestre], [id_annee_sco] in table 'semestre_annee'
ALTER TABLE [dbo].[semestre_annee]
ADD CONSTRAINT [PK_semestre_annee]
    PRIMARY KEY CLUSTERED ([ID_Semestre], [id_annee_sco] ASC);
GO

-- Creating primary key on [num_stg], [prof], [semestre] in table 'soiver_stg'
ALTER TABLE [dbo].[soiver_stg]
ADD CONSTRAINT [PK_soiver_stg]
    PRIMARY KEY CLUSTERED ([num_stg], [prof], [semestre] ASC);
GO

-- Creating primary key on [ID_Specialité] in table 'Specialites'
ALTER TABLE [dbo].[Specialites]
ADD CONSTRAINT [PK_Specialites]
    PRIMARY KEY CLUSTERED ([ID_Specialité] ASC);
GO

-- Creating primary key on [Num_STG] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [PK_Stagiairs]
    PRIMARY KEY CLUSTERED ([Num_STG] ASC);
GO

-- Creating primary key on [ID_etb], [num_stg] in table 'Transferers'
ALTER TABLE [dbo].[Transferers]
ADD CONSTRAINT [PK_Transferers]
    PRIMARY KEY CLUSTERED ([ID_etb], [num_stg] ASC);
GO

-- Creating primary key on [id_tuteur] in table 'tuteurs'
ALTER TABLE [dbo].[tuteurs]
ADD CONSTRAINT [PK_tuteurs]
    PRIMARY KEY CLUSTERED ([id_tuteur] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_Année_SCO] in table 'Absences'
ALTER TABLE [dbo].[Absences]
ADD CONSTRAINT [FK_Absence_annee_scolaire]
    FOREIGN KEY ([ID_Année_SCO])
    REFERENCES [dbo].[annee_scolaire]
        ([ID_Année_SCO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Absence_annee_scolaire'
CREATE INDEX [IX_FK_Absence_annee_scolaire]
ON [dbo].[Absences]
    ([ID_Année_SCO]);
GO

-- Creating foreign key on [ID_Semestre] in table 'Absences'
ALTER TABLE [dbo].[Absences]
ADD CONSTRAINT [FK_Absence_Semestre]
    FOREIGN KEY ([ID_Semestre])
    REFERENCES [dbo].[Semestres]
        ([ID_Semestre])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Absence_Semestre'
CREATE INDEX [IX_FK_Absence_Semestre]
ON [dbo].[Absences]
    ([ID_Semestre]);
GO

-- Creating foreign key on [Num_STG] in table 'Absences'
ALTER TABLE [dbo].[Absences]
ADD CONSTRAINT [FK_Absence_Stagiair]
    FOREIGN KEY ([Num_STG])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Absence_Stagiair'
CREATE INDEX [IX_FK_Absence_Stagiair]
ON [dbo].[Absences]
    ([Num_STG]);
GO

-- Creating foreign key on [ID_Année_SCO] in table 'Evaluations'
ALTER TABLE [dbo].[Evaluations]
ADD CONSTRAINT [FK_Evaluation_annee_scolaire]
    FOREIGN KEY ([ID_Année_SCO])
    REFERENCES [dbo].[annee_scolaire]
        ([ID_Année_SCO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evaluation_annee_scolaire'
CREATE INDEX [IX_FK_Evaluation_annee_scolaire]
ON [dbo].[Evaluations]
    ([ID_Année_SCO]);
GO

-- Creating foreign key on [id_annee_sco] in table 'semestre_annee'
ALTER TABLE [dbo].[semestre_annee]
ADD CONSTRAINT [FK_semestre_annee_annee_scolaire]
    FOREIGN KEY ([id_annee_sco])
    REFERENCES [dbo].[annee_scolaire]
        ([ID_Année_SCO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_semestre_annee_annee_scolaire'
CREATE INDEX [IX_FK_semestre_annee_annee_scolaire]
ON [dbo].[semestre_annee]
    ([id_annee_sco]);
GO

-- Creating foreign key on [ID_Branche] in table 'Specialites'
ALTER TABLE [dbo].[Specialites]
ADD CONSTRAINT [FK_Specialite_Branch]
    FOREIGN KEY ([ID_Branche])
    REFERENCES [dbo].[Branches]
        ([Code_Branche])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Specialite_Branch'
CREATE INDEX [IX_FK_Specialite_Branch]
ON [dbo].[Specialites]
    ([ID_Branche]);
GO

-- Creating foreign key on [id_emp] in table 'Contract_avenant_changement'
ALTER TABLE [dbo].[Contract_avenant_changement]
ADD CONSTRAINT [FK_Contract_avenant_changement_Employeur]
    FOREIGN KEY ([id_emp])
    REFERENCES [dbo].[Employeurs]
        ([ID_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [num_stg] in table 'Contract_avenant_changement'
ALTER TABLE [dbo].[Contract_avenant_changement]
ADD CONSTRAINT [FK_Contract_avenant_changement_Stagiair]
    FOREIGN KEY ([num_stg])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contract_avenant_changement_Stagiair'
CREATE INDEX [IX_FK_Contract_avenant_changement_Stagiair]
ON [dbo].[Contract_avenant_changement]
    ([num_stg]);
GO

-- Creating foreign key on [ID_emp] in table 'Contrat_changement_employeur'
ALTER TABLE [dbo].[Contrat_changement_employeur]
ADD CONSTRAINT [FK_Contrat_changement_employeur_Employeur]
    FOREIGN KEY ([ID_emp])
    REFERENCES [dbo].[Employeurs]
        ([ID_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contrat_changement_employeur_Employeur'
CREATE INDEX [IX_FK_Contrat_changement_employeur_Employeur]
ON [dbo].[Contrat_changement_employeur]
    ([ID_emp]);
GO

-- Creating foreign key on [Num_stg] in table 'Contrat_changement_employeur'
ALTER TABLE [dbo].[Contrat_changement_employeur]
ADD CONSTRAINT [FK_Contrat_changement_employeur_Stagiair]
    FOREIGN KEY ([Num_stg])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_PV_Délibiration] in table 'Decisions'
ALTER TABLE [dbo].[Decisions]
ADD CONSTRAINT [FK_Decision_Proce_verbal_delibation]
    FOREIGN KEY ([ID_PV_Délibiration])
    REFERENCES [dbo].[Proce_verbal_delibation]
        ([ID_PV_Délibiration])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Decision_Proce_verbal_delibation'
CREATE INDEX [IX_FK_Decision_Proce_verbal_delibation]
ON [dbo].[Decisions]
    ([ID_PV_Délibiration]);
GO

-- Creating foreign key on [ID_Promo] in table 'Decisions'
ALTER TABLE [dbo].[Decisions]
ADD CONSTRAINT [FK_Decision_Promo]
    FOREIGN KEY ([ID_Promo])
    REFERENCES [dbo].[Promoes]
        ([ID_Promo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Decision_Promo'
CREATE INDEX [IX_FK_Decision_Promo]
ON [dbo].[Decisions]
    ([ID_Promo]);
GO

-- Creating foreign key on [ID_Semestre] in table 'Decisions'
ALTER TABLE [dbo].[Decisions]
ADD CONSTRAINT [FK_Decision_Semestre]
    FOREIGN KEY ([ID_Semestre])
    REFERENCES [dbo].[Semestres]
        ([ID_Semestre])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Decision_Semestre'
CREATE INDEX [IX_FK_Decision_Semestre]
ON [dbo].[Decisions]
    ([ID_Semestre]);
GO

-- Creating foreign key on [Num_STG] in table 'Decisions'
ALTER TABLE [dbo].[Decisions]
ADD CONSTRAINT [FK_Decision_Stagiair]
    FOREIGN KEY ([Num_STG])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Decision_Stagiair'
CREATE INDEX [IX_FK_Decision_Stagiair]
ON [dbo].[Decisions]
    ([Num_STG]);
GO

-- Creating foreign key on [ID_Emp] in table 'Maitre_Apprentissage'
ALTER TABLE [dbo].[Maitre_Apprentissage]
ADD CONSTRAINT [FK_Maitre_Apprentissage_Employeur]
    FOREIGN KEY ([ID_Emp])
    REFERENCES [dbo].[Employeurs]
        ([ID_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Maitre_Apprentissage_Employeur'
CREATE INDEX [IX_FK_Maitre_Apprentissage_Employeur]
ON [dbo].[Maitre_Apprentissage]
    ([ID_Emp]);
GO

-- Creating foreign key on [ID_Emp] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_Employeur]
    FOREIGN KEY ([ID_Emp])
    REFERENCES [dbo].[Employeurs]
        ([ID_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_Employeur'
CREATE INDEX [IX_FK_Stagiair_Employeur]
ON [dbo].[Stagiairs]
    ([ID_Emp]);
GO

-- Creating foreign key on [ID_ETAB] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_Etablissement]
    FOREIGN KEY ([ID_ETAB])
    REFERENCES [dbo].[Etablissements]
        ([ID_ETAB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_Etablissement'
CREATE INDEX [IX_FK_Stagiair_Etablissement]
ON [dbo].[Stagiairs]
    ([ID_ETAB]);
GO

-- Creating foreign key on [ID_etb] in table 'Transferers'
ALTER TABLE [dbo].[Transferers]
ADD CONSTRAINT [FK_Transferer_Etablissement]
    FOREIGN KEY ([ID_etb])
    REFERENCES [dbo].[Etablissements]
        ([ID_ETAB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_Module] in table 'Evaluations'
ALTER TABLE [dbo].[Evaluations]
ADD CONSTRAINT [FK_Evaluation_Module]
    FOREIGN KEY ([ID_Module])
    REFERENCES [dbo].[Modules]
        ([ID_Module])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evaluation_Module'
CREATE INDEX [IX_FK_Evaluation_Module]
ON [dbo].[Evaluations]
    ([ID_Module]);
GO

-- Creating foreign key on [ID_Semestre] in table 'Evaluations'
ALTER TABLE [dbo].[Evaluations]
ADD CONSTRAINT [FK_Evaluation_Semestre]
    FOREIGN KEY ([ID_Semestre])
    REFERENCES [dbo].[Semestres]
        ([ID_Semestre])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evaluation_Semestre'
CREATE INDEX [IX_FK_Evaluation_Semestre]
ON [dbo].[Evaluations]
    ([ID_Semestre]);
GO

-- Creating foreign key on [Num_STG] in table 'Evaluations'
ALTER TABLE [dbo].[Evaluations]
ADD CONSTRAINT [FK_Evaluation_Stagiair]
    FOREIGN KEY ([Num_STG])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_Maitre_Apprentissage] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_Maitre_Apprentissage]
    FOREIGN KEY ([ID_Maitre_Apprentissage])
    REFERENCES [dbo].[Maitre_Apprentissage]
        ([ID_Maitre_Apprentissage])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_Maitre_Apprentissage'
CREATE INDEX [IX_FK_Stagiair_Maitre_Apprentissage]
ON [dbo].[Stagiairs]
    ([ID_Maitre_Apprentissage]);
GO

-- Creating foreign key on [Mode_de_formation] in table 'Promoes'
ALTER TABLE [dbo].[Promoes]
ADD CONSTRAINT [FK_Promo_Mode_formation]
    FOREIGN KEY ([Mode_de_formation])
    REFERENCES [dbo].[Mode_formation]
        ([ID_Mode_Formation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Promo_Mode_formation'
CREATE INDEX [IX_FK_Promo_Mode_formation]
ON [dbo].[Promoes]
    ([Mode_de_formation]);
GO

-- Creating foreign key on [ID_Mode_Formation] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [FK_Section_Mode_formation]
    FOREIGN KEY ([ID_Mode_Formation])
    REFERENCES [dbo].[Mode_formation]
        ([ID_Mode_Formation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Section_Mode_formation'
CREATE INDEX [IX_FK_Section_Mode_formation]
ON [dbo].[Sections]
    ([ID_Mode_Formation]);
GO

-- Creating foreign key on [ID_Option] in table 'Modules'
ALTER TABLE [dbo].[Modules]
ADD CONSTRAINT [FK_Module_Opation]
    FOREIGN KEY ([ID_Option])
    REFERENCES [dbo].[Opations]
        ([ID_Option])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Module_Opation'
CREATE INDEX [IX_FK_Module_Opation]
ON [dbo].[Modules]
    ([ID_Option]);
GO

-- Creating foreign key on [Specialite] in table 'Opations'
ALTER TABLE [dbo].[Opations]
ADD CONSTRAINT [FK_Opation_Specialite]
    FOREIGN KEY ([Specialite])
    REFERENCES [dbo].[Specialites]
        ([ID_Specialité])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Opation_Specialite'
CREATE INDEX [IX_FK_Opation_Specialite]
ON [dbo].[Opations]
    ([Specialite]);
GO

-- Creating foreign key on [ID_Option] in table 'Promoes'
ALTER TABLE [dbo].[Promoes]
ADD CONSTRAINT [FK_Promo_Opation]
    FOREIGN KEY ([ID_Option])
    REFERENCES [dbo].[Opations]
        ([ID_Option])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Promo_Opation'
CREATE INDEX [IX_FK_Promo_Opation]
ON [dbo].[Promoes]
    ([ID_Option]);
GO

-- Creating foreign key on [ID_Option] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [FK_Section_Opation]
    FOREIGN KEY ([ID_Option])
    REFERENCES [dbo].[Opations]
        ([ID_Option])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Section_Opation'
CREATE INDEX [IX_FK_Section_Opation]
ON [dbo].[Sections]
    ([ID_Option]);
GO

-- Creating foreign key on [prof] in table 'soiver_stg'
ALTER TABLE [dbo].[soiver_stg]
ADD CONSTRAINT [FK_soiver_stg_prof]
    FOREIGN KEY ([prof])
    REFERENCES [dbo].[profs]
        ([id_prof])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_soiver_stg_prof'
CREATE INDEX [IX_FK_soiver_stg_prof]
ON [dbo].[soiver_stg]
    ([prof]);
GO

-- Creating foreign key on [ID_Promo] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [FK_Section_Promo]
    FOREIGN KEY ([ID_Promo])
    REFERENCES [dbo].[Promoes]
        ([ID_Promo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Section_Promo'
CREATE INDEX [IX_FK_Section_Promo]
ON [dbo].[Sections]
    ([ID_Promo]);
GO

-- Creating foreign key on [ID_Promo] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_Promo]
    FOREIGN KEY ([ID_Promo])
    REFERENCES [dbo].[Promoes]
        ([ID_Promo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_Promo'
CREATE INDEX [IX_FK_Stagiair_Promo]
ON [dbo].[Stagiairs]
    ([ID_Promo]);
GO

-- Creating foreign key on [Section] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_Section]
    FOREIGN KEY ([Section])
    REFERENCES [dbo].[Sections]
        ([SectionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_Section'
CREATE INDEX [IX_FK_Stagiair_Section]
ON [dbo].[Stagiairs]
    ([Section]);
GO

-- Creating foreign key on [ID_Semestre] in table 'semestre_annee'
ALTER TABLE [dbo].[semestre_annee]
ADD CONSTRAINT [FK_semestre_annee_Semestre]
    FOREIGN KEY ([ID_Semestre])
    REFERENCES [dbo].[Semestres]
        ([ID_Semestre])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [semestre] in table 'soiver_stg'
ALTER TABLE [dbo].[soiver_stg]
ADD CONSTRAINT [FK_soiver_stg_Semestre]
    FOREIGN KEY ([semestre])
    REFERENCES [dbo].[Semestres]
        ([ID_Semestre])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_soiver_stg_Semestre'
CREATE INDEX [IX_FK_soiver_stg_Semestre]
ON [dbo].[soiver_stg]
    ([semestre]);
GO

-- Creating foreign key on [num_stg] in table 'soiver_stg'
ALTER TABLE [dbo].[soiver_stg]
ADD CONSTRAINT [FK_soiver_stg_Stagiair]
    FOREIGN KEY ([num_stg])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_tuteur] in table 'Stagiairs'
ALTER TABLE [dbo].[Stagiairs]
ADD CONSTRAINT [FK_Stagiair_tuteur]
    FOREIGN KEY ([id_tuteur])
    REFERENCES [dbo].[tuteurs]
        ([id_tuteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Stagiair_tuteur'
CREATE INDEX [IX_FK_Stagiair_tuteur]
ON [dbo].[Stagiairs]
    ([id_tuteur]);
GO

-- Creating foreign key on [num_stg] in table 'Transferers'
ALTER TABLE [dbo].[Transferers]
ADD CONSTRAINT [FK_Transferer_Stagiair]
    FOREIGN KEY ([num_stg])
    REFERENCES [dbo].[Stagiairs]
        ([Num_STG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Transferer_Stagiair'
CREATE INDEX [IX_FK_Transferer_Stagiair]
ON [dbo].[Transferers]
    ([num_stg]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------