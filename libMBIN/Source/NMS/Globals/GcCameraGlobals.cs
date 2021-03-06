using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8F2B5E8C2E2F0E78)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x00E8 */ public GcCameraFollowSettings VehicleCam;
        /* 0x01D0 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x01D4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x01D8 */ public float HmdEyeLookAngle;
        /* 0x01DC */ public float HmdEyeExtraTurnAngle;
        /* 0x01E0 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x01E4 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x01E8 */ public bool PauseThirdPersonCamInPause;
        /* 0x01EC */ public float DebugPlanetJumpNearHeight;
        /* 0x01F0 */ public float DebugPlanetJumpFarHeight;
        /* 0x01F4 */ public float TogglePerspectiveBlendTime;
        /* 0x01F8 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x01FC */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x0200 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x0204 */ public float VehicleExitFlashTime;
        /* 0x0208 */ public float VehicleExitFlashStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x020C */ public byte[] Padding20C;
        /* 0x0210 */ public Colour VehicleExitFlashColour;
        /* 0x0220 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0224 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0228 */ public float ShipThirdPersonBlendTime;
        /* 0x022C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0230 */ public float ShipThirdPersonBlendOffset;
        /* 0x0234 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0238 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x023C */ public float ShipFirstPersonBlendTime;
        /* 0x0240 */ public float ShipFirstPersonBlendOffset;
        /* 0x0244 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0248 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x024C */ public float FlybyMinRange;
        /* 0x0250 */ public float FlybyRange;
        /* 0x0254 */ public float FlybyMinRelativeSpeed;
        /* 0x0258 */ public float FlybyRelativeSpeedRange;
        /* 0x025C */ public float FlybyInVehicleDamper;
        /* 0x0260 */ public float BinocularFlashTime;
        /* 0x0264 */ public float BinocularFlashStrength;
        /* 0x0268 */ public float MinFirstPersonCameraPitch;
        /* 0x026C */ public float MaxFirstPersonCameraPitch;
        /* 0x0270 */ public float MaxCreatureRidingYaw;
        /* 0x0274 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x0278 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x027C */ public byte[] Padding27C;
        /* 0x0280 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x0368 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x0450 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x0538 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x0620 */ public GcCameraFollowSettings CharacterNexusCam;
        /* 0x0708 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x07F0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x08D8 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x09C0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        /* 0x0AA8 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0B90 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x0C78 */ public GcCameraFollowSettings CharacterSpaceCam;
        /* 0x0D60 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x0E48 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x0F30 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x1018 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x1100 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x11E8 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x12D0 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x1320 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x14A0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1588 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1670 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1674 */ public byte[] Padding1674;
        /* 0x1678 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1760 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1848 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x1930 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x1A18 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x1B00 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x1BE8 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x1CD0 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x1DB8 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x1EA0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x1F88 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x2070 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2158 */ public float FrontendModelCameraSpringTime;
        /* 0x215C */ public float ModelViewFlashTime;
        /* 0x2160 */ public Vector3f ModelViewOffset;
        /* 0x2170 */ public Vector2f ModelViewFocusOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2178 */ public byte[] Padding2178;
        /* 0x2180 */ public Vector3f InteractionOffset;
        /* 0x2190 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x21A0 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x21B0 */ public Vector3f InteractionOffsetDefault;
        /* 0x21C0 */ public Vector3f InteractionOffsetGek;
        /* 0x21D0 */ public Vector3f InteractionShipFocusOffset;
        /* 0x21E0 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x21F0 */ public float InteractionHeadHeightDefault;
        /* 0x21F4 */ public float InteractionHeadHeightGek;
        /* 0x21F8 */ public float InteractionHeadHeightVykeen;
        /* 0x21FC */ public float InteractionPitchAdjustTime;
        /* 0x2200 */ public float InteractionPitchAdjustStrength;
        /* 0x2204 */ public float InteractionPitchAdjustDeadZone;
        /* 0x2208 */ public float InteractionHeadPosHeightAdjust;
        /* 0x220C */ public float NPCTradeLateralShiftAmount;
        /* 0x2210 */ public float NPCTradeLateralShiftTime;
        /* 0x2214 */ public float DistanceForFleetInteraction;
        /* 0x2218 */ public float DistanceForFrigateInteraction;
        /* 0x221C */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x2220 */ public Vector3f OffsetForFleetInteraction;
        /* 0x2230 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x2240 */ public float FleetUIOrbitRate;
        /* 0x2244 */ public float FleetUIVerticalMotionDuration;
        /* 0x2248 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x224C */ public Vector2f PitchForFrigateInteraction;
        /* 0x2254 */ public Vector2f RotationForFrigateInteraction;
        /* 0x225C */ public float InteractionModeBlendTime;
        /* 0x2260 */ public float InteractionModeFocusCamBlend;
        /* 0x2264 */ public float InteractionModeFoV;
        /* 0x2268 */ public float MinInteractFocusAngle;
        /* 0x226C */ public float ModelViewInterpTime;
        /* 0x2270 */ public float ThirdPersonBlendInTime;
        /* 0x2274 */ public float ThirdPersonBlendOutTime;
        /* 0x2278 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x227C */ public float ThirdPersonOffsetSpringTime;
        /* 0x2280 */ public bool MaxBob;
        /* 0x2284 */ public float PhotoModeMoveSpeed;
        /* 0x2288 */ public float PhotoModeTurnSpeed;
        /* 0x228C */ public float PhotoModeMaxDistance;
        /* 0x2290 */ public float PhotoModeMaxDistanceSpace;
        /* 0x2294 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x2298 */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x229C */ public float PhotoModeCollisionRadius;
        /* 0x22A0 */ public float PhotoModeRollSpeed;
        /* 0x22A4 */ public float PhotoModeFlashDuration;
        /* 0x22A8 */ public float PhotoModeFlashIntensity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x22AC */ public byte[] Padding22AC;
        /* 0x22B0 */ public Vector3f PhotoModeShipOffset;
        /* 0x22C0 */ public Vector3f BuildingModeInitialOffset;
        /* 0x22D0 */ public float BuildingModeMaxDistance;
        /* 0x22D4 */ public float RunningFoVAdjust;
        /* 0x22D8 */ public float MeleeBoostedFoV;
        /* 0x22DC */ public float MeleeFoV;
        /* 0x22E0 */ public float AerialViewDownDistance;
        /* 0x22E4 */ public float AerialViewPause;
        /* 0x22E8 */ public float AerialViewStartTime;
        /* 0x22EC */ public float AerialViewBackTime;
        /* 0x22F0 */ public float AerialViewBlendTime;
        /* 0x22F4 */ public TkCurveType AerialViewCurve;
        /* 0x22F8 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x2328 */ public GcCameraAerialViewData SignalTransition;
        /* 0x2358 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x2388 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x23B8 */ public float ScreenshotHorizonHeight;
        /* 0x23BC */ public float ScreenshotHorizonFaceFactor;
        /* 0x23C0 */ public float ScreenshotBendDownAmount;
        /* 0x23C4 */ public float ScreenshotRightDistance;
        /* 0x23C8 */ public float ScreenshotBackDistance;
        /* 0x23CC */ public float ScreenshotInTime;
        /* 0x23D0 */ public float ScreenshotOutTime;
        /* 0x23D4 */ public float ShipCamSpringStrengthMin;
        /* 0x23D8 */ public float ShipCamSpringStrengthMax;
        /* 0x23DC */ public float ShipCamTurn;
        /* 0x23E0 */ public float ShipCamPitch;
        /* 0x23E4 */ public float ShipCamPitchMod;
        /* 0x23E8 */ public float ShipCamLookInterp;
        /* 0x23EC */ public float ShipCamMinReturnTime;
        /* 0x23F0 */ public float ShipCamReturnTime;
        /* 0x23F4 */ public float ShipCamMotionTurn;
        /* 0x23F8 */ public float ShipCamMotionPitch;
        /* 0x23FC */ public float ShipCamMotionPitchMod;
        /* 0x2400 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x2404 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x2408 */ public float ShipCamMotionInterp;
        /* 0x240C */ public float ShipCamRollAmountMin;
        /* 0x2410 */ public float ShipCamRollAmountMax;
        /* 0x2414 */ public float ShipCamRollSpeedScaler;
        /* 0x2418 */ public float ShipCamAimFOV;
        /* 0x241C */ public float MouseSensitivity;
        /* 0x2420 */ public float ModelViewRotateSpeed;
        /* 0x2424 */ public float ModelViewMouseRotateSpeed;
        /* 0x2428 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x242C */ public float ModelViewMouseMoveSpeed;
        /* 0x2430 */ public float ModelViewDistSpeed;
        /* 0x2434 */ public float ModelViewMinDist;
        /* 0x2438 */ public float ModelViewMaxDist;
        /* 0x243C */ public float ModelViewDefaultPitch;
        /* 0x2440 */ public float ModelViewDefaultYaw;
        /* 0x2444 */ public bool DebugMoveCam;
        /* 0x2448 */ public float DebugMoveCamSpeed;
        /* 0x244C */ public float DebugMoveCamHeight;
        /* 0x2450 */ public bool DebugAICam;
        /* 0x2454 */ public float DebugAICamUp;
        /* 0x2458 */ public float DebugAICamAt;
        /* 0x245C */ public float PainShakeTime;
        /* 0x2460 */ public float ShipShakeDamper;
        /* 0x2464 */ public float IndoorCamShakeDamper;
        /* 0x2468 */ public float FirstPersonSlerpAway;
        /* 0x246C */ public float FirstPersonSlerpTowards;
        [NMS(Size = 0x24)]
        /* 0x2470 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x3F70 */ public float BobAmount;
        /* 0x3F74 */ public float BobFactor;
        /* 0x3F78 */ public float BobFocus;
        /* 0x3F7C */ public float BobRollFactor;
        /* 0x3F80 */ public float BobRollAmount;
        /* 0x3F84 */ public float BobRollOffset;
        /* 0x3F88 */ public float BobFwdAmount;
        /* 0x3F8C */ public float CamSeed1;
        /* 0x3F90 */ public float CamSeed2;
        /* 0x3F94 */ public float CamWander1Phase;
        /* 0x3F98 */ public float CamWander2Phase;
        /* 0x3F9C */ public float CamWander1Amplitude;
        /* 0x3FA0 */ public float CamWander2Amplitude;
        /* 0x3FA4 */ public float DebugSpaceStationTeleportOffset;
        /* 0x3FA8 */ public float DebugCameraSlowFactor;
        /* 0x3FAC */ public float DebugCameraFastFactor;
        /* 0x3FB0 */ public float DebugCameraSpaceFastFactor;
        /* 0x3FB4 */ public float OffsetCamFOV;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3FB8 */ public byte[] Padding3FB8;
        /* 0x3FC0 */ public Vector3f OffsetCamOffset;
        /* 0x3FD0 */ public Vector3f OffsetCamRotation;
        /* 0x3FE0 */ public float ObjectFocusTime;
        /* 0x3FE4 */ public float CharCamFocusHeight;
        /* 0x3FE8 */ public float CharCamMaxDistance;
        /* 0x3FEC */ public float CharCamMinDistance;
        /* 0x3FF0 */ public float CharCamHeight;
        /* 0x3FF4 */ public float CharCamOffsetTime;
        /* 0x3FF8 */ public float CharCamAutoDirStartTime;
        /* 0x3FFC */ public float CharCamLookOffset;
        /* 0x4000 */ public float CharCamLookOffsetFactor;
        /* 0x4004 */ public float CharCamDeflectSpeed;
        /* 0x4008 */ public float CharCamMinSpeed;
        /* 0x400C */ public float CharCamRightStickX;
        /* 0x4010 */ public float CharCamRightStickY;
        /* 0x4014 */ public float FirstPersonCamHeight;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4018 */ public byte[] Padding4018;
        [NMS(Size = 0x8)]
        /* 0x4020 */ public Vector4f[] FirstPersonCamOffset;
        /* 0x40A0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x40B0 */ public float FirstPersonFoV;
        /* 0x40B4 */ public float ThirdPersonFoV;
        /* 0x40B8 */ public float FirstPersonZoom1FoV;
        /* 0x40BC */ public float FirstPersonZoom2FoV;
        /* 0x40C0 */ public float ShipFoVMin;
        /* 0x40C4 */ public float ShipFoVMin2;
        /* 0x40C8 */ public float ShipFoVMax;
        /* 0x40CC */ public float ShipWarpFoV;
        /* 0x40D0 */ public float ShipFoVMin3rdPerson;
        /* 0x40D4 */ public float ShipFoVMax3rdPerson;
        /* 0x40D8 */ public float ShipFoVBoost;
        /* 0x40DC */ public float ShipFoVMiniJump;
        /* 0x40E0 */ public float ShipFoVSpring;
        /* 0x40E4 */ public float ShipMiniJumpFoVSpring;
        /* 0x40E8 */ public float FoVSpring;
        /* 0x40EC */ public float FoVAdjust;
        /* 0x40F0 */ public bool FollowDrawCamProbes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x40F1 */ public byte[] Padding40F1;
        /* 0x40F4 */ public GcCameraAnimationData CameraAnimations;
        /* 0x4178 */ public TkTextureResource AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x41FC */ public string CameraAmbientAnimationsData;
        /* 0x427C */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x4280 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4284 */ public byte[] Padding4284;
        /* 0x4290 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x4340 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Size = 0x4)]
        /* 0x43F0 */ public TkPhysRelVectorData[] SavedCameraPositions;
        [NMS(Size = 0x4)]
        /* 0x4470 */ public Vector4f[] SavedCameraFacing;
        /* 0x44B0 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x44F4 */ public byte[] EndPadding;
    }
}
