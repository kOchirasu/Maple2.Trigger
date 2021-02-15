namespace Maple2.Trigger._52000091_qd {
    public static class _52000091_trigger {
        public class State분기검사01 : TriggerState {
            internal State분기검사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -39.0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {3})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {2})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {1})) {
                    return new State52000093로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002282}, arg3: new byte[] {3})) {
                    return new State20002282완료가능할때(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {1})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {3})) {
                    // return new State52000095로이동(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {1})) {
                    return new State52000094로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {1})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100550}, arg3: new byte[] {3})) {
                    return new State52000094로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100550}, arg3: new byte[] {3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {2})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002282}, arg3: new byte[] {2})) {
                    return new State20002282완료가능할때(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {2})) {
                    return new State분기검사02(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002282}, arg3: new byte[] {2})) {
                    return new State분기검사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기검사02 : TriggerState {
            internal State분기검사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {3})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {2})) {
                    // return new State50100570완료가능할때(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100570}, arg3: new byte[] {1})) {
                    return new State52000093로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {2})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002281}, arg3: new byte[] {2})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {1})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002281}, arg3: new byte[] {1})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100560}, arg3: new byte[] {3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002281}, arg3: new byte[] {3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100550}, arg3: new byte[] {2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002280}, arg3: new byte[] {2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100550}, arg3: new byte[] {1})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002280}, arg3: new byte[] {1})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100550}, arg3: new byte[] {3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002280}, arg3: new byte[] {3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100540}, arg3: new byte[] {3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002279}, arg3: new byte[] {3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {2})) {
                    return new State20002277완료가능할때(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002277}, arg3: new byte[] {2})) {
                    return new State20002277완료가능할때(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100520}, arg3: new byte[] {2})) {
                    return new State완료(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002277}, arg3: new byte[] {2})) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52000094로이동 : TriggerState {
            internal State52000094로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000094, arg2: 99);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000093로이동 : TriggerState {
            internal State52000093로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000093, arg2: 99);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000091로이동 : TriggerState {
            internal State52000091로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -9.8f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new[] {200, 201, 202, 203}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237}, isAutoTargeting: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State20002282완료가능할때02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002282완료가능할때 : TriggerState {
            internal State20002282완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -9.8f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new[] {200, 201, 202, 203}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237}, isAutoTargeting: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State20002282완료가능할때02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002282완료가능할때02 : TriggerState {
            internal State20002282완료가능할때02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {50100580}, arg3: new byte[] {3})) {
                    return new State마드리아쿠키01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002283}, arg3: new byte[] {3})) {
                    return new State마드리아쿠키01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키01 : TriggerState {
            internal State마드리아쿠키01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아쿠키02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키02 : TriggerState {
            internal State마드리아쿠키02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 90000, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__0$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아쿠키03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키03 : TriggerState {
            internal State마드리아쿠키03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__1$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아쿠키04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키04 : TriggerState {
            internal State마드리아쿠키04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__2$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아쿠키05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키05 : TriggerState {
            internal State마드리아쿠키05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001820, arg3: "$52000091_QD__52000091_TRIGGER__3$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아쿠키_끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키_끝 : TriggerState {
            internal State마드리아쿠키_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveUser(arg1: 02000402, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000099로이동 : TriggerState {
            internal State52000099로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000099, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료가능할때 : TriggerState {
            internal State20002277완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000091, arg2: 99);
                context.CreateMonster(arg1: new[] {200}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Stun_A", arg3: 18000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSoundEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSoundEffect : TriggerState {
            internal StateSoundEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마드라칸Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드라칸Cinematic01 : TriggerState {
            internal State마드라칸Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드라칸Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드라칸Cinematic02 : TriggerState {
            internal State마드라칸Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Jump_Damg_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State마드라칸Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드라칸Cinematic03 : TriggerState {
            internal State마드라칸Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1004, 1008, 1009, 1010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 18000)) {
                    return new State마드라칸Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드라칸Cinematic04 : TriggerState {
            internal State마드라칸Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드라칸Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드라칸Cinematic05 : TriggerState {
            internal State마드라칸Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}