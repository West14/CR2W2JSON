using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AtmosphereAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("skydomeColor")] public curveData<HDRColor> SkydomeColor { get; set; }
		[Ordinal(3)] [RED("skylightColor")] public curveData<HDRColor> SkylightColor { get; set; }
		[Ordinal(4)] [RED("groundReflectance")] public curveData<HDRColor> GroundReflectance { get; set; }
		[Ordinal(5)] [RED("sunMinZ")] public curveData<CFloat> SunMinZ { get; set; }
		[Ordinal(6)] [RED("horizonMinZ")] public curveData<CFloat> HorizonMinZ { get; set; }
		[Ordinal(7)] [RED("horizonFalloff")] public curveData<CFloat> HorizonFalloff { get; set; }
		[Ordinal(8)] [RED("turbidity")] public curveData<CFloat> Turbidity { get; set; }
		[Ordinal(9)] [RED("lutTurbidity")] public curveData<CFloat> LutTurbidity { get; set; }
		[Ordinal(10)] [RED("artisticDarkeningColor")] public curveData<HDRColor> ArtisticDarkeningColor { get; set; }
		[Ordinal(11)] [RED("artisticDarkeningStartPoint")] public curveData<CFloat> ArtisticDarkeningStartPoint { get; set; }
		[Ordinal(12)] [RED("artisticDarkeningEndPoint")] public curveData<CFloat> ArtisticDarkeningEndPoint { get; set; }
		[Ordinal(13)] [RED("artisticDarkeningExponent")] public curveData<CFloat> ArtisticDarkeningExponent { get; set; }
		[Ordinal(14)] [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
		[Ordinal(15)] [RED("sunFalloff")] public curveData<CFloat> SunFalloff { get; set; }
		[Ordinal(16)] [RED("rayTracedSunShadowRange")] public curveData<CFloat> RayTracedSunShadowRange { get; set; }
		[Ordinal(17)] [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
		[Ordinal(18)] [RED("moonFalloff")] public curveData<CFloat> MoonFalloff { get; set; }
		[Ordinal(19)] [RED("moonGlowIntensity")] public curveData<CFloat> MoonGlowIntensity { get; set; }
		[Ordinal(20)] [RED("moonGlowFalloff")] public curveData<CFloat> MoonGlowFalloff { get; set; }
		[Ordinal(21)] [RED("moonTexture")] public rRef<CBitmapTexture> MoonTexture { get; set; }
		[Ordinal(22)] [RED("galaxyIntensity")] public curveData<CFloat> GalaxyIntensity { get; set; }
		[Ordinal(23)] [RED("starMapIntensity")] public curveData<CFloat> StarMapIntensity { get; set; }
		[Ordinal(24)] [RED("starMapBrightScale")] public curveData<CFloat> StarMapBrightScale { get; set; }
		[Ordinal(25)] [RED("starMapDimScale")] public curveData<CFloat> StarMapDimScale { get; set; }
		[Ordinal(26)] [RED("starMapConstelationsScale")] public curveData<CFloat> StarMapConstelationsScale { get; set; }
		[Ordinal(27)] [RED("starCornerLuminanceFix")] public curveData<CFloat> StarCornerLuminanceFix { get; set; }
		[Ordinal(28)] [RED("starMapTexture")] public rRef<CCubeTexture> StarMapTexture { get; set; }
		[Ordinal(29)] [RED("galaxyTexture")] public rRef<CBitmapTexture> GalaxyTexture { get; set; }
		[Ordinal(30)] [RED("probeColorOverrideHorizon")] public curveData<HDRColor> ProbeColorOverrideHorizon { get; set; }
		[Ordinal(31)] [RED("probeAlphaOverrideHorizon")] public curveData<CFloat> ProbeAlphaOverrideHorizon { get; set; }
		[Ordinal(32)] [RED("probeColorOverrideZenith")] public curveData<HDRColor> ProbeColorOverrideZenith { get; set; }
		[Ordinal(33)] [RED("probeAlphaOverrideZenith")] public curveData<CFloat> ProbeAlphaOverrideZenith { get; set; }
		[Ordinal(34)] [RED("cloudSunShadowFaloff")] public curveData<CFloat> CloudSunShadowFaloff { get; set; }
		[Ordinal(35)] [RED("cloudSunScattering")] public curveData<CFloat> CloudSunScattering { get; set; }
		[Ordinal(36)] [RED("cloudMoonScattering")] public curveData<CFloat> CloudMoonScattering { get; set; }
		[Ordinal(37)] [RED("cloudAmbientIntensity")] public curveData<CFloat> CloudAmbientIntensity { get; set; }
		[Ordinal(38)] [RED("cloudCirrusOpacity")] public curveData<CFloat> CloudCirrusOpacity { get; set; }
		[Ordinal(39)] [RED("cloudCirrusScale")] public curveData<CFloat> CloudCirrusScale { get; set; }
		[Ordinal(40)] [RED("cloudCirrusAltitude")] public curveData<CFloat> CloudCirrusAltitude { get; set; }
		[Ordinal(41)] [RED("cloudCirrusTexture")] public rRef<CBitmapTexture> CloudCirrusTexture { get; set; }
		[Ordinal(42)] [RED("volWeatherTexture")] public rRef<CBitmapTexture> VolWeatherTexture { get; set; }
		[Ordinal(43)] [RED("volNoiseTexture")] public rRef<CBitmapTexture> VolNoiseTexture { get; set; }
		[Ordinal(44)] [RED("volHorizonCoverage")] public CFloat VolHorizonCoverage { get; set; }
		[Ordinal(45)] [RED("volCoverage")] public curveData<CFloat> VolCoverage { get; set; }
		[Ordinal(46)] [RED("volDensity")] public curveData<CFloat> VolDensity { get; set; }
		[Ordinal(47)] [RED("cloudsBottom")] public CFloat CloudsBottom { get; set; }
		[Ordinal(48)] [RED("cloudsTop")] public CFloat CloudsTop { get; set; }
		[Ordinal(49)] [RED("rayStartOffset")] public CFloat RayStartOffset { get; set; }
		[Ordinal(50)] [RED("rayStartFalloff")] public CFloat RayStartFalloff { get; set; }
		[Ordinal(51)] [RED("lightIntensity")] public curveData<CFloat> LightIntensity { get; set; }
		[Ordinal(52)] [RED("reflectionProbeLightIntensity")] public curveData<CFloat> ReflectionProbeLightIntensity { get; set; }
		[Ordinal(53)] [RED("shadowIntensity")] public curveData<CFloat> ShadowIntensity { get; set; }
		[Ordinal(54)] [RED("worldShadowIntensity")] public curveData<CFloat> WorldShadowIntensity { get; set; }
		[Ordinal(55)] [RED("ambientIntensity")] public curveData<CFloat> AmbientIntensity { get; set; }
		[Ordinal(56)] [RED("ambientOutscatter")] public curveData<CFloat> AmbientOutscatter { get; set; }
		[Ordinal(57)] [RED("inScatter")] public CFloat InScatter { get; set; }
		[Ordinal(58)] [RED("outScatter")] public CFloat OutScatter { get; set; }
		[Ordinal(59)] [RED("inVsOutScatter")] public CFloat InVsOutScatter { get; set; }
		[Ordinal(60)] [RED("silverLining")] public CFloat SilverLining { get; set; }
		[Ordinal(61)] [RED("volCoverageWindInfluence")] public CFloat VolCoverageWindInfluence { get; set; }
		[Ordinal(62)] [RED("volNoiseWindInfluence")] public CFloat VolNoiseWindInfluence { get; set; }
		[Ordinal(63)] [RED("volDetailWindInfluence")] public CFloat VolDetailWindInfluence { get; set; }
		[Ordinal(64)] [RED("volDistantFogOpacity")] public CFloat VolDistantFogOpacity { get; set; }

		public AtmosphereAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
