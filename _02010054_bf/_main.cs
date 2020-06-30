using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010054_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetGravity(gravity: -9.8f);
                context.SetInteractObject(arg1: new int[] {10000856}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000857}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000858}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000859}, arg2: 2);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221, 3222
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3315, 3316, 3317, 3318, 3319, 3320, 3321}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3130, 3131, 3132, 3133, 3134, 3135, 3136}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615,
                        3616, 3617, 3618, 3619, 3620
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3330}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetEffect(arg1: new int[] {6004}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetEffect(arg1: new int[] {607}, arg2: true);
                context.SetEffect(arg1: new int[] {608}, arg2: true);
                context.SetEffect(arg1: new int[] {609}, arg2: true);
                context.SetEffect(arg1: new int[] {612}, arg2: true);
                context.SetEffect(arg1: new int[] {613}, arg2: true);
                context.SetEffect(arg1: new int[] {614}, arg2: true);
                context.SetEffect(arg1: new int[] {615}, arg2: true);
                context.SetEffect(arg1: new int[] {616}, arg2: true);
                context.SetEffect(arg1: new int[] {620}, arg2: false);
                context.SetEffect(arg1: new int[] {621}, arg2: false);
                context.SetEffect(arg1: new int[] {622}, arg2: false);
                context.SetEffect(arg1: new int[] {625}, arg2: true);
                context.SetEffect(arg1: new int[] {626}, arg2: true);
                context.SetEffect(arg1: new int[] {627}, arg2: true);
                context.SetEffect(arg1: new int[] {628}, arg2: true);
                context.SetEffect(arg1: new int[] {629}, arg2: true);
                context.CreateMonster(arg1: new int[] {2099}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "100")) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new int[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(arg1: "인트로연출스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출해제 : TriggerState {
            internal State연출해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로연출스킵 : TriggerState {
            internal State인트로연출스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.RemoveBuff(arg1: 199, arg2: 70000107);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20105407, textID: 20105407, durationTime: 3500);
                context.SetEffect(arg1: new int[] {600}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {2001, 2002, 2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State반응대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기01 : TriggerState {
            internal State반응대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20105401, textID: 20105401);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new int[] {10000856}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000856}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20105401);
                    context.SetGravity(gravity: -39f);
                    context.State = new State반응대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기02 : TriggerState {
            internal State반응대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000860, 10000861}, arg2: 0)) {
                    context.SetEventUI(arg1: 1, arg2: "$02010054_BF__MAIN__1$", arg3: new int[] {5000}, arg4: "0");
                    context.SetInteractObject(arg1: new int[] {10000858}, arg2: 1);
                    context.State = new State반응대기03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기03 : TriggerState {
            internal State반응대기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000858}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {607}, arg2: false);
                    context.SetEffect(arg1: new int[] {608}, arg2: false);
                    context.SetEffect(arg1: new int[] {609}, arg2: false);
                    context.SetEffect(arg1: new int[] {6001}, arg2: false);
                    context.SetEffect(arg1: new int[] {6002}, arg2: true);
                    context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(
                        arg1: new int[] {
                            3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214,
                            3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222
                        }, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(
                        arg1: new int[] {
                            3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114,
                            3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123
                        }, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(
                        arg1: new int[] {
                            3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614,
                            3615, 3616, 3617, 3618, 3619, 3620
                        }, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(
                        arg1: new int[] {
                            3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514,
                            3515, 3516, 3517, 3518, 3519, 3520
                        }, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.CreateMonster(arg1: new int[] {2011, 2014, 2015, 2020, 2021}, arg2: false);
                    context.SetGravity(gravity: -9.8f);
                    context.State = new State인원체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인원체크 : TriggerState {
            internal State인원체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonMaxUserCount(value: 1)) {
                    context.State = new State반응둘중하나만(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State반응둘다01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응둘다01 : TriggerState {
            internal State반응둘다01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000884, 10000885}, arg2: 0)) {
                    context.State = new State반응대기05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응둘중하나만 : TriggerState {
            internal State반응둘중하나만(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000884}, arg2: 0)) {
                    context.State = new State반응대기05(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000885}, arg2: 0)) {
                    context.State = new State반응대기05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기05 : TriggerState {
            internal State반응대기05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000857}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000859}, arg2: 1);
                context.ShowGuideSummary(entityID: 20105401, textID: 20105401);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000857}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20105401);
                    context.SetGravity(gravity: -39f);
                    context.State = new State별생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State별생성 : TriggerState {
            internal State별생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3315, 3316, 3317, 3318, 3319, 3320, 3321}, arg2: true, arg3: 0,
                    arg4: 500, arg5: 3f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new int[] {3315, 3316, 3317, 3318, 3319, 3320, 3321}, arg2: false, arg3: 0,
                        arg4: 900, arg5: 2f);
                    context.State = new State반응대기06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기06 : TriggerState {
            internal State반응대기06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000859}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3330}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                    context.SetPortal(arg1: 10, arg2: false, arg3: true, arg4: false);
                    context.SetGravity(gravity: -9.8f);
                    context.State = new State중간보스소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중간보스소환 : TriggerState {
            internal State중간보스소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2098}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2098})) {
                    context.SetEffect(arg1: new int[] {6003}, arg2: false);
                    context.State = new State골렘소환대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골렘소환대기 : TriggerState {
            internal State골렘소환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEffect(arg1: new int[] {613}, arg2: false);
                context.SetEffect(arg1: new int[] {614}, arg2: false);
                context.SetEffect(arg1: new int[] {615}, arg2: false);
                context.SetEffect(arg1: new int[] {616}, arg2: false);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "107")) {
                    context.State = new State골렘소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골렘소환 : TriggerState {
            internal State골렘소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {620}, arg2: true);
                context.CreateMonster(arg1: new int[] {2024}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State골렘소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골렘소환2 : TriggerState {
            internal State골렘소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {621}, arg2: true);
                context.CreateMonster(arg1: new int[] {2025}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State골렘소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골렘소환3 : TriggerState {
            internal State골렘소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {622}, arg2: true);
                context.CreateMonster(arg1: new int[] {2026}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2024, 2025, 2026})) {
                    context.State = new State그라즈나전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State그라즈나전투 : TriggerState {
            internal State그라즈나전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {625}, arg2: false);
                context.SetEffect(arg1: new int[] {626}, arg2: false);
                context.SetEffect(arg1: new int[] {627}, arg2: false);
                context.SetEffect(arg1: new int[] {628}, arg2: false);
                context.SetEffect(arg1: new int[] {629}, arg2: false);
                context.SetEffect(arg1: new int[] {6004}, arg2: false);
                context.SetMesh(arg1: new int[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3130, 3131, 3132, 3133, 3134, 3135, 3136}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetTimer(arg1: "4", arg2: 4);
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}