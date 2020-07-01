using System;

namespace Maple2.Trigger._52020036_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State딜레이(context);

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000043}, arg2: 2);
                context.SetMesh(arg1: new int[] {9999}, arg2: true);
                context.CreateMonster(arg1: new int[] {7000});
                context.CreateMonster(arg1: new int[] {7001});
                context.CreateMonster(arg1: new int[] {7002});
                context.CreateMonster(arg1: new int[] {7003});
                context.CreateMonster(arg1: new int[] {7004});
                context.SetMesh(arg1: new int[] {4002}, arg2: false);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.CreateMonster(arg1: new int[] {901}, arg2: false);
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
                context.CreateMonster(arg1: new int[] {10000}, arg2: false);
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
                context.CreateMonster(arg1: new int[] {10003}, arg2: false);
                context.CreateMonster(arg1: new int[] {10004}, arg2: false);
                context.CreateMonster(arg1: new int[] {10006}, arg2: false);
                context.CreateMonster(arg1: new int[] {10007}, arg2: false);
                context.CreateMonster(arg1: new int[] {10008}, arg2: false);
                context.CreateMonster(arg1: new int[] {10009}, arg2: false);
                context.CreateMonster(arg1: new int[] {10010}, arg2: false);
                context.CreateMonster(arg1: new int[] {10011}, arg2: false);
                context.CreateMonster(arg1: new int[] {10014}, arg2: false);
                context.CreateMonster(arg1: new int[] {10015}, arg2: false);
                context.CreateMonster(arg1: new int[] {10016}, arg2: false);
                context.CreateMonster(arg1: new int[] {10017}, arg2: false);
                context.CreateMonster(arg1: new int[] {10018}, arg2: false);
                context.CreateMonster(arg1: new int[] {10019}, arg2: false);
                context.CreateMonster(arg1: new int[] {10020}, arg2: false);
                context.CreateMonster(arg1: new int[] {10021}, arg2: false);
                context.CreateMonster(arg1: new int[] {10022}, arg2: false);
                context.CreateMonster(arg1: new int[] {10023}, arg2: false);
                context.CreateMonster(arg1: new int[] {10024}, arg2: false);
                context.CreateMonster(arg1: new int[] {10025}, arg2: false);
                context.CreateMonster(arg1: new int[] {10026}, arg2: false);
                context.CreateMonster(arg1: new int[] {10027}, arg2: false);
                context.CreateMonster(arg1: new int[] {10028}, arg2: false);
                context.CreateMonster(arg1: new int[] {10029}, arg2: false);
                context.CreateMonster(arg1: new int[] {10030}, arg2: false);
                context.CreateMonster(arg1: new int[] {10031}, arg2: false);
                context.CreateMonster(arg1: new int[] {10032}, arg2: false);
                context.CreateMonster(arg1: new int[] {10033}, arg2: false);
                context.CreateMonster(arg1: new int[] {10034}, arg2: false);
                context.CreateMonster(arg1: new int[] {10035}, arg2: false);
                context.CreateMonster(arg1: new int[] {10036}, arg2: false);
                context.CreateMonster(arg1: new int[] {10037}, arg2: false);
                context.CreateMonster(arg1: new int[] {10038}, arg2: false);
                context.CreateMonster(arg1: new int[] {10039}, arg2: false);
                context.CreateMonster(arg1: new int[] {10040}, arg2: false);
                context.CreateMonster(arg1: new int[] {10041}, arg2: false);
                context.CreateMonster(arg1: new int[] {10042}, arg2: false);
                context.CreateMonster(arg1: new int[] {10043}, arg2: false);
                context.CreateMonster(arg1: new int[] {10044}, arg2: false);
                context.CreateMonster(arg1: new int[] {10045}, arg2: false);
                context.CreateMonster(arg1: new int[] {10046}, arg2: false);
                context.CreateMonster(arg1: new int[] {10047}, arg2: false);
                context.CreateMonster(arg1: new int[] {10048}, arg2: false);
                context.CreateMonster(arg1: new int[] {10049}, arg2: false);
                context.CreateMonster(arg1: new int[] {10050}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000049},
                    arg3: new byte[] {3})) {
                    context.State = new State공중지원퀘스트완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000049},
                    arg3: new byte[] {2})) {
                    context.State = new State공중지원퀘스트완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000049},
                    arg3: new byte[] {1})) {
                    context.State = new State네이린팝업1(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000048},
                    arg3: new byte[] {3})) {
                    context.State = new State부상자옮기기대사(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000048},
                    arg3: new byte[] {2})) {
                    context.State = new State부상자옮기기대사(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000048},
                    arg3: new byte[] {1})) {
                    context.State = new State티나비추기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000047},
                    arg3: new byte[] {3})) {
                    context.State = new State침략자소탕퀘스트완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000047},
                    arg3: new byte[] {2})) {
                    context.State = new State침략자소탕퀘스트완료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000047},
                    arg3: new byte[] {1})) {
                    context.State = new State오프닝연출끝(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State피그밍그부족의제단원경신1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피그밍그부족의제단원경신1 : TriggerState {
            internal State피그밍그부족의제단원경신1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(questID: 91000047);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$52020036_QD__MAIN__0$",
                    desc: "$52020036_QD__MAIN__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {3000, 3001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State피그밍그부족의제단원경신2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피그밍그부족의제단원경신2 : TriggerState {
            internal State피그밍그부족의제단원경신2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3013, 3014}, arg2: false);
                context.SetSceneSkip(arg1: "콘대르소환", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투상황비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투상황비추기 : TriggerState {
            internal State전투상황비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CameraSelect(arg1: 3003, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State유저발록보이게위치옮김(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저발록보이게위치옮김 : TriggerState {
            internal State유저발록보이게위치옮김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020036, arg2: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오프닝크림슨발록비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오프닝크림슨발록비추기 : TriggerState {
            internal State오프닝크림슨발록비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3015, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State크림슨발록오프닝대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록오프닝대사 : TriggerState {
            internal State크림슨발록오프닝대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003781, msg: "$52020036_QD__MAIN__2$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State콘대르등장카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르등장카메라 : TriggerState {
            internal State콘대르등장카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3002, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르소환 : TriggerState {
            internal State콘대르소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020036, arg2: 1);
                context.CreateMonster(arg1: new int[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State유저를경로이동시킨다(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저를경로이동시킨다 : TriggerState {
            internal State유저를경로이동시킨다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "User_PatrolData_0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State콘대르등장대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르등장대사 : TriggerState {
            internal State콘대르등장대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52020036_QD__MAIN__3$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State콘대르이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르이동 : TriggerState {
            internal State콘대르이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "Conder_Spawn_Opening_PatrolData_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State오프닝연출끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오프닝연출끝 : TriggerState {
            internal State오프닝연출끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {100});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구르는천둥대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구르는천둥대사 : TriggerState {
            internal State구르는천둥대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11000009, illust: "RollingThunder_normal", duration: 7000,
                    script: "$52020036_QD__main__12$", voice: @"ko/Npc/00002150");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State콘대르전투참여대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르전투참여대사 : TriggerState {
            internal State콘대르전투참여대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003776, illust: "Conder_normal", duration: 8300,
                    script: "$52020036_QD__main__13$", voice: @"ko/Npc/00002147");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8300)) {
                    context.State = new State침략자소탕퀘스트완료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침략자소탕퀘스트완료체크 : TriggerState {
            internal State침략자소탕퀘스트완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000047},
                    arg3: new byte[] {2})) {
                    context.State = new State침략자소탕퀘스트완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침략자소탕퀘스트완료 : TriggerState {
            internal State침략자소탕퀘스트완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetQuestComplete(questID: 91000047);
                context.SetQuestAccept(questID: 91000048);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {3005, 3006}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State티나비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State티나비추기 : TriggerState {
            internal State티나비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 3004, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State티나대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State티나대사1 : TriggerState {
            internal State티나대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcID: 11000136, illustID: "Tina_normal", msg: "$52020036_QD__MAIN__4$",
                    duration: 5000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State몬스터한번더스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터한번더스폰 : TriggerState {
            internal State몬스터한번더스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {20001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10000}, arg2: false);
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
                context.CreateMonster(arg1: new int[] {10003}, arg2: false);
                context.CreateMonster(arg1: new int[] {10004}, arg2: false);
                context.CreateMonster(arg1: new int[] {10005}, arg2: false);
                context.CreateMonster(arg1: new int[] {10006}, arg2: false);
                context.CreateMonster(arg1: new int[] {10007}, arg2: false);
                context.CreateMonster(arg1: new int[] {10008}, arg2: false);
                context.CreateMonster(arg1: new int[] {10010}, arg2: false);
                context.CreateMonster(arg1: new int[] {10012}, arg2: false);
                context.CreateMonster(arg1: new int[] {10014}, arg2: false);
                context.CreateMonster(arg1: new int[] {10016}, arg2: false);
                context.CreateMonster(arg1: new int[] {10016}, arg2: false);
                context.CreateMonster(arg1: new int[] {10017}, arg2: false);
                context.CreateMonster(arg1: new int[] {10018}, arg2: false);
                context.CreateMonster(arg1: new int[] {10019}, arg2: false);
                context.CreateMonster(arg1: new int[] {10020}, arg2: false);
                context.CreateMonster(arg1: new int[] {10021}, arg2: false);
                context.CreateMonster(arg1: new int[] {10022}, arg2: false);
                context.CreateMonster(arg1: new int[] {10023}, arg2: false);
                context.CreateMonster(arg1: new int[] {10024}, arg2: false);
                context.CreateMonster(arg1: new int[] {10025}, arg2: false);
                context.CreateMonster(arg1: new int[] {10026}, arg2: false);
                context.CreateMonster(arg1: new int[] {10027}, arg2: false);
                context.CreateMonster(arg1: new int[] {10028}, arg2: false);
                context.CreateMonster(arg1: new int[] {10029}, arg2: false);
                context.CreateMonster(arg1: new int[] {10030}, arg2: false);
                context.CreateMonster(arg1: new int[] {10031}, arg2: false);
                context.CreateMonster(arg1: new int[] {10032}, arg2: false);
                context.CreateMonster(arg1: new int[] {10033}, arg2: false);
                context.CreateMonster(arg1: new int[] {10034}, arg2: false);
                context.CreateMonster(arg1: new int[] {10035}, arg2: false);
                context.CreateMonster(arg1: new int[] {10036}, arg2: false);
                context.CreateMonster(arg1: new int[] {10037}, arg2: false);
                context.CreateMonster(arg1: new int[] {10038}, arg2: false);
                context.CreateMonster(arg1: new int[] {10039}, arg2: false);
                context.CreateMonster(arg1: new int[] {10040}, arg2: false);
                context.CreateMonster(arg1: new int[] {10041}, arg2: false);
                context.CreateMonster(arg1: new int[] {10042}, arg2: false);
                context.CreateMonster(arg1: new int[] {10043}, arg2: false);
                context.CreateMonster(arg1: new int[] {10044}, arg2: false);
                context.CreateMonster(arg1: new int[] {10045}, arg2: false);
                context.CreateMonster(arg1: new int[] {10046}, arg2: false);
                context.CreateMonster(arg1: new int[] {10047}, arg2: false);
                context.CreateMonster(arg1: new int[] {10048}, arg2: false);
                context.CreateMonster(arg1: new int[] {10049}, arg2: false);
                context.CreateMonster(arg1: new int[] {10050}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State부상자구하기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상자구하기시작 : TriggerState {
            internal State부상자구하기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부상자구출퀘스트완료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상자구출퀘스트완료체크 : TriggerState {
            internal State부상자구출퀘스트완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000048},
                    arg3: new byte[] {2})) {
                    context.State = new State부상자옮기기대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상자옮기기대사 : TriggerState {
            internal State부상자옮기기대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetQuestComplete(questID: 91000048);
                context.SetQuestAccept(questID: 91000049);
                context.SideNpcTalk(npcID: 11003780, illust: "WhitewolfGirl_normal", duration: 5648,
                    script: "$52020036_QD__main__14$", voice: @"ko/Npc/00002151");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5648)) {
                    context.State = new State네이린팝업1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린팝업1 : TriggerState {
            internal State네이린팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_normal", duration: 7000,
                    script: "$52020036_QD__main__15$", voice: @"ko/Npc/00002126");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State네이린팝업2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린팝업2 : TriggerState {
            internal State네이린팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_smile", duration: 7000,
                    script: "$52020036_QD__main__16$", voice: @"ko/Npc/00002127");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State네이린팝업3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린팝업3 : TriggerState {
            internal State네이린팝업3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_normal", duration: 7000,
                    script: "$52020036_QD__main__17$", voice: @"ko/Npc/00002128");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State공중지원퀘스트자동수락(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공중지원퀘스트자동수락 : TriggerState {
            internal State공중지원퀘스트자동수락(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000043}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {901});
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {201});
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르구르는천둥P3스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르구르는천둥P3스폰 : TriggerState {
            internal State콘대르구르는천둥P3스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {902}, arg2: false);
                context.CreateMonster(arg1: new int[] {8000}, arg2: false);
                context.CreateMonster(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State석궁비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State석궁비추기 : TriggerState {
            internal State석궁비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 3007, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State석궁비추기끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State석궁비추기끝 : TriggerState {
            internal State석궁비추기끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르팝업1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르팝업1 : TriggerState {
            internal State콘대르팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003776, illust: "Conder_normal", duration: 7000,
                    script: "$52020036_QD__main__18$", voice: @"ko/Npc/00002148");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State네이린팝업4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린팝업4 : TriggerState {
            internal State네이린팝업4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_shy", duration: 7000,
                    script: "$52020036_QD__main__19$", voice: @"ko/Npc/00002129");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State콘대르팝업2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르팝업2 : TriggerState {
            internal State콘대르팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003776, illust: "Conder_normal", duration: 6000,
                    script: "$52020036_QD__main__20$", voice: @"ko/Npc/00002149");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State네이린웨이브경고팝업(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업 : TriggerState {
            internal State네이린웨이브경고팝업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_surprise", duration: 1000,
                    script: "$52020036_QD__main__21$", voice: @"ko/Npc/00002130");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1340)) {
                    context.State = new State네이린웨이브경고팝업1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업1 : TriggerState {
            internal State네이린웨이브경고팝업1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_surprise", duration: 7000,
                    script: "$52020036_QD__main__22$", voice: @"ko/Npc/00002131");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7012)) {
                    context.State = new State네이린웨이브경고팝업2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네이린웨이브경고팝업2 : TriggerState {
            internal State네이린웨이브경고팝업2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State웨이브스폰1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰1 : TriggerState {
            internal State웨이브스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10051}, arg2: false);
                context.CreateMonster(arg1: new int[] {10059}, arg2: false);
                context.CreateMonster(arg1: new int[] {10067}, arg2: false);
                context.CreateMonster(arg1: new int[] {10075}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State웨이브스폰1패트롤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰1패트롤 : TriggerState {
            internal State웨이브스폰1패트롤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10051, arg2: "WavePatrolDataEast");
                context.MoveNpc(arg1: 10059, arg2: "WavePatrolDataEast");
                context.MoveNpc(arg1: 10067, arg2: "WavePatrolDataWest");
                context.MoveNpc(arg1: 10075, arg2: "WavePatrolDataSouth");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰2 : TriggerState {
            internal State웨이브스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10055}, arg2: false);
                context.CreateMonster(arg1: new int[] {10063}, arg2: false);
                context.CreateMonster(arg1: new int[] {10071}, arg2: false);
                context.CreateMonster(arg1: new int[] {10079}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰3 : TriggerState {
            internal State웨이브스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10052}, arg2: false);
                context.CreateMonster(arg1: new int[] {10060}, arg2: false);
                context.CreateMonster(arg1: new int[] {10068}, arg2: false);
                context.CreateMonster(arg1: new int[] {10076}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰4 : TriggerState {
            internal State웨이브스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10056}, arg2: false);
                context.CreateMonster(arg1: new int[] {10064}, arg2: false);
                context.CreateMonster(arg1: new int[] {10072}, arg2: false);
                context.CreateMonster(arg1: new int[] {10080}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰5 : TriggerState {
            internal State웨이브스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10053}, arg2: false);
                context.CreateMonster(arg1: new int[] {10061}, arg2: false);
                context.CreateMonster(arg1: new int[] {10069}, arg2: false);
                context.CreateMonster(arg1: new int[] {10078}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰6 : TriggerState {
            internal State웨이브스폰6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10054}, arg2: false);
                context.CreateMonster(arg1: new int[] {10057}, arg2: false);
                context.CreateMonster(arg1: new int[] {10065}, arg2: false);
                context.CreateMonster(arg1: new int[] {10073}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State웨이브스폰7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브스폰7 : TriggerState {
            internal State웨이브스폰7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10058}, arg2: false);
                context.CreateMonster(arg1: new int[] {10062}, arg2: false);
                context.CreateMonster(arg1: new int[] {10066}, arg2: false);
                context.CreateMonster(arg1: new int[] {10070}, arg2: false);
                context.CreateMonster(arg1: new int[] {10074}, arg2: false);
                context.CreateMonster(arg1: new int[] {10077}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2차웨이브스폰1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브스폰1 : TriggerState {
            internal State2차웨이브스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10051}, arg2: false);
                context.CreateMonster(arg1: new int[] {10059}, arg2: false);
                context.CreateMonster(arg1: new int[] {10067}, arg2: false);
                context.CreateMonster(arg1: new int[] {10075}, arg2: false);
                context.CreateMonster(arg1: new int[] {10079}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2차웨이브스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브스폰2 : TriggerState {
            internal State2차웨이브스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10052}, arg2: false);
                context.CreateMonster(arg1: new int[] {10055}, arg2: false);
                context.CreateMonster(arg1: new int[] {10060}, arg2: false);
                context.CreateMonster(arg1: new int[] {10063}, arg2: false);
                context.CreateMonster(arg1: new int[] {10071}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2차웨이브스폰3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브스폰3 : TriggerState {
            internal State2차웨이브스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10056}, arg2: false);
                context.CreateMonster(arg1: new int[] {10064}, arg2: false);
                context.CreateMonster(arg1: new int[] {10068}, arg2: false);
                context.CreateMonster(arg1: new int[] {10072}, arg2: false);
                context.CreateMonster(arg1: new int[] {10076}, arg2: false);
                context.CreateMonster(arg1: new int[] {10080}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2차웨이브스폰4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브스폰4 : TriggerState {
            internal State2차웨이브스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10053}, arg2: false);
                context.CreateMonster(arg1: new int[] {10057}, arg2: false);
                context.CreateMonster(arg1: new int[] {10061}, arg2: false);
                context.CreateMonster(arg1: new int[] {10065}, arg2: false);
                context.CreateMonster(arg1: new int[] {10069}, arg2: false);
                context.CreateMonster(arg1: new int[] {10073}, arg2: false);
                context.CreateMonster(arg1: new int[] {10078}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State2차웨이브스폰5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브스폰5 : TriggerState {
            internal State2차웨이브스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {10054}, arg2: false);
                context.CreateMonster(arg1: new int[] {10058}, arg2: false);
                context.CreateMonster(arg1: new int[] {10062}, arg2: false);
                context.CreateMonster(arg1: new int[] {10066}, arg2: false);
                context.CreateMonster(arg1: new int[] {10070}, arg2: false);
                context.CreateMonster(arg1: new int[] {10074}, arg2: false);
                context.CreateMonster(arg1: new int[] {10077}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State공중지원퀘스트완료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공중지원퀘스트완료체크 : TriggerState {
            internal State공중지원퀘스트완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {91000049},
                    arg3: new byte[] {2})) {
                    context.State = new State공중지원퀘스트완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공중지원퀘스트완료 : TriggerState {
            internal State공중지원퀘스트완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000043}, arg2: 0);
                context.VisibleMyPc(isVisible: false);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetQuestComplete(questID: 91000049);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩크림슨발록보이는위치로유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩크림슨발록보이는위치로유저이동 : TriggerState {
            internal State엔딩크림슨발록보이는위치로유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020036, arg2: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩크림슨발록비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩크림슨발록비추기 : TriggerState {
            internal State엔딩크림슨발록비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 3015, arg2: true);
                context.CreateMonster(arg1: new int[] {7000}, arg2: false);
                context.CreateMonster(arg1: new int[] {7001}, arg2: false);
                context.CreateMonster(arg1: new int[] {7002}, arg2: false);
                context.CreateMonster(arg1: new int[] {7003}, arg2: false);
                context.CreateMonster(arg1: new int[] {7004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State크림슨발록엔딩닝대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록엔딩닝대사 : TriggerState {
            internal State크림슨발록엔딩닝대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 9000, arg2: 99910150);
                context.AddCinematicTalk(npcID: 11003781, msg: "$52020036_QD__MAIN__5$", duration: 5000, align: "left");
                context.SetNpcEmotionSequence(arg1: 7000, arg2: "Attack_01_A", arg3: 1900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State엔딩연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출준비 : TriggerState {
            internal State엔딩연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {7000});
                context.DestroyMonster(arg1: new int[] {7001});
                context.DestroyMonster(arg1: new int[] {7002});
                context.DestroyMonster(arg1: new int[] {7003});
                context.DestroyMonster(arg1: new int[] {7004});
                context.SetMesh(arg1: new int[] {9999}, arg2: false, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State엔딩연출1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출1 : TriggerState {
            internal State엔딩연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.CreateMonster(arg1: new int[] {3500}, arg2: false);
                context.CreateMonster(arg1: new int[] {4500}, arg2: false);
                context.CreateMonster(arg1: new int[] {5500}, arg2: false);
                context.SetSceneSkip(arg1: "전부지우기", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State엔딩카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩카메라1 : TriggerState {
            internal State엔딩카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3008, arg2: true);
                context.MoveUser(arg1: 52020036, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르엔딩대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩대사1 : TriggerState {
            internal State콘대르엔딩대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52020036_QD__MAIN__6$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State구르는천둥엔딩대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구르는천둥엔딩대사1 : TriggerState {
            internal State구르는천둥엔딩대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003779, illustID: "LoudFist_normal", msg: "$52020036_QD__MAIN__7$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State트리스탄생성1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄생성1 : TriggerState {
            internal State트리스탄생성1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6500}, arg2: false);
                context.MoveUser(arg1: 52020036, arg2: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State트리스탄등장카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄등장카메라1 : TriggerState {
            internal State트리스탄등장카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3009, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리스탄대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄대사1 : TriggerState {
            internal State트리스탄대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001975, illustID: "Tristan_normal", msg: "$52020036_QD__MAIN__8$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State콘대르엔딩카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩카메라1 : TriggerState {
            internal State콘대르엔딩카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3010, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State콘대르엔딩카메라2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩카메라2 : TriggerState {
            internal State콘대르엔딩카메라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3010, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르엔딩대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩대사2 : TriggerState {
            internal State콘대르엔딩대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52020036_QD__MAIN__9$",
                    duration: 1000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State콘대르엔딩카메라3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩카메라3 : TriggerState {
            internal State콘대르엔딩카메라3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3012, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    context.State = new State콘대르엔딩대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르엔딩대사3 : TriggerState {
            internal State콘대르엔딩대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52020036_QD__MAIN__10$",
                    duration: 2000, align: "left");
                context.SetNpcEmotionSequence(arg1: 3500, arg2: "Bore_A", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리스탄엔딩카메라2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄엔딩카메라2 : TriggerState {
            internal State트리스탄엔딩카메라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3009, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리스탄엔딩대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄엔딩대사2 : TriggerState {
            internal State트리스탄엔딩대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003777, illustID: "Tristan_normal", msg: "$52020036_QD__MAIN__11$",
                    duration: 4000, align: "left");
                context.SetNpcEmotionSequence(arg1: 6500, arg2: "Talk_A", arg3: 7000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State엔딩카메라2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩카메라2 : TriggerState {
            internal State엔딩카메라2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3007, 3016}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전부지우기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전부지우기 : TriggerState {
            internal State전부지우기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}