namespace Maple2.Trigger._52020030_qd {
    public static class _main30000334 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{30000334}, questStates: new byte[]{1})) {
                    return new StateStartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{30000334}, questStates: new byte[]{2})) {
                    return new State크란츠습격04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4023, 4020}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52020030, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저걸어감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저걸어감 : TriggerState {
            internal State유저걸어감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 0, script: "천공의 심장을 손에 넣었으니 티어스 코어를 완벽히 다시 만들 순 없을거야.", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "지금쯤 수호군은 도착했을까...", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "빨리 라딘에게 돌아가야겠어.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State바라보는크란츠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바라보는크란츠 : TriggerState {
            internal State바라보는크란츠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State바라보는크란츠_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바라보는크란츠_01 : TriggerState {
            internal State바라보는크란츠_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4027, 4014}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State바라보는크란츠_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바라보는크란츠_02 : TriggerState {
            internal State바라보는크란츠_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_C");
                context.AddCinematicTalk(npcId: 11003761, script: "후우... 말을 안 듣는군.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State바라보는크란츠_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바라보는크란츠_03 : TriggerState {
            internal State바라보는크란츠_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4024}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State잠시암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시암전 : TriggerState {
            internal State잠시암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4016, 4015}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크란츠습격전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격전 : TriggerState {
            internal State크란츠습격전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크란츠습격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격 : TriggerState {
            internal State크란츠습격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.AddCinematicTalk(npcId: 11003761, script: "... 봐 주는건, 여기까지야.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠습격01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격01 : TriggerState {
            internal State크란츠습격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 300, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 0, script: "커헉!", duration: 1500);
                context.MoveUser(mapId: 52020030, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State크란츠습격02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격02 : TriggerState {
            internal State크란츠습격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 300, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Stun_A", duration: 20000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠습격03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격03 : TriggerState {
            internal State크란츠습격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4025}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "으으... 넌...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State크란츠습격03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격03_01 : TriggerState {
            internal State크란츠습격03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4026}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "빨리 이곳에서 나가라니깐, 정~말 말을 안 듣는 인간이군.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠습격03_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격03_01_01 : TriggerState {
            internal State크란츠습격03_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4028}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "이런 귀중한 크리티아스의 보물을 당신과 같은 외지인에게 넘길 순 없어.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠습격03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격03_02 : TriggerState {
            internal State크란츠습격03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4025}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "잠깐... 이건 오해야. 난 이오네 왕녀를 위해서...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State크란츠습격03_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격03_03 : TriggerState {
            internal State크란츠습격03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4029}, returnView: false);
                context.AddCinematicTalk(npcId: 11003761, script: "... 천공의 심장은 내가 가져가겠다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State크란츠습격04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격04 : TriggerState {
            internal State크란츠습격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크란츠습격04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격04_01 : TriggerState {
            internal State크란츠습격04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크란츠습격05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크란츠습격05 : TriggerState {
            internal State크란츠습격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.5f);
                context.DestroyMonster(spawnIds: new []{106});
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "AttackSomeone");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
