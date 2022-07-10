using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020036_qd {
    public static class _main {
        public class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000043}, state: 2);
                context.SetMesh(triggerIds: new []{9999}, visible: true);
                context.CreateMonster(spawnIds: new []{7000});
                context.CreateMonster(spawnIds: new []{7001});
                context.CreateMonster(spawnIds: new []{7002});
                context.CreateMonster(spawnIds: new []{7003});
                context.CreateMonster(spawnIds: new []{7004});
                context.SetMesh(triggerIds: new []{4002}, visible: false);
                context.CreateMonster(spawnIds: new []{201, 901, 400, 10000, 10001, 10002, 10003, 10004, 10006, 10007, 10008, 10009, 10010, 10011, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034, 10035, 10036, 10037, 10038, 10039, 10040, 10041, 10042, 10043, 10044, 10045, 10046, 10047, 10048, 10049, 10050}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000049}, questStates: new byte[]{3})) {
                    return new State공중지원Quest완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000049}, questStates: new byte[]{2})) {
                    return new State공중지원Quest완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000049}, questStates: new byte[]{1})) {
                    return new State네이린팝업1(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000048}, questStates: new byte[]{3})) {
                    return new State부상자옮기기대사(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000048}, questStates: new byte[]{2})) {
                    return new State부상자옮기기대사(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000048}, questStates: new byte[]{1})) {
                    return new State티나비추기(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000047}, questStates: new byte[]{3})) {
                    return new State침략자소탕Quest완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000047}, questStates: new byte[]{2})) {
                    return new State침략자소탕Quest완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000047}, questStates: new byte[]{1})) {
                    return new State오프닝EndCinematic(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State피그밍그부족의제단원경신1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피그밍그부족의제단원경신1 : TriggerState {
            internal State피그밍그부족의제단원경신1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(questId: 91000047);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52020036_QD__MAIN__0$", script: "$52020036_QD__MAIN__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State피그밍그부족의제단원경신2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피그밍그부족의제단원경신2 : TriggerState {
            internal State피그밍그부족의제단원경신2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3013, 3014}, returnView: false);
                context.SetSceneSkip(state: new State콘대르소환(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전투상황비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투상황비추기 : TriggerState {
            internal State전투상황비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 3003, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State유저발록보이게위치옮김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저발록보이게위치옮김 : TriggerState {
            internal State유저발록보이게위치옮김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020036, portalId: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오프닝크림슨발록비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오프닝크림슨발록비추기 : TriggerState {
            internal State오프닝크림슨발록비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3015, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록오프닝대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록오프닝대사 : TriggerState {
            internal State크림슨발록오프닝대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003781, script: "$52020036_QD__MAIN__2$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State콘대르SpawnCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르SpawnCamera : TriggerState {
            internal State콘대르SpawnCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3002, enable: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르소환 : TriggerState {
            internal State콘대르소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020036, portalId: 1);
                context.CreateMonster(spawnIds: new []{100}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State유저를경로이동시킨다(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저를경로이동시킨다 : TriggerState {
            internal State유저를경로이동시킨다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "User_PatrolData_0");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State콘대르Spawn대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르Spawn대사 : TriggerState {
            internal State콘대르Spawn대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52020036_QD__MAIN__3$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State콘대르이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르이동 : TriggerState {
            internal State콘대르이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "Conder_Spawn_Opening_PatrolData_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State오프닝EndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오프닝EndCinematic : TriggerState {
            internal State오프닝EndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{100});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구르는천둥대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구르는천둥대사 : TriggerState {
            internal State구르는천둥대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11000009, illust: "RollingThunder_normal", duration: 7000, script: "$52020036_QD__main__12$", voice: @"ko/Npc/00002150");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State콘대르전투참여대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르전투참여대사 : TriggerState {
            internal State콘대르전투참여대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003776, illust: "Conder_normal", duration: 8300, script: "$52020036_QD__main__13$", voice: @"ko/Npc/00002147");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8300)) {
                    return new State침략자소탕Quest완료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침략자소탕Quest완료체크 : TriggerState {
            internal State침략자소탕Quest완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000047}, questStates: new byte[]{2})) {
                    return new State침략자소탕Quest완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침략자소탕Quest완료 : TriggerState {
            internal State침략자소탕Quest완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetQuestComplete(questId: 91000047);
                context.SetQuestAccept(questId: 91000048);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{3005, 3006}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State티나비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티나비추기 : TriggerState {
            internal State티나비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(triggerId: 3004, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State티나Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티나Script1 : TriggerState {
            internal State티나Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11000136, illustId: "Tina_normal", script: "$52020036_QD__MAIN__4$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMonster한번더Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster한번더Spawn : TriggerState {
            internal StateMonster한번더Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{20001, 10000, 10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10010, 10012, 10014, 10016, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034, 10035, 10036, 10037, 10038, 10039, 10040, 10041, 10042, 10043, 10044, 10045, 10046, 10047, 10048, 10049, 10050}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State부상자구하기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상자구하기시작 : TriggerState {
            internal State부상자구하기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부상자구출Quest완료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상자구출Quest완료체크 : TriggerState {
            internal State부상자구출Quest완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000048}, questStates: new byte[]{2})) {
                    return new State부상자옮기기대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상자옮기기대사 : TriggerState {
            internal State부상자옮기기대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetQuestComplete(questId: 91000048);
                context.SetQuestAccept(questId: 91000049);
                context.SideNpcTalk(npcId: 11003780, illust: "WhitewolfGirl_normal", duration: 5648, script: "$52020036_QD__main__14$", voice: @"ko/Npc/00002151");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5648)) {
                    return new State네이린팝업1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린팝업1 : TriggerState {
            internal State네이린팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 7000, script: "$52020036_QD__main__15$", voice: @"ko/Npc/00002126");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State네이린팝업2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린팝업2 : TriggerState {
            internal State네이린팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_smile", duration: 7000, script: "$52020036_QD__main__16$", voice: @"ko/Npc/00002127");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State네이린팝업3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린팝업3 : TriggerState {
            internal State네이린팝업3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 7000, script: "$52020036_QD__main__17$", voice: @"ko/Npc/00002128");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State공중지원Quest자동수락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공중지원Quest자동수락 : TriggerState {
            internal State공중지원Quest자동수락(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000043}, state: 1);
                context.DestroyMonster(spawnIds: new []{901, 101, 201, -1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르구르는천둥P3Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르구르는천둥P3Spawn : TriggerState {
            internal State콘대르구르는천둥P3Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{902, 8000, 8001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State석궁비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State석궁비추기 : TriggerState {
            internal State석궁비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 3007, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State석궁비추기끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State석궁비추기끝 : TriggerState {
            internal State석궁비추기끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르팝업1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르팝업1 : TriggerState {
            internal State콘대르팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003776, illust: "Conder_normal", duration: 7000, script: "$52020036_QD__main__18$", voice: @"ko/Npc/00002148");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State네이린팝업4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린팝업4 : TriggerState {
            internal State네이린팝업4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_shy", duration: 7000, script: "$52020036_QD__main__19$", voice: @"ko/Npc/00002129");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State콘대르팝업2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르팝업2 : TriggerState {
            internal State콘대르팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003776, illust: "Conder_normal", duration: 6000, script: "$52020036_QD__main__20$", voice: @"ko/Npc/00002149");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State네이린웨이브경고팝업(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업 : TriggerState {
            internal State네이린웨이브경고팝업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 1000, script: "$52020036_QD__main__21$", voice: @"ko/Npc/00002130");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1340)) {
                    return new State네이린웨이브경고팝업1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업1 : TriggerState {
            internal State네이린웨이브경고팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 7000, script: "$52020036_QD__main__22$", voice: @"ko/Npc/00002131");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7012)) {
                    return new State네이린웨이브경고팝업2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업2 : TriggerState {
            internal State네이린웨이브경고팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State웨이브Spawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn1 : TriggerState {
            internal State웨이브Spawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10051, 10059, 10067, 10075}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State웨이브Spawn1패트롤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn1패트롤 : TriggerState {
            internal State웨이브Spawn1패트롤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 10051, patrolName: "WavePatrolDataEast");
                context.MoveNpc(spawnId: 10059, patrolName: "WavePatrolDataEast");
                context.MoveNpc(spawnId: 10067, patrolName: "WavePatrolDataWest");
                context.MoveNpc(spawnId: 10075, patrolName: "WavePatrolDataSouth");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn2 : TriggerState {
            internal State웨이브Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10055, 10063, 10071, 10079}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn3 : TriggerState {
            internal State웨이브Spawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10052, 10060, 10068, 10076}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn4 : TriggerState {
            internal State웨이브Spawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10056, 10064, 10072, 10080}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn5 : TriggerState {
            internal State웨이브Spawn5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10053, 10061, 10069, 10078}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn6 : TriggerState {
            internal State웨이브Spawn6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10054, 10057, 10065, 10073}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State웨이브Spawn7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브Spawn7 : TriggerState {
            internal State웨이브Spawn7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10058, 10062, 10066, 10070, 10074, 10077}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2차웨이브Spawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Spawn1 : TriggerState {
            internal State2차웨이브Spawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10051, 10059, 10067, 10075, 10079}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차웨이브Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Spawn2 : TriggerState {
            internal State2차웨이브Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10052, 10055, 10060, 10063, 10071}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차웨이브Spawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Spawn3 : TriggerState {
            internal State2차웨이브Spawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10056, 10064, 10068, 10072, 10076, 10080}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차웨이브Spawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Spawn4 : TriggerState {
            internal State2차웨이브Spawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10053, 10057, 10061, 10065, 10069, 10073, 10078}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State2차웨이브Spawn5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Spawn5 : TriggerState {
            internal State2차웨이브Spawn5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10054, 10058, 10062, 10066, 10070, 10074, 10077}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State공중지원Quest완료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공중지원Quest완료체크 : TriggerState {
            internal State공중지원Quest완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000049}, questStates: new byte[]{2})) {
                    return new State공중지원Quest완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공중지원Quest완료 : TriggerState {
            internal State공중지원Quest완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000043}, state: 0);
                context.VisibleMyPc(visible: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetQuestComplete(questId: 91000049);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엔딩크림슨발록보이는위치로유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩크림슨발록보이는위치로유저이동 : TriggerState {
            internal State엔딩크림슨발록보이는위치로유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020036, portalId: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엔딩크림슨발록비추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩크림슨발록비추기 : TriggerState {
            internal State엔딩크림슨발록비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 3015, enable: true);
                context.CreateMonster(spawnIds: new []{7000, 7001, 7002, 7003, 7004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨발록엔딩닝대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록엔딩닝대사 : TriggerState {
            internal State크림슨발록엔딩닝대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 9000, skillId: 99910150);
                context.AddCinematicTalk(npcId: 11003781, script: "$52020036_QD__MAIN__5$", duration: 5000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 7000, sequenceName: "Attack_01_A", durationTick: 1900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State엔딩SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩SetupCinematic : TriggerState {
            internal State엔딩SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{7000, 7001, 7002, 7003, 7004});
                context.SetMesh(triggerIds: new []{9999}, visible: false, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State엔딩Cinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Cinematic1 : TriggerState {
            internal State엔딩Cinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.CreateMonster(spawnIds: new []{3500, 4500, 5500}, arg2: false);
                context.SetSceneSkip(state: new State전부지우기(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State엔딩Camera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Camera1 : TriggerState {
            internal State엔딩Camera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3008, enable: true);
                context.MoveUser(mapId: 52020036, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르엔딩Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Script1 : TriggerState {
            internal State콘대르엔딩Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52020036_QD__MAIN__6$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State구르는천둥엔딩Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구르는천둥엔딩Script1 : TriggerState {
            internal State구르는천둥엔딩Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003779, illustId: "LoudFist_normal", script: "$52020036_QD__MAIN__7$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리스탄Creation1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Creation1 : TriggerState {
            internal State트리스탄Creation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6500}, arg2: false);
                context.MoveUser(mapId: 52020036, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State트리스탄SpawnCamera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄SpawnCamera1 : TriggerState {
            internal State트리스탄SpawnCamera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3009, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리스탄Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script1 : TriggerState {
            internal State트리스탄Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001975, illustId: "Tristan_normal", script: "$52020036_QD__MAIN__8$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State콘대르엔딩Camera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Camera1 : TriggerState {
            internal State콘대르엔딩Camera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3010, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State콘대르엔딩Camera2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Camera2 : TriggerState {
            internal State콘대르엔딩Camera2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3010, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르엔딩Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Script2 : TriggerState {
            internal State콘대르엔딩Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52020036_QD__MAIN__9$", duration: 1000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State콘대르엔딩Camera3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Camera3 : TriggerState {
            internal State콘대르엔딩Camera3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3012, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new State콘대르엔딩Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩Script3 : TriggerState {
            internal State콘대르엔딩Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003776, illustId: "Conder_normal", script: "$52020036_QD__MAIN__10$", duration: 2000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 3500, sequenceName: "Bore_A", durationTick: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리스탄엔딩Camera2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄엔딩Camera2 : TriggerState {
            internal State트리스탄엔딩Camera2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3009, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리스탄엔딩Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄엔딩Script2 : TriggerState {
            internal State트리스탄엔딩Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003777, illustId: "Tristan_normal", script: "$52020036_QD__MAIN__11$", duration: 4000, align: Align.Left);
                context.SetNpcEmotionSequence(spawnId: 6500, sequenceName: "Talk_A", durationTick: 7000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State엔딩Camera2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔딩Camera2 : TriggerState {
            internal State엔딩Camera2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3007, 3016}, returnView: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전부지우기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전부지우기 : TriggerState {
            internal State전부지우기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52010052, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
