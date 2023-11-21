using System.Text.Json.Serialization;

namespace VehicleInformationService.Infrastructure.Rdw;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
internal class LicensedVehicleDto
{
    [JsonPropertyName("kenteken")]
    public string Kenteken { get; set; }
    [JsonPropertyName("voertuigsoort")]
    public string Voertuigsoort { get; set; }
    [JsonPropertyName("merk")]
    public string Merk { get; set; }
    [JsonPropertyName("handelsbenaming")]
    public string Handelsbenaming { get; set; }
    [JsonPropertyName("vervaldatum_apk")]
    public int VervaldatumApk { get; set; }
    [JsonPropertyName("datum_tenaamstelling")]
    public int DatumTenaamstelling { get; set; }
    [JsonPropertyName("bruto_bpm")]
    public int BrutoBpm { get; set; }
    [JsonPropertyName("inrichting")]
    public string Inrichting { get; set; }
    [JsonPropertyName("aantal_zitplaatsen")]
    public int AantalZitplaatsen { get; set; }
    [JsonPropertyName("eerste_kleur")]
    public string EersteKleur { get; set; }
    [JsonPropertyName("tweede_kleur")]
    public string TweedeKleur { get; set; }
    [JsonPropertyName("aantal_cilinders")]
    public int AantalCilinders { get; set; }
    [JsonPropertyName("cilinderinhoud")]
    public int Cilinderinhoud { get; set; }
    [JsonPropertyName("massa_ledig_voertuig")]
    public int MassaLedigVoertuig { get; set; }
    [JsonPropertyName("toegestane_maximum_massa_voertuig")]
    public int ToegestaneMaximumMassaVoertuig { get; set; }
    [JsonPropertyName("massa_rijklaar")]
    public int MassaRijklaar { get; set; }
    [JsonPropertyName("maximum_massa_trekken_ongeremd")]
    public int MaximumMassaTrekkenOngeremd { get; set; }
    [JsonPropertyName("maximum_trekken_massa_geremd")]
    public int MaximumTrekkenMassaGeremd { get; set; }
    [JsonPropertyName("datum_eerste_toelating")]
    public int DatumEersteToelating { get; set; }
    [JsonPropertyName("datum_eerste_tenaamstelling_in_nederland")]
    public int DatumEersteTenaamstellingInNederland { get; set; }
    [JsonPropertyName("wacht_op_keuren")]
    public string WachtOpKeuren { get; set; }
    [JsonPropertyName("catalogusprijs")]
    public int Catalogusprijs { get; set; }
    [JsonPropertyName("wam_verzekerd")]
    public string WamVerzekerd { get; set; }
    [JsonPropertyName("maximale_constructiesnelheid")]
    public int MaximaleConstructiesnelheid { get; set; }
    [JsonPropertyName("laadvermogen")]
    public int Laadvermogen { get; set; }
    [JsonPropertyName("oplegger_geremd")]
    public int OpleggerGeremd { get; set; }
    [JsonPropertyName("aanhangwagen_autonoom_geremd")]
    public int AanhangwagenAutonoomGeremd { get; set; }
    [JsonPropertyName("aanhangwagen_middenas_geremd")]
    public int AanhangwagenMiddenasGeremd { get; set; }
    [JsonPropertyName("aantal_staanplaatsen")]
    public int AantalStaanplaatsen { get; set; }
    [JsonPropertyName("aantal_deuren")]
    public int AantalDeuren { get; set; }
    [JsonPropertyName("aantal_wielen")]
    public int AantalWielen { get; set; }
    [JsonPropertyName("afstand_hart_koppeling_tot_achterzijde_voertuig")]
    public int AfstandHartKoppelingTotAchterzijdeVoertuig { get; set; }
    [JsonPropertyName("afstand_voorzijde_voertuig_tot_hart_koppeling")]
    public int AfstandVoorzijdeVoertuigTotHartKoppeling { get; set; }
    [JsonPropertyName("afwijkende_maximum_snelheid")]
    public int AfwijkendeMaximumSnelheid { get; set; }
    [JsonPropertyName("lengte")]
    public int Lengte { get; set; }
    [JsonPropertyName("breedte")]
    public int Breedte { get; set; }
    [JsonPropertyName("europese_voertuigcategorie")]
    public string EuropeseVoertuigcategorie { get; set; }
    [JsonPropertyName("europese_voertuigcategorie_toevoeging")]
    public string EuropeseVoertuigcategorieToevoeging { get; set; }
    [JsonPropertyName("europese_uitvoeringcategorie_toevoeging")]
    public string EuropeseUitvoeringcategorieToevoeging { get; set; }
    [JsonPropertyName("plaats_chassisnummer")]
    public string PlaatsChassisnummer { get; set; }
    [JsonPropertyName("technische_max_massa_voertuig")]
    public int TechnischeMaxMassaVoertuig { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("type_gasinstallatie")]
    public string TypeGasinstallatie { get; set; }
    [JsonPropertyName("typegoedkeuringsnummer")]
    public string Typegoedkeuringsnummer { get; set; }
    [JsonPropertyName("variant")]
    public string Variant { get; set; }
    [JsonPropertyName("uitvoering")]
    public string Uitvoering { get; set; }
    [JsonPropertyName("volgnummer_wijziging_eu_typegoedkeuring")]
    public int VolgnummerWijzigingEuTypegoedkeuring { get; set; }
    [JsonPropertyName("vermogen_massarijklaar")]
    public double VermogenMassrijklaar { get; set; }
    [JsonPropertyName("wielbasis")]
    public int Wielbasis { get; set; }
    [JsonPropertyName("export_indicator")]
    public string ExportIndicator { get; set; }
    [JsonPropertyName("openstaande_terugroepactie_indicator")]
    public string OpenstaandeTerugroepactieIndicator { get; set; }
    [JsonPropertyName("vervaldatum_tachograaf")]
    public int VervaldatumTachograaf { get; set; }
    [JsonPropertyName("taxi_indicator")]
    public string TaxiIndicator { get; set; }
    [JsonPropertyName("maximum_massa_samenstelling")]
    public int MaximumMassaSamenstelling { get; set; }
    [JsonPropertyName("aantal_rolstoelplaatsen")]
    public int AantalRolstoelplaatsen { get; set; }
    [JsonPropertyName("maximum_ondersteunende_snelheid")]
    public double MaximumOndersteunendeSnelheid { get; set; }
    [JsonPropertyName("jaar_laatste_registratie_tellerstand")]
    public int JaarLaatsteRegistratieTellerstand { get; set; }
    [JsonPropertyName("tellerstandoordeel")]
    public string Tellerstandoordeel { get; set; }
    [JsonPropertyName("code_toelichting_tellerstandoordeel")]
    public string CodeToelichtingTellerstandoordeel { get; set; }
    [JsonPropertyName("tenaamstellen_mogelijk")]
    public string TenaamstellenMogelijk { get; set; }
    [JsonPropertyName("vervaldatum_apk_dt")]
    public DateTime? VervaldatumApkDt { get; set; }
    [JsonPropertyName("datum_tenaamstelling_dt")]
    public DateTime? DatumTenaamstellingDt { get; set; }
    [JsonPropertyName("datum_eerste_toelating_dt")]
    public DateTime? DatumEersteToelatingDt { get; set; }
    [JsonPropertyName("datum_eerste_tenaamstelling_in_nederland_dt")]
    public DateTime? DatumEersteTenaamstellingInNederlandDt { get; set; }
    [JsonPropertyName("vervaldatum_tachograaf_dt")]
    public DateTime? VervaldatumTachograafDt { get; set; }
    [JsonPropertyName("maximum_last_onder_de_vooras_sen_tezamen_koppeling")]
    public int MaximumLastOnderDeVoorasSenTezamenKoppeling { get; set; }
    [JsonPropertyName("type_remsysteem_voertuig_code")]
    public string TypeRemsysteemVoertuigCode { get; set; }
    [JsonPropertyName("rupsonderstelconfiguratiecode")]
    public string Rupsonderstelconfiguratiecode { get; set; }
    [JsonPropertyName("wielbasis_voertuig_minimum")]
    public int WielbasisVoertuigMinimum { get; set; }
    [JsonPropertyName("wielbasis_voertuig_maximum")]
    public int WielbasisVoertuigMaximum { get; set; }
    [JsonPropertyName("hoogte_voertuig")]
    public int HoogteVoertuig { get; set; }
    [JsonPropertyName("hoogte_voertuig_minimum")]
    public int HoogteVoertuigMinimum { get; set; }
    [JsonPropertyName("hoogte_voertuig_maximum")]
    public int HoogteVoertuigMaximum { get; set; }
    [JsonPropertyName("massa_bedrijfsklaar_minimaal")]
    public int MassaBedrijfsklaarMinimaal { get; set; }
    [JsonPropertyName("massa_bedrijfsklaar_maximaal")]
    public int MassaBedrijfsklaarMaximaal { get; set; }
    [JsonPropertyName("technisch_toelaatbaar_massa_koppelpunt")]
    public int TechnischToelaatbaarMassaKoppelpunt { get; set; }
    [JsonPropertyName("maximum_massa_technisch_maximaal")]
    public int MaximumMassaTechnischMaximaal { get; set; }
    [JsonPropertyName("maximum_massa_technisch_minimaal")]
    public int MaximumMassaTechnischMinimaal { get; set; }
    [JsonPropertyName("subcategorie_nederland")]
    public string SubcategorieNederland { get; set; }
    [JsonPropertyName("verticale_belasting_koppelpunt_getrokken_voertuig")]
    public int VerticaleBelastingKoppelpuntGetrokkenVoertuig { get; set; }
    [JsonPropertyName("zuinigheidsclassificatie")]
    public string Zuinigheidsclassificatie { get; set; }
    [JsonPropertyName("registratie_datum_goedkeuring_afschrijvingsmoment_bpm")]
    public string RegistratieDatumGoedkeuringAfschrijvingsmomentBpm { get; set; }
    [JsonPropertyName("registratie_datum_goedkeuring_afschrijvingsmoment_bpm_dt")]
    public DateTime? RegistratieDatumGoedkeuringAfschrijvingsmomentBpmDt { get; set; }
    [JsonPropertyName("gem_lading_wrde")]
    public int GemLadingWrde { get; set; }
    [JsonPropertyName("aerodyn_voorz")]
    public string AerodynVoorz { get; set; }
    [JsonPropertyName("massa_alt_aandr")]
    public int MassaAltAandr { get; set; }
    [JsonPropertyName("verl_cab_ind")]
    public string VerlCabInd { get; set; }
    [JsonPropertyName("api_gekentekende_voertuigen_assen")]
    public string ApiGekentekendeVoertuigenAssen { get; set; }
    [JsonPropertyName("api_gekentekende_voertuigen_brandstof")]
    public string ApiGekentekendeVoertuigenBrandstof { get; set; }
    [JsonPropertyName("api_gekentekende_voertuigen_carrosserie")]
    public string ApiGekentekendeVoertuigenCarrosserie { get; set; }
    [JsonPropertyName("api_gekentekende_voertuigen_carrosserie_specifiek")]
    public string ApiGekentekendeVoertuigenCarrosserieSpecifiek { get; set; }
    [JsonPropertyName("api_gekentekende_voertuigen_voertuigklasse")]
    public string ApiGekentekendeVoertuigenVoertuigklasse { get; set; }
}
