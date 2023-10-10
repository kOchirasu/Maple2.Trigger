namespace Maple2.Trigger._52000091_qd {
    public static class _52000091_trigger {
        public class State분기검사01 : TriggerState {
            internal State분기검사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -39.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{3})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{2})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{1})) {
                    return new State52000093로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002282}, questStates: new byte[]{3})) {
                    return new State20002282완료가능할때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{1})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{3})) {
                    // return new State52000095로이동(context);
                    return null;
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{1})) {
                    return new State52000094로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{1})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100550}, questStates: new byte[]{3})) {
                    return new State52000094로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100550}, questStates: new byte[]{3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{3})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State분기검사02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002282}, questStates: new byte[]{2})) {
                    return new State20002282완료가능할때(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{2})) {
                    return new State분기검사02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002282}, questStates: new byte[]{2})) {
                    return new State분기검사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기검사02 : TriggerState {
            internal State분기검사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{3})) {
                    return new State52000091로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{2})) {
                    // return new State50100570완료가능할때(context);
                    return null;
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100570}, questStates: new byte[]{1})) {
                    return new State52000093로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{2})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002281}, questStates: new byte[]{2})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{1})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002281}, questStates: new byte[]{1})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100560}, questStates: new byte[]{3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002281}, questStates: new byte[]{3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100550}, questStates: new byte[]{2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002280}, questStates: new byte[]{2})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100550}, questStates: new byte[]{1})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002280}, questStates: new byte[]{1})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100550}, questStates: new byte[]{3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002280}, questStates: new byte[]{3})) {
                    return new State완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100540}, questStates: new byte[]{3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002279}, questStates: new byte[]{3})) {
                    return new State52000099로이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State20002277완료가능할때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002277}, questStates: new byte[]{2})) {
                    return new State20002277완료가능할때(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State완료(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002277}, questStates: new byte[]{2})) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52000094로이동 : TriggerState {
            internal State52000094로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000094, portalId: 99);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000093로이동 : TriggerState {
            internal State52000093로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000093, portalId: 99);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000091로이동 : TriggerState {
            internal State52000091로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -9.8f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000091, portalId: 99);
                context.CreateMonster(spawnIds: new []{200, 201, 202, 203}, arg2: true);
                context.SpawnNpcRange(spawnIds: new []{210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000091, portalId: 99);
                context.CreateMonster(spawnIds: new []{200, 201, 202, 203}, arg2: true);
                context.SpawnNpcRange(spawnIds: new []{210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100580}, questStates: new byte[]{3})) {
                    return new State마드리아쿠키01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002283}, questStates: new byte[]{3})) {
                    return new State마드리아쿠키01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아쿠키01 : TriggerState {
            internal State마드리아쿠키01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetSound(triggerId: 90000, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000091_QD__52000091_TRIGGER__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000091_QD__52000091_TRIGGER__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000091_QD__52000091_TRIGGER__2$", arg4: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000091_QD__52000091_TRIGGER__3$", arg4: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000402, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000099로이동 : TriggerState {
            internal State52000099로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000099, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료가능할때 : TriggerState {
            internal State20002277완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000091, portalId: 99);
                context.CreateMonster(spawnIds: new []{200}, arg2: true);
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Stun_A", duration: 18000f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Jump_Damg_A"});
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{1004, 1008, 1009, 1010}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
