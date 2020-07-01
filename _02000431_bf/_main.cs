namespace Maple2.Trigger._02000431_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10001108}, arg2: 2);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201, 3901, 3902, 3903, 3904}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1099, 2094, 2095, 2096, 2097, 2098, 2099}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {601, 602, 603}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "start") == 1) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "연출종료");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State부선장대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부선장대사01 : TriggerState {
            internal State부선장대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 24003011, arg3: "$02000431_BF__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State해적이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해적이동01 : TriggerState {
            internal State해적이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2099, arg3: "$02000431_BF__MAIN__1$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 1099, arg2: "Attack_01_C");
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveNpc(arg1: 2094, arg2: "MS2PatrolData_2094A");
                context.MoveNpc(arg1: 2095, arg2: "MS2PatrolData_2095A");
                context.MoveNpc(arg1: 2096, arg2: "MS2PatrolData_2096A");
                context.MoveNpc(arg1: 2097, arg2: "MS2PatrolData_2097A");
                context.MoveNpc(arg1: 2098, arg2: "MS2PatrolData_2098A");
                context.MoveNpc(arg1: 2099, arg2: "MS2PatrolData_2099A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State카메라302(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라302 : TriggerState {
            internal State카메라302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부선장대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부선장대사03 : TriggerState {
            internal State부선장대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24003011, arg3: "$02000431_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4858)) {
                    return new State세이렌대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌대사01 : TriggerState {
            internal State세이렌대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 309, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24003010, arg3: "$02000431_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4179)) {
                    return new State카메라310(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라310 : TriggerState {
            internal State카메라310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "Dungeon_Siren_Harp01");
                context.SetNpcEmotionSequence(arg1: 1098, arg2: "Attack_01_D");
                context.SetConversation(arg1: 1, arg2: 1099, arg3: "$02000431_BF__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 1099, arg2: "Attack_01_D");
                context.CameraSelect(arg1: 310, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.AddBuff(arg1: new[] {2094}, arg2: 70000055, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {2095}, arg2: 70000055, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {2096}, arg2: 70000055, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {2097}, arg2: 70000055, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {2098}, arg2: 70000055, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {2099}, arg2: 70000055, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카메라304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라304 : TriggerState {
            internal State카메라304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2099, arg3: "$02000431_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 1099, arg2: "Attack_01_I");
                context.CameraSelect(arg1: 304, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.DestroyMonster(arg1: new[] {1099});
                    return new State딜레이01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카메라305(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라305 : TriggerState {
            internal State카메라305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.DestroyMonster(arg1: new[] {2094, 2095, 2096, 2097, 2098, 2099});
                context.CreateMonster(arg1: new[] {2100, 1098}, arg2: false);
                context.CameraSelect(arg1: 305, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State세이렌연주02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌연주02 : TriggerState {
            internal State세이렌연주02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1098, arg3: "$02000431_BF__MAIN__6$", arg4: 3, arg5: 0);
                context.PlaySystemSoundInBox(arg2: "Dungeon_Siren_Harp01");
                context.SetNpcEmotionSequence(arg1: 1098, arg2: "Attack_01_D");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State물큐브제거(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State물큐브제거 : TriggerState {
            internal State물큐브제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State세이렌이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌이동 : TriggerState {
            internal State세이렌이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1098, arg3: "$02000431_BF__MAIN__7$", arg4: 3, arg5: 0);
                context.CameraSelect(arg1: 306, arg2: true);
                context.MoveNpc(arg1: 1098, arg2: "MS2PatrolData_1098A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State카메라307(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라307 : TriggerState {
            internal State카메라307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1098});
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24003011, arg3: "$02000431_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카메라308(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라308 : TriggerState {
            internal State카메라308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2100, arg2: "Attack_01_A");
                context.SetConversation(arg1: 1, arg2: 2100, arg3: "$02000431_BF__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3901, 3902, 3903, 3904}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DestroyMonster(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 1098, 1099, 2094, 2095, 2096, 2097, 2098, 2099, 2100});
                    return new State룸체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State던전시작(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new State퀘스트던전시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2199}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, isAutoTargeting: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039101, textId: 20039101, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2199})) {
                    return new State사망딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전시작 : TriggerState {
            internal State퀘스트던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2299}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, isAutoTargeting: false);
                context.ShowGuideSummary(entityId: 20039101, textId: 20039101, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2299})) {
                    return new State사망딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사망딜레이 : TriggerState {
            internal State사망딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011});
                    return new State오브젝트카메라(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트카메라 : TriggerState {
            internal State오브젝트카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "하프반응대기");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetInteractObject(arg1: new[] {10001108}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State하프반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하프반응대기 : TriggerState {
            internal State하프반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039102, textId: 20039102, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001108}, arg2: 0)) {
                    context.PlaySystemSoundInBox(arg2: "Dungeon_Siren_Harp01");
                    context.SetEffect(arg1: new[] {601}, arg2: false);
                    return new State연주딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연주딜레이 : TriggerState {
            internal State연주딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State물큐브제거2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State물큐브제거2 : TriggerState {
            internal State물큐브제거2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "종료");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039103, textId: 20039103);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}