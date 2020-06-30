using System;

namespace Maple2.Trigger._52000091_qd {
    public static class _52000091_trigger {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State분기검사01(context);

        private class State분기검사01 : TriggerState {
            internal State분기검사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -39.0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {3})) {
                    context.State = new State52000091로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {2})) {
                    context.State = new State52000091로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {1})) {
                    context.State = new State52000093로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002282},
                    arg3: new byte[] {3})) {
                    context.State = new State20002282완료가능할때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {1})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {3})) {
                    // context.State = new State52000095로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {3})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {1})) {
                    context.State = new State52000094로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {1})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100550},
                    arg3: new byte[] {3})) {
                    context.State = new State52000094로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100550},
                    arg3: new byte[] {3})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {3})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {3})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002282},
                    arg3: new byte[] {2})) {
                    context.State = new State20002282완료가능할때(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {2})) {
                    context.State = new State분기검사02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002282},
                    arg3: new byte[] {2})) {
                    context.State = new State분기검사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State분기검사02 : TriggerState {
            internal State분기검사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {3})) {
                    context.State = new State52000091로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {2})) {
                    // context.State = new State50100570완료가능할때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100570},
                    arg3: new byte[] {1})) {
                    context.State = new State52000093로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {2})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002281},
                    arg3: new byte[] {2})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {1})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002281},
                    arg3: new byte[] {1})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100560},
                    arg3: new byte[] {3})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002281},
                    arg3: new byte[] {3})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100550},
                    arg3: new byte[] {2})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002280},
                    arg3: new byte[] {2})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100550},
                    arg3: new byte[] {1})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002280},
                    arg3: new byte[] {1})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100550},
                    arg3: new byte[] {3})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002280},
                    arg3: new byte[] {3})) {
                    context.State = new State완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100540},
                    arg3: new byte[] {3})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002279},
                    arg3: new byte[] {3})) {
                    context.State = new State52000099로이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State20002277완료가능할때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002277},
                    arg3: new byte[] {2})) {
                    context.State = new State20002277완료가능할때(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State완료(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002277},
                    arg3: new byte[] {2})) {
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State52000094로이동 : TriggerState {
            internal State52000094로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000094, arg2: 99);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State52000093로이동 : TriggerState {
            internal State52000093로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000093, arg2: 99);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State52000091로이동 : TriggerState {
            internal State52000091로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -9.8f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new int[] {200}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.SpawnNpcRange(
                    rangeID: new int[] {
                        210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228,
                        229, 230, 231, 232, 233, 234, 235, 236, 237
                    }, isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State20002282완료가능할때02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002282완료가능할때 : TriggerState {
            internal State20002282완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -9.8f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new int[] {200}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.SpawnNpcRange(
                    rangeID: new int[] {
                        210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228,
                        229, 230, 231, 232, 233, 234, 235, 236, 237
                    }, isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State20002282완료가능할때02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002282완료가능할때02 : TriggerState {
            internal State20002282완료가능할때02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100580},
                    arg3: new byte[] {3})) {
                    context.State = new State마드리아쿠키01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002283},
                    arg3: new byte[] {3})) {
                    context.State = new State마드리아쿠키01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키01 : TriggerState {
            internal State마드리아쿠키01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아쿠키02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키02 : TriggerState {
            internal State마드리아쿠키02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아쿠키03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키03 : TriggerState {
            internal State마드리아쿠키03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아쿠키04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키04 : TriggerState {
            internal State마드리아쿠키04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__2$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아쿠키05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키05 : TriggerState {
            internal State마드리아쿠키05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__3$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드리아쿠키_끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키_끝 : TriggerState {
            internal State마드리아쿠키_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02000402, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State52000099로이동 : TriggerState {
            internal State52000099로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000099, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State20002277완료가능할때 : TriggerState {
            internal State20002277완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new int[] {200}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Stun_A", arg3: 18000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State사운드이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사운드이펙트 : TriggerState {
            internal State사운드이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마드라칸연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드라칸연출01 : TriggerState {
            internal State마드라칸연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {1000, 1001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드라칸연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드라칸연출02 : TriggerState {
            internal State마드라칸연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1002, 1003}, arg2: 0);
                context.SetPcEmotionSequence(arg1: "Jump_Damg_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State마드라칸연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드라칸연출03 : TriggerState {
            internal State마드라칸연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1004, 1008, 1009, 1010}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    context.State = new State마드라칸연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드라칸연출04 : TriggerState {
            internal State마드라칸연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마드라칸연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마드라칸연출05 : TriggerState {
            internal State마드라칸연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}