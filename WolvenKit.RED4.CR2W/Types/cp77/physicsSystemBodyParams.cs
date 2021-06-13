using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBodyParams : CVariable
	{
		[Ordinal(0)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(1)] [RED("linearDamping")] public CFloat LinearDamping { get; set; }
		[Ordinal(2)] [RED("angularDamping")] public CFloat AngularDamping { get; set; }
		[Ordinal(3)] [RED("solverIterationsCountPosition")] public CUInt32 SolverIterationsCountPosition { get; set; }
		[Ordinal(4)] [RED("solverIterationsCountVelocity")] public CUInt32 SolverIterationsCountVelocity { get; set; }
		[Ordinal(5)] [RED("maxDepenetrationVelocity")] public CFloat MaxDepenetrationVelocity { get; set; }
		[Ordinal(6)] [RED("maxAngularVelocity")] public CFloat MaxAngularVelocity { get; set; }
		[Ordinal(7)] [RED("maxContactImpulse")] public CFloat MaxContactImpulse { get; set; }
		[Ordinal(8)] [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(9)] [RED("inertia")] public Vector3 Inertia { get; set; }
		[Ordinal(10)] [RED("comOffset")] public Transform ComOffset { get; set; }

		public physicsSystemBodyParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
